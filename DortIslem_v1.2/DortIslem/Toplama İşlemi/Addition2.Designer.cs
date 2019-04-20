namespace DortIslem.Toplama_İşlemi
{
    partial class Addition2
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
            this.ReturnAddition = new System.Windows.Forms.Button();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.Sonuc = new System.Windows.Forms.Label();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.TextBox();
            this.add2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnMain
            // 
            this.ReturnMain.Location = new System.Drawing.Point(16, 135);
            this.ReturnMain.Name = "ReturnMain";
            this.ReturnMain.Size = new System.Drawing.Size(105, 23);
            this.ReturnMain.TabIndex = 17;
            this.ReturnMain.Text = "Ana Menü";
            this.ReturnMain.UseVisualStyleBackColor = true;
            this.ReturnMain.Click += new System.EventHandler(this.ReturnMain_Click);
            // 
            // ReturnAddition
            // 
            this.ReturnAddition.Location = new System.Drawing.Point(16, 105);
            this.ReturnAddition.Name = "ReturnAddition";
            this.ReturnAddition.Size = new System.Drawing.Size(105, 23);
            this.ReturnAddition.TabIndex = 16;
            this.ReturnAddition.Text = "Toplama Menüsü";
            this.ReturnAddition.UseVisualStyleBackColor = true;
            this.ReturnAddition.Click += new System.EventHandler(this.ReturnAddition_Click);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(16, 75);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(105, 23);
            this.ButtonRefresh.TabIndex = 15;
            this.ButtonRefresh.Text = "Yeniden Dene";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // Sonuc
            // 
            this.Sonuc.AutoSize = true;
            this.Sonuc.Location = new System.Drawing.Point(13, 49);
            this.Sonuc.Name = "Sonuc";
            this.Sonuc.Size = new System.Drawing.Size(38, 13);
            this.Sonuc.TabIndex = 14;
            this.Sonuc.Text = "Sonuc";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(220, 12);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(75, 23);
            this.ButtonSubmit.TabIndex = 13;
            this.ButtonSubmit.Text = "Tamamla";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(114, 14);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(100, 20);
            this.Addition.TabIndex = 12;
            // 
            // add2
            // 
            this.add2.AutoSize = true;
            this.add2.Location = new System.Drawing.Point(73, 17);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(35, 13);
            this.add2.TabIndex = 11;
            this.add2.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "+";
            // 
            // add1
            // 
            this.add1.AutoSize = true;
            this.add1.Location = new System.Drawing.Point(13, 17);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(35, 13);
            this.add1.TabIndex = 9;
            this.add1.Text = "label1";
            // 
            // Addition2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 192);
            this.Controls.Add(this.ReturnMain);
            this.Controls.Add(this.ReturnAddition);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.Sonuc);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add1);
            this.Name = "Addition2";
            this.Text = "Addition2";
            this.Load += new System.EventHandler(this.Addition2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnMain;
        private System.Windows.Forms.Button ReturnAddition;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.Label Sonuc;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.TextBox Addition;
        private System.Windows.Forms.Label add2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label add1;
    }
}