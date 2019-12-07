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
using Omail.API;
namespace Omail.View
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class SignIn : UserControl
    {
        public SignIn()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void SignIn_Button_Click(object sender, RoutedEventArgs e)
        {
            CRUD.Emp data = new CRUD.Emp();
            string email = Email.Value;
            string pass = Password.Value;
            Employee emp = data.CheckSignIn(email, pass);
            if (emp != null)
            {
                MessageBox.Show("Welcome Mr " + emp.EmpName + " (:");
            }
        }
    }
}
