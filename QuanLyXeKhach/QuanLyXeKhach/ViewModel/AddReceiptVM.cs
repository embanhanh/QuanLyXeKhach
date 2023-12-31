﻿using QuanLyXeKhach.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.CodeDom;
using System.Windows.Controls;
using System.Linq.Expressions;

namespace QuanLyXeKhach.ViewModel
{
    public class AddReceiptVM:BaseViewModel
    {
        //public int index;
        private string GiaGoc;
        private double GiaVee;
        public bool isAdd;
        private BIENLAI _new;
        private List<string> _LThuNgan;
        private List<string> _LGiamGia;
        private List<string> _LGhe;
        private List<string> _LLichTrinh;
        private string _ThuNgan;
        private string _Ghe;
        private string _GiaVe;
        private string _GiamGia;
        private string _IDLichTrinh;
        private string _ErrorMessage;
        private string _BenDau;
        private string _BenCuoi;
        private string _ThoiGianXuatPhat;
        public string ErrorMessage { get => _ErrorMessage; set { _ErrorMessage = value; OnPropertyChanged(); } }
        public string BenDau { get => _BenDau; set { _BenDau = value; OnPropertyChanged(); } }
        public string BenCuoi { get => _BenCuoi; set { _BenCuoi = value; OnPropertyChanged(); } }
        public string ThoiGianXuatPhat { get => _ThoiGianXuatPhat; set { _ThoiGianXuatPhat = value; OnPropertyChanged(); } }
        public string GiamGia { get { return _GiamGia; } set { _GiamGia = value; OnPropertyChanged(); } }
        public string ThuNgan { get { return _ThuNgan; } set { _ThuNgan = value; OnPropertyChanged(); } }
        public string Ghe { get { return _Ghe; } set { _Ghe = value; OnPropertyChanged(); } }
        public string GiaVe { get { return _GiaVe; } set { _GiaVe = value; OnPropertyChanged(); } }
        public string IDLichTrinh { get { return _IDLichTrinh; } set { _IDLichTrinh = value; OnPropertyChanged(); } }
        private ObservableCollection<BIENLAI> _listnew;
        private ObservableCollection<LICHTRINH> _listLT;
        private ObservableCollection<GHE> _listG;
        private ObservableCollection<THUNGAN> _listTN;
        public BIENLAI New { get => _new; set { _new = value; OnPropertyChanged(); } }
        public List<string> LThuNgan { get { return _LThuNgan; } set { _LThuNgan = value; OnPropertyChanged(); } }
        public List<string> LGiamGia { get { return _LGiamGia; } set { _LGiamGia = value; OnPropertyChanged(); } }
        public List<string> LGhe { get { return _LGhe; } set { _LGhe = value; OnPropertyChanged(); } }
        public List<string> LLichTrinh { get { return _LLichTrinh; } set { _LLichTrinh = value; OnPropertyChanged(); } }
        public ObservableCollection<BIENLAI> ListNew { get => _listnew; set { _listnew = value; OnPropertyChanged(); } }
        public ObservableCollection<LICHTRINH> listLT { get => _listLT; set { _listLT = value; OnPropertyChanged(); } }
        public ObservableCollection<GHE> listG { get => _listG; set { _listG = value; OnPropertyChanged(); } }
        public ObservableCollection<THUNGAN> listTN { get => _listTN; set { _listTN = value; OnPropertyChanged(); } }
        public ICommand closeCommand { get; set; }
        public ICommand addCommand { get; set; }
        public ICommand Show { get; set; }
        public ICommand GGia { get; set; }
        public ICommand Check { get; set; }
        public AddReceiptVM()
        {
            LGhe = new List<string>();
            LGiamGia = new List<string>() { "TREEM", "NGUOIGIA","TET","KHONG" };
            //index = 0;
            New = new BIENLAI();
            ListNew = new ObservableCollection<BIENLAI>();
            isAdd = false;
            closeCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                LGhe.Clear();
                BenDau = "";
                BenCuoi = "";
                ThoiGianXuatPhat = "";
                GiaVe = "";
                ThuNgan = "";
                IDLichTrinh = "";
                New = new BIENLAI();
                isAdd = false;
                p.Close();
            });
            addCommand = new RelayCommand<Window>((p) => {
                if (string.IsNullOrEmpty(New.IDGhe) || string.IsNullOrEmpty(New.GiamGia) || string.IsNullOrEmpty(ThuNgan) || string.IsNullOrEmpty(New.TenHanhKhach) || string.IsNullOrEmpty(New.SoDienThoaiHK) 
                || string.IsNullOrEmpty(IDLichTrinh) || New.NgayMua == null|| string.IsNullOrEmpty(New.IDBienLai) || ErrorMessage != "")
                    return false;
                return true;
            }, (p) =>
            {
                foreach(var tn in listTN)
                    if(ThuNgan == tn.HoTen)
                    {
                        New.ThuNgan = tn.CCCDTN;
                        New.THUNGAN1 = tn;
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
                ListNew.Add(New);
                DataProvider.Ins.db.BIENLAIs.Add(New);
                DataProvider.Ins.db.SaveChanges();
                GiaVe = "";
                ThuNgan = "";
                IDLichTrinh = "";
                BenDau = "";
                BenCuoi = "";
                ThoiGianXuatPhat = "";
                New = new BIENLAI();
                //index++;
                isAdd = true;
                p.Close();
            });
            Show = new RelayCommand<ComboBox>((p) => { return true; }, (p) =>
            {
                LGhe.Clear();
                foreach (var gh in listG)
                    if (gh.IDLICHTRINH == IDLichTrinh && gh.TINHTRANG == false)
                        LGhe.Add(gh.IDGhe);
                foreach(var lt in listLT)
                    if(lt.IDLICHTRINH == IDLichTrinh)
                    {
                        BenDau = lt.TUYENXE?.BENXE1.TenBenXe;
                        BenCuoi = lt.TUYENXE?.BENXE.TenBenXe;
                        DateTime ngay = (DateTime)lt.NgayXuatPhat;
                        DateTime time = ngay.Add((TimeSpan)lt.TUYENXE?.GioXuatPhat);
                        ThoiGianXuatPhat = time.ToString();
                        GiaVe = lt.GiaVe.ToString();
                        GiaVee = (double)lt.GiaVe;
                    }
                GiaGoc = GiaVe;
                switch (New.GiamGia)
                {
                    case "TREEM": GiaVe = (GiaVee*0.5).ToString(); break;
                    case "TET": GiaVe = (GiaVee * 0.85).ToString(); break;
                    case "NGUOIGIA": GiaVe = (GiaVee * 0.6).ToString(); break;
                    case "KHONG": GiaVe = GiaGoc; break;
                    default: GiaVe = GiaGoc; break;
                }
            });
            GGia = new RelayCommand<ComboBox>((p) => { return true; }, (p) =>
            {
                if (GiaGoc == null || GiaGoc == "") return;
                switch (New.GiamGia)
                {
                    case "TREEM": GiaVe = (GiaVee * 0.5).ToString(); break;
                    case "TET": GiaVe = (GiaVee * 0.85).ToString(); break;
                    case "NGUOIGIA": GiaVe = (GiaVee * 0.6).ToString(); break;
                    case "KHONG": GiaVe = GiaGoc; break;
                    default: GiaVe = GiaGoc; break;
                }
            });
            Check = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                if (New.IDBienLai?.Length < 6)
                {
                    ErrorMessage = "";
                    return;
                }
                foreach (var tx in ListNew)
                    if (New.IDBienLai == tx.IDBienLai)
                    {
                        ErrorMessage = "Mã Biên lai đã tồn tại!";
                        return;
                    }
                ErrorMessage = "";
            });
        }
    }
}
