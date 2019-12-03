using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Automation;
namespace Omail.View
{

    public partial class MainWindow :Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ToSignIn(object sender, RoutedEventArgs evnt)
        {
            Main.Navigate(new Uri("View/SignIn.xaml", UriKind.Relative));
        }
        private void ButtomTextChecked(object sender, RoutedEventArgs evnt)
        {
            ButtomText.IsChecked = false;
        }

    }
}
