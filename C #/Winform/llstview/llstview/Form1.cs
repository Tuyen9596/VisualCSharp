using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace llstview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<listView1.Items.Count;i++)
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();
                }
        }

        private void button2_Click(object sender, EventArgs e)    
        {
            int dem = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text.ToString() == txtht.Text.ToString())
                {
                    MessageBox.Show("Khach hang da ton tai", "Thông báo");
                    dem++;
                }
           }
            if (dem <= 0)
            {
                Congto a = new Congto();
                a.Ht = txtht.Text;
                a.Ns = txtns.Text;
                a.Dc = txtdc.Text;
                a.Mct = txtmct.Text;
                a.Chisott = float.Parse(txtchisott.Text);
                ListViewItem b = new ListViewItem(a.Ht);
                b.SubItems.Add(a.Ns);
                b.SubItems.Add(a.Dc);
                b.SubItems.Add(a.Mct);
                b.SubItems.Add(a.Chisott.ToString());
                b.SubItems.Add(a.Sotientra.ToString());
                listView1.Items.Add(b);
                txtsotientra.Text = a.Sotientra.ToString();

            }
        }
    }
}
