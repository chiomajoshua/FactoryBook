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
    /// Interaction logic for ManageRoles.xaml
    /// </summary>
    public partial class ManageRoles : Window
    {
        bool StateClosed = true;
        public ManageRoles()
        {
            InitializeComponent();
            RoleListItems();
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

        public void RoleListItems()
        {
            this.roleList.Items.Add(new RoleModel { Id = 1, RoleName = "Administrator", RoleActivity = "Super User, Full Control", DateCreated = "12-01-2019", CreatedBy = "Ayo Sobowale", Designation = "Operations" });
            this.roleList.Items.Add(new RoleModel { Id = 2, RoleName = "Administrator", RoleActivity = "Super User, Full Control", DateCreated = "12-01-2019", CreatedBy = "Ayo Sobowale", Designation = "Operations" });
            this.roleList.Items.Add(new RoleModel { Id = 3, RoleName = "Administrator", RoleActivity = "Super User, Full Control", DateCreated = "12-01-2019", CreatedBy = "Ayo Sobowale", Designation = "Operations" });
            this.roleList.Items.Add(new RoleModel { Id = 4, RoleName = "Administrator", RoleActivity = "Super User, Full Control", DateCreated = "12-01-2019", CreatedBy = "Ayo Sobowale", Designation = "Operations" });
            this.roleList.Items.Add(new RoleModel { Id = 5, RoleName = "Administrator", RoleActivity = "Super User, Full Control", DateCreated = "12-01-2019", CreatedBy = "Ayo Sobowale", Designation = "Operations" });
            this.roleList.Items.Add(new RoleModel { Id = 6, RoleName = "Administrator", RoleActivity = "Super User, Full Control", DateCreated = "12-01-2019", CreatedBy = "Ayo Sobowale", Designation = "Operations" });
        }

        private void staffMenu_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            StaffManagement staffManagement = new StaffManagement();
            staffManagement.Show();
            Hide();
        }
    }
}
