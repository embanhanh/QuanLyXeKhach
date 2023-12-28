using QuanLyXeKhach.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace QuanLyXeKhach.ViewModel
{
    public class AddClientVM: BaseViewModel
    {
        //public int index;
        public bool isAdd;
        private HANHKHACH _new;
        private List<string> _Gtinh;
        private ObservableCollection<HANHKHACH> _listnew;
        public HANHKHACH New { get => _new; set { _new = value;OnPropertyChanged(); } }
        public List<string> Gtinh{ get { return _Gtinh;} set { _Gtinh = value; OnPropertyChanged(); } }
        public ObservableCollection<HANHKHACH> ListNew { get => _listnew; set { _listnew = value; OnPropertyChanged(); } }
        public ICommand closeCommand { get; set; }
        public ICommand addCommand { get; set; }
        public AddClientVM() 
        {
            //index = 0;
            Gtinh = new List<string>() {"Nam","Nữ","Khác" };
            New = new HANHKHACH();
            //ListNew = new ObservableCollection<HANHKHACH>();
            isAdd= false;
            closeCommand = new RelayCommand<Window>((p) => {
                if (string.IsNullOrEmpty(New.SDTHK) || string.IsNullOrEmpty(New.IDHanhKhach) || string.IsNullOrEmpty(New.TenHanhKhach) || string.IsNullOrEmpty(New.CCCD) ||
                string.IsNullOrEmpty(New.DiaChiHK) || string.IsNullOrEmpty(New.GioiTinh) || string.IsNullOrEmpty(New.Tuoi))
                    return false;
                return true;
            }, (p) =>
            {
                New = new HANHKHACH();
                isAdd = false;
                p.Close();
            });
            addCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                ListNew.Add(New);
                DataProvider.Ins.db.HANHKHACHes.Add(New);
                DataProvider.Ins.db.SaveChanges();
                New = new HANHKHACH();
                //index++;
                isAdd = true;
                p.Close();
            });
            
        }
    }
}
