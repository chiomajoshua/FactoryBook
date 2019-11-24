using FactoryBook.Model;
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
    /// Interaction logic for ManageStaff.xaml
    /// </summary>
    public partial class ManageStaff : Window
    {
        bool StateClosed = true;
        public ManageStaff()
        {
            InitializeComponent();
            StaffListItems();
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

        public void StaffListItems()
        {
            this.staffList.Items.Add(new StaffModel { Id = 1, Title = "Mr", Lastname = "Izoho", Firstname = "Uche", StaffId = "FBINC-2019022", Department = "Security", Designation = "Analyst II" });
            this.staffList.Items.Add(new StaffModel { Id = 2, Title = "Mr", Lastname = "Izoho", Firstname = "Uche", StaffId = "FBINC-2019022", Department = "Security", Designation = "Analyst II" });
            this.staffList.Items.Add(new StaffModel { Id = 3, Title = "Mr", Lastname = "Izoho", Firstname = "Uche", StaffId = "FBINC-2019022", Department = "Security", Designation = "Analyst II" });
            this.staffList.Items.Add(new StaffModel { Id = 4, Title = "Mr", Lastname = "Izoho", Firstname = "Uche", StaffId = "FBINC-2019022", Department = "Security", Designation = "Analyst II" });
            this.staffList.Items.Add(new StaffModel { Id = 5, Title = "Mr", Lastname = "Izoho", Firstname = "Uche", StaffId = "FBINC-2019022", Department = "Security", Designation = "Analyst II" });
            this.staffList.Items.Add(new StaffModel { Id = 6, Title = "Mr", Lastname = "Izoho", Firstname = "Uche", StaffId = "FBINC-2019022", Department = "Security", Designation = "Analyst II" });
        }

        private void staffMenu_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            StaffManagement staffManagement = new StaffManagement();
            staffManagement.Show();
            Hide();
        }
    }
}