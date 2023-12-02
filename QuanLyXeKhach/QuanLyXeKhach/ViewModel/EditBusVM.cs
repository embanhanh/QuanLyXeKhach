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
        public ObservableCollection<XEKHACH> ListNew { get => _listnew; set { _listnew = value;  OnPropertyChanged(); } }
        private XEKHACH _new;
        public XEKHACH New { get => _new; set { _new = value; OnPropertyChanged(); } }
        private List<string> _BenXeXuatPhat;
        public List<string> BenXeXuatPhat { get => _BenXeXuatPhat; set { _BenXeXuatPhat = value; OnPropertyChanged(); } }
        public ICommand editCommand { get; set; }
        public ICommand closeCommand { get; set; }

        public EditBusVM()
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
