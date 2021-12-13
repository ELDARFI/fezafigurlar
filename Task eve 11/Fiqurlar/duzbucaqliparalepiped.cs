using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_eve_11.Fiqurlar
{
    class duzbucaqliparalepiped 
    {
        private double yan;
        private double en;
        private double hundurluk;

        public duzbucaqliparalepiped(double a, double b, double c)
        {
            yan = a;
            en = b;
            hundurluk = c;
        }
        public double Hecmi()
        {
            return yan * en * hundurluk;
        }
        public double STam()
        {
            return 2 * (yan * en + en * hundurluk + hundurluk * yan);
        }
    }
}
