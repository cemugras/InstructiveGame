namespace DortIslem
{
    partial class MenuNotification
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
            this.label1 = new System.Windows.Forms.Label();
            this.ButttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dil Türkçe Olarak Ayarlanmıştır.";
            // 
            // ButttonClose
            // 
            this.ButttonClose.Location = new System.Drawing.Point(204, 74);
            this.ButttonClose.Name = "ButttonClose";
            this.ButttonClose.Size = new System.Drawing.Size(75, 23);
            this.ButttonClose.TabIndex = 1;
            this.ButttonClose.Text = "Kapat";
            this.ButttonClose.UseVisualStyleBackColor = true;
            this.ButttonClose.Click += new System.EventHandler(this.ButttonClose_Click);
            // 
            // MenuNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 162);
            this.Controls.Add(this.ButttonClose);
            this.Controls.Add(this.label1);
            this.Name = "MenuNotification";
            this.Text = "MenuNotification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButttonClose;
    }
}