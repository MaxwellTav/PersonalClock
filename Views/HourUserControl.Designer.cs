
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
            this.HourLabel = new System.Windows.Forms.Label();
            this.HourTimer = new System.Windows.Forms.Timer(this.components);
            this.DateLabel = new System.Windows.Forms.Label();
            this.DetailDotLabel1 = new System.Windows.Forms.Label();
            this.DetailDotLabel2 = new System.Windows.Forms.Label();
            this.DetailDotAnim = new System.Windows.Forms.Timer(this.components);
            this.Form_drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Form_drag2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.TooltipConfig = new System.Windows.Forms.ToolTip(this.components);
            this.MenuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.configuracionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opacidadDeVentanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siempreAlFrenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarDatosDeFabricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeFabricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnimTimer = new System.Windows.Forms.Timer(this.components);
            this.MenuContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // HourLabel
            // 
            this.HourLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HourLabel.ContextMenuStrip = this.MenuContext;
            this.HourLabel.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HourLabel.Location = new System.Drawing.Point(-3, 5);
            this.HourLabel.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(270, 39);
            this.HourLabel.TabIndex = 0;
            this.HourLabel.Text = "00  00  00  PM";
            this.HourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HourTimer
            // 
            this.HourTimer.Enabled = true;
            this.HourTimer.Interval = 1000;
            this.HourTimer.Tick += new System.EventHandler(this.HourTimer_Tick);
            // 
            // DateLabel
            // 
            this.DateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DateLabel.Location = new System.Drawing.Point(0, 44);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(262, 21);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "07/09/2001 | Viernes";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DetailDotLabel1
            // 
            this.DetailDotLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DetailDotLabel1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailDotLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DetailDotLabel1.Location = new System.Drawing.Point(51, 7);
            this.DetailDotLabel1.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.DetailDotLabel1.Name = "DetailDotLabel1";
            this.DetailDotLabel1.Size = new System.Drawing.Size(18, 31);
            this.DetailDotLabel1.TabIndex = 2;
            this.DetailDotLabel1.Text = ":";
            // 
            // DetailDotLabel2
            // 
            this.DetailDotLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DetailDotLabel2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailDotLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DetailDotLabel2.Location = new System.Drawing.Point(113, 7);
            this.DetailDotLabel2.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.DetailDotLabel2.Name = "DetailDotLabel2";
            this.DetailDotLabel2.Size = new System.Drawing.Size(18, 31);
            this.DetailDotLabel2.TabIndex = 3;
            this.DetailDotLabel2.Text = ":";
            // 
            // DetailDotAnim
            // 
            this.DetailDotAnim.Enabled = true;
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
            // MenuContext
            // 
            this.MenuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.configuracionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.MenuContext.Name = "MenuContext";
            this.MenuContext.Size = new System.Drawing.Size(162, 54);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(158, 6);
            // 
            // configuracionesToolStripMenuItem
            // 
            this.configuracionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opacidadDeVentanaToolStripMenuItem,
            this.siempreAlFrenteToolStripMenuItem,
            this.reiniciarDatosDeFabricaToolStripMenuItem,
            this.datosDeFabricaToolStripMenuItem});
            this.configuracionesToolStripMenuItem.Name = "configuracionesToolStripMenuItem";
            this.configuracionesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.configuracionesToolStripMenuItem.Text = "Configuraciones";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // opacidadDeVentanaToolStripMenuItem
            // 
            this.opacidadDeVentanaToolStripMenuItem.Name = "opacidadDeVentanaToolStripMenuItem";
            this.opacidadDeVentanaToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.opacidadDeVentanaToolStripMenuItem.Text = "Opacidad de ventana";
            this.opacidadDeVentanaToolStripMenuItem.Click += new System.EventHandler(this.opacidadDeVentanaToolStripMenuItem_Click);
            // 
            // siempreAlFrenteToolStripMenuItem
            // 
            this.siempreAlFrenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siToolStripMenuItem,
            this.noToolStripMenuItem});
            this.siempreAlFrenteToolStripMenuItem.Name = "siempreAlFrenteToolStripMenuItem";
            this.siempreAlFrenteToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.siempreAlFrenteToolStripMenuItem.Text = "Siempre al frente";
            // 
            // siToolStripMenuItem
            // 
            this.siToolStripMenuItem.Name = "siToolStripMenuItem";
            this.siToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siToolStripMenuItem.Text = "Si";
            // 
            // noToolStripMenuItem
            // 
            this.noToolStripMenuItem.Name = "noToolStripMenuItem";
            this.noToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noToolStripMenuItem.Text = "No";
            // 
            // reiniciarDatosDeFabricaToolStripMenuItem
            // 
            this.reiniciarDatosDeFabricaToolStripMenuItem.Name = "reiniciarDatosDeFabricaToolStripMenuItem";
            this.reiniciarDatosDeFabricaToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.reiniciarDatosDeFabricaToolStripMenuItem.Text = "Horas para avisar";
            // 
            // datosDeFabricaToolStripMenuItem
            // 
            this.datosDeFabricaToolStripMenuItem.Name = "datosDeFabricaToolStripMenuItem";
            this.datosDeFabricaToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.datosDeFabricaToolStripMenuItem.Text = "Restablecer configuracion";
            // 
            // AnimTimer
            // 
            this.AnimTimer.Interval = 1;
            this.AnimTimer.Tick += new System.EventHandler(this.AnimTimer_Tick);
            // 
            // HourUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(38F, 77F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.DetailDotLabel2);
            this.Controls.Add(this.DetailDotLabel1);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.HourLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(19, 18, 19, 18);
            this.Name = "HourUserControl";
            this.Size = new System.Drawing.Size(262, 70);
            this.Load += new System.EventHandler(this.HourUserControl_Load);
            this.MenuContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.Timer HourTimer;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label DetailDotLabel1;
        private System.Windows.Forms.Label DetailDotLabel2;
        private System.Windows.Forms.Timer DetailDotAnim;
        private Guna.UI2.WinForms.Guna2DragControl Form_drag;
        private Guna.UI2.WinForms.Guna2DragControl Form_drag2;
        private System.Windows.Forms.ToolTip TooltipConfig;
        private System.Windows.Forms.ContextMenuStrip MenuContext;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem configuracionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opacidadDeVentanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siempreAlFrenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarDatosDeFabricaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDeFabricaToolStripMenuItem;
        private System.Windows.Forms.Timer AnimTimer;
    }
}
