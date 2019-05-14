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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minus));
            this.MainMenu = new System.Windows.Forms.Button();
            this.Level2Minus = new System.Windows.Forms.Button();
            this.Level1Minus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(310, 204);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(75, 23);
            this.MainMenu.TabIndex = 8;
            this.MainMenu.Text = "Ana Menü";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click_1);
            // 
            // Level2Minus
            // 
            this.Level2Minus.Location = new System.Drawing.Point(310, 104);
            this.Level2Minus.Name = "Level2Minus";
            this.Level2Minus.Size = new System.Drawing.Size(75, 23);
            this.Level2Minus.TabIndex = 7;
            this.Level2Minus.Text = "Seviye - 2";
            this.Level2Minus.UseVisualStyleBackColor = true;
            this.Level2Minus.Click += new System.EventHandler(this.Level2Minus_Click);
            // 
            // Level1Minus
            // 
            this.Level1Minus.Location = new System.Drawing.Point(310, 74);
            this.Level1Minus.Name = "Level1Minus";
            this.Level1Minus.Size = new System.Drawing.Size(75, 23);
            this.Level1Minus.TabIndex = 6;
            this.Level1Minus.Text = "Seviye - 1";
            this.Level1Minus.UseVisualStyleBackColor = true;
            this.Level1Minus.Click += new System.EventHandler(this.Level1Minus_Click);
            // 
            // Minus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 312);
            this.ControlBox = false;
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Level2Minus);
            this.Controls.Add(this.Level1Minus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Minus";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çıkarma İşlemi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button Level2Minus;
        private System.Windows.Forms.Button Level1Minus;
    }
}