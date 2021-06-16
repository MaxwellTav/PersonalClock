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
        public float FormOpacity = 1;
        public bool AlwaysFront = false;

        //Settings
        int smoth = 10;

        public Index()
        { InitializeComponent(); }

        private void TVDateTime_Load(object sender, EventArgs e)
        { ApplySavedConfigForm(); }

        private void ApplySavedConfigForm()
        {
            if (File.Exists(pathClass._Path + "FormOpacity.txt"))
            { FirstTime = false; LoadConfig(); }//¿No es primera vez?, pues carga
            else
            { FirstTime = true; SaveConfig(); }//¿Es primera vez?, pues crea y/o guarda
        }

        private void SaveConfig()
        {
            try
            {
                #region Variables
                TextWriter opacityWritter = new StreamWriter(pathClass._Path + "FormOpacity.txt", true);
                TextWriter alwaysWritter = new StreamWriter(pathClass._Path + "AlwaysFront.txt", true);
                #endregion
                #region Escritura
                //Opacidad
                opacityWritter.WriteLine(FormOpacity);
                alwaysWritter.WriteLine(AlwaysFront);
                #endregion
                #region Aplicar escritura a todo
                opacityWritter.Close();
                alwaysWritter.Close();
                #endregion
            }
            catch (Exception error)
            {
                DialogResult dialog = MessageBox.Show("No se pudo completar la ultima acción que se hizo.\n\nCausa del error:\n" + error.Message + "\n\n¿Quieres reintentar el proceso?",
                    "Error al intentar guardar | " + error.HResult,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (dialog == DialogResult.Yes)
                    ApplySavedConfigForm();
            }
        }

        private void LoadConfig()
        {
            //Leyendo el archivo de la opacidad
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(pathClass._Path + "FormOpacity.txt").ToList();
            foreach (string line in lines)
            { Opacity = float.Parse(line); }

            //__________________________________________________________________

            //Leyendo el archivo de siempre en frete
            List<string> _lines = new List<string>();
            _lines = File.ReadAllLines(pathClass._Path + "AlwaysFront.txt").ToList();
            foreach (string line in _lines)
            {
                if (line == "True")
                {
                    TopMost = true;
                    AlwaysFront = true;
                }
                else
                {
                    TopMost = false;
                    AlwaysFront = false;
                }
            }

            //Bug de la barra de Opacidad
            OpacityValue.Value = (int)(Opacity * 100);
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
                Application.Exit();
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
        { MessageBox.Show("Lamentablemente nosotros por nuestra cuenta no podemos hacer esta funcion, pero usted si...\n\nPara hacer esta acción manual, deberá crear un acceso directo de esta aplicación, cortarla y luego pegarla en la siguiente ubicación:\n\n" + @"C:\Users\The User Name\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup" + "\n\nLa ubicación puede variar.\n\nDisculpe los inconvenientes. :,(", "Excepción no programada", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        #endregion
    }
}
