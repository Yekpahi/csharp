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

namespace RadioButto
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


        private void radio_Checked(object sender, RoutedEventArgs e)
        {
            Uri resourceUri = new Uri("https://images.bfmtv.com/eh4UDIXJXc9tT3jZn443DjD6NCo=/0x0:2048x1152/2048x0/images/Barack-Obama-a-Las-Vegas-le-8-janvier-2022-1356455.jpg");
           imcheck.Source = new BitmapImage(resourceUri);
        }

        private void radio_Unchecked(object sender, RoutedEventArgs e)
        {
            Uri resourceUri = new Uri("https://resize.elle.fr/original/var/plain_site/storage/images/people/la-vie-des-people/news/michelle-obama-partage-un-tendre-message-pour-les-61-ans-de-barack-obama-4043135/97167072-1-fre-FR/Michelle-Obama-partage-un-tendre-message-pour-les-61-ans-de-Barack-Obama.jpg");
            imcheck.Source = new BitmapImage(resourceUri);

        }
    }
}
