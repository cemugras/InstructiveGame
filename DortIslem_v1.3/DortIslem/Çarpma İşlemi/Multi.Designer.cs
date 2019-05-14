namespace DortIslem.Çarpma_İşlemi
{
    partial class Multi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Multi));
            this.MainMenu = new System.Windows.Forms.Button();
            this.Level2Multi = new System.Windows.Forms.Button();
            this.Level1Multi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(320, 200);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(75, 23);
            this.MainMenu.TabIndex = 12;
            this.MainMenu.Text = "Ana Menü";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // Level2Multi
            // 
            this.Level2Multi.Location = new System.Drawing.Point(320, 100);
            this.Level2Multi.Name = "Level2Multi";
            this.Level2Multi.Size = new System.Drawing.Size(75, 23);
            this.Level2Multi.TabIndex = 11;
            this.Level2Multi.Text = "Seviye - 2";
            this.Level2Multi.UseVisualStyleBackColor = true;
            this.Level2Multi.Click += new System.EventHandler(this.Level2Multi_Click);
            // 
            // Level1Multi
            // 
            this.Level1Multi.Location = new System.Drawing.Point(320, 70);
            this.Level1Multi.Name = "Level1Multi";
            this.Level1Multi.Size = new System.Drawing.Size(75, 23);
            this.Level1Multi.TabIndex = 10;
            this.Level1Multi.Text = "Seviye - 1";
            this.Level1Multi.UseVisualStyleBackColor = true;
            this.Level1Multi.Click += new System.EventHandler(this.Level1Multi_Click);
            // 
            // Multi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 312);
            this.ControlBox = false;
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Level2Multi);
            this.Controls.Add(this.Level1Multi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "Multi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çarpma İşlemi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button Level2Multi;
        private System.Windows.Forms.Button Level1Multi;
    }
}