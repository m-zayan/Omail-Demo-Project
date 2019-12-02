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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Omail.Components;
using Omail.API.API_Validator;
namespace Omail
{

    public partial class MainWindow :Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public event PropertyChangedEventHandler propertyChanged;

        
        public void OnPropertyChanged([CallerMemberName] string propertyName=null)
        {
            propertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        private void Login(object sender, RoutedEventArgs evnt)
        {


            string username = Username.Value;
            string password = Password.Value;

            
            MessageBox.Show(password);
           



        }

    }
}
