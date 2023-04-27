using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppHome
{
    internal class Pruzina:Fyzika
    {
        double k = 2;

        public void Nastav(double xFyz, double yFyz, double dt, double hmotnost, double vx, double vy,double k)
        {
            this.xFyz = xFyz;
            this.yFyz = yFyz;
            deltaT = dt;
            m = hmotnost;
            this.vx = vx;
            this.vy = vy;
            this.k = k;
        }


        public override void calculateF()
        {
            Fx = 0;
            Fy = -k * yFyz;
        }
        
    }
}
