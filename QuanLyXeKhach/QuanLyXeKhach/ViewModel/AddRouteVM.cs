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
    internal class AddRouteVM : BaseViewModel
    {
        private string _ErrorMessage;
        public string ErrorMessage { get => _ErrorMessage; set { _ErrorMessage = value; OnPropertyChanged(); } }
        //public int index = 0;
        public bool isAdd = false;
        private string _BenXeXP;
        public string BenXeXP { get => _BenXeXP; set { _BenXeXP = value; OnPropertyChanged(); } }
        private string _BenXeDD;
        public string BenXeDD { get => _BenXeDD; set { _BenXeDD = value; OnPropertyChanged(); } }
        private DateTime _GioXP;
        public DateTime GioXP  { get => _GioXP; set { _GioXP = value; OnPropertyChanged(); } }
        private DateTime _GioDD;
        public DateTime GioDD { get => _GioDD; set { _GioDD = value; OnPropertyChanged(); } }
        private ObservableCollection<TUYENXE> _listnew;
        private ObservableCollection<BENXE> _listBX;
        public ObservableCollection<TUYENXE> ListNew { get => _listnew; set { _listnew = value; OnPropertyChanged(); } }
        public ObservableCollection<BENXE> listBX { get => _listBX; set { _listBX = value; OnPropertyChanged(); } }
        private TUYENXE _new;
        public TUYENXE New { get => _new; set { _new = value; OnPropertyChanged(); } }
        private List<string> _BenXe;
        public List<string> BenXe { get => _BenXe; set { _BenXe = value; OnPropertyChanged(); } }
        public ICommand addCommand { get; set; }
        public ICommand closeCommand { get; set; }
        public ICommand Check { get; set; }

        public AddRouteVM()
        {
            ListNew= new ObservableCollection<TUYENXE>();
            New = new TUYENXE();    
            addCommand = new RelayCommand<Window>((p) => {
                if (string.IsNullOrEmpty(New.IDTuyenXe) || string.IsNullOrEmpty(BenXeXP) || string.IsNullOrEmpty(BenXeDD) || GioXP == null || GioDD == null || ErrorMessage != "")
                    return false;
                return true;
            }, (p) =>
            {
                foreach (BENXE bx in listBX)
                {
                    if(BenXeXP == bx.TenBenXe)
                    {
                        New.IDBenXeXuatPhat = bx.IDBenXe;
                        New.BENXE1 = bx;
                        break;
                    }
                }
                foreach (BENXE bx in listBX)
                {
                    if (BenXeDD == bx.TenBenXe)
                    {
                        New.IDBenKetThuc = bx.IDBenXe;
                        New.BENXE = bx;
                        break;
                    }
                }
                New.GioXuatPhat = GioXP.TimeOfDay;
                New.ThoiGianDuKien = GioDD.TimeOfDay;
                ListNew.Add(New);
                DataProvider.Ins.db.TUYENXEs.Add(New);
                DataProvider.Ins.db.SaveChanges();
                BenXeXP = "";
                BenXeDD = "";
                GioXP = DateTime.Today;
                GioDD = DateTime.Today;
                New = new TUYENXE();
                //index++;
                isAdd = true;
                p.Close();
            });
            closeCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                New = new TUYENXE();
                isAdd = false;
                p.Close();
            });
            Check = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                if (New.IDTuyenXe?.Length < 6)
                {
                    ErrorMessage = "";
                    return;
                }
                foreach (var tx in ListNew)
                    if (New.IDTuyenXe == tx.IDTuyenXe)
                    {
                        ErrorMessage = "Mã tuyến xe đã tồn tại!";
                        return;
                    }
                ErrorMessage = "";
            });
        }
    }
}
