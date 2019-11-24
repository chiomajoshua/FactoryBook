using FactoryBook.Common;
using FactoryBook.Pages.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FactoryBook.ViewModels.Login
{
    public class LoginViewModel : BaseViewModel
    {
        //private readonly IDialogService _dialogService;
        public Action CloseAction { get; set; }
        public MyICommand LoginCommand { get; set; }
        public LoginViewModel()
        {
            LoginCommand = new MyICommand(Login);
        }

        public string Email
        {
            get => GetValue<string>();
            set => SetValue(value);
        }
        public string Password
        {
            get => GetValue<string>();
            set => SetValue(value);
        }
        public string ErrorMessage
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        public async void Login()
        {
            if (!string.IsNullOrEmpty(Email))
            {
                if (Utils.ValidateEmail(Email))
                {
                    if (!string.IsNullOrEmpty(Password))
                    {
                        //var loginModel = new LoginModel()
                        //{
                        //    Email = Email,
                        //    Password = Utils.GenerateSHA256String(Password)
                        //};
                        //var vm = DIFactory.Resolve<AuthenticationVM>();
                        //var result = await vm.Login(loginModel);
                        //if (result != null)
                        //{
                        //    if (Common.Helpers.HandleResponseCode(result.ResponseCode.ToString(), out string message))
                        //    {
                        //        if (result.ResponseCode == Response.SUCCESS)
                        //        {
                                    MessageBox.Show(Email + " Has Successfully Signed In", "FactoryBook || Admin Center", MessageBoxButton.OK, MessageBoxImage.Information);
                        MainWindow menuWindow = new MainWindow();
                        menuWindow.Show();
                        CloseAction();
                        //        }
                        //        else
                        //        {
                        //            ErrorMessage = result.RespMessage;
                        //        }
                        //    }
                        //}
                    }
                    else
                    {
                        ErrorMessage = "Password Field Is Empty";
                    }
                }
                else
                {
                    ErrorMessage = "Email Format Is Incorrect";
                }
            }
            else
            {
                ErrorMessage = "Email Field Is Empty";
            }
        }
    }
}