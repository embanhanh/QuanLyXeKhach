using QuanLyXeKhach.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Runtime.InteropServices.ComTypes;

namespace QuanLyXeKhach.ViewModel
{
    public class AddScheduleVM : BaseViewModel
    {
        //public int index = 0;
        public bool isAdd = false;
        private List<string> _BienSoXe;
        private string _GiaVe;
        private string _ErrorMessage;
        public string ErrorMessage { get => _ErrorMessage; set { _ErrorMessage = value; OnPropertyChanged(); } }
        public List<string> BienSoXe { get => _BienSoXe; set { _BienSoXe = value; OnPropertyChanged(); } }
        public string GiaVe { get => _GiaVe; set { _GiaVe = value; OnPropertyChanged(); } }
        private List<string> _IDTuyenXe;
        public List<string> IDTuyenXe { get => _IDTuyenXe; set { _IDTuyenXe = value; OnPropertyChanged(); } }
        private ObservableCollection<LICHTRINH> _listnew;
        private ObservableCollection<XEKHACH> _listXK;
        private ObservableCollection<TUYENXE> _listTX;
        private ObservableCollection<GHE> _listG;  
        public ObservableCollection<LICHTRINH> ListNew { get => _listnew; set { _listnew = value; OnPropertyChanged(); } }
        public ObservableCollection<XEKHACH> listXK { get => _listXK; set { _listXK = value; OnPropertyChanged(); } }
        public ObservableCollection<TUYENXE> listTX { get => _listTX; set { _listTX = value; OnPropertyChanged(); } }
        public ObservableCollection<GHE> listG { get => _listG; set { _listG = value; OnPropertyChanged(); } }
        private LICHTRINH _new;
        public LICHTRINH New { get => _new; set { _new = value; OnPropertyChanged(); } }
        public ICommand addCommand { get; set; }
        public ICommand closeCommand { get; set; }
        public ICommand Check { get; set; }

        public AddScheduleVM()
        {
            //ListNew = new ObservableCollection<LICHTRINH>();
            New = new LICHTRINH();
            addCommand = new RelayCommand<Window>((p) => {
                if (string.IsNullOrEmpty(New.IDTuyenXe) || string.IsNullOrEmpty(New.BienSoXe) || string.IsNullOrEmpty(New.IDLICHTRINH) || string.IsNullOrEmpty(GiaVe) || New.NgayXuatPhat == null || ErrorMessage !="")
                    return false;
                return true;
            }, (p) =>
            {
                foreach (var xk in listXK)
                    if (New.BienSoXe == xk.BienSoXe)
                        New.XEKHACH = xk;
                foreach (var tx in listTX)
                    if(New.IDTuyenXe == tx.IDTuyenXe)
                        New.TUYENXE = tx;
                New.GiaVe = Decimal.Parse(GiaVe);
                ListNew.Add(New);
                try
                {
                    int k = listG.Count();
                    for (int i = 1; i <= New.XEKHACH.SoGhe; i++)
                    {
                        GHE gh = new GHE();
                        gh.IDLICHTRINH = New.IDLICHTRINH;
                        gh.TINHTRANG = false;
                        gh.LICHTRINH = New;
                        if (k + i < 100)
                        {
                            gh.IDGhe = "0000" + (k + i);
                        }
                        if (k + i >= 100 && k + 1 < 1000)
                        {
                            gh.IDGhe = "000" + (k + i);
                        }
                        if (k + i >= 1000 && k + 1 < 10000)
                        {
                            gh.IDGhe = "00" + (k + i);
                        }
                        if (k + i >= 10000 && k + 1 < 100000)
                        {
                            gh.IDGhe = "0" + (k + i);
                        }
                        if (k + 1 >= 100000)
                        {
                            gh.IDGhe = (k + i).ToString();
                        }
                        listG.Add(gh);
                        DataProvider.Ins.db.GHEs.Add(gh);
                    }
                    DataProvider.Ins.db.LICHTRINHs.Add(New);
                    DataProvider.Ins.db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                GiaVe = "";
                New = new LICHTRINH();
                //index++;
                isAdd = true;
                p.Close();
            });
            closeCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                New = new LICHTRINH();
                isAdd = false;
                p.Close();
            });
            Check = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                if (New.IDLICHTRINH?.Length < 6)
                {
                    ErrorMessage = "";
                    return;
                }
                foreach (var tx in ListNew)
                    if (New.IDLICHTRINH == tx.IDLICHTRINH)
                    {
                        ErrorMessage = "Mã lịch trình đã tồn tại!";
                        return;
                    }
                ErrorMessage = "";
            });
        }
    }
}
