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
    public class EditClientVM:BaseViewModel
    {
        public bool isEdit;
        private List<string> _Gtinh;
        public List<string> Gtinh { get { return _Gtinh; } set { _Gtinh = value; OnPropertyChanged(); } }
        private HANHKHACH _new;
        public HANHKHACH New { get => _new; set { _new = value; OnPropertyChanged(); } }
        public ICommand closeCommand { get; set; }
        public ICommand editCommand { get; set; }
        public EditClientVM()
        {
            Gtinh = new List<string>() { "Nam", "Nữ", "Khác" };
            New = new HANHKHACH();
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
