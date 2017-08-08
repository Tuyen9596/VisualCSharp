using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Thi_c_sharp
{
    class Sach
    {
        String theloai, tentacgia, nhaxuatban;

        public String Tentacgia
        {
            get { return tentacgia; }
            set { tentacgia = value; }
        }

        public String Nhaxuatban
        {
            get { return nhaxuatban; }
            set { nhaxuatban = value; }
        }

        public String Theloai
        {
            get { return theloai; }
            set { theloai = value; }
        }
        float giaban, namsanxuat;

        public float Namsanxuat
        {
            get { return namsanxuat; }
            set { namsanxuat = value; }
        }

        public float Giaban
        {
            get { return giaban; }
            set { giaban = value; }
        }
        ~Sach() { }
        public Sach()
        {
            theloai = "Sach tham khao";
            tentacgia = "Pham Huu Minh";
            nhaxuatban = "Kim Dong";
            giaban = 15000;
            namsanxuat = 2014;
        }
        public String ketxuat()
        {
            return Theloai +", "+Tentacgia+",  "+Nhaxuatban+",  "+giaban+",  "+Namsanxuat;

        }
    }
}
