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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Div));
            this.MainMenu = new System.Windows.Forms.Button();
            this.Level2Div = new System.Windows.Forms.Button();
            this.Level1Div = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(308, 201);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(75, 23);
            this.MainMenu.TabIndex = 20;
            this.MainMenu.Text = "Ana Menü";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // Level2Div
            // 
            this.Level2Div.Location = new System.Drawing.Point(308, 101);
            this.Level2Div.Name = "Level2Div";
            this.Level2Div.Size = new System.Drawing.Size(75, 23);
            this.Level2Div.TabIndex = 19;
            this.Level2Div.Text = "Seviye - 2";
            this.Level2Div.UseVisualStyleBackColor = true;
            this.Level2Div.Click += new System.EventHandler(this.Level2Div_Click);
            // 
            // Level1Div
            // 
            this.Level1Div.Location = new System.Drawing.Point(308, 71);
            this.Level1Div.Name = "Level1Div";
            this.Level1Div.Size = new System.Drawing.Size(75, 23);
            this.Level1Div.TabIndex = 18;
            this.Level1Div.Text = "Seviye - 1";
            this.Level1Div.UseVisualStyleBackColor = true;
            this.Level1Div.Click += new System.EventHandler(this.Level1Div_Click);
            // 
            // Div
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 312);
            this.ControlBox = false;
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Level2Div);
            this.Controls.Add(this.Level1Div);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Div";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bölme İşlemi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button Level2Div;
        private System.Windows.Forms.Button Level1Div;
    }
}