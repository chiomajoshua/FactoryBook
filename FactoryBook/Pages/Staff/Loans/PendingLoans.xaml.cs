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

namespace FactoryBook.Pages.Staff.Loans
{
    /// <summary>
    /// Interaction logic for PendingLoans.xaml
    /// </summary>
    public partial class PendingLoans : Window
    {
        bool StateClosed = true;
        public PendingLoans()
        {
            InitializeComponent();
            PendingLoanListItems();
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

        public void PendingLoanListItems()
        {
           pendingLoanList.Items.Add(new LoanModel { Id = 1, StaffId = "FBINC-2019022", Department = "Security", DateApplied = "12-01-2019", LoanAmount = "NGN25000", StaffGrade = "Grade 13" });
           pendingLoanList.Items.Add(new LoanModel { Id = 2, StaffId = "FBINC-2019022", Department = "Security", DateApplied = "12-01-2019", LoanAmount = "NGN25000", StaffGrade = "Grade 13" });
           pendingLoanList.Items.Add(new LoanModel { Id = 3, StaffId = "FBINC-2019022", Department = "Security", DateApplied = "12-01-2019", LoanAmount = "NGN25000", StaffGrade = "Grade 13" });
           pendingLoanList.Items.Add(new LoanModel { Id = 4, StaffId = "FBINC-2019022", Department = "Security", DateApplied = "12-01-2019", LoanAmount = "NGN25000", StaffGrade = "Grade 13" });
           pendingLoanList.Items.Add(new LoanModel { Id = 5, StaffId = "FBINC-2019022", Department = "Security", DateApplied = "12-01-2019", LoanAmount = "NGN25000", StaffGrade = "Grade 13" });
           pendingLoanList.Items.Add(new LoanModel { Id = 6, StaffId = "FBINC-2019022", Department = "Security", DateApplied = "12-01-2019", LoanAmount = "NGN25000", StaffGrade = "Grade 13" });
           pendingLoanList.Items.Add(new LoanModel { Id = 7, StaffId = "FBINC-2019022", Department = "Security", DateApplied = "12-01-2019", LoanAmount = "NGN25000", StaffGrade = "Grade 13" });
           pendingLoanList.Items.Add(new LoanModel { Id = 8, StaffId = "FBINC-2019022", Department = "Security", DateApplied = "12-01-2019", LoanAmount = "NGN25000", StaffGrade = "Grade 13" });
           pendingLoanList.Items.Add(new LoanModel { Id = 9, StaffId = "FBINC-2019022", Department = "Security", DateApplied = "12-01-2019", LoanAmount = "NGN25000", StaffGrade = "Grade 13" });
           pendingLoanList.Items.Add(new LoanModel { Id = 10, StaffId = "FBINC-2019022", Department = "Security", DateApplied = "12-01-2019", LoanAmount = "NGN25000", StaffGrade = "Grade 13" });
           pendingLoanList.Items.Add(new LoanModel { Id = 11, StaffId = "FBINC-2019022", Department = "Security", DateApplied = "12-01-2019", LoanAmount = "NGN25000", StaffGrade = "Grade 13" });
           pendingLoanList.Items.Add(new LoanModel { Id = 12, StaffId = "FBINC-2019022", Department = "Security", DateApplied = "12-01-2019", LoanAmount = "NGN25000", StaffGrade = "Grade 13" });
        }

        private void staffMenu_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            StaffManagement staffManagement = new StaffManagement();
            staffManagement.Show();
            Hide();
        }
    }
}