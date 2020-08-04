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

namespace WpfAccessingDatabase
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

        private void btnSQL_Click(object sender, RoutedEventArgs e)
        {
            tbTitles.Text = "Linq to SQL";
            listBoxData.Background = Brushes.Azure;
            using (SQL.PudsDataContext DB = new SQL.PudsDataContext())
            {
                var allTitles = from t in DB.Customers
                                select t.FirstName;

                listBoxData.ItemsSource = allTitles;
            }

        }

        private void btnEntities_Click(object sender, RoutedEventArgs e)
        {
            tbTitles.Text = "Ling to Entities";
            listBoxData.Background = Brushes.Red;

            using (CustomerEntities1 p = new CustomerEntities1())
            {
                var allTitles = from t in p.Orders
                                select t.OrderDate;

                listBoxData.ItemsSource = allTitles;
            }
        }

        private void btnADONET_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
