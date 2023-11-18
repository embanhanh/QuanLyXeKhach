using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLyXeKhach.ViewModel
{
    public class LoginViewModel
    {
        public bool isLogin { get; set; }
        private string _username;
        private string _password;
        public string Username { get { return _username; } set { _username = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public ICommand LoginWindowCommand { get; set; }
        public ICommand PasswordChangedCommand { get; set; }
        public ICommand CloseLgWdCommand { get; set; }

        public LoginViewModel() 
        {
            isLogin = false;
            LoginWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                if (p == null)
                    return;
                //kiem tra tai khoan mat khau co chinh xac khong
                if(Username == Password)
                {
                    isLogin = true;
                    p.Close();
                }
                else
                {
                    isLogin = false;
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            });
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) =>
            {
                Password = p.Password;
            });
            CloseLgWdCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                p.Close();
            });
        } 
    }
}
