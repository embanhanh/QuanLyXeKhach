using QuanLyXeKhach.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace QuanLyXeKhach.ViewModel
{
    public class EditCashierVM:BaseViewModel
    {
        public bool isEdit;
        private THUNGAN _new;
        private THUNGAN _new2;
        private List<string> _GioiTinh;
        private string _Luong;
        public string Luong { get => _Luong; set { _Luong = value; OnPropertyChanged(); } }
        public List<string> GioiTinh { get => _GioiTinh; set { _GioiTinh = value; OnPropertyChanged(); } }
        public THUNGAN New { get => _new; set { _new = value; OnPropertyChanged(); } }
        public THUNGAN New2 { get => _new2; set { _new2 = value; OnPropertyChanged(); } }
        public ICommand closeCommand { get; set; }
        public ICommand editCommand { get; set; }
        public EditCashierVM()
        {
            GioiTinh = new List<string>() { "Nam", "Nữ", "Khác" };
            New2 = new THUNGAN();
            isEdit = false;
            closeCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                isEdit = false;
                p.Close();
            });
            editCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                New.Luong = Decimal.Parse(Luong);
                isEdit = true;
                p.Close();
            });
        }
    }
}
