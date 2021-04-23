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

namespace _17300732_7c1_P2A2
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
        int a1 = 0;
        int b1 = 0;
        int c1 = 0;
        int d1 = 0;
        int e1 = 0;
        int f1 = 0;
        int g1 = 0;
        int r1 = 0;
        private void Btn_A_Click(object sender, RoutedEventArgs e)
        {
            if (a1 == 0)
            {
                Btn_A.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
                a1 = 1;

            }
            else
            {
                a1 = 0;
                Btn_A.Background = new SolidColorBrush(Color.FromArgb(112, 112, 112, 0));
            }
            r1 = a1 * 1 + b1 * 2 + c1 * 4 + d1 * 8 + e1 * 16 + f1 * 32 + g1 * 64;
            resultado_txt.Text = r1.ToString();


        }

        private void Btn_B_Click(object sender, RoutedEventArgs e)
        {
            if (b1 == 0)
            {
                Btn_B.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
                b1 = 1;

            }
            else
            {
                b1 = 0;
                Btn_B.Background = new SolidColorBrush(Color.FromArgb(112, 112, 112, 0));
            }
            r1 = a1 * 1 + b1 * 2 + c1 * 4 + d1 * 8 + e1 * 16 + f1 * 32 + g1 * 64;
            resultado_txt.Text = r1.ToString();
        }

        private void Btn_C_Click(object sender, RoutedEventArgs e)
        {
            if (c1 == 0)
            {
                Btn_C.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
                c1 = 1;

            }
            else
            {
                c1 = 0;
                Btn_C.Background = new SolidColorBrush(Color.FromArgb(112, 112, 112, 0));
            }
            r1 = a1 * 1 + b1 * 2 + c1 * 4 + d1 * 8 + e1 * 16 + f1 * 32 + g1 * 64;
            resultado_txt.Text = r1.ToString();
        }

        private void Btn_D_Click(object sender, RoutedEventArgs e)
        {
            if (d1 == 0)
            {
                Btn_D.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
                d1 = 1;

            }
            else
            {
                d1 = 0;
                Btn_D.Background = new SolidColorBrush(Color.FromArgb(112, 112, 112, 0));
            }
            r1 = a1 * 1 + b1 * 2 + c1 * 4 + d1 * 8 + e1 * 16 + f1 * 32 + g1 * 64;
            resultado_txt.Text = r1.ToString();
        }

        private void Btn_E_Click(object sender, RoutedEventArgs e)
        {
            if (e1 == 0)
            {
                Btn_E.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
                e1 = 1;

            }
            else
            {
                e1 = 0;
                Btn_E.Background = new SolidColorBrush(Color.FromArgb(112, 112, 112, 0));
            }
            r1 = a1 * 1 + b1 * 2 + c1 * 4 + d1 * 8 + e1 * 16 + f1 * 32 + g1 * 64;
            resultado_txt.Text = r1.ToString();
        }

        private void Btn_F_Click(object sender, RoutedEventArgs e)
        {
            if (f1 == 0)
            {
                Btn_F.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
                f1 = 1;

            }
            else
            {
                f1 = 0;
                Btn_F.Background = new SolidColorBrush(Color.FromArgb(112, 112, 112, 0));
            }
            r1 = a1 * 1 + b1 * 2 + c1 * 4 + d1 * 8 + e1 * 16 + f1 * 32 + g1 * 64;
            resultado_txt.Text = r1.ToString();
        }

        private void Btn_G_Click(object sender, RoutedEventArgs e)
        {
            if (g1 == 0)
            {
                Btn_G.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
                g1 = 1;

            }
            else
            {
                g1 = 0;
                Btn_G.Background = new SolidColorBrush(Color.FromArgb(112, 112, 112, 0));
            }
            r1 = a1 * 1 + b1 * 2 + c1 * 4 + d1 * 8 + e1 * 16 + f1 * 32 + g1 * 64;
            resultado_txt.Text = r1.ToString();
        }

        private void Evaluar_Click(object sender, RoutedEventArgs e)
        {
            evaluar_txt.Text = "nulo";
            switch(r1)
            {
                //Carácter 1
                case 63: evaluar_txt.Text = "0"; break;
                //Carácter 2
                case 6: evaluar_txt.Text = "1"; break;
                //Carácter 3
                case 91: evaluar_txt.Text = "2"; break;
                //Carácter 4
                case 79: evaluar_txt.Text = "3"; break;
                //Carácter 5
                case 102: evaluar_txt.Text = "4"; break;
                //Carácter 6
                case 109: evaluar_txt.Text = "5"; break;
                //Carácter 7
                case 125: evaluar_txt.Text = "6"; break;
                //Carácter 8
                case 7: evaluar_txt.Text = "7"; break;
                //Carácter 9
                case 127: evaluar_txt.Text = "8"; break;
                //Carácter 10
                case 103: evaluar_txt.Text = "9"; break;
                //Carácter 11
                case 119: evaluar_txt.Text = "A"; break;
                //Carácter 12
                case 124: evaluar_txt.Text = "b"; break;
                //Carácter 13
                case 57: evaluar_txt.Text = "C"; break;
                //Carácter 14
                case 94: evaluar_txt.Text = "d"; break;
                //Carácter 15
                case 121: evaluar_txt.Text = "E"; break;
                //Carácter 16
                case 113: evaluar_txt.Text = "F"; break;
                //Carácter 17
                case 111: evaluar_txt.Text = "g"; break;
                //Carácter 18
                case 118: evaluar_txt.Text = "H"; break;
                //Carácter 19
                case 14: evaluar_txt.Text = "J"; break;
                //Carácter 20
                case 56: evaluar_txt.Text = "L"; break;
                //carácter 21 
                case 55: evaluar_txt.Text = "N"; break;
             

            }    
        }
    }
}
