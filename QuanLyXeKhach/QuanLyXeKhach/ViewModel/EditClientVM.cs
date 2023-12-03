using QuanLyXeKhach.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace QuanLyXeKhach.ViewModel
{
    public class EditClientVM:BaseViewModel
    {
        public bool isEdit;
        private List<string> _Gtinh;
        private List<string> _SoHG;
        public List<string> Gtinh { get { return _Gtinh; } set { _Gtinh = value; OnPropertyChanged(); } }
        public List<string> SohG { get { return _SoHG; } set { _SoHG = value; OnPropertyChanged(); } }
        private HANHKHACH _new;
        private HANHKHACH _new2;
        public HANHKHACH New { get => _new; set { _new = value; OnPropertyChanged(); } }
        public HANHKHACH New2 { get => _new2; set { _new2 = value; OnPropertyChanged(); } }
        public ICommand closeCommand { get; set; }
        public ICommand editCommand { get; set; }
        public EditClientVM()
        {
            SohG = new List<string>();
            var gheTrong = DataProvider.Ins.db.GHEs.Where(g => g.TINHTRANG == false).ToList();
            for (int i = 0; i < gheTrong.Count; i++)
            {
                SohG.Add(gheTrong[i].IDGhe);
            }
            Gtinh = new List<string>() { "Nam", "Nữ", "Khác" };
            New2 = new HANHKHACH();
            isEdit = false;
            closeCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                isEdit = false;
                p.Close();
            });
            editCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                isEdit = true;
                p.Close();
            });
        }
    }
}
