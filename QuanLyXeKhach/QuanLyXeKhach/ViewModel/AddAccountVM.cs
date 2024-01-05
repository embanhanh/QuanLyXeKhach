using QuanLyXeKhach.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Windows.Controls;
using System.Net.Sockets;

namespace QuanLyXeKhach.ViewModel
{
    public class AddAccountVM: BaseViewModel
    {
        public ICommand closeCommand { get; set; }
        public ICommand Password1ChangedCommand { get; set; }
        public ICommand Password2ChangedCommand { get; set; }
        public ICommand addCommand { get; set; }
        public ICommand UsernameEmpty { get; set; }
        public ICommand PasswordEmpty { get; set; }
        public ICommand SelectRole { get; set; }
        public ICommand SelectFullName { get; set; }
        private string _errormessageuser;
        private string _errormessagpassword;
        private string _pass1;
        private string _pass2;
        private string _SDT;
        private List<string> _ListChucVu;
        private List<string> _ListThuNgan;
        private List<string> _ListPhuXe;
        private List<string> _ListTaiXe;
        private List<string> _ListHoten;
        private UserInfo _new;
        public UserInfo New { get => _new; set { _new = value; OnPropertyChanged(); } }
        public string ErrorMessageUser { get => _errormessageuser; set { _errormessageuser = value; OnPropertyChanged(); } }
        public string ErrorMessagePassword { get => _errormessagpassword; set { _errormessagpassword = value; OnPropertyChanged(); } }
        public List<string> ListChucVu { get => _ListChucVu; set { _ListChucVu = value; OnPropertyChanged(); } }
        public List<string> ListThuNgan { get => _ListThuNgan; set { _ListThuNgan = value; OnPropertyChanged(); } }
        public List<string> ListPhuXe { get => _ListPhuXe; set { _ListPhuXe = value; OnPropertyChanged(); } }
        public List<string> ListTaiXe { get => _ListTaiXe; set { _ListTaiXe = value; OnPropertyChanged(); } }
        public List<string> ListHoten { get => _ListHoten; set { _ListHoten = value; OnPropertyChanged(); } }
        public string Pass1 { get => _pass1; set { _pass1 = value; OnPropertyChanged(); } }
        public string Pass2 { get => _pass2; set { _pass2 = value; OnPropertyChanged(); } }
        public string SDT { get => _SDT; set { _SDT = value; OnPropertyChanged(); } }

        public AddAccountVM()
        {
            New  = new UserInfo();
            ListChucVu = new List<string>() {"Thu Ngân", "Tài Xế", "Phụ Xe" };
            closeCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                New = new UserInfo();
                p.Close();
            });
            addCommand = new RelayCommand<Window>((p) => { 
                if(string.IsNullOrEmpty(New.UserName)||string.IsNullOrEmpty(New.FullName)||string.IsNullOrEmpty(New.SDT)||string.IsNullOrEmpty(New.Roles) || string.IsNullOrEmpty(Pass1) || string.IsNullOrEmpty(Pass2)) 
                    return false; 
                return true; 
            }, (p) =>
            {
                List<UserInfo> UI = DataProvider.Ins.db.UserInfoes.ToList();
                bool ok = false;
                foreach (UserInfo ui in UI)
                {
                    if (ui.UserName == New.UserName)
                    {
                        ErrorMessageUser = "Tên tài khoản đã tồn tại, vui lòng tạo tên mới";
                        ok = true;
                        break;
                    }
                }
                if (Pass1 != Pass2)
                {
                    ErrorMessagePassword = "Mật khẩu nhập lại không khớp, vui lòng nhập lại";
                }
                else if (!ok)
                {
                    MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    New.UserPassword = MD5Hash(Base64Encode(Pass1));
                    DataProvider.Ins.db.UserInfoes.Add(New);
                    DataProvider.Ins.db.SaveChanges();
                    p.Close();
                    New = new UserInfo();
                }
            });
            Password1ChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) =>
            {
                Pass1 = p.Password;
            });
            Password2ChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) =>
            {
                Pass2 = p.Password;
            });
            UsernameEmpty = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                ErrorMessageUser = "";
            });
            PasswordEmpty = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                ErrorMessagePassword = "";
            });
            SelectRole = new RelayCommand<TextBox>((p) => { return true; }, (p) =>
            {
                if(New.Roles == "Thu Ngân")
                {
                    ListHoten = ListThuNgan;
                }
                else if(New.Roles == "Tài Xế")
                {
                    ListHoten = ListTaiXe;
                }
                else if (New.Roles == "Phụ Xe")
                {
                    ListHoten = ListPhuXe;
                }
            });
            SelectFullName = new RelayCommand<TextBox>((p) => { return true; }, (p) =>
            {
                if (New.Roles == "Thu Ngân")
                {
                    List<THUNGAN> tns = DataProvider.Ins.db.THUNGANs.ToList();
                    foreach(var t in tns)
                        if(t.HoTen == New.FullName)
                        {
                            SDT = t.SoDienThoai;
                            New.SDT = t.SoDienThoai;
                            break;
                        }
                }
                else if (New.Roles == "Tài Xế")
                {
                    List<TAIXE> tns = DataProvider.Ins.db.TAIXEs.ToList();
                    foreach (var t in tns)
                        if (t.TenTaiXe == New.FullName)
                        {
                            SDT = t.SoDienThoai;
                            New.SDT = t.SoDienThoai;
                            break;
                        }
                }
                else if (New.Roles == "Phụ Xe")
                {
                    List<NHANVIEN> tns = DataProvider.Ins.db.NHANVIENs.ToList();
                    foreach (var t in tns)
                        if (t.HoTenNhanVien == New.FullName)
                        {
                            SDT = t.SoDienThoai;
                            New.SDT = t.SoDienThoai;
                            break;
                        }
                }
            });
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
