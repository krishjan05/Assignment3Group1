/* MainWindow.xaml.cs
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
        bookclubpoints bookClubpoints;
        public MainWindow()
        {
            InitializeComponent();
            txtNumberOfBooks.Focus();
            bookClubpoints = new bookclubpoints();
            DataContext = bookClubpoints;

            
        }
        //Function to calculate the points earned by a member
        private void btnCalculatePoints_Click(object sender, RoutedEventArgs e)
        {
            bookClubpoints.calculatePoints(txtNumberOfBooks.Text);
                
        }
        //Function to reset the value of text box
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            bookClubpoints.reset(txtNumberOfBooks);
        }
        //Function to show the help message box with rules for calculating the points
        private void btnInformation_Click(object sender, RoutedEventArgs e)
        {
            bookClubpoints.showInfo();
        }
    }
}
