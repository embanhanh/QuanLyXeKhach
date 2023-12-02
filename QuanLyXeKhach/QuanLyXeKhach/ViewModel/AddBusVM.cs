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
        public int index = 0;
        public bool isAdd = false;
        public List<string> TBX;
        private string _TenBenXe;
        public string TenBenXe { get => _TenBenXe; set { _TenBenXe = value; OnPropertyChanged(); } }
        private ObservableCollection<XEKHACH> _listnew;
        public ObservableCollection<XEKHACH> ListNew { get => _listnew; set { _listnew = value; OnPropertyChanged(); } }
        private XEKHACH _new;
        public XEKHACH New { get => _new; set { _new = value; OnPropertyChanged(); } }
        private List<string> _BenXeXuatPhat;
        public List<string> BenXeXuatPhat { get => _BenXeXuatPhat; set {_BenXeXuatPhat = value; OnPropertyChanged(); } }
        public ICommand addCommand { get; set; }
        public ICommand closeCommand { get; set; }

        public AddBusVM()
        {
            BenXeXuatPhat = new List<string>() { "Ben Xe Mien Dong", "Ben Xe Mien Tay", "Ben Xe Chin Nghia" };
            /* Dùng  database để lấy tên các bến xe
            var BXXP = DataProvider.Ins.db.BENXEs.ToList();
            BenXeXuatPhat = new List<string>();
            while (BXXP.Count > 0)
            {
                BenXeXuatPhat.Add(BXXP.First().TenBenXe);
                BXXP.RemoveAt(0);
            }
            */
            New = new XEKHACH();
            var _BX = DataProvider.Ins.db.BENXEs.ToList();
            var _TX = DataProvider.Ins.db.TUYENXEs.ToList();
            addCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                bool isOk = false;
                foreach (BENXE bx in _BX)
                {
                    foreach(TUYENXE tx in _TX)
                    {
                        if(TenBenXe == bx.TenBenXe && bx.IDBenXe == tx.IDBenXeXuatPhat)
                        {
                            New.IDTuyenXe = tx.IDTuyenXe;
                            isOk = true;
                            break;
                        }
                    }
                    if (isOk) break;
                }
                ListNew.Add(New);
                New = new XEKHACH();
                index++;
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
