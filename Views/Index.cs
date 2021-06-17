using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PersonalClock
{
    public partial class Index : Form
    {
        //Ubicacion, esta está en una clase
        private Classes.PathClass pathClass = new Classes.PathClass();

        public bool FirstTime; //Tal vez no es necesario ponerla publica
        private double FormOpacity = 1;
        private bool AlwaysFront = false;

        private Point FormLocation;

        //Settings
        int smoth = 10;
        private int TimeCronometro = 7200;
        private int saveTimeCronometro;

        public Index()
        { InitializeComponent(); }

        private void TVDateTime_Load(object sender, EventArgs e)
        { saveTimeCronometro = TimeCronometro; LoadConfig(); }

        private void SaveConfig()
        {
            FormLocation = Location;
            FormOpacity = Opacity;
            AlwaysFront = ShowInTaskbar;

            try
            {
                //opacity, always, showtop
                Properties.Settings.Default["Ubicacion"] = FormLocation;
                Properties.Settings.Default["Opacidad"] = Opacity;
                Properties.Settings.Default["ShowInTop"] = AlwaysFront;

                Properties.Settings.Default.Save();
            }
            catch (Exception error)
            {
                DialogResult dialog = MessageBox.Show("No se pudo completar la ultima acción que se hizo.\n\nCausa del error:\n" + error.Message + "\n\n¿Quieres reintentar el proceso?",
                    "Error al intentar guardar | " + error.HResult,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (dialog == DialogResult.Yes)
                    SaveConfig();
            }
        }

        private void LoadConfig()
        {
            Location = new Point((Size)Properties.Settings.Default.Ubicacion);
            Opacity = Properties.Settings.Default.Opacidad;
            ShowInTaskbar = Properties.Settings.Default.ShowInTop;
            
            //Bug de la barra de Opacidad
            //OpacityValue.Value = (int)(Opacity * 100);
            TitleLabel.Text = "Opacidad: " + OpacityValue.Value + "%";
        }

        #region Menú
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        { SaveConfig(); ExitApp(); }
        #endregion

        private void ExitApp()
        {
            DialogResult Dialog = MessageBox.Show("¿Está seguro que desea salir de la aplicación?",
                "!Está saliendo la app¡",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (Dialog == DialogResult.Yes)
            {
                SaveConfig();
                Application.Exit();
            }
        }

        #region Open Close Anim
        private void opacidadDeVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpacityPanel.Visible = true;
            OpacityDetailTimer.Enabled = true;
        }

        private void OpacityDetailTimer_Tick(object sender, EventArgs e)
        {
            //Animación de la altura
            if (Size.Width <= 530)
                Size = new Size(Size.Width + smoth, Height);

            //Animación de la achura
            else if (Size.Width >= 530 && Size.Height <= 254)
                Size = new Size(530, Height + smoth);

            //Finalización del proceso
            else
            {
                OpacityDetailTimer.Enabled = false;
                CloseOpacityTimer.Enabled = false;
                Size = new Size(530, 254);
            }

        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            OpacityPanel.Visible = false;
            CloseOpacityTimer.Enabled = true;
            FormOpacity = ((float)(OpacityValue.Value) / 100.0f);
            SaveConfig();
        }

        private void CloseOpacityTimer_Tick(object sender, EventArgs e)
        {
            //Animación de la altura
            if (Size.Width >= 266)
                Size = new Size(Size.Width - smoth, Height);

            //Animación de la achura
            else if (Size.Width <= 266 && Size.Height >= 76)
                Size = new Size(266, Height - smoth);

            //Finalización del proceso
            else
            {
                OpacityDetailTimer.Enabled = false;
                CloseOpacityTimer.Enabled = false;
                Size = new Size(266, 76);
            }

        }

        private void OpacityValue_Scroll(object sender, ScrollEventArgs e)
        {
            TitleLabel.Text = "Opacidad: " + OpacityValue.Value + "%";
            Opacity = ((double)(OpacityValue.Value) / 100.0);
        }
        #endregion

        #region Siempre al frente
        private void siToolStripMenuItem_Click(object sender, EventArgs e)
        { AlwaysFront = true; TopMost = true; SaveConfig(); }

        private void noToolStripMenuItem_Click(object sender, EventArgs e)
        { AlwaysFront = false; TopMost = false; SaveConfig(); }
        #endregion

        #region Iniciar con el sistema
        private void iniciarConElSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("shell:startup");
            MessageBox.Show("Lamentablemente nosotros por nuestra cuenta no podemos hacer esta funcion, pero usted si...\n\nEs muy facil. Para hacer esta acción manual, deberá hacer lo siguiente:\n\n1.Crear un acceso directo de esta aplicación\n2.Copiar esta ubicación = \"shell:startup\" (ya está copiada en tu portapapeles)\n3.Presionar en tu teclado \"Tecla de windows + R\"\n4.Pega el texto copiado y darle a \"Enter\"\n5.Copiar y pegar el acceso directo de la aplicación que creaste en la carpeta que se abrió\n6.Listo\n\nDisculpe los inconvenientes. :,(", "Excepción no controlada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Cronometro
        private void fijarTiempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Body = "Digite el tiempo en segundos que quisiera setear para avisar\n\n(Por defecto: \"2 Horas (7200 segundos)\")",
                Title = "Ingrese el tiempo en segundos",
                DefaultInput = "7200",

                dialogo = Microsoft.VisualBasic.Interaction.InputBox(Body, Title, DefaultInput);

            try
            {
                TimeCronometro = Int32.Parse(dialogo);
                saveTimeCronometro = TimeCronometro;
            }
            catch (Exception error)
            {
                MessageBox.Show("No puedes hacer semejante barbaridad\n\n" + "Causas del error:" + error.Message, "Codigo del error: " + error.HResult, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RestCronometro_Tick(object sender, EventArgs e)
        {
            if (saveTimeCronometro > 0)
            {
                AlarmIndicator.Visible = true;
                saveTimeCronometro--;
            }
            else
                Alarma();
        }

        private void Alarma()
        {
            AlarmIndicator.Visible = false;
            RestCronometro.Enabled = false;
            saveTimeCronometro = TimeCronometro;

            Random rng = new Random();
            string[] Body1 = { "Descansa tu espalda y tus ojos ", "Estár mucho tiempo en la pc te hace mal ¿Sabías?" };
            string[] Body2 = { "Es cierto que quieres ser productivo, pero no podrás serlo si no estas...\n¿Como decirlo?\nVIVO...", "Hazte un favor, y apartate de la computadora al menos 5 minutos..." };
            string[] Title = { "La mejor manera de trabajar es con un buen descanso", "Deberías descansar, has estado mucho tiempo en la pc" };

            DialogResult dialogResult = MessageBox.Show(Body1[rng.Next(0, Body1.Length)] + ", " + Body2[rng.Next(0, Body2.Length)] + "\n\nCuando hayas vuelto presiona el boton \"Si\" para continuar trabajando", Title[rng.Next(0, Title.Length)], MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
                RestCronometro.Enabled = true;
        }

        private void siToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RestCronometro.Enabled = true;
            MessageBox.Show("Se activó el cronometro de descanso, sonará en " + saveTimeCronometro + " segundos", "Cronometro de descanso activado", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void noToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RestCronometro.Enabled = false;
            saveTimeCronometro = TimeCronometro;
        }
        #endregion

        #region Barra de tareas
        private void siToolStripMenuItem2_Click(object sender, EventArgs e)
        { ShowInTaskbar = false; }

        private void noToolStripMenuItem2_Click(object sender, EventArgs e)
        { ShowInTaskbar = true; }
        #endregion

        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfig();
        }
    }
}
