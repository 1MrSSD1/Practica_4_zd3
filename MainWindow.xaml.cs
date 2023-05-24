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

namespace WpfApp81
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(Box1.Text);
            double y = double.Parse(Box2.Text);
            double a, b, c, d;

            switch (x)
            {
                case 1:
                    a = y;
                    b = 2 * a;
                    c = 2 * 3.14 * a;
                    d = 3.14 * a * a;
                    break;

                case 2:
                    b = y;
                    a = b / 2;
                    c = 2 * 3.14 * a;
                    d = 3.14 * a * a;
                    break;

                case 3:
                    c = y;
                    a = c / (2 * 3.14);
                    b = 2 * a;
                    d = 3.14 * a * a;
                    break;

                case 4:
                    d = y;
                    a = Math.Sqrt(d / 3.14); b = 2 * a;
                    c = 2 * 3.14 * a;
                    break;

                default:
                    a = b = c = d = 0;
                    break;
            }
            Boxa.Text = $"{a}";
            Boxb.Text = $"{b}";
            Boxc.Text = $"{c}";
            Boxd.Text = $"{d}";
        }
    }
}