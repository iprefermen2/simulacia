using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppHome
{
    public class Fyzika
    {
        protected double xFyz = 100.0; 
        protected double yFyz = 100.0; 

        protected double vx = 100.0; 
        protected double vy = 200.0; 

        protected double ax = 0.0;
        protected double ay = 0;

        protected const double ag = -9.81;

        protected double deltaT = 0.01; 
        protected double m = 100; 

        protected double Fx = 0;
        protected double Fy = 0;

        public virtual void Nastav(double xFyz, double yFyz, double dt, double hmotnost, double vx, double vy)
        {
            this.xFyz = xFyz;
            this.yFyz = yFyz;
            deltaT = dt;
            m = hmotnost;
            this.vx = vx;
            this.vy = vy;
        }
  

        public virtual void calculateF()
        {
            Fx = 0;
            Fy = m * ag;
        }
        protected void UpdateZrychlenie()
        {
            ax = Fx / m;
            ay = Fy / m ;
        }

        protected void UpdateRychlost()
        {
            vx += ax * deltaT;
            vy += ay * deltaT;
        }
       

        protected void UpdatePosition()
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
