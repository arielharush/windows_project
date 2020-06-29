using BE;
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
              //  dataGrid.ItemsSource = bl.getProductsList();
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
            addProduct addproductWindow = new addProduct();
            addproductWindow.Show();
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
              //  dataGrid.ItemsSource = bl.getProductsList();
                datagridShops.ItemsSource = bl.getShopsList();
            }
            catch (Exception)
            {


            }

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
             // error event if need more pages , to complete
            dataGrid.ItemsSource =   bl.getProductsListByListOfId( ((BE.Shop)datagridShops.SelectedItem).products);
            
           
        }

        private void add_p_Click(object sender, RoutedEventArgs e)
        {
            addProduct product = new addProduct(((BE.Shop)datagridShops.SelectedItem).id);
            product.Show();


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Windows.UserWindow user = new Windows.UserWindow();
            user.Show();
        }

        private void datagridShops_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void generate_Click(object sender, RoutedEventArgs e)
        {
            Address address = new Address();
            address.city = "Jerusalem";
            address.street = "Ben Yehuda";
            address.num = 12;
            address.latitude = 31.7815865;
            address.longitude = 35.2196747;
            //System.Drawing.Image image = imagec;
            Shop shop = new Shop(BE.Config.getShopId(), "ariel", address,"0520000000", "https://arielharush.com", "face",null);
            bl.addShop(shop);





            address = new Address();
            address.city = "Jerusalem";
            address.street = "Ben Yehuda";
            address.num = 40;
            address.latitude = 31.7811235;
            address.longitude = 35.2167907;
            //System.Drawing.Image image = imagec;
            shop = new Shop(BE.Config.getShopId(), "Moshe", address, "0520000000", "https://arielharush.com", "face", null);
            bl.addShop(shop);

        }
    }
}
