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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addition));
            this.Level1Sum = new System.Windows.Forms.Button();
            this.Level2Sum = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Level1Sum
            // 
            this.Level1Sum.Location = new System.Drawing.Point(320, 70);
            this.Level1Sum.Name = "Level1Sum";
            this.Level1Sum.Size = new System.Drawing.Size(75, 23);
            this.Level1Sum.TabIndex = 1;
            this.Level1Sum.Text = "Seviye - 1";
            this.Level1Sum.UseVisualStyleBackColor = true;
            this.Level1Sum.Click += new System.EventHandler(this.Level1Sum_Click);
            // 
            // Level2Sum
            // 
            this.Level2Sum.Location = new System.Drawing.Point(320, 100);
            this.Level2Sum.Name = "Level2Sum";
            this.Level2Sum.Size = new System.Drawing.Size(75, 23);
            this.Level2Sum.TabIndex = 2;
            this.Level2Sum.Text = "Seviye - 2";
            this.Level2Sum.UseVisualStyleBackColor = true;
            this.Level2Sum.Click += new System.EventHandler(this.Level2Sum_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(320, 200);
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
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 312);
            this.ControlBox = false;
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Level2Sum);
            this.Controls.Add(this.Level1Sum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Addition";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplama İşlemi";
            this.Load += new System.EventHandler(this.Addition_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Level1Sum;
        private System.Windows.Forms.Button Level2Sum;
        private System.Windows.Forms.Button MainMenu;
    }
}