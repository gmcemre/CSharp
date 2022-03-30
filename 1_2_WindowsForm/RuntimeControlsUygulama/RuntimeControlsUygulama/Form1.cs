using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuntimeControlsUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipler.SelectedIndex = 0;
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(nudAdet.Value);
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < adet; i++)
            {
                switch (cmbTipler.Text)
                {
                    case "Button":
                        Button btn = new Button();
                        btn.Height = 30;
                        btn.Width = 80;
                        btn.Text = string.Format("Button {0}", i + 1);
                        btn.Font = new Font("Tahoma", 10);
                        btn.BackColor = Color.Gray;
                        btn.Click += Btn_Click;
                        btn.MouseHover += Btn_MouseHover;
                        btn.MouseLeave += Btn_MouseLeave;
                        flowLayoutPanel1.Controls.Add(btn);
                        break;
                    case "TextBox":
                        TextBox txt = new TextBox();
                        flowLayoutPanel1.Controls.Add(txt);
                        break;
                    case "ListBox":
                        ListBox list = new ListBox();
                        flowLayoutPanel1.Controls.Add(list);
                        break;
                    case "ComboBox":
                        //Girilen adet kadar comboBox üretilecek. Her comboBox ın item larına eleman eklenecek. SelectedIndexChanged eventi tanımlanacak. Bu eventte seçilen elemanın ismi messageBox ile gösterilecek.Comboboxların dropdownstyle özelliği dropdownlist olacak .Her comboBox flowlayoutpanel e eklenecek.
                        ComboBox cmb = new ComboBox();
                        cmb.Items.Add("Item 1");
                        cmb.Items.Add("Item 2");
                        cmb.Items.Add("Item 3");
                        cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                        cmb.SelectedIndexChanged += Cmb_SelectedIndexChanged;
                        flowLayoutPanel1.Controls.Add(cmb);
                        break;
                    case "PictureBox":
                        PictureBox pct = new PictureBox();
                        flowLayoutPanel1.Controls.Add(pct);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox secilen = (ComboBox)sender;
            MessageBox.Show(secilen.Text);
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            tiklanan.BackColor = Color.Gray;
        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            tiklanan.BackColor = Color.Red;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            MessageBox.Show(string.Format("{0}'e Tıklandı.", tiklanan.Text));
        }
    }
}
