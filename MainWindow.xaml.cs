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
      
        string text = "";

        public void vypocitajFaktorial(object sender, RoutedEventArgs e)
        {
            hanoi(3, 1, 3);
            lbl.Content = text;
        }

        public void hanoi(int n, int start, int end)
        {
            if (n == 1)
            {
                text += $"kamen {n} presun z {start} ---> {end} \n";
            }
            else
            {
                int other = 6 - (start + end);
                hanoi(n - 1, start, other);
                text += $"kamen {n} presun z {start} ---> {end} \n";
                hanoi(n - 1, other, end);            
            }
        }

    }
}
