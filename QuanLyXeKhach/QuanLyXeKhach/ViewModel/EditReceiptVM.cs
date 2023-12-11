using QuanLyXeKhach.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;
using System.Windows.Media.Animation;

namespace QuanLyXeKhach.ViewModel
{
    public class EditReceiptVM: BaseViewModel
    {
        public int index;
        public bool isEdit;
        private BIENLAI _new;
        private BIENLAI _new2;
        private List<string> _LHanhKhach;
        private List<string> _LThuNgan;
        private List<string> _LGiamGia;
        private List<string> _LGhe;
        private List<string> _LLichTrinh;
        private string _HanhKhach;
        private string _ThuNgan;
        private string _Ghe;
        private string _GiaVe;
        private string _GiamGia;
        private string _IDLichTrinh;
        public string GiamGia { get { return _GiamGia; } set { _GiamGia = value; OnPropertyChanged(); } }
        public string HanhKhach { get { return _HanhKhach; } set { _HanhKhach = value; OnPropertyChanged(); } }
        public string ThuNgan { get { return _ThuNgan; } set { _ThuNgan = value; OnPropertyChanged(); } }
        public string Ghe { get { return _Ghe; } set { _Ghe = value; OnPropertyChanged(); } }
        public string GiaVe { get { return _GiaVe; } set { _GiaVe = value; OnPropertyChanged(); } }
        public string IDLichTrinh { get { return _IDLichTrinh; } set { _IDLichTrinh = value; OnPropertyChanged(); } }
        private ObservableCollection<LICHTRINH> _listLT;
        private ObservableCollection<GHE> _listG;
        private ObservableCollection<HANHKHACH> _listHK;
        private ObservableCollection<THUNGAN> _listTN;
        public BIENLAI New { get => _new; set { _new = value; OnPropertyChanged(); } }
        public BIENLAI New2 { get => _new2; set { _new2 = value; OnPropertyChanged(); } }
        public List<string> LHanhKhach { get { return _LHanhKhach; } set { _LHanhKhach = value; OnPropertyChanged(); } }
        public List<string> LThuNgan { get { return _LThuNgan; } set { _LThuNgan = value; OnPropertyChanged(); } }
        public List<string> LGiamGia { get { return _LGiamGia; } set { _LGiamGia = value; OnPropertyChanged(); } }
        public List<string> LGhe { get { return _LGhe; } set { _LGhe = value; OnPropertyChanged(); } }
        public List<string> LLichTrinh { get { return _LLichTrinh; } set { _LLichTrinh = value; OnPropertyChanged(); } }
        public ObservableCollection<LICHTRINH> listLT { get => _listLT; set { _listLT = value; OnPropertyChanged(); } }
        public ObservableCollection<GHE> listG { get => _listG; set { _listG = value; OnPropertyChanged(); } }
        public ObservableCollection<HANHKHACH> listHK { get => _listHK; set { _listHK = value; OnPropertyChanged(); } }
        public ObservableCollection<THUNGAN> listTN { get => _listTN; set { _listTN = value; OnPropertyChanged(); } }
        public ICommand closeCommand { get; set; }
        public ICommand editCommand { get; set; }
        public ICommand Show { get; set; }
        public ICommand LoadGhe { get; set; }
        public EditReceiptVM()
        {
            LGhe = new List<string>();
            LGiamGia = new List<string>() { "TREEM", "NGUOIGIA", "TET", "KHONG" };
            index = 0;
            New2 = new BIENLAI();
            isEdit = false;
            closeCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                LGhe.Clear();
                isEdit = false;
                p.Close();
            });
            editCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                foreach (var tn in listTN)
                    if (ThuNgan == tn.HoTen)
                    {
                        New.ThuNgan = tn.CCCDTN;
                        New.THUNGAN1 = tn;
                        break;
                    }
                foreach (var hk in listHK)
                    if (HanhKhach == hk.TenHanhKhach)
                    {
                        New.IDHanhKhach = hk.IDHanhKhach;
                        New.HANHKHACH = hk;
                        break;
                    }
                foreach (var gh in listG)
                    if (gh.IDGhe == New.IDGhe)
                    {
                        gh.TINHTRANG = true;
                        New.GHE = gh;
                        break;
                    }
                LGhe.Clear();
                index++;
                isEdit = true;
                p.Close();
            });
            Show = new RelayCommand<ComboBox>((p) => { return true; }, (p) =>
            {
                LGhe.Clear();
                foreach (var lt in listLT)
                    if (lt.IDLICHTRINH == IDLichTrinh)
                        GiaVe = lt.GiaVe.ToString();
                foreach (var gh in listG)
                    if (gh.IDLICHTRINH == IDLichTrinh && gh.TINHTRANG == false)
                        LGhe.Add(gh.IDGhe);
            });
        }
    }
}
