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

namespace UI
{
    /// <summary>
    /// Interaction logic for AdminMenu.xaml
    /// </summary>
    /// 
    public partial class AdminMenu : UserControl
    {

        BL.IBL bl = BL.FactoryBL.getBL();
        public AdminMenu()
        {
            
            InitializeComponent();
        }

        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                dataGrid.ItemsSource = bl.getProductsList();
            }
            catch (Exception)
            {


            }
        }

        private void datagridShops_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                this.datagridShops.ItemsSource = bl.getShopsList();
            }
            catch (Exception)
            {


            }
        }

        private void addProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addShop_Click(object sender, RoutedEventArgs e)
        {
           AddShopW addShopWindow = new AddShopW();
           addShopWindow.Show();
            
        }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dataGrid.ItemsSource = bl.getProductsList();
                datagridShops.ItemsSource = bl.getShopsList();
            }
            catch (Exception)
            {


            }

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
             // error event if need more pages , to complete
            datagridShops.ItemsSource =   bl.getProductsListByListOfId( ((BE.Shop)dataGrid.SelectedItem).products);
            
           
        }
    }
}
