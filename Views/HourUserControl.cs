using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalClock.Views
{
    public partial class HourUserControl : UserControl
    {
        //Variables
        private bool DotLabelBool = true;

        #region Useless or Untouchable
        public HourUserControl()
        { InitializeComponent(); }
        #endregion

        private void HourTimer_Tick(object sender, EventArgs e)
        {
            HourLabel.Text = System.DateTime.Now.ToString("hh  mm  ss  tt");
            DateLabel.Text = System.DateTime.Now.ToString("dd/MMM/yyyy | dddd");
        }

        #region Menu
        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        { ExitApp(); }
        #endregion

        #region Detallitos
        private void HourUserControl_Load(object sender, EventArgs e)
        {
            TooltipConfig.SetToolTip(HourLabel, "Click derecho en la hora para mostrar opciones");
        }

        private void DetailDotAnim_Tick(object sender, EventArgs e)
        {
            #region DotLabelAnim
            if (DotLabelBool)
            {
                DotLabelBool = false;
                DetailDotLabel1.Visible = DotLabelBool;
                DetailDotLabel2.Visible = DotLabelBool;
            }
            else
            {
                DotLabelBool = true;
                DetailDotLabel1.Visible = DotLabelBool;
                DetailDotLabel2.Visible = DotLabelBool;
            }
            #endregion
        }
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

        private void opacidadDeVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigOpacity configOpacity = new ConfigOpacity();
            configOpacity.ShowDialog();
        }
    }
}
