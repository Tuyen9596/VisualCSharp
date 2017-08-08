using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace llstview
{
    class Nguoi
    {
        String ht, ns, dc;

        public String Dc
        {
            get { return dc; }
            set { dc = value; }
        }

        public String Ns
        {
            get { return ns; }
            set { ns = value; }
        }

        public String Ht
        {
            get { return ht; }
            set { ht = value; }
        }
        ~Nguoi() { }
        public Nguoi()
        {
            ht = "a";
            ns = "12";
            dc="as";
        }
        public string ketxuat()
        {
            return ht + "," + ns + "," + dc;
        }
    }
}
