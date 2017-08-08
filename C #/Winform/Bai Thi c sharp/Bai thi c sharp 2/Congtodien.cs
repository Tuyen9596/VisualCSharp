using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_thi_c_sharp_2
{
    class Congtodien:Nguoi
    {
        string macongto, ngaynapdat;

        public string Ngaynapdat
        {
            get { return ngaynapdat; }
            set { ngaynapdat = value; }
        }

        public string Macongto
        {
            get { return macongto; }
            set { macongto = value; }
        }
        float chisotieuthu, sotientra;

        public float Sotientra
        {
            get
            {
                if (chisotieuthu < 50)
                    sotientra = chisotieuthu * 1500;
                else if (chisotieuthu < 100 && chisotieuthu > 50)
                    sotientra = chisotieuthu * 1500 + (chisotieuthu - 50) * 200;
                else sotientra = chisotieuthu * 1500 + (100 - 50) * 200+(chisotieuthu-100)*500;
                return sotientra; }
            set { sotientra = value; }
        }

        public float Chisotieuthu
        {
            get { return chisotieuthu; }
            set { chisotieuthu = value; }
        }
        public string ketxuatdl()
        {
            base.ketxuat();
            return macongto + ",  " + ngaynapdat + ",  " + chisotieuthu + ",  " + Sotientra;
        }
    }
}
