using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mar17Delo
{
    internal class GrafKonvert
    {
        //funkcie
        public double XgrafToFyz(int xG)
        {
            double xF = (double)xG / (xGmaxC - xGminC) * (xFmaxC - xFminC) + xFminC;
            return xF;
        }

        public double XgrafToFyz(int xG, int xGmax, int xGmin, double xFmax, double xFmin)
        {
            double xF = (double)xG / (xGmax - xGmin) * (xFmax - xFmin) + xFmin;
            return xF;
        }

        //z Ygraf na Yfyz


        //z Xfyz na Xgraf


        //z Yfyz na Ygraf
        public int YfyzToGraf(double yF)
        {
            yF = yF - yFminC; //z <yFmin,yFmax> na <0,yFmax - yFmin>
            yF = yF / (yFmaxC - yFminC);//z <0,yFmax - yFmin> na <0,1>
            int yG = (int)(yF * 1.0 * (yGmaxC - yGminC)); //z <0,1> na <0,yGmax - yGmin>
            yG = (yGmaxC - yGminC) - yG; //z <0,yGmax - yGmin> na <yGmax - yGmin,0>
            yG = yG + yGminC;                //z  <yGmax - yGmin,0> na <yGmax,yGmin>

            return yG;

        }
        //z Xgraf na Xfyz
        public int YfyzToGraf(double yF, int yGmax, int yGmin, double yFmax, double yFmin)
        {
            yF = yF - yFmin; //z <yFmin,yFmax> na <0,yFmax - yFmin>
            yF = yF / (yFmax - yFmin);//z <0,yFmax - yFmin> na <0,1>
            int yG = (int)(yF * 1.0 * (yGmax - yGmin)); //z <0,1> na <0,yGmax - yGmin>
            yG = (yGmax - yGmin) - yG; //z <0,yGmax - yGmin> na <yGmax - yGmin,0>
            yG = yG + yGmin;                //z  <yGmax - yGmin,0> na <yGmax,yGmin>

            return yG;

        }

        public void NastavXGmin(int xgmin)
        {
            xGminC = xgmin;
        }
        public void NastavXGmax(int xgmax)
        {
            xGmaxC = xgmax;
        }

        public void NastavYGmin(int ygmin)
        {
            yGminC = ygmin;
        }

        public void NastavYGmax(int ygmax)
        {
            yGmaxC = ygmax;
        }

        public void NastavXFmin(double xfmin)
        {
            xFminC = xfmin;
        }
        public void NastavXFmax(double xfmax)
        {
            xFmaxC = xfmax;
        }

        public void NastavYFmin(double yfmin)
        {
            yFminC = yfmin;
        }

        public void NastavYFmax(double yfmax)
        {
            yFmaxC = yfmax;
        }






        //premenne
        int xGminC = 0;
        int xGmaxC = 400;
        int yGminC = 0;
        int yGmaxC = 400;

        double xFminC = -1.0;
        double xFmaxC = 1.0;
        double yFminC = -1.0;
        double yFmaxC = 1.0;


    }
}
