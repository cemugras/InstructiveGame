namespace DortIslem
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.AddButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.CrossButton = new System.Windows.Forms.Button();
            this.SubsButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.türkçeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Location = new System.Drawing.Point(287, 658);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(80, 80);
            this.AddButton.TabIndex = 0;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DivideButton.BackgroundImage")));
            this.DivideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DivideButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DivideButton.Location = new System.Drawing.Point(1104, 396);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(80, 80);
            this.DivideButton.TabIndex = 1;
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // CrossButton
            // 
            this.CrossButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CrossButton.BackgroundImage")));
            this.CrossButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CrossButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrossButton.Location = new System.Drawing.Point(866, 488);
            this.CrossButton.Name = "CrossButton";
            this.CrossButton.Size = new System.Drawing.Size(80, 80);
            this.CrossButton.TabIndex = 2;
            this.CrossButton.UseVisualStyleBackColor = true;
            this.CrossButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // SubsButton
            // 
            this.SubsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SubsButton.BackgroundImage")));
            this.SubsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubsButton.Location = new System.Drawing.Point(612, 575);
            this.SubsButton.Name = "SubsButton";
            this.SubsButton.Size = new System.Drawing.Size(80, 80);
            this.SubsButton.TabIndex = 3;
            this.SubsButton.UseVisualStyleBackColor = true;
            this.SubsButton.Click += new System.EventHandler(this.SubsButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dilAyarlarıToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menüToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // dilAyarlarıToolStripMenuItem
            // 
            this.dilAyarlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.türkçeToolStripMenuItem});
            this.dilAyarlarıToolStripMenuItem.Name = "dilAyarlarıToolStripMenuItem";
            this.dilAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.dilAyarlarıToolStripMenuItem.Text = "Dil Ayarları";
            // 
            // türkçeToolStripMenuItem
            // 
            this.türkçeToolStripMenuItem.Name = "türkçeToolStripMenuItem";
            this.türkçeToolStripMenuItem.Size = new System.Drawing.Size(145, 30);
            this.türkçeToolStripMenuItem.Text = "Türkçe";
            this.türkçeToolStripMenuItem.Click += new System.EventHandler(this.türkçeToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.yardımToolStripMenuItem.Text = "Yardım";
            this.yardımToolStripMenuItem.Click += new System.EventHandler(this.yardımToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(202, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(930, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dört işlem egzersiz uygulamasına hoşgeldiniz. Yapmak istediğiniz egzersizi aşağıd" +
    "an seçiniz.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubsButton);
            this.Controls.Add(this.CrossButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dört İşlem Oyunu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button CrossButton;
        private System.Windows.Forms.Button SubsButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem türkçeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}