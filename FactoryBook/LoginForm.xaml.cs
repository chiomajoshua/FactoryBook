using FactoryBook.ViewModels.Login;
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
using System.Windows.Shapes;

namespace FactoryBook
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        LoginViewModel vm = new LoginViewModel();
        public LoginForm()
        {
            InitializeComponent();
            // this sets the newly created ViewModel as the DataContext for the View
            this.DataContext = vm;
            if (vm.CloseAction == null)
                vm.CloseAction = new Action(() => this.Close());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow menuWindow = new MainWindow();
            menuWindow.Show();
            this.Hide();
        }

        private void HomeImage_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do You Want To Exit The Application?", "Logs App || Admin Center", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
