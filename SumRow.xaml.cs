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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            result.IsReadOnly = true;
            chisloX.MaxLength = 3;
            chisloE.MaxLength = 3;
        }

        private void Button_Click(object sender, RoutedEventArgs a)
        {
            if (chisloX.Text.Length <= 3 && chisloE.Text.Length <= 3)
            {
                double x = Convert.ToDouble(chisloX.Text);
                double e = Convert.ToDouble(chisloE.Text);
                double res;
                int i, c =3, b=3;

                for (i = 0; ; i++)
                {
                    Math.Pow(x, c);
                    res = x / b;
                    c++;
                    c++;
                    b++;
                    b++;
                    if (res < e)
                    {
                        break;
                    }
                } 
                result.Text = res.ToString();
            }   
            else
            {
                MessageBox.Show("Error");
            }          
        }
    }
}
