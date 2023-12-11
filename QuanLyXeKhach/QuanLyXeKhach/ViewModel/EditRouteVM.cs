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
    internal class EditRouteVM : BaseViewModel
    {
        public bool isEdit = false;
        private string _BenXeXP;
        public string BenXeXP { get => _BenXeXP; set { _BenXeXP = value; OnPropertyChanged(); } }
        private string _BenXeDD;
        public string BenXeDD { get => _BenXeDD; set { _BenXeDD = value; OnPropertyChanged(); } }
        private DateTime _GioXP;
        public DateTime GioXP { get => _GioXP; set { _GioXP = value; OnPropertyChanged(); } }
        private DateTime _GioDD;
        public DateTime GioDD { get => _GioDD; set { _GioDD = value; OnPropertyChanged(); } }
        private ObservableCollection<BENXE> _listBX;
        public ObservableCollection<BENXE> listBX { get => _listBX; set { _listBX = value; OnPropertyChanged(); } }
        private TUYENXE _new;
        private TUYENXE _new2;
        public TUYENXE New { get => _new; set { _new = value; OnPropertyChanged(); } }
        public TUYENXE New2 { get => _new2; set { _new2 = value; OnPropertyChanged(); } }
        private List<string> _BenXe;
        public List<string> BenXe { get => _BenXe; set { _BenXe = value; OnPropertyChanged(); } }
        public ICommand editCommand { get; set; }
        public ICommand closeCommand { get; set; }

        public EditRouteVM()
        {
            var BXXP = DataProvider.Ins.db.BENXEs.ToList();
            New2 = new TUYENXE();
            editCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                foreach (BENXE bx in listBX)
                {
                    if (BenXeXP == bx.TenBenXe)
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
