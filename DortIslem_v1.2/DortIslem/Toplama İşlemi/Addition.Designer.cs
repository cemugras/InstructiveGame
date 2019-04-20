namespace DortIslem
{
    partial class Addition
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
            this.Notification = new System.Windows.Forms.Label();
            this.Level1Sum = new System.Windows.Forms.Button();
            this.Level2Sum = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Notification
            // 
            this.Notification.AutoSize = true;
            this.Notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Notification.Location = new System.Drawing.Point(13, 13);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(330, 20);
            this.Notification.TabIndex = 0;
            this.Notification.Text = "Toplama egzersiz sayfasına hoşgeldiniz.";
            // 
            // Level1Sum
            // 
            this.Level1Sum.Location = new System.Drawing.Point(17, 93);
            this.Level1Sum.Name = "Level1Sum";
            this.Level1Sum.Size = new System.Drawing.Size(75, 23);
            this.Level1Sum.TabIndex = 1;
            this.Level1Sum.Text = "Seviye - 1";
            this.Level1Sum.UseVisualStyleBackColor = true;
            this.Level1Sum.Click += new System.EventHandler(this.Level1Sum_Click);
            // 
            // Level2Sum
            // 
            this.Level2Sum.Location = new System.Drawing.Point(17, 122);
            this.Level2Sum.Name = "Level2Sum";
            this.Level2Sum.Size = new System.Drawing.Size(75, 23);
            this.Level2Sum.TabIndex = 2;
            this.Level2Sum.Text = "Seviye - 2";
            this.Level2Sum.UseVisualStyleBackColor = true;
            this.Level2Sum.Click += new System.EventHandler(this.Level2Sum_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(140, 231);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(75, 23);
            this.MainMenu.TabIndex = 4;
            this.MainMenu.Text = "Ana Menü";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // Addition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 287);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Level2Sum);
            this.Controls.Add(this.Level1Sum);
            this.Controls.Add(this.Notification);
            this.Name = "Addition";
            this.Text = "Addition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Notification;
        private System.Windows.Forms.Button Level1Sum;
        private System.Windows.Forms.Button Level2Sum;
        private System.Windows.Forms.Button MainMenu;
    }
}