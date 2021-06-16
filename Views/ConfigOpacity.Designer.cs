
namespace PersonalClock.Views
{
    partial class ConfigOpacity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpacityValue = new Guna.UI2.WinForms.Guna2TrackBar();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ApplyButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.SuspendLayout();
            // 
            // OpacityValue
            // 
            this.OpacityValue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.OpacityValue.HoverState.Parent = this.OpacityValue;
            this.OpacityValue.Location = new System.Drawing.Point(12, 51);
            this.OpacityValue.Name = "OpacityValue";
            this.OpacityValue.Size = new System.Drawing.Size(493, 23);
            this.OpacityValue.TabIndex = 0;
            this.OpacityValue.ThumbColor = System.Drawing.Color.Lime;
            this.OpacityValue.Value = 100;
            this.OpacityValue.ValueChanged += new System.EventHandler(this.OpacityValue_ValueChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleLabel.Location = new System.Drawing.Point(144, 12);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(235, 32);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Opacidad: 100%";
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
            this.ApplyButton.Location = new System.Drawing.Point(12, 84);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.ShadowDecoration.Parent = this.ApplyButton;
            this.ApplyButton.Size = new System.Drawing.Size(493, 40);
            this.ApplyButton.TabIndex = 2;
            this.ApplyButton.Text = "Aplicar Opacidad";
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // ConfigOpacity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(517, 136);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.OpacityValue);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ConfigOpacity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigOpacity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TrackBar OpacityValue;
        private System.Windows.Forms.Label TitleLabel;
        private Guna.UI2.WinForms.Guna2GradientTileButton ApplyButton;
    }
}