/*
 * Peter McEwen
 * Feb 8,2018
 * Computer project
 * displays the parts of a computer
 */
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
namespace _01_03PeterComputer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int imgcount = 0;
        List<string> imagelst = new List<string>();

        List<string> titlelst = new List<string>();

        List<string> linklst = new List<string>();
        public MainWindow()
        {
            imagelst.Add("https://images-na.ssl-images-amazon.com/images/I/81aAqEzKuDL.SL1500_.jpg"); ///pos 0 (CPU)
            imagelst.Add("https://images10.newegg.com/NeweggImage/ProductImage/17-182-322-08.jpg");///pos 1 (Power Supply)
            imagelst.Add("https://images10.newegg.com/ProductImage/13-128-565-36.jpg");///pos 2 (motherboard)
            imagelst.Add("https://images10.newegg.com/ProductImage/11-119-274-09.jpg");///pos 3 (Case)
            imagelst.Add("https://images10.newegg.com/NeweggImage/ProductImage/22-172-025-S03.jpg");///pos 4 (Storage)
            imagelst.Add("https://images10.newegg.com/NeweggImage/ProductImage/20-233-232-02.jpg");///pos 5 (memory)

            titlelst.Add("AMD FX 8370 Processor");///pos 0 (CPU)
            titlelst.Add("Rosewill PHOTON Series 750W Full Modular Gaming Power Supply");///pos 1 (Power Supply)
            titlelst.Add("GIGABYTE GA-78LMT-USB3");///pos 2 (motherboard)
            titlelst.Add("Cooler Master N200");///pos 3 (Case)
            titlelst.Add("Seagate IronWolf ST12000VN0007 12TB");///pos 4 (Storage)
            titlelst.Add("CORSAIR Vengeance 32GB (4 x 8GB) 240-Pin");///pos 5 (memory)

            linklst.Add("http://www.tigerdirect.ca/applications/SearchTools/item-details.asp?EdpNo=10060669&CatId=11857"); ///pos 0 (CPU)
            linklst.Add("https://www.newegg.ca/Product/Product.aspx?Item=N82E16817182323 "); ///pos 1 (Power Supply)
            linklst.Add("https://www.newegg.ca/Product/Product.aspx?Item=N82E16813145049&cm_re=Socket_AM3%2b-_-13-145-049-_-Product"); ///pos 2 (motherboard)
            linklst.Add("https://www.newegg.ca/Product/Product.aspx?Item=N82E16811119274&cm_re=Cooler_Master_-_N200_MicroATX_Mini_Tower_Case-_-11-119-274-_-Product"); ///pos 3 (Case)
            linklst.Add("https://www.newegg.ca/Product/Product.aspx?item=9SIA7BB6KV5396"); ///pos 4 (Storage)
            linklst.Add("https://www.newegg.ca/Product/Product.aspx?item=N82E16820233232"); ///pos 5 (memory)
            InitializeComponent();
        }

        private void btnbackwards_Click(object sender, RoutedEventArgs e)
        {
            if (imgcount > 0)
            {
                imgcount -= 1;
            }
            BitmapImage bi = new BitmapImage(new Uri(imagelst[imgcount]));
            imgComputerParts.Source = bi;
            lblTitle.Content = titlelst[imgcount];
        }

        private void btnforward_Click(object sender, RoutedEventArgs e)
        {
            if (imgcount < 5)
            {
                imgcount += 1;
            }
            BitmapImage bi = new BitmapImage(new Uri(imagelst[imgcount]));
            imgComputerParts.Source = bi;
            lblTitle.Content = titlelst[imgcount];
        }

        private void msgInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(linklst[imgcount]);
        }
  }
}
