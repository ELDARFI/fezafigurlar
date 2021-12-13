using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_eve_11.Fiqurlar
{
    class Konus : fezafiqurlari
    {
        private double Pi;
        private double radius;
        private double hundurluk;
        public Konus(double a, double b, double c)
            :base(a, b, c )
        {
            this.radius = a;
            this.hundurluk = b;
            this.Pi = c;
        }

        public double Hecmi()
        {
            return radius * radius * Pi * hundurluk / 3;
        }
        public double Tamsethininsahesi()
        {
            return Pi * radius * (radius + hundurluk);
        }
    }
}
