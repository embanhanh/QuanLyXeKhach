using QuanLyXeKhach.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace QuanLyXeKhach.ViewModel
{
    public class AddClientVM:BaseViewModel
    {
        public bool isAdd;
        private List<string> _Gtinh;
        public List<string> Gtinh{ get { return _Gtinh;} set { _Gtinh = value; OnPropertyChanged(); } }
        private HANHKHACH _new;
        public HANHKHACH New { get => _new; set { _new = value; OnPropertyChanged(); } }
        public ICommand closeCommand { get; set; }
        public ICommand addCommand { get; set; }
        public AddClientVM() 
        {
            Gtinh = new List<string>() {"Nam","Nữ","Khác" };
            New = new HANHKHACH();
            isAdd= false;
            closeCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                isAdd = false;
                p.Close();
            });
            addCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                isAdd = true;
                p.Close();
            });
            
        }
    }
}
