
namespace PersonalClock.Views
{
    partial class HourUserControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HourUserControl));
            this.HourLabel = new System.Windows.Forms.Label();
            this.HourTimer = new System.Windows.Forms.Timer(this.components);
            this.DateLabel = new System.Windows.Forms.Label();
            this.DetailDotAnim = new System.Windows.Forms.Timer(this.components);
            this.Form_drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Form_drag2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.TooltipConfig = new System.Windows.Forms.ToolTip(this.components);
            this.LoadingIndicador = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.SuspendLayout();
            // 
            // HourLabel
            // 
            resources.ApplyResources(this.HourLabel, "HourLabel");
            this.HourLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HourLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HourLabel.Name = "HourLabel";
            this.TooltipConfig.SetToolTip(this.HourLabel, resources.GetString("HourLabel.ToolTip"));
            this.HourLabel.UseWaitCursor = true;
            this.HourLabel.TextChanged += new System.EventHandler(this.HourLabel_TextChanged);
            // 
            // HourTimer
            // 
            this.HourTimer.Enabled = true;
            this.HourTimer.Interval = 1000;
            this.HourTimer.Tick += new System.EventHandler(this.HourTimer_Tick);
            // 
            // DateLabel
            // 
            resources.ApplyResources(this.DateLabel, "DateLabel");
            this.DateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DateLabel.Name = "DateLabel";
            this.TooltipConfig.SetToolTip(this.DateLabel, resources.GetString("DateLabel.ToolTip"));
            this.DateLabel.UseWaitCursor = true;
            // 
            // DetailDotAnim
            // 
            this.DetailDotAnim.Interval = 200;
            this.DetailDotAnim.Tick += new System.EventHandler(this.DetailDotAnim_Tick);
            // 
            // Form_drag
            // 
            this.Form_drag.TargetControl = this.HourLabel;
            // 
            // Form_drag2
            // 
            this.Form_drag2.TargetControl = this.DateLabel;
            // 
            // LoadingIndicador
            // 
            resources.ApplyResources(this.LoadingIndicador, "LoadingIndicador");
            this.LoadingIndicador.AutoStart = true;
            this.LoadingIndicador.CircleSize = 1F;
            this.LoadingIndicador.Name = "LoadingIndicador";
            this.LoadingIndicador.ProgressColor = System.Drawing.Color.White;
            this.TooltipConfig.SetToolTip(this.LoadingIndicador, resources.GetString("LoadingIndicador.ToolTip"));
            this.LoadingIndicador.UseWaitCursor = true;
            // 
            // HourUserControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.LoadingIndicador);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.HourLabel);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "HourUserControl";
            this.TooltipConfig.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.HourUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.Timer HourTimer;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Timer DetailDotAnim;
        private Guna.UI2.WinForms.Guna2DragControl Form_drag;
        private Guna.UI2.WinForms.Guna2DragControl Form_drag2;
        private System.Windows.Forms.ToolTip TooltipConfig;
        private Guna.UI2.WinForms.Guna2ProgressIndicator LoadingIndicador;
    }
}
