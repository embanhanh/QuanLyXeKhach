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
    public class AddDriverVM: BaseViewModel
    {
        public int index;
        public bool isAdd;
        private TAIXE _new;
        private List<string> _BangLai;
        private string _Luong;
        public string Luong { get => _Luong; set { _Luong = value; OnPropertyChanged(); } }
        public List<string> BangLai { get => _BangLai; set { _BangLai = value; OnPropertyChanged(); } }
        public TAIXE New { get => _new; set { _new = value; OnPropertyChanged(); } }
        private ObservableCollection<TAIXE> _listnew;
        public ObservableCollection<TAIXE> ListNew { get => _listnew; set { _listnew = value; OnPropertyChanged(); } }
        public ICommand closeCommand { get; set; }
        public ICommand addCommand { get; set; }
        public AddDriverVM()
        {
            BangLai = new List<string>() { "C", "D", "E" };
            ListNew = new ObservableCollection<TAIXE>();
            New = new TAIXE();
            isAdd = false;
            closeCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                New = new TAIXE();
                isAdd = false;
                p.Close();
            });
            addCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                New.Luong = Decimal.Parse(Luong);
                ListNew.Add(New);
                Luong = "";
                New = new TAIXE();
                index++;
                isAdd = true;
                p.Close();
            });

        }
    }
}
