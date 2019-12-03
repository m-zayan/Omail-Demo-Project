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
using Omail.Components;
namespace Omail.View
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class SignIn : Page
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private void Login(object sender, RoutedEventArgs evnt)
        {
            string username = Username.Value;
            string password = Password.Value;
            MessageBox.Show(password);
        }
        private void ToSignUp(object sender, RoutedEventArgs evnt)
        {
            SignUp signup = new SignUp();
            NavigationService.Navigate(signup);
        }
    }
}
