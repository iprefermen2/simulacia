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

        int pocet = 0;
        string text = "";

        public void vypocitajFaktorial(object sender, RoutedEventArgs e)
        {
            hanoi(4, 1, 3);
            text += $"Pocet krokov: {pocet}";
            lbl.Content = text;
        }

        public void hanoi(int n, int start, int end)
        {
            if (n > 0)
            {
                pocet++;
                int other = 6 - (start + end);
                hanoi(n - 1, start, other);
                text += $"kamen {n} presun z {start} ---> {end} \n";
                hanoi(n - 1, other, end);
            }          
        }

    }
}
