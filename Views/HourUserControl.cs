using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalClock.Views
{
    public partial class HourUserControl : UserControl
    {
        //Variables
        CultureInfo ci = new CultureInfo("Es-Es");

        #region Useless or Untouchable
        public HourUserControl()
        { InitializeComponent(); }
        #endregion

        private void HourTimer_Tick(object sender, EventArgs e)
        {
            //Hora, minutos, segundos, Meridiano
            HourLabel.Text = System.DateTime.Now.ToString("hh:mm:ss - tt");
            //Dia
            DateLabel.Text = System.DateTime.Now.ToString("dd/");
            //Mes
            DateLabel.Text += ci.DateTimeFormat.GetMonthName(DateTime.Now.Month);
            //Año
            DateLabel.Text += System.DateTime.Now.ToString("/yyyy | ");
            //Dia de la semana
            DateLabel.Text += ci.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);
        }

        #region Detallitos
        private void HourUserControl_Load(object sender, EventArgs e)
        {
            TooltipConfig.SetToolTip(HourLabel, "Click derecho en la hora para mostrar opciones");
        }

        private void DetailDotAnim_Tick(object sender, EventArgs e)
        {
            #region DotLabelAnim
            
            #endregion
        }
        #endregion

        private void HourLabel_TextChanged(object sender, EventArgs e)
        { DetailDotAnim.Enabled = true; LoadingIndicador.Visible = false; UseWaitCursor = false; }
    }
}
