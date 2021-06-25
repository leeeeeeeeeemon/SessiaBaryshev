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
        public Window1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void objects_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (objects.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Kniga");
                    AuthorBook.Visibility = Visibility.Visible;
                    IllustratorBook.Visibility = Visibility.Visible;
                    PublisherBook.Visibility = Visibility.Visible;
                    bornYearBook.Visibility = Visibility.Visible;
                    
                    break;
            }
        }
    }
}
