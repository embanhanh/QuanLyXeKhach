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
        public int index;
        public bool isAdd;
        private HANHKHACH _new;
        private List<string> _Gtinh;
        private List<string> _SohG;
        private ObservableCollection<HANHKHACH> _listnew;
        public HANHKHACH New { get => _new; set { _new = value;OnPropertyChanged(); } }
        public List<string> Gtinh{ get { return _Gtinh;} set { _Gtinh = value; OnPropertyChanged(); } }
        public List<string> SohG { get { return _SohG; } set { _SohG = value; OnPropertyChanged(); } }
        public ObservableCollection<HANHKHACH> ListNew { get => _listnew; set { _listnew = value; OnPropertyChanged(); } }
        public ICommand closeCommand { get; set; }
        public ICommand addCommand { get; set; }
        public AddClientVM() 
        {
            SohG = new List<string>();
            var gheTrong = DataProvider.Ins.db.GHEs.Where(g => g.TINHTRANG == false).ToList();
            for(int i = 0;i< gheTrong.Count; i++)
            {
                SohG.Add(gheTrong[i].IDGhe);
            }
            index = 0;
            Gtinh = new List<string>() {"Nam","Nu","Khac" };
            New = new HANHKHACH();
            ListNew = new ObservableCollection<HANHKHACH>();
            isAdd= false;
            closeCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                New = new HANHKHACH();
                isAdd = false;
                p.Close();
            });
            addCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                ListNew.Add(New);
                New = new HANHKHACH();
                index++;
                isAdd = true;
                p.Close();
            });
            
        }
    }
}
