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
            addCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
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
