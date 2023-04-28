using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfAppHome
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        int x = 200;
        int y = 200;
        bool fireState, stringState, magnetState;

        CGrafPrevod prevod = new CGrafPrevod();
        Vrh vrh = new Vrh();
        Pruzina pruzina = new Pruzina();
        Magnet magnet = new Magnet();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            fireState = true;
            stringState = false;
            magnetState = false;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            vrh.Nastav(100, 100, 100 / 1000.0, 100, 100, 200);
            

            x = prevod.XmathToGraf(vrh.GetXFyz());
            y = prevod.YMathToGraf(vrh.GetYFyz());
            Canvas.SetLeft(ball, x);
            Canvas.SetTop(ball, y);

            //nastav hranice realneho priestoru a grafiky
            prevod.ZadajHraniceX(0, Convert.ToInt32(canvas.Width), 0, 5000);
            prevod.ZadajHraniceY(0, Convert.ToInt32(canvas.Height), 0, 3000);

        }

        private void doStringEvent(object sender, RoutedEventArgs e)
        {
            fireState = false;
            stringState = true;
            magnetState = false;
            pruzina.Nastav(1, 6, 10 / 1000.0, 4, 0, 0, 4);
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            magnet.Nastav(2500, 2000, 10 / 1000.0, 100, 1, 0, 75);

            x = prevod.XmathToGraf(vrh.GetXFyz());
            y = prevod.YMathToGraf(vrh.GetYFyz());
            Canvas.SetLeft(ball, x);
            Canvas.SetTop(ball, y);
            prevod.ZadajHraniceX(0, Convert.ToInt32(canvas.Width), 0, 2);
            prevod.ZadajHraniceY(0, Convert.ToInt32(canvas.Height), -10, 10);

        }

        private void doMagnetEvent(object sender, RoutedEventArgs e)
        {
            fireState = false;
            stringState = false;
            magnetState = true;

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            
            //Ak casovac ide, zastav       
            //nakresli prvu gulu cervenu

            x = prevod.XmathToGraf(magnet.GetXFyz());
            y = prevod.YMathToGraf(magnet.GetYFyz());
            Canvas.SetLeft(ball, x);
            Canvas.SetTop(ball, y);

            //nastav hranice realneho priestoru a grafiky
            prevod.ZadajHraniceX(0, Convert.ToInt32(canvas.Width), 0, 5000);
            prevod.ZadajHraniceY(0, Convert.ToInt32(canvas.Height), 0, 4000);
            

        }

        private void doFireEvent(object sender, RoutedEventArgs e)
        {
            fireState = true;
            stringState = false;
            magnetState = false;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            vrh.Nastav(100, 100, 100 / 1000.0, 100, 100, 200);
            //Ak casovac ide, zastav       
            //nakresli prvu gulu cervenu

            x = prevod.XmathToGraf(vrh.GetXFyz());
            y = prevod.YMathToGraf(vrh.GetYFyz());
            Canvas.SetLeft(ball, x);
            Canvas.SetTop(ball, y);

            //nastav hranice realneho priestoru a grafiky
            prevod.ZadajHraniceX(0,Convert.ToInt32(canvas.Width), 0, 5000);
            prevod.ZadajHraniceY(0, Convert.ToInt32(canvas.Height), 0, 3000);

        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            if (fireState)
            {
                vrh.Update();
                x = prevod.XmathToGraf(vrh.GetXFyz());
                y = prevod.YMathToGraf(vrh.GetYFyz());
            }
            else if (stringState)
            {
                pruzina.Update();
                x = prevod.XmathToGraf(pruzina.GetXFyz());
                y = prevod.YMathToGraf(pruzina.GetYFyz());
            }
            else if (magnetState)
            {
                magnet.Update();
                x = prevod.XmathToGraf(magnet.GetXFyz());
                y = prevod.YMathToGraf(magnet.GetYFyz());
            }       
            Canvas.SetLeft(ball, x);
            Canvas.SetTop(ball, y);
        }

        
    }
}
