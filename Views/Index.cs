using System;
using System.IO;
using System.Windows.Forms;


namespace PersonalClock
{
    public partial class Index : Form
    {
        //Ubicacion, esta está en una clase
        private Classes.PathClass pathClass = new Classes.PathClass();

        public bool FirstTime; //Tal vez no es necesario ponerla publica
        public float FormOpacity = 100;
        public bool AlwaysFront = false;
        public bool StartwithSo = false;

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
                TextWriter refreshWritter = new StreamWriter(pathClass._Path + "RefreshTimes.txt", true);
                TextWriter startWritter = new StreamWriter(pathClass._Path + "StartWithSo.txt", true);
                #endregion

                #region Escritura
                //Opacidad
                opacityWritter.WriteLine(FormOpacity);
                alwaysWritter.WriteLine(AlwaysFront);
                refreshWritter.WriteLine(RefreshTimes);
                startWritter.WriteLine(StartwithSo);
                #endregion

                #region Aplicar escritura a todo
                opacityWritter.Close();
                alwaysWritter.Close();
                refreshWritter.Close();
                startWritter.Close();
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

        }

        private void Update_Tick(object sender, EventArgs e)
        {
            //Applying Configs
            Opacity = FormOpacity;
        }
    }
}
