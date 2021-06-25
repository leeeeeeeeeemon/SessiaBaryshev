﻿using System;
using System.Collections.Generic;
using System.IO;
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
using SessiaBaryshev;

namespace SessiaBaryshev
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string[] owners = new string[4] { "Emil", "Danil", "Diyar", "Marsell" };
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 newForm = new Window1(this);
            newForm.Show();
            
        }

        private void fillButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        public void AddBooksGridViewRows(Book kniga)
        {
        //Add rows to grid view.
        booksTable.Items.Add(kniga);
        booksTable.Items.Refresh();
       
        }
        public void AddPazzlesGridViewRows(Pazzle pazzle)
        {
            //Add rows to grid view.
            pazzleTable.Items.Add(pazzle);
            pazzleTable.Items.Refresh();

        }

        private void addPazzleButton_Click(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2(this);
            w2.Show();
        }

        private void showTableButton_Click(object sender, RoutedEventArgs e)
        {
            switch (tableName.SelectedIndex)
            {
                case 0:
                    pazzleTable.Visibility = Visibility.Hidden;
                    booksTable.Visibility = Visibility.Visible;
                    break;
                case 1:
                    pazzleTable.Visibility = Visibility.Visible;
                    booksTable.Visibility = Visibility.Hidden;
                    break;
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }


}
