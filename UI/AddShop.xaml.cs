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
    /// Interaction logic for AddShop.xaml
    /// </summary>
    public partial class AddShop : UserControl
    {
        BL.IBL bl = BL.FactoryBL.getBL();
        public AddShop()
        {
            InitializeComponent();
        }

        private void AddB_Click(object sender, RoutedEventArgs e)
        {
            Address address= new Address();
            address.city = textBoxCity.Text;
            address.street = textBoxStreet.Text;
            address.num = int.Parse(textBoxNumber.Text);
            
            Shop shop = new Shop(0,textBoxName.Text , address,textBoxPhone.Text , textBoxWebsite.Text , textBoxFacebook.Text);
            bl.addShop(shop);
        }
    }
}
