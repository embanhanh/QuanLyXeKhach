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
    public class EditScheduleVM: BaseViewModel
    {
        public int index = 0;
        public bool isedit = false;
        private List<string> _BienSoXe;
        private string _GiaVe;
        public List<string> BienSoXe { get => _BienSoXe; set { _BienSoXe = value; OnPropertyChanged(); } }
        public string GiaVe { get => _GiaVe; set { _GiaVe = value; OnPropertyChanged(); } }
        private List<string> _IDTuyenXe;
        public List<string> IDTuyenXe { get => _IDTuyenXe; set { _IDTuyenXe = value; OnPropertyChanged(); } }
        private LICHTRINH _new;
        private LICHTRINH _new2;
        private ObservableCollection<XEKHACH> _listXK;
        private ObservableCollection<TUYENXE> _listTX;
        public ObservableCollection<XEKHACH> listXK { get => _listXK; set { _listXK = value; OnPropertyChanged(); } }
        public ObservableCollection<TUYENXE> listTX { get => _listTX; set { _listTX = value; OnPropertyChanged(); } }
        public LICHTRINH New { get => _new; set { _new = value; OnPropertyChanged(); } }
        public LICHTRINH New2 { get => _new2; set { _new2 = value; OnPropertyChanged(); } }
        public ICommand editCommand { get; set; }
        public ICommand closeCommand { get; set; }
        
        public EditScheduleVM()
        {
            BienSoXe = new List<string>();
            IDTuyenXe = new List<string>();
            New2 = new LICHTRINH();
            editCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                foreach (var xk in listXK)
                    if (New.BienSoXe == xk.BienSoXe)
                        New.XEKHACH = xk;
                foreach (var tx in listTX)
                    if (New.IDTuyenXe == tx.IDTuyenXe)
                        New.TUYENXE = tx;
                New.GiaVe = Decimal.Parse(GiaVe);
                index++;
                isedit = true;
                p.Close();
            });
            closeCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                isedit = false;
                p.Close();
            });
        }
    }
}
