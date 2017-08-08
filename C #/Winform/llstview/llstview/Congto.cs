using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace llstview
{
    class Congto:Nguoi
    {
        string mct;

        public string Mct
        {
            get { return mct; }
            set { mct = value; }
        }
        float chisott, sotientra;

        public float Sotientra
        {
            get {
                if (chisott <50)
                    sotientra = chisott * 1500;
                else
                    if (chisott < 100 && chisott > 50)
                        sotientra = chisott * 1500 + (100 - 50) * 200;
                    else if (chisott > 100)
                        sotientra = chisott * 1500 + (100 - 50) * 200 + (chisott - 100) * 500;
                return sotientra; }
            set { sotientra = value; }
        }

        public float Chisott
        {
            get { return chisott; }
            set { chisott = value; }
        }
        ~Congto() { }
        public Congto()
        {
            mct = "12";
            chisott = 12;
            sotientra = 1000;

        }
        public string ketxuatdl()
        {
            base.ketxuat();
            return mct+","+chisott+","+sotientra;
        }
    }
}
