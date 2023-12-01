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
    public class AddDriverVM: BaseViewModel
    {
        public bool isAdd;
        private TAIXE _new;
        private List<string> _BangLai;
        public List<string> BangLai { get => _BangLai; set { _BangLai = value; OnPropertyChanged(); } }
        public TAIXE New { get => _new; set { _new = value; OnPropertyChanged(); } }
        public ICommand closeCommand { get; set; }
        public ICommand addCommand { get; set; }
        public AddDriverVM()
        {
            BangLai = new List<string>() { "C", "D", "E" };
            New = new TAIXE();
            isAdd = false;
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
