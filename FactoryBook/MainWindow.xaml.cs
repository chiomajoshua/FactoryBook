using FactoryBook.Pages.Operations;
using FactoryBook.Pages.Reports;
using FactoryBook.Pages.Staff;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace FactoryBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool StateClosed = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonPower_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            //int index = ListViewMenu.SelectedIndex;
            //switch (index)
            //{
            //    case 0:
            //        MainWindow dashboard = new MainWindow();
            //        dashboard.Show();
            //        Hide();
            //        break;
            //    case 1:
            //        OperationsForms operationsForms = new OperationsForms();
            //        operationsForms.Show();
            //        Hide();
            //        break;
            //    case 2:
            //        StaffManagement staffManagement = new StaffManagement();
            //        staffManagement.Show();
            //        Hide();
            //        break;
            //    case 3:
            //        ReportsForms reportsForms = new ReportsForms();
            //        reportsForms.Show();
            //        Hide();
            //        break;
            //    default:
            //        break;
            //}
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
        

        private void StaffView_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
           
        }

        private void StaffMenu_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            StaffManagement staffManagement = new StaffManagement();
            staffManagement.Show();
            Hide();
        }
    }
}