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
    public class AddTroubleVM: BaseViewModel
    {
        public bool isAdd = false;
        private ObservableCollection<SUCO> _listnew;
        private ObservableCollection<XEKHACH> _listBus;
        private List<string> _li_BienSoXe;
        private List<string> _li_TinhTrang;
        private string _ErrorMessage;
        public string ErrorMessage { get => _ErrorMessage; set { _ErrorMessage = value; OnPropertyChanged(); } }
        public List<string> Li_BienSoXe { get => _li_BienSoXe; set { _li_BienSoXe = value; OnPropertyChanged(); } }
        public List<string> Li_TinhTrang { get => _li_TinhTrang; set { _li_TinhTrang = value; OnPropertyChanged(); } }
        private SUCO _new;
        public SUCO New { get => _new; set { _new = value; OnPropertyChanged(); } }
        public ObservableCollection<SUCO> ListNew { get => _listnew; set { _listnew = value; OnPropertyChanged(); } }
        public ObservableCollection<XEKHACH> ListBus { get => _listBus; set { _listBus = value; OnPropertyChanged(); } }
        public ICommand addCommand { get; set; }
        public ICommand closeCommand { get; set; }
        public ICommand Check { get; set; }

        public AddTroubleVM()
        {
            New = new SUCO();
            //ListNew= new ObservableCollection<XEKHACH>();
            Li_TinhTrang = new List<string>() { "Đang sửa chữa", "Đã sửa chữa", "Đã hủy" };
            addCommand = new RelayCommand<Window>((p) => {
                if (string.IsNullOrEmpty(New.IDsuco) || string.IsNullOrEmpty(New.TinhTrang) || string.IsNullOrEmpty(New.TenSuCo) || string.IsNullOrEmpty(New.BienSoXe)
                || New.ChiPhi == null || New.NgayGapSuCo == null || ErrorMessage != "")
                    return false;
                return true;
            }, (p) =>
            {
                foreach(var xk in ListBus)
                    if(xk.BienSoXe == New.BienSoXe)
                    {
                        New.XEKHACH = xk;
                        xk.TinhTrang = "Không hoạt động";
                        break;
                    }
                ListNew.Add(New);
                DataProvider.Ins.db.SUCOes.Add(New);
                DataProvider.Ins.db.SaveChanges();
                New = new SUCO();
                //index++;
                isAdd = true;
                p.Close();
            });
            closeCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                New = new SUCO();
                isAdd = false;
                p.Close();
            });
            Check = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                if (New.IDsuco?.Length < 6)
                {
                    ErrorMessage = "";
                    return;
                }
                foreach (var tx in ListNew)
                    if (New.IDsuco == tx.IDsuco)
                    {
                        ErrorMessage = "Mã sự cố đã tồn tại!";
                        return;
                    }
                ErrorMessage = "";
            });
        }
    }
}
