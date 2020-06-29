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
using Microsoft.Maps.MapControl.WPF;
using BE;

namespace UI.Controls
{
    /// <summary>
    /// Interaction logic for map.xaml
    /// </summary>
    public partial class map : UserControl
    {

        BL.IBL bl = BL.FactoryBL.getBL();
        public void  addPositions()
        {
            
            List<BE.Shop> shops = new List<BE.Shop>(bl.getShopsList());
            for (int i = 0; i < shops.Count; i++)
            {
                Canvas canvas = new Canvas();
                MapLayer mapla = new MapLayer();
                MaterialDesignThemes.Wpf.PackIcon icon = new MaterialDesignThemes.Wpf.PackIcon();
                icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.MapMarker;
                icon.ToolTip = shops[i].id;
            //    icon.Height = icon.Height + 2;
              //  icon.Width = icon.Width + 2;
                icon.MouseDown += new MouseButtonEventHandler(open);
                mapla.AddChild(icon, new Location(shops[i].address.latitude , shops[i].address.longitude));
                map1.Children.Add(mapla);
            }


           
        }


        public map()
        {
            InitializeComponent();

            addPositions();
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            map1.ZoomLevel = map1.ZoomLevel - 1;
        }

        private void open(object sender, RoutedEventArgs e)
        {
            MaterialDesignThemes.Wpf.PackIcon icon = (MaterialDesignThemes.Wpf.PackIcon)sender;
            BE.Shop temp = bl.getShopByID(int.Parse(icon.ToolTip.ToString()));
            MessageBox.Show("name:" + temp.name + "\n\n" + "Address: " +temp.address.street + " " + temp.address.num + ", " + temp.address.city);
        }
        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {

           // Shop shop = bl.getShopByID();
            map1.Center = new Location(((BE.Shop)datagridShops.CurrentItem).address.latitude, ((BE.Shop)datagridShops.CurrentItem).address.longitude);
            map1.Children.Clear();
            Canvas canvas = new Canvas();
            MapLayer mapla = new MapLayer();
            MaterialDesignThemes.Wpf.PackIcon icon = new MaterialDesignThemes.Wpf.PackIcon();
            icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.MapMarker;
            icon.ToolTip = ((BE.Shop)datagridShops.CurrentItem).id;
            //    icon.Height = icon.Height + 2;
            //  icon.Width = icon.Width + 2;
            icon.MouseDown += new MouseButtonEventHandler(open);


            mapla.AddChild(icon, new Location(((BE.Shop)datagridShops.CurrentItem).address.latitude, ((BE.Shop)datagridShops.CurrentItem).address.longitude));
            map1.Children.Add(mapla);

        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            map1.ZoomLevel = map1.ZoomLevel + 1;
        }

        private void datagridShops_Loaded(object sender, RoutedEventArgs e)
        {
            datagridShops.ItemsSource = bl.getShopsList();
        }

        private void Search_by_product_Click(object sender, RoutedEventArgs e)
        {
            List<BE.Product> tmp = new List<BE.Product>(bl.productsByName(ProductTextBox.Text));
            if (tmp.Count != 0) {

               
                datagridShops.ItemsSource = bl.getShopsThatHaveProduct(tmp[0].id);
            }
           
            
        }

        private void shopSearch_Click(object sender, RoutedEventArgs e)
        {
            datagridShops.ItemsSource = bl.getShopsByName(textboxShopname.Text);
        }
    }
}
