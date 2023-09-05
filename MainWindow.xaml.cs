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

namespace tarhelyFeladat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int speed = 0;
            double dblSpeed = 0.0;
            int size = 0;
            double calc = 0.0;

            size = Convert.ToInt32(txtCapacity.Text);
            if (cmbCapacity.SelectedIndex == 0)
            {
            }
            else if (cmbCapacity.SelectedIndex == 1)
            {
                size = size = 10000;
            }
            else if (cmbCapacity.SelectedIndex == 2)
            {
                size = size = 100000;
            }
            speed = Convert.ToInt32(sliSpeed.Value);
            dblSpeed = Convert.ToDouble(speed);
            if (cmbCapacity.SelectedIndex == 0)
            {

            }
            else if (cmbCapacity.SelectedIndex == 1)
            {
                speed *= 1000;
            }
            else if (cmbCapacity.SelectedIndex == 2)
            {
                speed *= 10000;
            }
            dblSpeed /= 0.125;

            calc = size / dblSpeed;
            /*
            double current = calc / (60 * 24);
            int day = 0;
            int hour = 0;
            int minute = 0;
            int second = 0;

            if (current >= 1)
            {
                day = Convert.ToInt32(current);
                current = Convert.ToInt32(current) - current;
            }
            current *= 24;
            if (current/24>=1)
            {
                hour = Convert.ToInt32(current);
                current = Convert.ToInt32(current) - current;
            }
            current*= 60;
            if (current/60>=1)
            {
                minute = Convert.ToInt32(current);
                current = Convert.ToInt32(current) - current;
            }
            if (current/60>=1)
            {
                second = Convert.ToInt32(current);
                current = Convert.ToInt32(current) - current;
            }

            lblResult.Content = day + " day(s) " + hour + " hour(s) " + minute + " minute(s) " + second + " second(s) ";*/

            
            /*TimeSpan t = TimeSpan.FromSeconds(calc*60);
            string answer = string.Format("{0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms",
            t.Hours,
            t.Minutes,
            t.Seconds,
            t.Milliseconds);

            lblResult.Content = answer;*/
            lblResult.Content = 60 * calc + " sec";
        }
    }
}
