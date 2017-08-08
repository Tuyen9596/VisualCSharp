using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Thi_c_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++) //duyệt tất cả các item trong list
            {

                if (listView1.Items[i].Selected)//nếu item đó dc click
                {
                    listView1.Items[i].Remove();//xóa item đó đi
                    i--;//giải thích ở dưới.
               }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sachsieuthi a = new Sachsieuthi();
            //Nap du lieu vao bien sachsieuthi
            a.Theloai = txttheloai.Text;
            a.Tentacgia = txttentacgia.Text;
            a.Nhaxuatban = txtnxb.Text;
            a.Giaban = float.Parse(txtgiaban.Text);
            a.Namsanxuat =int.Parse( txtnamxb.Text);
            a.Masach = txtmasach.Text;
            a.Tensach = txttensach.Text;
            a.Soluongban = int.Parse(txtsoluongban.Text);
            a.Soluongton = int.Parse(txtsoluonton.Text);
            a.Doanhthu =float.Parse( txtdoanhthu.Text);
            //Tao 1 item cho listview
            ListViewItem item = new ListViewItem(a.Theloai);
            item.SubItems.Add(a.Tentacgia);
            item.SubItems.Add(a.Nhaxuatban);
            item.SubItems.Add(a.Giaban.ToString());
            item.SubItems.Add(a.Namsanxuat.ToString());
            item.SubItems.Add(a.Masach);
            item.SubItems.Add(a.Tensach);
            item.SubItems.Add(a.Soluongban.ToString());
            item.SubItems.Add(a.Soluongton.ToString());
            item.SubItems.Add(a.Doanhthu.ToString());
            //add item vao listview
            listView1.Items.Add(item);
        }
    }
}
