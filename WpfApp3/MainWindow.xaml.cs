using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
    String size = "";
    String thick = "";
    String add = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void s1_Click(object sender, RoutedEventArgs e)
        {
            size = "mała";
            s2.IsEnabled = false;
            s3.IsEnabled = false;
        }

        private void s2_Click(object sender, RoutedEventArgs e)
        {
            s1.IsEnabled = false;
            size = "średnia";
            s3.IsEnabled = false;
        }

        private void s3_Click(object sender, RoutedEventArgs e)
        {
            s1.IsEnabled = false;
            s2.IsEnabled = false;
            size = "duża";
        }

        private void t1_Click(object sender, RoutedEventArgs e)
        {
            thick = "cienkie";
            t2.IsEnabled = false;
            t3.IsEnabled = false;
        }

        private void t2_Click(object sender, RoutedEventArgs e)
        {
            t1.IsEnabled = false;
            thick = "średnie";
            t3.IsEnabled = false;
        }

        private void t3_Click(object sender, RoutedEventArgs e)
        {
            t1.IsEnabled = false;
            t2.IsEnabled = false;
            thick = "grube";
        }

        private void a1_Click(object sender, RoutedEventArgs e)
        {
            add += a1.Content + " ";
            a1.Opacity = 100;
        }

        private void a2_Click(object sender, RoutedEventArgs e)
        {
            add += a2.Content + " ";
            a2.Opacity = 100;
        }

        private void a3_Click(object sender, RoutedEventArgs e)
        {
            add += a3.Content + " ";
            a3.Opacity = 100;
        }

        private void a4_Click(object sender, RoutedEventArgs e)
        {
            add += a4.Content + " ";
            a4.Opacity = 100;
        }

        private void a5_Click(object sender, RoutedEventArgs e)
        {
            add += a5.Content + " ";
            a5.Opacity = 100;
        }

        private void a6_Click(object sender, RoutedEventArgs e)
        {
            add += a6.Content + " ";
            a6.Opacity = 100;
        }

        private void confirm_Click(object sender, RoutedEventArgs e)
        {
            if(size!="" && thick!="" && add != "")
            {
                Console.WriteLine ("Zamówiono " + size + " pizza, " + thick + " ciasto z dodatkami: " + add);
                tb.Foreground = Brushes.Black;
                tb.Text = "Zamówiono " + size + " pizza " + thick + " ciasto z dodatkami: " + add;                
                clearForm();
            }
            else
            {
                Console.WriteLine("Wybierz parametry!");
                tb.Text="Wybierz parametry!";
                tb.Foreground = Brushes.Red;
            }
        }


        private void clearForm()
        {
            s1.IsEnabled = s2.IsEnabled = s3.IsEnabled = true;
            t1.IsEnabled = t2.IsEnabled = t3.IsEnabled = true;
            //a1.IsEnabled = a2.IsEnabled = a3.IsEnabled = a4.IsEnabled = a5.IsEnabled = a6.IsEnabled = true;
            a1.Opacity = a2.Opacity = a3.Opacity = a4.Opacity = a5.Opacity = a6.Opacity = 0.5;
            //tb.Text = "";
            size = thick = add = "";
        }
    }
}
