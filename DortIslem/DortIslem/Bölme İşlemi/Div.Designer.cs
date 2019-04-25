namespace DortIslem.Bölme_İşlemi
{
    partial class Div
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
            this.Level2Div = new System.Windows.Forms.Button();
            this.Level1Div = new System.Windows.Forms.Button();
            this.Notification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(139, 227);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(75, 23);
            this.MainMenu.TabIndex = 20;
            this.MainMenu.Text = "Ana Menü";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // Level2Div
            // 
            this.Level2Div.Location = new System.Drawing.Point(16, 118);
            this.Level2Div.Name = "Level2Div";
            this.Level2Div.Size = new System.Drawing.Size(75, 23);
            this.Level2Div.TabIndex = 19;
            this.Level2Div.Text = "Seviye - 2";
            this.Level2Div.UseVisualStyleBackColor = true;
            this.Level2Div.Click += new System.EventHandler(this.Level2Div_Click);
            // 
            // Level1Div
            // 
            this.Level1Div.Location = new System.Drawing.Point(16, 89);
            this.Level1Div.Name = "Level1Div";
            this.Level1Div.Size = new System.Drawing.Size(75, 23);
            this.Level1Div.TabIndex = 18;
            this.Level1Div.Text = "Seviye - 1";
            this.Level1Div.UseVisualStyleBackColor = true;
            this.Level1Div.Click += new System.EventHandler(this.Level1Div_Click);
            // 
            // Notification
            // 
            this.Notification.AutoSize = true;
            this.Notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Notification.Location = new System.Drawing.Point(12, 9);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(312, 20);
            this.Notification.TabIndex = 17;
            this.Notification.Text = "Bölme egzersiz sayfasına hoşgeldiniz.";
            // 
            // Div
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 287);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Level2Div);
            this.Controls.Add(this.Level1Div);
            this.Controls.Add(this.Notification);
            this.Name = "Div";
            this.Text = "Div";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button Level2Div;
        private System.Windows.Forms.Button Level1Div;
        private System.Windows.Forms.Label Notification;
    }
}