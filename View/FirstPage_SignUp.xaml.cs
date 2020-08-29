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
using Omail.API;
namespace Omail.View
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class FirstPage_SignUp : UserControl
    {
        public FirstPage_SignUp()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        private void addData(object sender,RoutedEventArgs e)
        {
            CRUD.Emp add = new CRUD.Emp();
            
            string first= FirstName.Value;
            string last = LastName.Value;
            string pass = Password.Value;
            string valPass = VerifyPassword.Value;
            string email = Email.Value;

            if (valPass != pass) {
                MessageBox.Show("Not Equal");
                return;
            }
            DateTime date = DateTime.Now;

            add.AddNewEmployee(first, last, email,
             date   , "01129700808", pass, "Male", "0yey");

            MessageBox.Show("Data Added");
        }
    }
}
