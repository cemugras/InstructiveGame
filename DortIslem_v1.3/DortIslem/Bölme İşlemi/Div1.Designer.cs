﻿namespace DortIslem.Bölme_İşlemi
{
    partial class Div1
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
            this.ReturnDiv = new System.Windows.Forms.Button();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.Sonuc = new System.Windows.Forms.Label();
            this.ButtonDiv = new System.Windows.Forms.Button();
            this.Dividing = new System.Windows.Forms.TextBox();
            this.add2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnMain
            // 
            this.ReturnMain.Location = new System.Drawing.Point(18, 133);
            this.ReturnMain.Name = "ReturnMain";
            this.ReturnMain.Size = new System.Drawing.Size(105, 23);
            this.ReturnMain.TabIndex = 35;
            this.ReturnMain.Text = "Ana Menü";
            this.ReturnMain.UseVisualStyleBackColor = true;
            this.ReturnMain.Click += new System.EventHandler(this.ReturnMain_Click);
            // 
            // ReturnDiv
            // 
            this.ReturnDiv.Location = new System.Drawing.Point(18, 103);
            this.ReturnDiv.Name = "ReturnDiv";
            this.ReturnDiv.Size = new System.Drawing.Size(105, 23);
            this.ReturnDiv.TabIndex = 34;
            this.ReturnDiv.Text = "Bölme Menüsü";
            this.ReturnDiv.UseVisualStyleBackColor = true;
            this.ReturnDiv.Click += new System.EventHandler(this.ReturnDiv_Click);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(18, 73);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(105, 23);
            this.ButtonRefresh.TabIndex = 33;
            this.ButtonRefresh.Text = "Yeniden Dene";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // Sonuc
            // 
            this.Sonuc.AutoSize = true;
            this.Sonuc.Location = new System.Drawing.Point(15, 47);
            this.Sonuc.Name = "Sonuc";
            this.Sonuc.Size = new System.Drawing.Size(38, 13);
            this.Sonuc.TabIndex = 32;
            this.Sonuc.Text = "Sonuc";
            // 
            // ButtonDiv
            // 
            this.ButtonDiv.Location = new System.Drawing.Point(222, 10);
            this.ButtonDiv.Name = "ButtonDiv";
            this.ButtonDiv.Size = new System.Drawing.Size(75, 23);
            this.ButtonDiv.TabIndex = 31;
            this.ButtonDiv.Text = "Tamamla";
            this.ButtonDiv.UseVisualStyleBackColor = true;
            this.ButtonDiv.Click += new System.EventHandler(this.ButtonDiv_Click);
            // 
            // Dividing
            // 
            this.Dividing.Location = new System.Drawing.Point(116, 12);
            this.Dividing.MaxLength = 5;
            this.Dividing.Name = "Dividing";
            this.Dividing.Size = new System.Drawing.Size(100, 20);
            this.Dividing.TabIndex = 30;
            // 
            // add2
            // 
            this.add2.AutoSize = true;
            this.add2.Location = new System.Drawing.Point(75, 15);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(35, 13);
            this.add2.TabIndex = 29;
            this.add2.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "/";
            // 
            // add1
            // 
            this.add1.AutoSize = true;
            this.add1.Location = new System.Drawing.Point(15, 15);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(35, 13);
            this.add1.TabIndex = 27;
            this.add1.Text = "label1";
            // 
            // Div1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 192);
            this.ControlBox = false;
            this.Controls.Add(this.ReturnMain);
            this.Controls.Add(this.ReturnDiv);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.Sonuc);
            this.Controls.Add(this.ButtonDiv);
            this.Controls.Add(this.Dividing);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Div1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bölme İşlemi - Seviye 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnMain;
        private System.Windows.Forms.Button ReturnDiv;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.Label Sonuc;
        private System.Windows.Forms.Button ButtonDiv;
        private System.Windows.Forms.TextBox Dividing;
        private System.Windows.Forms.Label add2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label add1;
    }
}