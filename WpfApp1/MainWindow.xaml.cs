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

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Search_Employees(object sender, RoutedEventArgs e)
        {
            if (!this.MyCarousel.IsLoaded)
            {
                return;
            }

            var searchQuery = this.TextBoxSearchName.Text;

            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                return;
            }

            var items = (IEnumerable<Employee>)this.MyCarousel.ItemsSource;
            Employee selectedEmployee = null;

            if (items != null)
            {
                selectedEmployee = items.FirstOrDefault(x => x.FirstName.ToLower().Contains(searchQuery.ToLower()));

                this.MyCarousel.BringDataItemIntoView(selectedEmployee);
                this.MyCarousel.SelectedItem = selectedEmployee;
            }
        }
    
}
}
