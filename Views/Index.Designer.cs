
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
            this.Form_elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Update = new System.Windows.Forms.Timer(this.components);
            this.OpacityPanel = new System.Windows.Forms.Panel();
            this.ApplyButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.OpacityValue = new Guna.UI2.WinForms.Guna2TrackBar();
            this.TVDateTime = new PersonalClock.Views.HourUserControl();
            this.OpacityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form_elipse
            // 
            this.Form_elipse.BorderRadius = 8;
            this.Form_elipse.TargetControl = this;
            // 
            // Update
            // 
            this.Update.Enabled = true;
            this.Update.Interval = 1000;
            this.Update.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // OpacityPanel
            // 
            this.OpacityPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OpacityPanel.Controls.Add(this.ApplyButton);
            this.OpacityPanel.Controls.Add(this.TitleLabel);
            this.OpacityPanel.Controls.Add(this.OpacityValue);
            this.OpacityPanel.Location = new System.Drawing.Point(12, 121);
            this.OpacityPanel.Name = "OpacityPanel";
            this.OpacityPanel.Size = new System.Drawing.Size(508, 127);
            this.OpacityPanel.TabIndex = 1;
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
            this.OpacityValue.Location = new System.Drawing.Point(3, 42);
            this.OpacityValue.Name = "OpacityValue";
            this.OpacityValue.Size = new System.Drawing.Size(493, 23);
            this.OpacityValue.TabIndex = 3;
            this.OpacityValue.ThumbColor = System.Drawing.Color.Lime;
            this.OpacityValue.Value = 100;
            // 
            // TVDateTime
            // 
            this.TVDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TVDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.TVDateTime.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVDateTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TVDateTime.Location = new System.Drawing.Point(0, 3);
            this.TVDateTime.Margin = new System.Windows.Forms.Padding(19, 18, 19, 18);
            this.TVDateTime.Name = "TVDateTime";
            this.TVDateTime.Size = new System.Drawing.Size(262, 69);
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
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Index";
            this.OpacityPanel.ResumeLayout(false);
            this.OpacityPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse Form_elipse;
        private System.Windows.Forms.Timer Update;
        private System.Windows.Forms.Panel OpacityPanel;
        private Guna.UI2.WinForms.Guna2GradientTileButton ApplyButton;
        private System.Windows.Forms.Label TitleLabel;
        private Guna.UI2.WinForms.Guna2TrackBar OpacityValue;
        private Views.HourUserControl TVDateTime;
    }
}

