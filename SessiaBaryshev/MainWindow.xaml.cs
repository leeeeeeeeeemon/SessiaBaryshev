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
using SessiaBaryshev;
namespace SessiaBaryshev
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string[] owners = new string[4] { "Emil", "Danil", "Diar", "Marsell" };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 newForm = new Window1();
            newForm.Show();
        }
    }

    public class BooksTable
    {
        public string Object { get; set; }
        public string NameObject { get; set; }
        public string Author { get; set; }
        public string Illustartor { get; set; }
        public string Publisher { get; set; }
        public int bornYear { get; set; }
        public string ownerName { get; set; }
    }
}
