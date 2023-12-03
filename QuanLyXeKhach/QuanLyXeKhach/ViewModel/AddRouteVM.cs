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
        public int index = 0;
        public bool isAdd = false;
        private string _BenXeXP;
        public string BenXeXP { get => _BenXeXP; set { _BenXeXP = value; OnPropertyChanged(); } }
        private string _BenXeDD;
        public string BenXeDD { get => _BenXeDD; set { _BenXeDD = value; OnPropertyChanged(); } }
        private DateTime _NgayXP;
        public DateTime NgayXP { get => _NgayXP; set { _NgayXP = value; OnPropertyChanged(); } }
        private DateTime _NgayDD;
        public DateTime NgayDD { get => _NgayDD; set { _NgayDD = value; OnPropertyChanged(); } }
        private DateTime _GioXP;
        public DateTime GioXP  { get => _GioXP; set { _GioXP = value; OnPropertyChanged(); } }
        private DateTime _GioDD;
        public DateTime GioDD { get => _GioDD; set { _GioDD = value; OnPropertyChanged(); } }
        private ObservableCollection<TUYENXE> _listnew;
        public ObservableCollection<TUYENXE> ListNew { get => _listnew; set { _listnew = value; OnPropertyChanged(); } }
        private TUYENXE _new;
        public TUYENXE New { get => _new; set { _new = value; OnPropertyChanged(); } }
        private List<string> _BenXe;
        public List<string> BenXe { get => _BenXe; set { _BenXe = value; OnPropertyChanged(); } }
        public ICommand addCommand { get; set; }
        public ICommand closeCommand { get; set; }

        public AddRouteVM()
        {
            ListNew= new ObservableCollection<TUYENXE>();
            var BXXP = DataProvider.Ins.db.BENXEs.ToList();
            BenXe = new List<string>();
            while (BXXP.Count > 0)
            {
                BenXe.Add(BXXP.First().TenBenXe);
                BXXP.RemoveAt(0);
            }
            New = new TUYENXE();
            var _BX = DataProvider.Ins.db.BENXEs.ToList();
            addCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                foreach (BENXE bx in _BX)
                {
                    if(BenXeXP == bx.TenBenXe)
                    {
                        New.IDBenXeXuatPhat = bx.IDBenXe;
                        break;
                    }
                }
                foreach (BENXE bx in _BX)
                {
                    if (BenXeDD == bx.TenBenXe)
                    {
                        New.IDBenKetThuc = bx.IDBenXe;
                        break;
                    }
                }
                New.ThoiGianXuatPhat = new DateTime(NgayXP.Year, NgayXP.Month, NgayXP.Day, GioXP.Hour, GioXP.Minute, GioXP.Second);
                New.ThoiGianKetThuc = new DateTime(NgayDD.Year, NgayDD.Month, NgayDD.Day, NgayDD.Hour, NgayDD.Minute, NgayDD.Second);
                ListNew.Add(New);
                New = new TUYENXE();
                index++;
                isAdd = true;
                p.Close();
            });
            closeCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                New = new TUYENXE();
                isAdd = false;
                p.Close();
            });
        }
    }
}
