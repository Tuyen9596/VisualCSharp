using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_thi_c_sharp_2
{
    class Nguoi
    {
        string hoten, ngaysinh, sodienthoai, diachia;

        public string Diachia
        {
            get { return diachia; }
            set { diachia = value; }
        }

        public string Sodienthoai
        {
            get { return sodienthoai; }
            set { sodienthoai = value; }
        }

        public string Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        ~Nguoi() { }
        public Nguoi()
        {
            hoten = "Tu";
            ngaysinh = "1/1/2011";
            sodienthoai = "019239192";
            diachia="Nam Dinh";
        }
        public string ketxuat()
        {
            return hoten + ",  " + ngaysinh + ",  " + sodienthoai + ",  " + diachia;
        }
    }
}
