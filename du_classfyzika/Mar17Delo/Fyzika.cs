using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mar17Delo
{
    public class Fyzika
    {
        private double xFyz = 100.0; 
        private double yFyz = 100.0; 

        private double vx = 100.0; 
        private double vy = 200.0; 

        private double ax = 0.0;
        private double ay = 0;

        const double ag = -9.81;

        private double deltaT = 0.01; 
        private double m = 100; 

        private double Fx = 0;
        private double Fy = 0;

        public void Nastav(double xFyz, double yFyz, double dt, double hmotnost, double vx, double vy)
        {
            this.xFyz = xFyz;
            this.yFyz = yFyz;
            deltaT = dt;
            m = hmotnost;
            this.vx = vx;
            this.vy = vy;
        }
  

        private void calculateF()
        {
            Fx = 0;
            Fy = m * ag;
        }
        private void UpdateZrychlenie()
        {
            ax = Fx / m;
            ay = Fy / m - 9.81;
        }

        private void UpdateRychlost()
        {
            vx += ax * deltaT;
            vy += ay * deltaT;
        }
       

        private void UpdatePosition()
        {
            xFyz += vx * deltaT;
            yFyz += vy * deltaT;
        }


        public void Update()
        {
            calculateF();
            UpdateZrychlenie();
            UpdateRychlost();
            UpdatePosition();        
        }

        public double GetXFyz()
        {
            return xFyz;
        }

        public double GetYFyz()
        {
            return yFyz;
        }

        public void IncreaseRychlost()
        {
            if (vx >= 0)
                vx++;
            else
                vx--;
            if (vy >= 0)
                vy++;
            else
                vy--;
        }
        public void DecreaseRychlost()
        {
            if (vx > 0)
                vx--;
            if (vx < 0)
                vx++;
            if (vy > 0)
                vy--;
            if (vy < 0)
                vy++;
        }
    }

}
