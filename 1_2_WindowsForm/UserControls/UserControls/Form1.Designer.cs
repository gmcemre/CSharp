﻿
namespace UserControls
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctrlTelefon = new UserControls.InputControl();
            this.ctrlAdres = new UserControls.InputControl();
            this.ctrlSoyadi = new UserControls.InputControl();
            this.ctrlAdi = new UserControls.InputControl();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(56, 111);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(682, 312);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyadı";
            this.columnHeader2.Width = 143;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adres";
            this.columnHeader3.Width = 196;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 366;
            // 
            // ctrlTelefon
            // 
            this.ctrlTelefon.Location = new System.Drawing.Point(376, 46);
            this.ctrlTelefon.Name = "ctrlTelefon";
            this.ctrlTelefon.Size = new System.Drawing.Size(267, 59);
            this.ctrlTelefon.TabIndex = 4;
            // 
            // ctrlAdres
            // 
            this.ctrlAdres.Location = new System.Drawing.Point(376, 0);
            this.ctrlAdres.Name = "ctrlAdres";
            this.ctrlAdres.Size = new System.Drawing.Size(267, 59);
            this.ctrlAdres.TabIndex = 3;
            // 
            // ctrlSoyadi
            // 
            this.ctrlSoyadi.Location = new System.Drawing.Point(56, 54);
            this.ctrlSoyadi.Name = "ctrlSoyadi";
            this.ctrlSoyadi.Size = new System.Drawing.Size(267, 51);
            this.ctrlSoyadi.TabIndex = 2;
            // 
            // ctrlAdi
            // 
            this.ctrlAdi.Location = new System.Drawing.Point(56, 1);
            this.ctrlAdi.Name = "ctrlAdi";
            this.ctrlAdi.Size = new System.Drawing.Size(267, 59);
            this.ctrlAdi.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlTelefon);
            this.Controls.Add(this.ctrlAdres);
            this.Controls.Add(this.ctrlSoyadi);
            this.Controls.Add(this.ctrlAdi);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public InputControl ctrlSoyadi;
        public InputControl ctrlAdres;
        public InputControl ctrlTelefon;
        public InputControl ctrlAdi;
    }
}

