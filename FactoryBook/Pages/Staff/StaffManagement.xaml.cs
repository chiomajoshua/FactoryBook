using FactoryBook.Model;
using FactoryBook.Pages.Staff.Departments;
using FactoryBook.Pages.Staff.Employee;
using FactoryBook.Pages.Staff.Loans;
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

namespace FactoryBook.Pages.Staff
{
    /// <summary>
    /// Interaction logic for StaffManagement.xaml
    /// </summary>
    public partial class StaffManagement : Window
    {
        bool StateClosed = true;
        public StaffManagement()
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

        private void Grid_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void NewStaff_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            NewStaffRegistration newStaffRegistration = new NewStaffRegistration();
            newStaffRegistration.Show();
            Hide();
        }

        private void ManageStaff_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            ManageStaff manageStaff = new ManageStaff();
            manageStaff.Show();
            Hide();
        }

        private void ManageRoles_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            ManageRoles manageRoles = new ManageRoles();
            manageRoles.Show();
            Hide();
        }

        private void AddDepartments_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ManageDepartments_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            ManageDepartments manageDepartments = new ManageDepartments();
            manageDepartments.Show();
            Hide();
        }

        public void StaffListItems()
        {
            this.staffList.Items.Add(new StaffModel { Id = 1, Title = "Mr", Lastname = "Izoho", Firstname = "Uche", StaffId = "FBINC-2019022", Department = "Security", Designation = "Analyst II"});
            this.staffList.Items.Add(new StaffModel { Id = 2, Title = "Mr", Lastname = "Izoho", Firstname = "Uche", StaffId = "FBINC-2019022", Department = "Security", Designation = "Analyst II" });
            this.staffList.Items.Add(new StaffModel { Id = 3, Title = "Mr", Lastname = "Izoho", Firstname = "Uche", StaffId = "FBINC-2019022", Department = "Security", Designation = "Analyst II" });
            this.staffList.Items.Add(new StaffModel { Id = 4, Title = "Mr", Lastname = "Izoho", Firstname = "Uche", StaffId = "FBINC-2019022", Department = "Security", Designation = "Analyst II" });
            this.staffList.Items.Add(new StaffModel { Id = 5, Title = "Mr", Lastname = "Izoho", Firstname = "Uche", StaffId = "FBINC-2019022", Department = "Security", Designation = "Analyst II" });
            this.staffList.Items.Add(new StaffModel { Id = 6, Title = "Mr", Lastname = "Izoho", Firstname = "Uche", StaffId = "FBINC-2019022", Department = "Security", Designation = "Analyst II" });
        }

        private void PendingLoans_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            PendingLoans pendingLoans = new PendingLoans();
            pendingLoans.Show();
            Hide();
        }

        private void DisbursedLoans_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            DisbursedLoans disbursedLoans = new DisbursedLoans();
            disbursedLoans.Show();
            Hide();
        }

        private void LoanHistory_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            LoanHistory loanHistory = new LoanHistory();
            loanHistory.Show();
            Hide();
        }
    }
}
