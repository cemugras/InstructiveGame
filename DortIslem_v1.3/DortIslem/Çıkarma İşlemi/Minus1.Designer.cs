namespace DortIslem.Çıkarma_İşlemi
{
    partial class Minus1
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
            this.ReturnMain = new System.Windows.Forms.Button();
            this.ReturnMinus = new System.Windows.Forms.Button();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.Sonuc = new System.Windows.Forms.Label();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.TextBox();
            this.add2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnMain
            // 
            this.ReturnMain.Location = new System.Drawing.Point(14, 133);
            this.ReturnMain.Name = "ReturnMain";
            this.ReturnMain.Size = new System.Drawing.Size(105, 23);
            this.ReturnMain.TabIndex = 17;
            this.ReturnMain.Text = "Ana Menü";
            this.ReturnMain.UseVisualStyleBackColor = true;
            this.ReturnMain.Click += new System.EventHandler(this.ReturnMain_Click_1);
            // 
            // ReturnMinus
            // 
            this.ReturnMinus.Location = new System.Drawing.Point(14, 103);
            this.ReturnMinus.Name = "ReturnMinus";
            this.ReturnMinus.Size = new System.Drawing.Size(105, 23);
            this.ReturnMinus.TabIndex = 16;
            this.ReturnMinus.Text = "Çıkarma Menüsü";
            this.ReturnMinus.UseVisualStyleBackColor = true;
            this.ReturnMinus.Click += new System.EventHandler(this.ReturnMinus_Click);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(14, 73);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(105, 23);
            this.ButtonRefresh.TabIndex = 15;
            this.ButtonRefresh.Text = "Yeniden Dene";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click_1);
            // 
            // Sonuc
            // 
            this.Sonuc.AutoSize = true;
            this.Sonuc.Location = new System.Drawing.Point(11, 47);
            this.Sonuc.Name = "Sonuc";
            this.Sonuc.Size = new System.Drawing.Size(38, 13);
            this.Sonuc.TabIndex = 14;
            this.Sonuc.Text = "Sonuc";
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Location = new System.Drawing.Point(218, 10);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(75, 23);
            this.ButtonMinus.TabIndex = 13;
            this.ButtonMinus.Text = "Tamamla";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(112, 12);
            this.Addition.MaxLength = 5;
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(100, 20);
            this.Addition.TabIndex = 12;
            // 
            // add2
            // 
            this.add2.AutoSize = true;
            this.add2.Location = new System.Drawing.Point(71, 15);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(35, 13);
            this.add2.TabIndex = 11;
            this.add2.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "-";
            // 
            // add1
            // 
            this.add1.AutoSize = true;
            this.add1.Location = new System.Drawing.Point(11, 15);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(35, 13);
            this.add1.TabIndex = 9;
            this.add1.Text = "label1";
            // 
            // Minus1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 192);
            this.ControlBox = false;
            this.Controls.Add(this.ReturnMain);
            this.Controls.Add(this.ReturnMinus);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.Sonuc);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Minus1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çıkarma İşlemi - Seviye 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnMain;
        private System.Windows.Forms.Button ReturnMinus;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.Label Sonuc;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.TextBox Addition;
        private System.Windows.Forms.Label add2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label add1;
    }
}