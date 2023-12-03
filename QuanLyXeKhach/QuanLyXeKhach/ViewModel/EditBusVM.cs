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
            New = new XEKHACH();
            ListPhuXe = new List<string>();
            ListTaiXe = new List<string>();
            var listTX = DataProvider.Ins.db.TAIXEs.ToList();
            var listPX = DataProvider.Ins.db.NHANVIENs.ToList();
            foreach (var tx in listTX)
                ListTaiXe.Add(tx.CCCDTX);
            foreach (var px in listPX)
                ListPhuXe.Add(px.CCCDNV);
            New2 = new XEKHACH();
            editCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
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
