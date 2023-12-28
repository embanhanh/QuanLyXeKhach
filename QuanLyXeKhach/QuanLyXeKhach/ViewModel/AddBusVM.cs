using QuanLyXeKhach.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Windows.Navigation;

namespace QuanLyXeKhach.ViewModel
{
    public class AddBusVM : BaseViewModel
    {
        //public int index = 0;
        public bool isAdd = false;
        private ObservableCollection<XEKHACH> _listnew;
        private List<string> _ListTaiXe;
        private List<string> _ListPhuXe;
        private string _TaiXe;
        private string _PhuXe;
        private ObservableCollection<TAIXE> _listTX;
        private ObservableCollection<NHANVIEN> _listPX;
        public ObservableCollection<TAIXE> listTX { get => _listTX; set { _listTX = value; OnPropertyChanged(); } }
        public ObservableCollection<NHANVIEN> listPX { get => _listPX; set { _listPX = value; OnPropertyChanged(); } }
        public string TaiXe { get => _TaiXe; set { _TaiXe = value; OnPropertyChanged(); } }
        public string PhuXe { get => _PhuXe; set { _PhuXe = value; OnPropertyChanged(); } }
        public List<string> ListTaiXe { get=> _ListTaiXe; set { _ListTaiXe = value;OnPropertyChanged(); } }
        public List<string> ListPhuXe { get=> _ListPhuXe; set { _ListPhuXe = value;OnPropertyChanged(); } }
        public ObservableCollection<XEKHACH> ListNew { get => _listnew; set { _listnew = value; OnPropertyChanged(); } }
        private XEKHACH _new;
        public XEKHACH New { get => _new; set { _new = value; OnPropertyChanged(); } }
        private List<string> _BenXeXuatPhat;
        public List<string> BenXeXuatPhat { get => _BenXeXuatPhat; set {_BenXeXuatPhat = value; OnPropertyChanged(); } }
        public ICommand addCommand { get; set; }
        public ICommand closeCommand { get; set; }

        public AddBusVM()
        {
            New = new XEKHACH();
            //ListNew= new ObservableCollection<XEKHACH>();
            addCommand = new RelayCommand<Window>((p) => {
                if (string.IsNullOrEmpty(New.BienSoXe) || string.IsNullOrEmpty(New.LoaiXe)|| string.IsNullOrEmpty(New.TinhTrang)|| New.SoGhe == null|| string.IsNullOrEmpty(TaiXe) || string.IsNullOrEmpty(PhuXe))
                    return false;
                return true;
            }, (p) =>
            {
                foreach (var tx in listTX)
                    if(tx.TenTaiXe == TaiXe)
                    {
                        New.CCCDTX = tx.CCCDTX;
                        New.TAIXE = tx;
                        break;
                    }
                foreach(var px in listPX)
                    if(px.HoTenNhanVien == PhuXe)
                    {
                        New.CCCDNV = px.CCCDNV;
                        New.NHANVIEN = px;
                        break;
                    }
                ListNew.Add(New);
                DataProvider.Ins.db.XEKHACHes.Add(New);
                DataProvider.Ins.db.SaveChanges();
                TaiXe = "";
                PhuXe = "";
                New = new XEKHACH();
                //index++;
                isAdd = true;
                p.Close();
            });
            closeCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                New = new XEKHACH();
                isAdd = false;
                p.Close();
            });
        }
    }
}
