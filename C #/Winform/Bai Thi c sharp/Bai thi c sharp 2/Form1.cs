using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_thi_c_sharp_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //nap du lieu cho bien congtodien
            Congtodien a = new Congtodien();
            a.Hoten = txthoten.Text;
            a.Ngaysinh = txtngaysinh.Text;
            a.Sodienthoai = txtsodienthoai.Text;
            a.Diachia = txtdiachi.Text;
            a.Macongto = txtmacongto.Text;
            a.Ngaynapdat = txtngaynapdat.Text;
            a.Chisotieuthu = float.Parse(txtchiso.Text);
            txtsotientra.Text = a.Sotientra.ToString();
            //tao 1 listviewitem
            ListViewItem item = new ListViewItem(a.Hoten);
            item.SubItems.Add(a.Ngaysinh);
            item.SubItems.Add(a.Sodienthoai);
            item.SubItems.Add(a.Diachia);
            item.SubItems.Add(a.Macongto);
            item.SubItems.Add(a.Ngaynapdat);
            item.SubItems.Add(a.Chisotieuthu.ToString());
            item.SubItems.Add(txtsotientra.Text);
            //add vao listview
            listView1.Items.Add(item);

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
    }
}
