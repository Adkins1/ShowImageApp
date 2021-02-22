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

namespace ShowImageApp
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

        private void CloseAppButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ShowHideButton_Click(object sender, RoutedEventArgs e)
        {
            if((ImagesListBox.SelectedItem.ToString().Contains("Kot")) && (image1.Visibility == Visibility.Hidden))
            {
                image1.Visibility = Visibility.Visible;
            }
            else if((ImagesListBox.SelectedItem.ToString().Contains("Kot")) && (image1.Visibility == Visibility.Visible))
            {
                image1.Visibility = Visibility.Hidden;
            }

            if ((ImagesListBox.SelectedItem.ToString().Contains("Robot")) && (image2.Visibility == Visibility.Hidden))
            {
                image2.Visibility = Visibility.Visible;
            }
            else if ((ImagesListBox.SelectedItem.ToString().Contains("Robot")) && (image2.Visibility == Visibility.Visible))
            {
                image2.Visibility = Visibility.Hidden;
            }

            if ((ImagesListBox.SelectedItem.ToString().Contains("Ketchup")) && (image3.Visibility == Visibility.Hidden))
            {
                image3.Visibility = Visibility.Visible;
            }
            else if ((ImagesListBox.SelectedItem.ToString().Contains("Ketchup")) && (image3.Visibility == Visibility.Visible))
            {
                image3.Visibility = Visibility.Hidden;
            }
        }
    }
}
