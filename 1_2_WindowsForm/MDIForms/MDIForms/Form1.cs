using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PersonelForm pf = new PersonelForm();
        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Eğer herhangi bir formu MDI form olarak açmak istiyorsak Show metodu ile açmalıyız.
            if (!pf.IsDisposed)
            {
                pf = new PersonelForm();
            }
            pf.MdiParent = this;
            pf.Show();
        }
        MusteriForm mf = new MusteriForm();
        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mf.IsDisposed)
            {
                mf = new MusteriForm();
            }
            mf.MdiParent = this;
            mf.Show();
        }
    }
}
