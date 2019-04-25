namespace DortIslem
{
    partial class MenuExit
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
            this.ExitConfirm = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitConfirm
            // 
            this.ExitConfirm.AutoSize = true;
            this.ExitConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitConfirm.Location = new System.Drawing.Point(102, 35);
            this.ExitConfirm.Name = "ExitConfirm";
            this.ExitConfirm.Size = new System.Drawing.Size(281, 20);
            this.ExitConfirm.TabIndex = 0;
            this.ExitConfirm.Text = "Çıkış yapmak istediğinize emin misiniz?";
            this.ExitConfirm.Click += new System.EventHandler(this.ExitConfirm_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(106, 83);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Çıkış";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(308, 83);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(75, 23);
            this.MainMenu.TabIndex = 4;
            this.MainMenu.Text = "Ana Menü";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // MenuExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(484, 162);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ExitConfirm);
            this.Name = "MenuExit";
            this.Text = "MenuExit";
            this.Load += new System.EventHandler(this.MenuExit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitConfirm;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MainMenu;
    }
}