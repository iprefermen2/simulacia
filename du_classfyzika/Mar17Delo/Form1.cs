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

        bool vrhState, pruzinaState, magnetState;

        CGrafPrevod prevod = new CGrafPrevod();
        Vrh vrh = new Vrh();
        Pruzina pruzina = new Pruzina();
        Magnet magnet = new Magnet();

        public Form1()
        {
            InitializeComponent();
            //nastav grafiku
            mojaG = pbTeren.CreateGraphics();    
            pruzina.Nastav(1, 6, spustac.Interval / 1000.0, 4, 0, 0,4);
        }

        private void btnVrh_Click(object sender, EventArgs e)
        {
            vrh.Nastav(100, 100, spustac.Interval / 1000.0, 100, 100, 200);
            //Ak casovac ide, zastav
            if (spustac.Enabled)
            {
                spustac.Enabled = false;
                pbTeren.Image = null;
            }

            //ak nejde spusti
            else
            {
                spustac.Enabled = true;
                vrhState = true;
                pruzinaState = false;
                magnetState = false;
            }
            //nakresli prvu gulu cervenu

            xGraf = prevod.XmathToGraf(vrh.GetXFyz());
            yGraf = prevod.YMathToGraf(vrh.GetYFyz());
            mojaG.FillEllipse(Brushes.Red, xGraf, yGraf, sirka, sirka);

            //nastav hranice realneho priestoru a grafiky
            prevod.ZadajHraniceX(0, pbTeren.Width, 0, 5000);
            prevod.ZadajHraniceY(0, pbTeren.Height, 0,3000);
        }

        private void spustac_Tick(object sender, EventArgs e)
        {
            //zmazat gulu v startej pozicii (nakresli bielu gulu
            mojaG.FillEllipse(Brushes.White, xGraf, yGraf, sirka, sirka);
            //******zmen poziciu

            if (vrhState)
            {
                vrh.Update();
                xGraf = prevod.XmathToGraf(vrh.GetXFyz());
                yGraf = prevod.YMathToGraf(vrh.GetYFyz());
            }
            else if (pruzinaState)
            {
                pruzina.Update();
                xGraf = prevod.XmathToGraf(pruzina.GetXFyz());
                yGraf = prevod.YMathToGraf(pruzina.GetYFyz());
            }
            else if (magnetState)
            {
                magnet.Update();
                xGraf = prevod.XmathToGraf(magnet.GetXFyz());
                yGraf = prevod.YMathToGraf(magnet.GetYFyz());
            }

            //nakresli gulu v novej pozicii(nakresli cervenu  gulu
            mojaG.FillEllipse(Brushes.Red, xGraf, yGraf, sirka, sirka);
            

        }

        private void btnMagnet_Click(object sender, EventArgs e)
        {
            magnet.Nastav(2500, 2000, spustac.Interval / 1000.0, 100, 1, 0, 75);
            //Ak casovac ide, zastav
            if (spustac.Enabled)
            {
                spustac.Enabled = false;
                pbTeren.Image = null;
            }
                

            //ak nejde spusti
            else
            {
                spustac.Enabled = true;
                vrhState = false;
                pruzinaState = false;
                magnetState = true;
            }


            //nakresli prvu gulu cervenu

            xGraf = prevod.XmathToGraf(magnet.GetXFyz());
            yGraf = prevod.YMathToGraf(magnet.GetYFyz());
            mojaG.FillEllipse(Brushes.Red, xGraf, yGraf, sirka, sirka);

            //nastav hranice realneho priestoru a grafiky
            prevod.ZadajHraniceX(0, pbTeren.Width, 0, 5000);
            prevod.ZadajHraniceY(0, pbTeren.Height, 0, 4000);
        }

        private void btnPruzina_Click(object sender, EventArgs e)
        {
            pruzina.Nastav(1, 6, spustac.Interval / 1000.0, 4, 0, 0, 4);
            //Ak casovac ide, zastav
            if (spustac.Enabled)
            {
                spustac.Enabled = false;
                pbTeren.Image = null;
            }

            //ak nejde spusti
            else {
                spustac.Enabled = true;
                vrhState = false;
                pruzinaState = true;
                magnetState = false;
            }
               
                
            //nakresli prvu gulu cervenu

            xGraf = prevod.XmathToGraf(pruzina.GetXFyz());
            yGraf = prevod.YMathToGraf(pruzina.GetYFyz());
            mojaG.FillEllipse(Brushes.Red, xGraf, yGraf, sirka, sirka);

            //nastav hranice realneho priestoru a grafiky
            prevod.ZadajHraniceX(0, pbTeren.Width, 0, 2);
            prevod.ZadajHraniceY(0, pbTeren.Height, -10, 10);
        }

    }
    
}
