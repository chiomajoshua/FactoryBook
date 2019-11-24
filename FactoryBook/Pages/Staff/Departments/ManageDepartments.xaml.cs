using FactoryBook.Model;
using System.Windows;
using System.Windows.Media.Animation;

namespace FactoryBook.Pages.Staff.Departments
{
    /// <summary>
    /// Interaction logic for ManageDepartments.xaml
    /// </summary>
    public partial class ManageDepartments : Window
    {
        bool StateClosed = true;
        public ManageDepartments()
        {
            InitializeComponent();
            DepartmentListItems();
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

        public void DepartmentListItems()
        {
            this.departmentList.Items.Add(new DepartmentModel { Id = 1, DepartmentName = "Information Technology", CreatedBy = "Ayo Sobowale", DateCreated = "12-01-2019", Hod = "Zlatan Mercedes", SubDepartment = "No" });
            this.departmentList.Items.Add(new DepartmentModel { Id = 2, DepartmentName = "General Services", CreatedBy = "Ayo Sobowale", DateCreated = "12-01-2019", Hod = "Zlatan Mercedes", SubDepartment = "Yes" });
            this.departmentList.Items.Add(new DepartmentModel { Id = 3, DepartmentName = "Security", CreatedBy = "Ayo Sobowale", DateCreated = "12-01-2019", Hod = "Zlatan Mercedes", SubDepartment = "Yes" });
            this.departmentList.Items.Add(new DepartmentModel { Id = 4, DepartmentName = "Investment Banking", CreatedBy = "Ayo Sobowale", DateCreated = "12-01-2019", Hod = "Zlatan Mercedes", SubDepartment = "No" });
            this.departmentList.Items.Add(new DepartmentModel { Id = 5, DepartmentName = "Relationship Managers", CreatedBy = "Ayo Sobowale", DateCreated = "12-01-2019", Hod = "Zlatan Mercedes", SubDepartment = "No" });
        }

        private void staffMenu_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            StaffManagement staffManagement = new StaffManagement();
            staffManagement.Show();
            Hide();
        }
    }
}