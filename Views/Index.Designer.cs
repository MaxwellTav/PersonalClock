
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
            this.TVDateTime = new PersonalClock.Views.HourUserControl();
            this.Update = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Form_elipse
            // 
            this.Form_elipse.BorderRadius = 8;
            this.Form_elipse.TargetControl = this;
            // 
            // TVDateTime
            // 
            this.TVDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            // Update
            // 
            this.Update.Enabled = true;
            this.Update.Interval = 1000;
            this.Update.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(266, 76);
            this.Controls.Add(this.TVDateTime);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Index";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse Form_elipse;
        private Views.HourUserControl TVDateTime;
        private System.Windows.Forms.Timer Update;
    }
}

