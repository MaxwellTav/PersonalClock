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
    public partial class ConfigOpacity : Form
    {
        public ConfigOpacity()
        { InitializeComponent(); }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Opacity = OpacityValue.Value;
            Dispose();
            Close();
        }

        private void OpacityValue_ValueChanged(object sender, EventArgs e)
        {
            TitleLabel.Text = "Opacidad: " + OpacityValue.Value + "%";
        }
    }
}
