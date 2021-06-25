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

namespace SessiaBaryshev
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        MainWindow mw;
        public Window2(MainWindow mwf)
        {
            InitializeComponent();
            mw = mwf;
        }

        private void addPazzleButton_Click(object sender, RoutedEventArgs e)
        {
            bool right = true;
            if(nameObject.Text == "" || nameOwner.Text == "" || dateInLibrary.Text == "" || ValueElements.Text == ""|| Company.Text == "")
            {
                right = false;
                MessageBox.Show("Неверно введенны данные");
            }
            if (right)
            {
                mw.AddPazzlesGridViewRows(new Pazzle(nameObject.Text, nameOwner.Text, dateInLibrary.Text, Convert.ToInt32(ValueElements.Text), Company.Text));
                this.addPzzleWindow.Close();
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.addPzzleWindow.Close();
        }
    }
}
