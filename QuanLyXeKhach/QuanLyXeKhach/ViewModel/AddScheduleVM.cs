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
    public class AddScheduleVM : BaseViewModel
    {
        public int index = 0;
        public bool isAdd = false;
        private List<string> _BienSoXe;
        private string _GiaVe;
        public List<string> BienSoXe { get => _BienSoXe; set { _BienSoXe = value; OnPropertyChanged(); } }
        public string GiaVe { get => _GiaVe; set { _GiaVe = value; OnPropertyChanged(); } }
        private List<string> _IDTuyenXe;
        public List<string> IDTuyenXe { get => _IDTuyenXe; set { _IDTuyenXe = value; OnPropertyChanged(); } }
        private ObservableCollection<LICHTRINH> _listnew;
        private ObservableCollection<XEKHACH> _listXK;
        private ObservableCollection<TUYENXE> _listTX;
        public ObservableCollection<LICHTRINH> ListNew { get => _listnew; set { _listnew = value; OnPropertyChanged(); } }
        public ObservableCollection<XEKHACH> listXK { get => _listXK; set { _listXK = value; OnPropertyChanged(); } }
        public ObservableCollection<TUYENXE> listTX { get => _listTX; set { _listTX = value; OnPropertyChanged(); } }
        private LICHTRINH _new;
        public LICHTRINH New { get => _new; set { _new = value; OnPropertyChanged(); } }
        public ICommand addCommand { get; set; }
        public ICommand closeCommand { get; set; }

        public AddScheduleVM()
        {
            ListNew = new ObservableCollection<LICHTRINH>();
            New = new LICHTRINH();
            addCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                foreach (var xk in listXK)
                    if (New.BienSoXe == xk.BienSoXe)
                        New.XEKHACH = xk;
                foreach (var tx in listTX)
                    if(New.IDTuyenXe == tx.IDTuyenXe)
                        New.TUYENXE = tx;
                New.GiaVe = Decimal.Parse(GiaVe);
                ListNew.Add(New);
                GiaVe = "";
                New = new LICHTRINH();
                index++;
                isAdd = true;
                p.Close();
            });
            closeCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                New = new LICHTRINH();
                isAdd = false;
                p.Close();
            });
        }
    }
}
