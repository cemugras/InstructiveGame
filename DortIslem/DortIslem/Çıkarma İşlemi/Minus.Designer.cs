namespace DortIslem.Çıkarma_İşlemi
{
    partial class Minus
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
            this.MainMenu = new System.Windows.Forms.Button();
            this.Level2Minus = new System.Windows.Forms.Button();
            this.Level1Minus = new System.Windows.Forms.Button();
            this.Notification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(139, 227);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(75, 23);
            this.MainMenu.TabIndex = 8;
            this.MainMenu.Text = "Ana Menü";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click_1);
            // 
            // Level2Minus
            // 
            this.Level2Minus.Location = new System.Drawing.Point(16, 118);
            this.Level2Minus.Name = "Level2Minus";
            this.Level2Minus.Size = new System.Drawing.Size(75, 23);
            this.Level2Minus.TabIndex = 7;
            this.Level2Minus.Text = "Seviye - 2";
            this.Level2Minus.UseVisualStyleBackColor = true;
            this.Level2Minus.Click += new System.EventHandler(this.Level2Minus_Click);
            // 
            // Level1Minus
            // 
            this.Level1Minus.Location = new System.Drawing.Point(16, 89);
            this.Level1Minus.Name = "Level1Minus";
            this.Level1Minus.Size = new System.Drawing.Size(75, 23);
            this.Level1Minus.TabIndex = 6;
            this.Level1Minus.Text = "Seviye - 1";
            this.Level1Minus.UseVisualStyleBackColor = true;
            this.Level1Minus.Click += new System.EventHandler(this.Level1Minus_Click);
            // 
            // Notification
            // 
            this.Notification.AutoSize = true;
            this.Notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Notification.Location = new System.Drawing.Point(12, 9);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(327, 20);
            this.Notification.TabIndex = 5;
            this.Notification.Text = "Çıkarma egzersiz sayfasına hoşgeldiniz.";
            // 
            // Minus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 287);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Level2Minus);
            this.Controls.Add(this.Level1Minus);
            this.Controls.Add(this.Notification);
            this.Name = "Minus";
            this.Text = "Minus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button Level2Minus;
        private System.Windows.Forms.Button Level1Minus;
        private System.Windows.Forms.Label Notification;
    }
}