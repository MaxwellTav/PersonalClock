
namespace PersonalClock
{
    partial class Index
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.Form_elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.OpacityPanel = new System.Windows.Forms.Panel();
            this.ApplyButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.OpacityValue = new Guna.UI2.WinForms.Guna2TrackBar();
            this.OpacityDetailTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseOpacityTimer = new System.Windows.Forms.Timer(this.components);
            this.MenuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.configuracionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opacidadDeVentanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siempreAlFrenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.iniciarConElSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.avisoDeEjericioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.noToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fijarTiempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestCronometro = new System.Windows.Forms.Timer(this.components);
            this.TVDateTime = new PersonalClock.Views.HourUserControl();
            this.OpacityPanel.SuspendLayout();
            this.MenuContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form_elipse
            // 
            this.Form_elipse.BorderRadius = 20;
            this.Form_elipse.TargetControl = this;
            // 
            // OpacityPanel
            // 
            this.OpacityPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OpacityPanel.Controls.Add(this.ApplyButton);
            this.OpacityPanel.Controls.Add(this.TitleLabel);
            this.OpacityPanel.Controls.Add(this.OpacityValue);
            this.OpacityPanel.Location = new System.Drawing.Point(14, 121);
            this.OpacityPanel.Name = "OpacityPanel";
            this.OpacityPanel.Size = new System.Drawing.Size(508, 127);
            this.OpacityPanel.TabIndex = 1;
            this.OpacityPanel.Visible = false;
            // 
            // ApplyButton
            // 
            this.ApplyButton.BorderRadius = 10;
            this.ApplyButton.CheckedState.Parent = this.ApplyButton;
            this.ApplyButton.CustomImages.Parent = this.ApplyButton;
            this.ApplyButton.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.ApplyButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ApplyButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ApplyButton.HoverState.Parent = this.ApplyButton;
            this.ApplyButton.Location = new System.Drawing.Point(3, 75);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.ShadowDecoration.Parent = this.ApplyButton;
            this.ApplyButton.Size = new System.Drawing.Size(493, 40);
            this.ApplyButton.TabIndex = 5;
            this.ApplyButton.Text = "Aplicar Opacidad";
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleLabel.Location = new System.Drawing.Point(135, 3);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(235, 32);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Opacidad: 100%";
            // 
            // OpacityValue
            // 
            this.OpacityValue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.OpacityValue.HoverState.Parent = this.OpacityValue;
            this.OpacityValue.LargeChange = 100;
            this.OpacityValue.Location = new System.Drawing.Point(3, 42);
            this.OpacityValue.Minimum = 15;
            this.OpacityValue.MouseWheelBarPartitions = 1;
            this.OpacityValue.Name = "OpacityValue";
            this.OpacityValue.Size = new System.Drawing.Size(493, 23);
            this.OpacityValue.TabIndex = 3;
            this.OpacityValue.ThumbColor = System.Drawing.Color.Lime;
            this.OpacityValue.Value = 100;
            this.OpacityValue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OpacityValue_Scroll);
            // 
            // OpacityDetailTimer
            // 
            this.OpacityDetailTimer.Interval = 1;
            this.OpacityDetailTimer.Tick += new System.EventHandler(this.OpacityDetailTimer_Tick);
            // 
            // CloseOpacityTimer
            // 
            this.CloseOpacityTimer.Interval = 1;
            this.CloseOpacityTimer.Tick += new System.EventHandler(this.CloseOpacityTimer_Tick);
            // 
            // MenuContext
            // 
            this.MenuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.configuracionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.MenuContext.Name = "MenuContext";
            this.MenuContext.Size = new System.Drawing.Size(181, 76);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // configuracionesToolStripMenuItem
            // 
            this.configuracionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opacidadDeVentanaToolStripMenuItem,
            this.siempreAlFrenteToolStripMenuItem,
            this.toolStripMenuItem3,
            this.iniciarConElSistemaToolStripMenuItem,
            this.toolStripMenuItem4,
            this.avisoDeEjericioToolStripMenuItem});
            this.configuracionesToolStripMenuItem.Name = "configuracionesToolStripMenuItem";
            this.configuracionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configuracionesToolStripMenuItem.Text = "Configuraciones";
            // 
            // opacidadDeVentanaToolStripMenuItem
            // 
            this.opacidadDeVentanaToolStripMenuItem.Name = "opacidadDeVentanaToolStripMenuItem";
            this.opacidadDeVentanaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.opacidadDeVentanaToolStripMenuItem.Text = "Opacidad de ventana";
            this.opacidadDeVentanaToolStripMenuItem.Click += new System.EventHandler(this.opacidadDeVentanaToolStripMenuItem_Click);
            // 
            // siempreAlFrenteToolStripMenuItem
            // 
            this.siempreAlFrenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siToolStripMenuItem,
            this.noToolStripMenuItem});
            this.siempreAlFrenteToolStripMenuItem.Name = "siempreAlFrenteToolStripMenuItem";
            this.siempreAlFrenteToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.siempreAlFrenteToolStripMenuItem.Text = "Siempre al frente";
            // 
            // siToolStripMenuItem
            // 
            this.siToolStripMenuItem.Name = "siToolStripMenuItem";
            this.siToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siToolStripMenuItem.Text = "Si";
            this.siToolStripMenuItem.Click += new System.EventHandler(this.siToolStripMenuItem_Click);
            // 
            // noToolStripMenuItem
            // 
            this.noToolStripMenuItem.Name = "noToolStripMenuItem";
            this.noToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noToolStripMenuItem.Text = "No";
            this.noToolStripMenuItem.Click += new System.EventHandler(this.noToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(183, 6);
            // 
            // iniciarConElSistemaToolStripMenuItem
            // 
            this.iniciarConElSistemaToolStripMenuItem.Name = "iniciarConElSistemaToolStripMenuItem";
            this.iniciarConElSistemaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.iniciarConElSistemaToolStripMenuItem.Text = "Iniciar con el sistema";
            this.iniciarConElSistemaToolStripMenuItem.Click += new System.EventHandler(this.iniciarConElSistemaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(183, 6);
            // 
            // avisoDeEjericioToolStripMenuItem
            // 
            this.avisoDeEjericioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activaciónToolStripMenuItem,
            this.fijarTiempoToolStripMenuItem});
            this.avisoDeEjericioToolStripMenuItem.Name = "avisoDeEjericioToolStripMenuItem";
            this.avisoDeEjericioToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.avisoDeEjericioToolStripMenuItem.Text = "Aviso de ejericio";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // activaciónToolStripMenuItem
            // 
            this.activaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siToolStripMenuItem1,
            this.noToolStripMenuItem1});
            this.activaciónToolStripMenuItem.Name = "activaciónToolStripMenuItem";
            this.activaciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.activaciónToolStripMenuItem.Text = "Activación";
            // 
            // siToolStripMenuItem1
            // 
            this.siToolStripMenuItem1.Name = "siToolStripMenuItem1";
            this.siToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.siToolStripMenuItem1.Text = "Si";
            this.siToolStripMenuItem1.Click += new System.EventHandler(this.siToolStripMenuItem1_Click);
            // 
            // noToolStripMenuItem1
            // 
            this.noToolStripMenuItem1.Name = "noToolStripMenuItem1";
            this.noToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.noToolStripMenuItem1.Text = "No";
            this.noToolStripMenuItem1.Click += new System.EventHandler(this.noToolStripMenuItem1_Click);
            // 
            // fijarTiempoToolStripMenuItem
            // 
            this.fijarTiempoToolStripMenuItem.Name = "fijarTiempoToolStripMenuItem";
            this.fijarTiempoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fijarTiempoToolStripMenuItem.Text = "Fijar tiempo";
            this.fijarTiempoToolStripMenuItem.Click += new System.EventHandler(this.fijarTiempoToolStripMenuItem_Click);
            // 
            // RestCronometro
            // 
            this.RestCronometro.Interval = 1000;
            this.RestCronometro.Tick += new System.EventHandler(this.RestCronometro_Tick);
            // 
            // TVDateTime
            // 
            this.TVDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TVDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.TVDateTime.ContextMenuStrip = this.MenuContext;
            this.TVDateTime.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVDateTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TVDateTime.Location = new System.Drawing.Point(3, 1);
            this.TVDateTime.Margin = new System.Windows.Forms.Padding(19, 18, 19, 18);
            this.TVDateTime.Name = "TVDateTime";
            this.TVDateTime.Size = new System.Drawing.Size(263, 72);
            this.TVDateTime.TabIndex = 0;
            this.TVDateTime.Load += new System.EventHandler(this.TVDateTime_Load);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(266, 76);
            this.Controls.Add(this.OpacityPanel);
            this.Controls.Add(this.TVDateTime);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Index";
            this.OpacityPanel.ResumeLayout(false);
            this.OpacityPanel.PerformLayout();
            this.MenuContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse Form_elipse;
        private System.Windows.Forms.Panel OpacityPanel;
        private Guna.UI2.WinForms.Guna2GradientTileButton ApplyButton;
        private System.Windows.Forms.Label TitleLabel;
        private Guna.UI2.WinForms.Guna2TrackBar OpacityValue;
        private System.Windows.Forms.Timer OpacityDetailTimer;
        private System.Windows.Forms.Timer CloseOpacityTimer;
        private System.Windows.Forms.ContextMenuStrip MenuContext;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem configuracionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opacidadDeVentanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siempreAlFrenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem iniciarConElSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private Views.HourUserControl TVDateTime;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem avisoDeEjericioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem noToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fijarTiempoToolStripMenuItem;
        private System.Windows.Forms.Timer RestCronometro;
    }
}

