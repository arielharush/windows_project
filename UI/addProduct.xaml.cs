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
    /// Interaction logic for addProduct.xaml
    /// </summary>
    public partial class addProduct : Window
    {
        System.Drawing.Image imagec;
        BL.IBL bl = BL.FactoryBL.getBL();
        public addProduct()
        {
            InitializeComponent();
        }

        int idShop;
        public addProduct(int idS)
        {
            InitializeComponent();
            idShop = idS;
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


        private void Image_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == true)
            {
                // display image in picture box  
                imagec = System.Drawing.Image.FromFile(open.FileName);
                image.Source = GetImageStream(imagec);

              

            }
        }

        private void AddB_Click(object sender, RoutedEventArgs e)
        {
            String name = textBoxName.Text;
            int rate =int.Parse(Rate.Text);
            System.Drawing.Image image = imagec;
            Product product=new Product(name,rate, image,idShop);
            product.id = BE.Config.getProductId();
            bl.addProduct(product);
            Shop shop =  bl.getShopByID(idShop);
            if (shop.products == null)
            {
                shop.products = new List<int>();
            }
            else {
                
            }
            shop.products.Add(product.id);
            bl.updateShop(shop);
            this.Close();
        }
    }
}
