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

namespace XyrilleAnn.Midterm3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int L = int.Parse(txtFrom.Text);
            int H = int.Parse(txtTo.Text);
            int Total = 0, OddTotal = 0, EvenTotal = 0, EvenCount = 0, OddCount = 0;

            for (int x = L; x <= H; x++)
            {
                Total += x;
                if (x % 2 != 0)
                {
                    OddTotal += x;
                    OddCount++;
                }
                else
                {
                    EvenTotal += x;
                    EvenCount++;
                }
            }
            lblResult.Content = "The Total Of All Numbers From " + txtFrom.Text + "To" + txtTo.Text + "Is" + Total.ToString();
            lblOddSum.Content = "The Total Of Odd Numbers is " + OddTotal.ToString();
            lblEvenSum.Content = "The Total Of Even Numbers is " + EvenTotal.ToString();
            lblEvenCounter.Content = "There Are/Is " + EvenCount.ToString() + " Even Number(s)";
            lblOddCounter.Content = "There Are/Is " + OddCount.ToString() + " Odd Number(s)";
        }
    }
}
