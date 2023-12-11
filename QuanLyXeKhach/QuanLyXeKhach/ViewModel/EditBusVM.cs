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
    internal class EditBusVM : BaseViewModel
    {
        public bool isEdit = false;
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
        public List<string> ListTaiXe { get => _ListTaiXe; set { _ListTaiXe = value; OnPropertyChanged(); } }
        public List<string> ListPhuXe { get => _ListPhuXe; set { _ListPhuXe = value; OnPropertyChanged(); } }
        public ObservableCollection<XEKHACH> ListNew { get => _listnew; set { _listnew = value;  OnPropertyChanged(); } }
        private XEKHACH _new;
        private XEKHACH _new2;
        public XEKHACH New { get => _new; set { _new = value; OnPropertyChanged(); } }
        public XEKHACH New2 { get => _new2; set { _new2 = value; OnPropertyChanged(); } }
        private List<string> _BenXeXuatPhat;
        public List<string> BenXeXuatPhat { get => _BenXeXuatPhat; set { _BenXeXuatPhat = value; OnPropertyChanged(); } }
        public ICommand editCommand { get; set; }
        public ICommand closeCommand { get; set; }

        public EditBusVM()
        {
            New2 = new XEKHACH();
            editCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                foreach (var tx in listTX)
                    if (tx.TenTaiXe == TaiXe)
                    {
                        New.CCCDTX = tx.CCCDTX;
                        New.TAIXE = tx;
                        break;
                    }
                foreach (var px in listPX)
                    if (px.HoTenNhanVien == PhuXe)
                    {
                        New.CCCDNV = px.CCCDNV;
                        New.NHANVIEN = px;
                        break;
                    }
                isEdit = true;
                p.Close();
            });
            closeCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                isEdit = false;
                p.Close();
            });
        }
    }
}
