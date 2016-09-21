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

namespace BookClubPoints
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

        private void btncalcpoints_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                uint x;
                if (uint.TryParse(tboEnteredNumberOfBooks.Text, out x))
                {
                    switch (x)
                    {
                        case 0:
                            MessageBox.Show("0 Points");
                            break;

                        case 1:
                            MessageBox.Show("5 Points");
                            break;

                        case 2:
                            MessageBox.Show("15 Points");
                            break;

                        case 3:
                            MessageBox.Show("30 Points");
                            break;

                        default:
                            MessageBox.Show("60 Points");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Enter Valid Number !");
                }
            }
            catch (Exception ex)
            {
            }


        }
    }
}
