using FactoryBook.Pages.Staff.Employee.EmployeePages;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FactoryBook.Pages.Staff.Employee
{
    /// <summary>
    /// Interaction logic for NewStaffRegistration.xaml
    /// </summary>
    public partial class NewStaffRegistration : Window
    {
        bool StateClosed = true;
        public NewStaffRegistration()
        {
            InitializeComponent();
            GridMain.Content = new PersonalDetails();
        }

        private void ButtonPower_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void ButtonMenu_Click(object sender, RoutedEventArgs e)
        {
            if (StateClosed)
            {
                Storyboard sb = FindResource("OpenMenu") as Storyboard;
                sb.Begin();
            }
            else
            {
                Storyboard sb = FindResource("CloseMenu") as Storyboard;
                sb.Begin();
            }
            StateClosed = !StateClosed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(10 + (180 * index), 0, 0, 0);

            //switch (index)
            //{
            //    case 0:
            //        GridMain.Background = Brushes.Aquamarine;
            //        break;
            //    case 1:
            //        GridMain.Background = Brushes.Beige;
            //        break;
            //    case 2:
            //        GridMain.Background = Brushes.CadetBlue;
            //        break;
            //    case 3:
            //        GridMain.Background = Brushes.DarkBlue;
            //        break;
            //    case 4:
            //        GridMain.Background = Brushes.Firebrick;
            //        break;
            //    case 5:
            //        GridMain.Background = Brushes.Gainsboro;
            //        break;
            //    case 6:
            //        GridMain.Background = Brushes.HotPink;
            //        break;
            //}
        }

        private void personalButton_Click(object sender, RoutedEventArgs e)
        {
           GridMain.Content = new PersonalDetails();
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(10 + (180 * index), 0, 0, 0);
        }

        private void employmentButton_Click(object sender, RoutedEventArgs e)
        {
            GridMain.Content = new EmploymentInfo();
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(10 + (180 * index), 0, 0, 0);
        }

        private void nextOfKinButton_Click(object sender, RoutedEventArgs e)
        {
            GridMain.Content = new NextofKinInfo();
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(10 + (180 * index), 0, 0, 0);
        }

        private void financialInfoButton_Click(object sender, RoutedEventArgs e)
        {
            GridMain.Content = new FinancialInfo();
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(10 + (180 * index), 0, 0, 0);
        }

        private void staffMenu_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            StaffManagement staffManagement = new StaffManagement();
            staffManagement.Show();
            Hide();
        }
    }
}
