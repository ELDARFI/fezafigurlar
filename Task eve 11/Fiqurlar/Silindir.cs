using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_eve_11.Fiqurlar
{
    class Silindir : fezafiqurlari
    {
        private double Pi;
        private double radius;
        private double hundurluk;
        public Silindir(double a, double b, double c)
            :base(a, b, c)
        {
            this.Pi = c;
            this.radius = a;
            this.hundurluk = b;
        }

        public double Hecmi()
        {
            return Pi * radius * radius* hundurluk;
        }

        public double Silindirinsahesi()
        {
            return 2 * radius * radius * Pi + 2 * Pi * radius * hundurluk;
        }

    }
}
