using QuanLyXeKhach.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace QuanLyXeKhach.ViewModel
{
    public class AddCashierVM:BaseViewModel
    {
        public int index;
        public bool isAdd;
        private THUNGAN _new;
        private List<string> _GioiTinh;
        private ObservableCollection<THUNGAN> _ListNew;
        private string _Luong;
        public string Luong { get => _Luong; set { _Luong = value; OnPropertyChanged(); } }
        public ObservableCollection<THUNGAN> ListNew { get => _ListNew; set { _ListNew = value; OnPropertyChanged(); } }
        public List<string> GioiTinh { get => _GioiTinh; set { _GioiTinh = value; OnPropertyChanged(); } }
        public THUNGAN New { get => _new; set { _new = value; OnPropertyChanged(); } }
        public ICommand closeCommand { get; set; }
        public ICommand addCommand { get; set; }
        public AddCashierVM()
        {
            ListNew = new ObservableCollection<THUNGAN>();
            index = 0;
            GioiTinh = new List<string>() { "Nam", "Nữ", "Khác" };
            New = new THUNGAN();
            isAdd = false;
            closeCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                New = new THUNGAN();
                isAdd = false;
                p.Close();
            });
            addCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                New.Luong = Decimal.Parse(Luong);
                ListNew.Add(New);
                index++;
                Luong = "";
                New = new THUNGAN();
                isAdd = true;
                p.Close();
            });
        }
    }
}
