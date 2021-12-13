using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_eve_11.Fiqurlar
{
    class fezafiqurlari
    {
        protected double radius;
        protected double Pi;

        protected double hundurluk;

        public fezafiqurlari (double radius, double hundurluk, double Pi)
        {
            this.radius = radius;
            this.hundurluk = hundurluk;
            this.Pi = Pi;

        }
        public double Oturacaqsahesi()
        {

            return radius * radius * Pi;

        }

    }
}
