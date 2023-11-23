using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLyXeKhach.ViewModel
{
    public class LoginViewModel : BaseViewModel, INotifyPropertyChanged
    {
        public bool isLogin { get; set; }
        private string _username;
        private string _password;
        private string _errorMessage1;
        private string _errorMessage2;
        private string _colorHint;
        public string ErrorMessage1 { get { return _errorMessage1; } set { _errorMessage1 = value; OnPropertyChanged("ErrorMessage1"); } }
        public string ErrorMessage2 { get { return _errorMessage2; } set { _errorMessage2 = value; OnPropertyChanged("ErrorMessage2"); } }
        public string ColorHint { get { return _colorHint; } set { _colorHint = value; OnPropertyChanged("ColorHint"); } }
        public string Username { get { return _username; } set { _username = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        
        public ICommand LoginWindowCommand { get; set; }
        public ICommand PasswordChangedCommand { get; set; }
        public ICommand CloseLgWdCommand { get; set; }
        public ICommand UsernameEmpty { get; set; }
        public ICommand PasswordEmpty { get; set; }
        public event PropertyChangingEventHandler PropertyChanged;
        protected virtual void OnPropertychanged(string Name)
        {
            if(PropertyChanged != null) PropertyChanged(this,new PropertyChangingEventArgs(Name));
        }

        public LoginViewModel() 
        {
            ColorHint = "Green";
            isLogin = false;
            LoginWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                if (p == null)
                    return;
                //kiem tra tai khoan mat khau co chinh xac khong
                if (Username == null || Password == null || Username == "" || Password == "")
                {
                    if (Username == null || Username == "")
                    {
                        ErrorMessage1 = "Vui lòng nhập trường này";
                        ColorHint = "Red";
                    }
                    if (Password == null || Password == "")
                    {
                        ErrorMessage2 = "Vui lòng nhập trường này";
                        ColorHint = "Red";
                    }
                }
                else
                {
                    if (Username == Password)
                    {
                        isLogin = true;
                        p.Close();
                    }
                    else
                    {
                        isLogin = false;
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
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
            UsernameEmpty = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                ErrorMessage1 = "";
                ColorHint = "Green";
            }); 
            PasswordEmpty = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                ErrorMessage2 = "";
                ColorHint = "Green";
            });
        } 
    }
}
