using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Omail
{
    public partial class App : Application
    {
        private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs Error)
        {
            MessageBox.Show("An unhandled exception just occurred: " + Error.Exception.Message, "Exception", MessageBoxButton.OK, MessageBoxImage.Warning);
            Error.Handled = true;
        }
    }
}
