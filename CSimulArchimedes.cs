using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppHome
{
    internal class Archimedes : Fyzika
    {
        //*****nastavit novu poziciu vo Fyz velicinach
        //vypocitame silu
        public void Nastav(double xFyz, double yFyz, double dt, double hmotnost, double vx, double vy, double hustotaVody, double hustotaMaterial)
        {
            this.xFyz = xFyz;
            this.yFyz = yFyz;
            deltaT = dt;
            m = hmotnost;
            this.vx = vx;
            this.vy = vy;
            roVody = hustotaVody;
            roMaterial = hustotaMaterial;
            m = priemer * priemer * priemer * roMaterial;
        }



        public override void calculateF()
        {
            double ponor = 0.5 * (hladina - yFyz) + 0.5;
            double viskozita = 1.0;
            Fx = 0.0;
            Fy = priemer * priemer * priemer * g * roMaterial;
            if (ponor >= 1.0)
            {
                Fy -= priemer * priemer * priemer * g * roVody;
                Fy -= 0.5 * 0.2 *priemer* priemer * Math.PI* roVody * vy * vy; //odpor
               // Fy -= 6.0 * viskozita * Math.PI * priemer* vy; //viskozita - Stokesov vzorec

            }
            else if (ponor >= 0.0)
            {
                Fy -= priemer * priemer * ponor * g * roVody;
                Fy -= 0.5 * 0.2 * priemer * priemer * Math.PI * roVody * vy * vy; //odpor
               // Fy -= 6.0 * viskozita * Math.PI * priemer * vy; //viskozita - Stokesov vzorec
            }
        }


        private double roVody = 1000.0; // v kg/m3
        private double roMaterial = 500.0; // v kg/m3
        public double hladina = 0.0;
        public double priemer = 0.4;





    }
}
