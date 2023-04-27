using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppHome
{
    internal class Magnet:Fyzika
    {
        private double q = 0;

        public void Nastav(double xFyz, double yFyz, double dt, double hmotnost, double vx, double vy, double naboj)
        {
            this.xFyz = xFyz;
            this.yFyz = yFyz;
            deltaT = dt;
            m = hmotnost;
            this.vx = vx;
            this.vy = vy;
            this.q = naboj;
        }

        public override void calculateF()
        {
            Fx = vx*q;
            Fy = vy*q;
        }

    }
}
