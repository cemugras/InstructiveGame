﻿namespace DortIslem.Çarpma_İşlemi
{
    partial class Multi1
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
            this.ReturnMulti = new System.Windows.Forms.Button();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.Sonuc = new System.Windows.Forms.Label();
            this.ButtonMulti = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.TextBox();
            this.add2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnMain
            // 
            this.ReturnMain.Location = new System.Drawing.Point(18, 135);
            this.ReturnMain.Name = "ReturnMain";
            this.ReturnMain.Size = new System.Drawing.Size(105, 23);
            this.ReturnMain.TabIndex = 26;
            this.ReturnMain.Text = "Ana Menü";
            this.ReturnMain.UseVisualStyleBackColor = true;
            this.ReturnMain.Click += new System.EventHandler(this.ReturnMain_Click);
            // 
            // ReturnMulti
            // 
            this.ReturnMulti.Location = new System.Drawing.Point(18, 105);
            this.ReturnMulti.Name = "ReturnMulti";
            this.ReturnMulti.Size = new System.Drawing.Size(105, 23);
            this.ReturnMulti.TabIndex = 25;
            this.ReturnMulti.Text = "Çarpma Menüsü";
            this.ReturnMulti.UseVisualStyleBackColor = true;
            this.ReturnMulti.Click += new System.EventHandler(this.ReturnMulti_Click);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(18, 75);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(105, 23);
            this.ButtonRefresh.TabIndex = 24;
            this.ButtonRefresh.Text = "Yeniden Dene";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // Sonuc
            // 
            this.Sonuc.AutoSize = true;
            this.Sonuc.Location = new System.Drawing.Point(15, 49);
            this.Sonuc.Name = "Sonuc";
            this.Sonuc.Size = new System.Drawing.Size(38, 13);
            this.Sonuc.TabIndex = 23;
            this.Sonuc.Text = "Sonuc";
            // 
            // ButtonMulti
            // 
            this.ButtonMulti.Location = new System.Drawing.Point(222, 12);
            this.ButtonMulti.Name = "ButtonMulti";
            this.ButtonMulti.Size = new System.Drawing.Size(75, 23);
            this.ButtonMulti.TabIndex = 22;
            this.ButtonMulti.Text = "Tamamla";
            this.ButtonMulti.UseVisualStyleBackColor = true;
            this.ButtonMulti.Click += new System.EventHandler(this.ButtonMulti_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(116, 14);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(100, 20);
            this.Multiplication.TabIndex = 21;
            // 
            // add2
            // 
            this.add2.AutoSize = true;
            this.add2.Location = new System.Drawing.Point(75, 17);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(35, 13);
            this.add2.TabIndex = 20;
            this.add2.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "X";
            // 
            // add1
            // 
            this.add1.AutoSize = true;
            this.add1.Location = new System.Drawing.Point(15, 17);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(35, 13);
            this.add1.TabIndex = 18;
            this.add1.Text = "label1";
            // 
            // Multi1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 192);
            this.Controls.Add(this.ReturnMain);
            this.Controls.Add(this.ReturnMulti);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.Sonuc);
            this.Controls.Add(this.ButtonMulti);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add1);
            this.Name = "Multi1";
            this.Text = "Multi1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnMain;
        private System.Windows.Forms.Button ReturnMulti;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.Label Sonuc;
        private System.Windows.Forms.Button ButtonMulti;
        private System.Windows.Forms.TextBox Multiplication;
        private System.Windows.Forms.Label add2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label add1;
    }
}