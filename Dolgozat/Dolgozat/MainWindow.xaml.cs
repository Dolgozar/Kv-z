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

namespace Dolgozat
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	/// 

	public partial class MainWindow : Window
	{
		ImageBrush myBrush = new ImageBrush();


		public MainWindow()
		{
			InitializeComponent();
			//myBrush.ImageSource = new BitmapImage(new Uri("", UriKind.Relative)); //majd valami háttér
			//this.Background = myBrush;
			nehez.Visibility = Visibility.Hidden;
			kozepes.Visibility = Visibility.Hidden;
			konnyu.Visibility = Visibility.Hidden;

		}




		private void Start_Click(object sender, RoutedEventArgs e)
		{ 
			title.Content = "Válassz egy nehézséget:";
			next_button.Visibility = Visibility.Hidden;
            nehez.Visibility = Visibility.Visible;
            kozepes.Visibility = Visibility.Visible;
            konnyu.Visibility = Visibility.Visible;


        }

        private void nehez_Click(object sender, RoutedEventArgs e)
        {

        }

        private void konnyu_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
