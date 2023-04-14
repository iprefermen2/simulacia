using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mar17Delo
{
    public partial class Form1 : Form
    {
        Graphics mojaG;
        int xGraf = 50;
        int yGraf = 50;

        int sirka = 40;

        CGrafPrevod prevod = new CGrafPrevod();
        Fyzika fyzika = new Fyzika();

        public Form1()
        {
            InitializeComponent();
            //nastav grafiku
            mojaG = pbTeren.CreateGraphics();
            fyzika.Nastav(100, 100, 1 * spustac.Interval / 1000.0,1 );
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Ak casovac ide, zastav
            if (spustac.Enabled)
                spustac.Enabled = false;
            //ak nejde spusti
            else
                spustac.Enabled = true;
            //nakresli prvu gulu cervenu

            xGraf = prevod.XmathToGraf(fyzika.GetXFyz());
            yGraf = prevod.YMathToGraf(fyzika.GetYFyz());
            mojaG.FillEllipse(Brushes.Red, xGraf, yGraf, sirka, sirka);

            //nastav hranice realneho priestoru a grafiky
            prevod.ZadajHraniceX(0, pbTeren.Width, 0.0, 5000.0);
            prevod.ZadajHraniceY(0, pbTeren.Height, 0.0, 3000.0);
        }

        private void spustac_Tick(object sender, EventArgs e)
        {
            //zmazat gulu v startej pozicii (nakresli bielu gulu
            mojaG.FillEllipse(Brushes.White, xGraf, yGraf, sirka, sirka);
            //******zmen poziciu

            fyzika.Update();


            //premen na xGraf a yGraf
            xGraf = prevod.XmathToGraf(fyzika.GetXFyz());
            yGraf = prevod.YMathToGraf(fyzika.GetYFyz());


            //nakresli gulu v novej pozicii(nakresli cervenu  gulu
            mojaG.FillEllipse(Brushes.Red, xGraf, yGraf, sirka, sirka);
            

        }

        private void btnZrychli_Click(object sender, EventArgs e)
        {
            fyzika.IncreaseRychlost();

        }

        private void btnSpomal_Click(object sender, EventArgs e)
        {
            fyzika.DecreaseRychlost();
        }
    }
}
