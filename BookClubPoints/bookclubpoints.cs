/* bookclubpoints.cs
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
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BookClubPoints
{
    class bookclubpoints : INotifyPropertyChanged
    {
        int _points;

        //get and set methods
        public int points
        {
            get { return _points; }
            set { _points = value; NotifyPropertyChanged(); }
        }
        #region
        //Function for calcuating earned points
        public void calculatePoints(String numberOfBooks)
        {
            try
            {
                int books = System.Convert.ToInt16(numberOfBooks);
                if (books >= 0)
                {
                    switch (books)
                    {
                        case 0:
                            points = 0;
                            MessageBox.Show("You have earned " + points + " points", "Earned Points");
                            break;
                        case 1:
                            points = 5;
                            MessageBox.Show("Congratulations, You have earned " + points + " points", "Earned Points");
                            break;
                        case 2:
                            points = 15;
                            MessageBox.Show("Congratulations, You have earned " + points + " points", "Earned Points");
                            break;
                        case 3:
                            points = 30;
                            MessageBox.Show("Congratulations, You have earned " + points + " points", "Earned Points");
                            break;
                        default:
                            points = 60;
                            MessageBox.Show("Congratulations, You have earned " + points + " points", "Earned Points");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid number of books", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter Numbers only !!!",ex.Message);
            }
            
        }

        //Function to reset textbox to 0 and set the focus
        public void reset(TextBox t)
        {
            t.Text = "0";
            t.Focus();
        }

        //Function to show info button
        public void showInfo()
        {
            MessageBox.Show("The points are awarded as follows:" +
                            "\n" + "If a customer purchases 0 books, he or she earns 0 points" +
                            "\n" + "If a customer purchases 1 book, he or she earns 5 points" +
                            "\n" + "If a customer purchases 2 books, he or she earns 15 points" +
                            "\n" + "If a customer purchases 3 books, he or she earns 30 points" +
                            "\n" + "If a customer purchases 4 or more books, he or she earns 60 points",
                            "Points Calculation Rules");
        }
        #endregion

        #region PropertyChangedImplementation
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
