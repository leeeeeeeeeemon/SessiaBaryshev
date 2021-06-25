using System;
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
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Windows.Forms;

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

        void SaveTable(DataGridView What_save)
        {
            string path = System.IO.Directory.GetCurrentDirectory() + @"\" + "Save_Excel.xlsx";

            Excel.Application excelapp = new Excel.Application();
            Excel.Workbook workbook = excelapp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            for (int i = 1; i < What_save.RowCount + 1; i++)
            {
                for (int j = 1; j < What_save.ColumnCount + 1; j++)
                {
                    worksheet.Rows[i].Columns[j] = What_save.Rows[i - 1].Cells[j - 1].Value;
                }
            }
            excelapp.AlertBeforeOverwriting = false;
            workbook.SaveAs(path);
            excelapp.Quit();

        }
    }


}
