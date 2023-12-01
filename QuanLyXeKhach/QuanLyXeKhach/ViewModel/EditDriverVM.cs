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
    public class EditDriverVM:BaseViewModel
    {
        public bool isEdit;
        private TAIXE _new;
        private List<string> _BangLai;
        public List<string> BangLai { get => _BangLai; set { _BangLai = value; OnPropertyChanged(); } }
        public TAIXE New { get => _new; set { _new = value; OnPropertyChanged(); } }
        public ICommand closeCommand { get; set; }
        public ICommand editCommand { get; set; }
        public EditDriverVM()
        {
            BangLai = new List<string>() { "C", "D", "E" };
            New = new TAIXE();
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
