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
    public class EditStaffVM:BaseViewModel
    {
        public bool isEdit;
        private NHANVIEN _new;
        private List<string> _GioiTinh;
        public List<string> GioiTinh { get => _GioiTinh; set { _GioiTinh = value; OnPropertyChanged(); } }
        public NHANVIEN New { get => _new; set { _new = value; OnPropertyChanged(); } }
        public ICommand closeCommand { get; set; }
        public ICommand editCommand { get; set; }
        public EditStaffVM()
        {
            GioiTinh = new List<string>() { "Nam", "Nữ", "Khác" };
            New = new NHANVIEN();
            isEdit = false;
            closeCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                isEdit = false;
                p.Close();
            });
            editCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                isEdit = true;
                p.Close();
            });
        }
    }
}
