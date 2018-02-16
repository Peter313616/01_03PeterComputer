/*
 * Peter McEwen
 * Feb 8,2018
 * Computer project
 * display of nessesary parts of a computer
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
            InitializeComponent();
        }

        private void btnbackwards_Click(object sender, RoutedEventArgs e)
        {
            if (imgcount > 0)
            {
                imgcount -= 1;
            }
            BitmapImage bi = new BitmapImage(new Uri(imagelst[imgcount]));
            img.Source = bi;
            lbltitle.Content = titlelst[imgcount];
        }

        private void btnforward_Click(object sender, RoutedEventArgs e)
        {
            if (imgcount < 5)
            {
                imgcount += 1;
            }
            BitmapImage bi = new BitmapImage(new Uri(imagelst[imgcount]));
            img.Source = bi;
            lbltitle.Content = titlelst[imgcount];
        }
    }
}
