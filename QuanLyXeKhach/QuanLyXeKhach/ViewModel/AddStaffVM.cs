using QuanLyXeKhach.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Collections.ObjectModel;

namespace QuanLyXeKhach.ViewModel
{
    public class AddStaffVM : BaseViewModel
    {
        //public int index;
        public bool isAdd;
        private NHANVIEN _new;
        private List<string> _GioiTinh;
        private ObservableCollection<NHANVIEN> _ListNew;
        private string _Luong;
        private string _ErrorMessage;
        public string ErrorMessage { get => _ErrorMessage; set { _ErrorMessage = value; OnPropertyChanged(); } }
        public string Luong { get => _Luong; set { _Luong = value; OnPropertyChanged(); } }
        public ObservableCollection<NHANVIEN> ListNew { get => _ListNew; set { _ListNew = value; OnPropertyChanged(); } }
        public List<string> GioiTinh { get => _GioiTinh; set { _GioiTinh = value; OnPropertyChanged(); } }
        public NHANVIEN New { get => _new; set { _new = value; OnPropertyChanged(); } }
        public ICommand closeCommand { get; set; }
        public ICommand addCommand { get; set; }
        public ICommand Check { get; set; }
        public AddStaffVM()
        {
            //ListNew = new ObservableCollection<NHANVIEN>();
            //index = 0;
            GioiTinh = new List<string>() { "Nam", "Nữ", "Khác" };
            New = new NHANVIEN();
            isAdd = false;
            closeCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                New = new NHANVIEN();
                isAdd = false;
                p.Close();
            });
            addCommand = new RelayCommand<Window>((p) => {
                if (string.IsNullOrEmpty(New.HoTenNhanVien) || string.IsNullOrEmpty(New.CCCDNV) || string.IsNullOrEmpty(New.GioiTinh) || string.IsNullOrEmpty(New.DiaChi) 
                || string.IsNullOrEmpty(New.SoDienThoai) || string.IsNullOrEmpty(Luong) || New.NgaySinh == null || ErrorMessage != "")
                    return false;
                return true;
            }, (p) =>
            {
                New.Luong = Decimal.Parse(Luong);
                ListNew.Add(New);
                DataProvider.Ins.db.NHANVIENs.Add(New);
                DataProvider.Ins.db.SaveChanges();
                //index++;
                Luong = "";
                New = new NHANVIEN();
                isAdd = true;
                p.Close();
            });
            Check = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                if (New.CCCDNV?.Length < 12)
                {
                    ErrorMessage = "";
                    return;
                }
                foreach (var tx in ListNew)
                    if (New.CCCDNV == tx.CCCDNV)
                    {
                        ErrorMessage = "Căn cước công dân đã tồn tại!";
                        return;
                    }
                ErrorMessage = "";
            });
        }
    }
}
