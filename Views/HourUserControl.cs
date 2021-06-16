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
    }
}
