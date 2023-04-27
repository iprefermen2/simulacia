using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppHome
{
    internal class CGrafPrevod
    {
        // privatne private ...

        //public CGrafPrevod (int XGrafMin, int XGrafMax, double XMathMin, double XMathMax, int YGrafMin, int YGrafMax, double YMathMin, double YMathMax)
        //{
        //    YgrafMin = YGrafMin;
        //    YgrafMax = YGrafMax;
        //    YmathMin = YMathMin;
        //    YmathMax = YMathMax;
        //    XgrafMin = XGrafMin;
        //    XgrafMax = XGrafMax;
        //    XmathMin = XMathMin;
        //    XmathMax = XMathMax;
        //}
        //funkcie
        
        public double XgrafToMath(int XGrafMin, int XGrafMax, double XMathMin, double XMathMax, int Xgraf)
        {
            //double x = (Xgraf - XGrafMin) * (XMathMax - XMathMin) / (XGrafMax - XGrafMin) + XMathMin; 
            //prevedie interval <XGrafMin..XGrafMax> na ,<0...(XMathMax-XMathMin)>
            int x1 = Xgraf - XGrafMin;
            //preskalovanie z <0...(XMathMax-XMathMin)> na <XGrafMin - XGrafMax>
            double x2 = Convert.ToDouble(1.0 * x1 * (XMathMax - XMathMin) / (XGrafMax - XGrafMin));
            double x3 = x2 + XGrafMin;
            return x3;
        }

        public double XgrafToMath(int Xgraf)
        {
            //double x = (Xgraf - XGrafMin) * (XMathMax - XMathMin) / (XGrafMax - XGrafMin) + XMathMin; 
            //prevedie interval <XGrafMin..XGrafMax> na ,<0...(XMathMax-XMathMin)>
            int x1 = Xgraf - XgrafMin;
            //preskalovanie z <0...(XMathMax-XMathMin)> na <XGrafMin - XGrafMax>
            double x2 = Convert.ToDouble(1.0 * x1 * (XmathMax - XmathMin) / (XgrafMax - XgrafMin));
            double x3 = x2 + XgrafMin;
            return x3;
        }

        public int XmathToGraf(int XGrafMin, int XGrafMax, double XMathMin, double XMathMax, double XMath)
        {
            double x1 =  XMath - XMathMin;
            double x2 = x1/(XMathMax - XMathMin); //dostanem interval <0,1>
            int x3 = Convert.ToInt32(x2 * (XGrafMax - XGrafMin)); //dostanem interval <0, graf max- graf min>....zostava uz len priratat pusun
            int x4 = x3 - XGrafMin;
            return x4;
        }
        public int XmathToGraf( double XMath)
        {
            double x1 = XMath - XmathMin;
            double x2 = x1 / (XmathMax - XmathMin); //dostanem interval <0,1>
            int x3 = Convert.ToInt32(x2 * (XgrafMax - XgrafMin)); //dostanem interval <0, graf max- graf min>....zostava uz len priratat pusun
            int x4 = x3 - XgrafMin;
            return x4;
        }

        public int YMathToGraf(int YGrafMin, int YGrafMax, double YMathMin, double YMathMax, double YMath)
        {
            //int y = YGrafMax - Convert.ToInt32(YMath * (YGrafMax - YGrafMin) / (YMathMax - YMathMin));
            // ********* postupne *********
            double y1 = YMath - YMathMin; //prevedie interval <YMathMin..YMathMax> na ,<0...(YMathMax-YMathMin)>
            int y2 = Convert.ToInt32(y1 * (YGrafMax - YGrafMin) / (YMathMax - YMathMin)); //preskalovanie z <0...(YMathMax-YMathMin)> na <YGrafMin - YGrafMax>
            int y3 = YGrafMax - y2; //obratenie z <YGrafMin - YGrafMax> na <YGrafMax - YGrafMin>
            return y3;
        }
        public int YMathToGraf(double YMath)
        {
            //int y = YGrafMax - Convert.ToInt32(YMath * (YGrafMax - YGrafMin) / (YMathMax - YMathMin));
            // ********* postupne *********
            double y1 = YMath - YmathMin; //prevedie interval <YMathMin..YMathMax> na ,<0...(YMathMax-YMathMin)>
            int y2 = Convert.ToInt32(y1 * (YgrafMax - YgrafMin) / (YmathMax - YmathMin)); //preskalovanie z <0...(YMathMax-YMathMin)> na <YGrafMin - YGrafMax>
            int y3 = YgrafMax - y2; //obratenie z <YGrafMin - YGrafMax> na <YGrafMax - YGrafMin>
            return y3;
        }

        public double YGrafToMath(int YGrafMin, int YGrafMax, double YMathMin, double YMathMax, int YGraf)
        {
            int y1 = YGraf + YGrafMax; //otočenie 
            int y2 = y1 - YGrafMin; // posun ...interval <0, ygrafmax-ygarf min>
            double y3 = 1.0 * y2 / (YGrafMax - YGrafMin); //interval <0,ymathmax -ymathmin>
            double y4 = y3 - (YMathMax - YMathMin); //posun na vyzadovany interval <Ymathmin, Ymathmax>
            return y4;
        }
        public double YGrafToMath( int YGraf)
        {
            int y1 = YGraf + YgrafMax; //otočenie 
            int y2 = y1 - YgrafMin; // posun ...interval <0, ygrafmax-ygarf min>
            double y3 = 1.0 * y2 / (YgrafMax - YgrafMin); //interval <0,ymathmax -ymathmin>
            double y4 = y3 - (YmathMax - YmathMin); //posun na vyzadovany interval <Ymathmin, Ymathmax>
            return y4;
        }

        //nevracia iba vzchdzaju
        public void ZadajHraniceY(int YGrafMin, int YGrafMax, double YMathMin, double YMathMax)
        {
            YgrafMin = YGrafMin;
            YgrafMax = YGrafMax;
            YmathMin = YMathMin;
            YmathMax = YMathMax;
        }
        public void ZadajHraniceX(int XGrafMin, int XGrafMax, double XMathMin, double XMathMax)
        {
            XgrafMin = XGrafMin;
            XgrafMax = XGrafMax;
            XmathMin = XMathMin;
            XmathMax = XMathMax;
        }


        //data clenske premenne triedy
        int YgrafMin = 0;
        int YgrafMax = 400;
        double YmathMin = -2.0;
        double YmathMax = 2.0;

        int XgrafMin = 0;
        int XgrafMax = 600;
        double XmathMin = 0.0;
        double XmathMax = 2.0 * Math.PI;

    }
}
