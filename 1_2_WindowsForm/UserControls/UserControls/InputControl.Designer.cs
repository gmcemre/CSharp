﻿
namespace UserControls
{
    partial class InputControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblControl = new System.Windows.Forms.Label();
            this.txtControl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Location = new System.Drawing.Point(27, 25);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(35, 13);
            this.lblControl.TabIndex = 0;
            this.lblControl.Text = "label1";
            // 
            // txtControl
            // 
            this.txtControl.Location = new System.Drawing.Point(102, 22);
            this.txtControl.Name = "txtControl";
            this.txtControl.Size = new System.Drawing.Size(140, 20);
            this.txtControl.TabIndex = 1;
            // 
            // InputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtControl);
            this.Controls.Add(this.lblControl);
            this.Name = "InputControl";
            this.Size = new System.Drawing.Size(267, 59);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblControl;
        public System.Windows.Forms.TextBox txtControl;
    }
}
