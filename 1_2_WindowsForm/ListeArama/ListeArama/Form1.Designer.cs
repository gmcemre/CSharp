
namespace ListeArama
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.listIsim = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsimAra = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnKisiSayisi = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim :";
            // 
            // txtIsim
            // 
            this.txtIsim.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIsim.Location = new System.Drawing.Point(68, 31);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(148, 20);
            this.txtIsim.TabIndex = 0;
            // 
            // listIsim
            // 
            this.listIsim.FormattingEnabled = true;
            this.listIsim.Location = new System.Drawing.Point(28, 60);
            this.listIsim.Name = "listIsim";
            this.listIsim.Size = new System.Drawing.Size(188, 160);
            this.listIsim.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "İsim :";
            // 
            // txtIsimAra
            // 
            this.txtIsimAra.Location = new System.Drawing.Point(68, 239);
            this.txtIsimAra.Name = "txtIsimAra";
            this.txtIsimAra.Size = new System.Drawing.Size(148, 20);
            this.txtIsimAra.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(222, 29);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(95, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnKisiSayisi
            // 
            this.btnKisiSayisi.Location = new System.Drawing.Point(222, 60);
            this.btnKisiSayisi.Name = "btnKisiSayisi";
            this.btnKisiSayisi.Size = new System.Drawing.Size(95, 23);
            this.btnKisiSayisi.TabIndex = 2;
            this.btnKisiSayisi.Text = "KİŞİ SAYISI";
            this.btnKisiSayisi.UseVisualStyleBackColor = true;
            this.btnKisiSayisi.Click += new System.EventHandler(this.btnKisiSayisi_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(222, 237);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(95, 23);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 288);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnKisiSayisi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.listIsim);
            this.Controls.Add(this.txtIsimAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.ListBox listIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIsimAra;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnKisiSayisi;
        private System.Windows.Forms.Button btnAra;
    }
}

