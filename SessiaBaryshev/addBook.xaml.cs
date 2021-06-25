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
using System.Windows.Shapes;
using SessiaBaryshev;

namespace SessiaBaryshev
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        MainWindow mw;
        public Window1(MainWindow mwf)
        {
            InitializeComponent();
              mw = mwf;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void objects_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {
            
        }

       

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            bool right = true;
            if(nameObject.Text == "" || nameOwner.Text == "" || dateinlibrary.Text == "" || AuthorBook.Text == "" || PublisherBook.Text == "" || bornYearBook.Text == "")
            {
                right = false;
                MessageBox.Show("Введенны неверные данные");

            }
            if (right)
            {
                mw.AddGridViewRows(new Book(nameObject.Text, nameOwner.Text, dateinlibrary.Text, AuthorBook.Text, IllustratorBook.Text, PublisherBook.Text, Convert.ToInt32(bornYearBook.Text)));
                this.addWindow.Close();
            }
        }

        private void endAddButton_Click(object sender, RoutedEventArgs e)
        {
            this.addWindow.Close();
        }
    }
}
