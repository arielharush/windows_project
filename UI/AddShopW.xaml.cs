using BE;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace UI
{
    /// <summary>
    /// Interaction logic for AddShopW.xaml
    /// </summary>
    public partial class AddShopW : Window
    {
        System.Drawing.Image imagec;
        BL.IBL bl = BL.FactoryBL.getBL();
        public AddShopW()
        {
            InitializeComponent();
        }

        public static BitmapSource GetImageStream(System.Drawing.Image myImage)
        {
            var bitmap = new Bitmap(myImage);
            IntPtr bmpPt = bitmap.GetHbitmap();
            BitmapSource bitmapSource =
             System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                   bmpPt,
                   IntPtr.Zero,
                   Int32Rect.Empty,
                   BitmapSizeOptions.FromEmptyOptions());

            //freeze bitmapSource and clear memory to avoid memory leaks
            bitmapSource.Freeze();
            DeleteObject(bmpPt);

            return bitmapSource;
        }
        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool DeleteObject(IntPtr value);

        private void AddB_Click(object sender, RoutedEventArgs e)
        {
            Address address = new Address();
            address.city = textBoxCity.Text;
            address.street = textBoxStreet.Text;
            address.num = int.Parse(textBoxNumber.Text);

            Shop shop = new Shop(0, textBoxName.Text, address, textBoxPhone.Text, textBoxWebsite.Text, textBoxFacebook.Text);
            shop.image = imagec;
            bl.addShop(shop);

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
           
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == true)
            {
                // display image in picture box  
                imagec = System.Drawing.Image.FromFile(open.FileName);
                image.Source = GetImageStream(imagec);
              
               // image.BeginAnimation()
                // image file path  
                
            }
        }
    }
}
