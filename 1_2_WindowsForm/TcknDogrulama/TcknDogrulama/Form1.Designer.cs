
namespace TcknDogrulama
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
            this.mtbTckn = new System.Windows.Forms.MaskedTextBox();
            this.btnDogrula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TCKN :";
            // 
            // mtbTckn
            // 
            this.mtbTckn.Location = new System.Drawing.Point(113, 65);
            this.mtbTckn.Mask = "00000000000";
            this.mtbTckn.Name = "mtbTckn";
            this.mtbTckn.Size = new System.Drawing.Size(165, 20);
            this.mtbTckn.TabIndex = 0;
            this.mtbTckn.ValidatingType = typeof(int);
            // 
            // btnDogrula
            // 
            this.btnDogrula.Location = new System.Drawing.Point(203, 91);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(75, 23);
            this.btnDogrula.TabIndex = 1;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = true;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDogrula;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 154);
            this.Controls.Add(this.btnDogrula);
            this.Controls.Add(this.mtbTckn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbTckn;
        private System.Windows.Forms.Button btnDogrula;
    }
}

