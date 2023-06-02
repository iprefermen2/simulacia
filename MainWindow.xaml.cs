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
        int height, weight;

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            lbl.Content = $"BMI: {BMIindex()}";
            scale();
        }

        private float BMIindex()
        {
            float bmi = 0;

            height = Convert.ToInt32(txth.Text);
            weight = Convert.ToInt32(txtw.Text);

            bmi = ((float)weight / (float)(height * height)) * 10000;

            return bmi;
        }

        private void scale()
        {
            pBar.Background = Brushes.Gray;

            float bmi = BMIindex();
            if (bmi >= 18.5 && bmi < 25)
            {
                pBar.Value = bmi;
                lblObes.Content = "Ste v normále";
                pBar.Foreground = Brushes.DarkGreen;
            }
            else if (bmi >= 25 && bmi < 30)
            {
                pBar.Value = bmi;
                lblObes.Content = "Máte nadváhu";
                pBar.Foreground = Brushes.Yellow;
            }
            else if (bmi >= 30 && bmi < 35)
            {
                pBar.Value = bmi;
                lblObes.Content = "Máte obezitu I. stupňa";
                pBar.Foreground = Brushes.Orange;
            }
            else if (bmi >= 35 && bmi < 40)
            {
                pBar.Value = bmi;
                lblObes.Content = "Máte obezitu II. stupňa";
                pBar.Foreground = Brushes.OrangeRed;
            }
            else if (bmi < 18.5)
            {
                pBar.Value = 0;
                lblObes.Content = "Máte podváhu";
                pBar.Background = Brushes.LightBlue;
            }
            else if (bmi >= 40)
            {
                pBar.Value = 40;
                lblObes.Content = "Máte obezitu III. stupňa";
                pBar.Foreground = Brushes.DarkRed;
            }
        }
    }
}
