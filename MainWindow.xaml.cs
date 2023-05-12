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
        public int number;
        public void vypocitajFaktorial(object sender, RoutedEventArgs e)
        {
            
            int n = Convert.ToInt32(txtbx.Text);
            txtbx.Text = $"Faktorial cisla {n} je {Convert.ToString(recurse(n))}";
        }

        public int recurse(int num)
        {         
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * recurse(num - 1);
            }
        }

    }
}
