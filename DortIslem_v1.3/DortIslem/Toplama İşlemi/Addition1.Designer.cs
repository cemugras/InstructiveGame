namespace DortIslem
{
    partial class Addition1
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
            this.add1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add2 = new System.Windows.Forms.Label();
            this.Addition = new System.Windows.Forms.TextBox();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.Sonuc = new System.Windows.Forms.Label();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.ReturnAddition = new System.Windows.Forms.Button();
            this.ReturnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add1
            // 
            this.add1.AutoSize = true;
            this.add1.Location = new System.Drawing.Point(11, 17);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(31, 13);
            this.add1.TabIndex = 0;
            this.add1.Text = "add1";
            this.add1.Click += new System.EventHandler(this.add1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "+";
            // 
            // add2
            // 
            this.add2.AutoSize = true;
            this.add2.Location = new System.Drawing.Point(71, 17);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(31, 13);
            this.add2.TabIndex = 2;
            this.add2.Text = "add2";
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(112, 14);
            this.Addition.MaxLength = 5;
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(100, 20);
            this.Addition.TabIndex = 3;
            this.Addition.TextChanged += new System.EventHandler(this.Addition_TextChanged);
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(218, 12);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(75, 23);
            this.ButtonSubmit.TabIndex = 4;
            this.ButtonSubmit.Text = "Tamamla";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // Sonuc
            // 
            this.Sonuc.AutoSize = true;
            this.Sonuc.Location = new System.Drawing.Point(11, 49);
            this.Sonuc.Name = "Sonuc";
            this.Sonuc.Size = new System.Drawing.Size(38, 13);
            this.Sonuc.TabIndex = 5;
            this.Sonuc.Text = "Sonuc";
            this.Sonuc.Click += new System.EventHandler(this.Sonuc_Click);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(14, 75);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(105, 23);
            this.ButtonRefresh.TabIndex = 6;
            this.ButtonRefresh.Text = "Yeniden Dene";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // ReturnAddition
            // 
            this.ReturnAddition.Location = new System.Drawing.Point(14, 105);
            this.ReturnAddition.Name = "ReturnAddition";
            this.ReturnAddition.Size = new System.Drawing.Size(105, 23);
            this.ReturnAddition.TabIndex = 7;
            this.ReturnAddition.Text = "Toplama Menüsü";
            this.ReturnAddition.UseVisualStyleBackColor = true;
            this.ReturnAddition.Click += new System.EventHandler(this.ReturnAddition_Click);
            // 
            // ReturnMain
            // 
            this.ReturnMain.Location = new System.Drawing.Point(14, 135);
            this.ReturnMain.Name = "ReturnMain";
            this.ReturnMain.Size = new System.Drawing.Size(105, 23);
            this.ReturnMain.TabIndex = 8;
            this.ReturnMain.Text = "Ana Menü";
            this.ReturnMain.UseVisualStyleBackColor = true;
            this.ReturnMain.Click += new System.EventHandler(this.ReturnMain_Click);
            // 
            // Addition1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 192);
            this.ControlBox = false;
            this.Controls.Add(this.ReturnMain);
            this.Controls.Add(this.ReturnAddition);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.Sonuc);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Addition1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplama İşlemi - Seviye 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label add1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label add2;
        private System.Windows.Forms.TextBox Addition;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.Label Sonuc;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.Button ReturnAddition;
        private System.Windows.Forms.Button ReturnMain;
    }
}