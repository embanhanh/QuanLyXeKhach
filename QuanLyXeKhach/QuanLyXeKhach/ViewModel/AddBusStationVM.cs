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
    public class AddBusStationVM:BaseViewModel
    {
        //public int index;
        public bool isAdd;
        private BENXE _new;
        public BENXE New { get => _new; set { _new = value; OnPropertyChanged(); } }
        private ObservableCollection<BENXE> _listnew;
        public ObservableCollection<BENXE> ListNew { get => _listnew; set { _listnew = value; OnPropertyChanged(); } }
        public ICommand closeCommand { get; set; }
        public ICommand addCommand { get; set; }
        public AddBusStationVM()
        {
            //index = 0;
            //ListNew = new ObservableCollection<BENXE>();
            New = new BENXE();
            isAdd = false;
            closeCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                New = new BENXE();
                isAdd = false;
                p.Close();
            });
            addCommand = new RelayCommand<Window>((p) => {
                if (string.IsNullOrEmpty(New.IDBenXe) || string.IsNullOrEmpty(New.TenBenXe) || string.IsNullOrEmpty(New.DiaChi) || string.IsNullOrEmpty(New.SoDienThoaiBen))
                    return false;
                return true;
            }, (p) =>
            {
                ListNew.Add(New);
                DataProvider.Ins.db.BENXEs.Add(New);
                DataProvider.Ins.db.SaveChanges();
                New = new BENXE();
                //index++;
                isAdd = true;
                p.Close();
            });

        }
    }
}
