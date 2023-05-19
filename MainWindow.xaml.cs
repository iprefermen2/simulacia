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
            
            int n = Convert.ToInt32(txtbx.Text);
            int[] cisla = new int[n];
            //cisla[0] = 0;
            //cisla[1] = 1;
            foreach (int i in cisla)
            {
                cisla[i] = recurse(i);
            }

            foreach (int i in cisla)
            {
                text = text + $"{Convert.ToString(cisla[i])}, ";
            }
            lbl.Content = text;
        }
      
        public int recurse(int num)
        {
            int result;

            if (num <= 1)
            {
                result = num;                          
            }
            else
            {
                result = recurse(num - 1) + recurse(num - 2);
            }
            return result;
        }

    }
}
