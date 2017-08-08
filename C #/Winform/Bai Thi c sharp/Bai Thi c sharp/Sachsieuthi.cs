using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Thi_c_sharp
{
    class Sachsieuthi:Sach
    {
        string masach, tensach;

        public string Tensach
        {
            get { return tensach; }
            set { tensach = value; }
        }

        public string Masach
        {
            get { return masach; }
            set { masach = value; }
        }
        int soluongban, soluongton;

        public int Soluongton
        {
            get { return soluongton; }
            set { soluongton = value; }
        }

        public int Soluongban
        {
            get { return soluongban; }
            set { soluongban = value; }
        }
        float doanhthu;

        public float Doanhthu
        {
            get { return doanhthu; }
            set { doanhthu = value; }
        }
        ~Sachsieuthi(){}
        public Sachsieuthi()
        {
            masach = "Sach01";
            tensach = "Chuyen chua ke";
            soluongban = 20; soluongton = 5;
            doanhthu =Giaban * soluongban;
        }
        public string ketxuatstring()
        {
            base.ketxuat();
            return Masach+",  "+Tensach+",  "+Soluongban+",  "+Soluongton+",  "+Doanhthu;
        }
    }
}
