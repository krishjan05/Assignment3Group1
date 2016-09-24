/* MainWindow.xaml
   * Created by Krishna Kanhaiya
   * Assignment 3 
   * Group Members:
   * 1. Krishna Kanhaiya
   * 2. Oleksandr Rudavka
   * 3. Niral Gandhi
   * 4. Tanmay Teckchandani
   * 5. Priya Tharuman
   * 6. Lucas Currah
   * 7. Jonathan Nagata
   * Source: https://github.com/krishjan05/Assignment3Group1
*/

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
        //Function to calculate the points earned by a member
        private void btnCalculatePoints_Click(object sender, RoutedEventArgs e)
        {
            uint NumberOfBook;
           
                if(uint.TryParse(txtNumberOfBooks.Text, out NumberOfBook))
                {
                    switch (NumberOfBook)
                    {
                        case 0: MessageBox.Show("0 Points", "Earned Points");
                            break;
                        case 1: MessageBox.Show("5 Points", "Earned Points");
                            break;
                        case 2: MessageBox.Show("15 Points", "Earned Points");
                            break;
                        case 3: MessageBox.Show("30 Points", "Earned Points");
                            break;
                        default: MessageBox.Show("60 Points", "Earned Points");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Enter Valid Number of books", "Warning");
                }      
        }
        //Function to reset the value of text box
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtNumberOfBooks.Text = "0";
        }
        //Function to show the help message box with rules for calculating the points
        private void btnInformation_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The points are awarded as follows:"+
                            "\n" + "If a customer purchases 0 books, he or she earns 0 points"+
                            "\n" + "If a customer purchases 1 book, he or she earns 5 points"+
                            "\n" + "If a customer purchases 2 books, he or she earns 15 points"+
                            "\n" + "If a customer purchases 3 books, he or she earns 30 points"+
                            "\n" + "If a customer purchases 4 or more books, he or she earns 60 points",
                            "Points Calculation Rules");
        }
    }
}
