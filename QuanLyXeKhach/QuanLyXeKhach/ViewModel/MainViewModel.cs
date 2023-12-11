using QuanLyXeKhach.AddWindow;
using QuanLyXeKhach.EditWindow;
using QuanLyXeKhach.Model;
using QuanLyXeKhach.UserControlFolder;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyXeKhach.ViewModel
{
    public class MainViewModel : BaseViewModel
    {   
        //ItemSource ComboBox
        private List<string> _BenXe;
        private List<string> _BienSoXe;
        private List<string> _IDTuyenXe;
        private List<string> _HoTenTX;
        private List<string> _HoTenNV;
        private List<string> _HoTenTN;
        private List<string> _HoTenHK;
        private List<string> _IDLichTrinh;
        private List<string> _IDGhe;
        public List<string> BenXe { get => _BenXe; set { _BenXe = value; OnPropertyChanged(); } }
        public List<string> BienSoXe { get => _BienSoXe; set { _BienSoXe = value; OnPropertyChanged(); } }
        public List<string> IDTuyenXe { get => _IDTuyenXe; set { _IDTuyenXe = value; OnPropertyChanged(); } }
        public List<string> HoTenTX { get => _HoTenTX; set { _HoTenTX = value; OnPropertyChanged(); } }
        public List<string> HoTenNV { get => _HoTenNV; set { _HoTenNV = value; OnPropertyChanged(); } }
        public List<string> HoTenTN { get => _HoTenTN; set { _HoTenTN = value; OnPropertyChanged(); } }
        public List<string> HoTenHK { get => _HoTenHK; set { _HoTenHK = value; OnPropertyChanged(); } }
        public List<string> IDLichTrinh { get => _IDLichTrinh; set { _IDLichTrinh = value; OnPropertyChanged(); } }
        public List<string> IDGhe { get => _IDGhe; set { _IDGhe = value; OnPropertyChanged(); } }
        //UserControl
        private UserControl SelectedTagClient = null;
        private UserControl SelectedTagStaff = null;
        private UserControl SelectedTagDriver = null;
        private UserControl SelectedTagBusStation = null;
        private UserControl SelectedTagBus = null;
        private UserControl SelectedTagRoute = null;
        private UserControl SelectedTagSchedule = null;
        private UserControl SelectedTagCashier = null;
        private UserControl SelectedTagReceipt = null;
        //List
        private ObservableCollection<HANHKHACH> _ListClient;
        private ObservableCollection<TAIXE> _ListDriver;
        private ObservableCollection<NHANVIEN> _ListStaff;
        private ObservableCollection<XEKHACH> _ListBus;
        private ObservableCollection<BENXE> _ListBusStation;
        private ObservableCollection<TUYENXE> _ListRoute;
        private ObservableCollection<LICHTRINH> _ListSchedule;
        private ObservableCollection<THUNGAN> _ListCashier;
        private ObservableCollection<BIENLAI> _ListReceipt;
        private ObservableCollection<GHE> _ListSeat;
        public ObservableCollection<HANHKHACH> ListClient { get =>_ListClient;set { _ListClient = value; OnPropertyChanged(); } }
        public ObservableCollection<TAIXE> ListDriver { get => _ListDriver; set { _ListDriver = value; OnPropertyChanged(); } }
        public ObservableCollection<NHANVIEN> ListStaff { get => _ListStaff; set { _ListStaff = value; OnPropertyChanged(); } }
        public ObservableCollection<XEKHACH> ListBus { get => _ListBus; set { _ListBus = value; OnPropertyChanged(); } }
        public ObservableCollection<BENXE> ListBusStation { get => _ListBusStation; set { _ListBusStation = value; OnPropertyChanged(); } }
        public ObservableCollection<TUYENXE> ListRoute { get => _ListRoute; set { _ListRoute = value; OnPropertyChanged(); } }
        public ObservableCollection<LICHTRINH> ListSchedule { get => _ListSchedule; set { _ListSchedule = value; OnPropertyChanged(); } }
        public ObservableCollection<THUNGAN> ListCashier { get => _ListCashier; set { _ListCashier = value; OnPropertyChanged(); } }
        public ObservableCollection<BIENLAI> ListReceipt { get => _ListReceipt; set { _ListReceipt = value; OnPropertyChanged(); } }
        public ObservableCollection<GHE> ListSeat { get => _ListSeat; set { _ListSeat = value; OnPropertyChanged(); } }
        //SelectedItem
        private HANHKHACH _SelectedItemClient;
        public HANHKHACH SelectedItemClient { get => _SelectedItemClient; set { _SelectedItemClient = value; OnPropertyChanged(); } }
        private NHANVIEN _SelectedItemStaff;
        public NHANVIEN SelectedItemStaff { get => _SelectedItemStaff; set { _SelectedItemStaff = value; OnPropertyChanged(); } }
        private XEKHACH _SelectedItemBus;
        public XEKHACH SelectedItemBus { get => _SelectedItemBus; set { _SelectedItemBus = value; OnPropertyChanged(); } }
        private TUYENXE _SelectedItemRoute;
        public TUYENXE SelectedItemRoute { get => _SelectedItemRoute; set { _SelectedItemRoute = value; OnPropertyChanged(); } }
        private TAIXE _SelectedItemDriver;
        public TAIXE SelectedItemDriver { get => _SelectedItemDriver; set { _SelectedItemDriver = value; OnPropertyChanged(); } }
        private BENXE _SelectedItemBusStation;
        public BENXE SelectedItemBusStation { get => _SelectedItemBusStation; set { _SelectedItemBusStation = value; OnPropertyChanged(); } }
        private LICHTRINH _SelectedItemSchedule;
        public LICHTRINH SelectedItemSchedule { get => _SelectedItemSchedule; set { _SelectedItemSchedule = value; OnPropertyChanged(); } }
        private THUNGAN _SelectedItemCashier;
        public THUNGAN SelectedItemCashier { get => _SelectedItemCashier; set { _SelectedItemCashier = value; OnPropertyChanged(); } }
        private BIENLAI _SelectedItemReceipt;
        public BIENLAI SelectedItemReceipt { get => _SelectedItemReceipt; set { _SelectedItemReceipt = value; OnPropertyChanged(); } }
        //Command
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand AddClientCommand { get; set; }
        public ICommand EditClientCommand { get; set; }
        public ICommand DeleteClientCommand { get; set; }
        public ICommand AddStaffCommand { get; set; }
        public ICommand EditStaffCommand { get; set; }
        public ICommand DeleteStaffCommand { get; set; }
        public ICommand AddBusCommand { get; set; }
        public ICommand EditBusCommand { get; set; }
        public ICommand DeleteBusCommand { get; set; }
        public ICommand AddRouteCommand { get; set; }
        public ICommand EditRouteCommand { get; set; }
        public ICommand DeleteRouteCommand { get; set; }
        public ICommand AddDriverCommand { get; set; }
        public ICommand EditDriverCommand { get; set; }
        public ICommand DeleteDriverCommand { get; set; }
        public ICommand AddBusStationCommand { get; set; }
        public ICommand EditBusStationCommand { get; set; }
        public ICommand DeleteBusStationCommand { get; set; }
        public ICommand AddScheduleCommand { get; set; }
        public ICommand EditScheduleCommand { get; set; }
        public ICommand DeleteScheduleCommand { get; set; }
        public ICommand AddCashierCommand { get; set; }
        public ICommand EditCashierCommand { get; set; }
        public ICommand DeleteCashierCommand { get; set; }
        public ICommand AddReceiptCommand { get; set; }
        public ICommand EditReceiptCommand { get; set; }
        public ICommand DeleteReceiptCommand { get; set; }
        //UserControlCommand
        public ICommand SelectTagClient { get; set; }
        public ICommand SelectTagStaff { get; set; }
        public ICommand SelectTagDriver { get; set; }
        public ICommand SelectTagBusStation { get; set; }
        public ICommand SelectTagBus { get; set; }
        public ICommand SelectTagRoute { get; set; }
        public ICommand SelectTagSchedule { get; set; }
        public ICommand SelectTagCashier { get; set; }
        public ICommand SelectTagReceipt { get; set; }
        //Search Command
        public ICommand SearchClient { get; set; }
        public ICommand SearchDriver { get; set; }
        public ICommand SearchStaff { get; set; }
        public ICommand SearchBus { get; set; }
        public ICommand SearchBusStation { get; set; }
        public ICommand SearchRoute { get; set; }
        public ICommand SearchSchedule { get; set; }
        public ICommand SearchCashier { get; set; }
        public ICommand SearchReceipt { get; set; }

        public MainViewModel()
        {
            BenXe = new List<string>();
            HoTenNV = new List<string>();
            HoTenTX = new List<string>();
            BienSoXe = new List<string>();
            HoTenTN = new List<string>();
            IDTuyenXe = new List<string>();
            HoTenHK = new List<string>();
            IDLichTrinh = new List<string>();
            IDGhe = new List<string>();
            //Load MainWindow
            LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) => 
            {
                if(p == null)
                    return;
                //p.Hide();
                //LoginWindow lg = new LoginWindow();
                //lg.ShowDialog();
                //var lgVM = lg.DataContext as LoginViewModel;
                //if (lgVM == null)
                //    return;
                //if (lgVM.isLogin)
                //{
                //    p.Show();
                //}
                //else
                //    p.Close();
                
                //Load Tag 
                var mainWd = p as MainWindow;
                LoadDataClient(mainWd.ucContainerClient);
                LoadDataStaff(mainWd.ucContainerStaff);
                LoadDataDriver(mainWd.ucContainerDriver);
                LoadDataBusStation(mainWd.ucContainerBusStation);
                LoadDataBus(mainWd.ucContainerBus);
                LoadDataRoute(mainWd.ucContainerRoute);
                LoadDataSchedule(mainWd.ucContainerSchedule);
                LoadDataCashier(mainWd.ucContainerCashier);
                LoadDataReceipt(mainWd.ucContainerReceipt);
            });
            //Load Data
            ListClient = new ObservableCollection<HANHKHACH>(DataProvider.Ins.db.HANHKHACHes);
            foreach (var hk in ListClient)
                HoTenHK.Add(hk.TenHanhKhach);
            ListDriver = new ObservableCollection<TAIXE>(DataProvider.Ins.db.TAIXEs);
            foreach (var tx in ListDriver)
                HoTenTX.Add(tx.TenTaiXe);
            ListStaff = new ObservableCollection<NHANVIEN>(DataProvider.Ins.db.NHANVIENs);
            foreach (var px in ListStaff)
                HoTenNV.Add(px.HoTenNhanVien);
            ListBusStation = new ObservableCollection<BENXE>(DataProvider.Ins.db.BENXEs);
            foreach (var bx in ListBusStation)
                BenXe.Add(bx.TenBenXe);
            ListBus = new ObservableCollection<XEKHACH>(DataProvider.Ins.db.XEKHACHes);
            foreach (var bx in ListBus)
                BienSoXe.Add(bx.BienSoXe);
            ListRoute = new ObservableCollection<TUYENXE>(DataProvider.Ins.db.TUYENXEs);
            foreach (var tx in ListRoute)
                IDTuyenXe.Add(tx.IDTuyenXe);
            ListSchedule = new ObservableCollection<LICHTRINH>(DataProvider.Ins.db.LICHTRINHs);
            foreach (var lt in ListSchedule)
                IDLichTrinh.Add(lt.IDLICHTRINH);
            ListCashier = new ObservableCollection<THUNGAN>(DataProvider.Ins.db.THUNGANs);
            foreach (var tn in ListCashier)
                HoTenTN.Add(tn.HoTen);
            ListReceipt = new ObservableCollection<BIENLAI>(DataProvider.Ins.db.BIENLAIs);
            ListSeat = new ObservableCollection<GHE>(DataProvider.Ins.db.GHEs);
            //Command Button Add, Edit, Delete
            //Client
            SelectedItemClient = new HANHKHACH();
            AddClientCommand = new RelayCommand<StackPanel>((p) => { return true; }, (p) => { 
                AddClientWd wd = new AddClientWd(); 
                var clientVM = wd.DataContext as AddClientVM;
                
                wd.ShowDialog();
                if (clientVM.isAdd)
                {
                    ListClient.Add(clientVM.ListNew[clientVM.index-1]);
                    HoTenHK.Add(ListClient.Last().TenHanhKhach);
                    LoadDataClient(p);
                }
            });
            EditClientCommand = new RelayCommand<ListView>((p) => {
                if (SelectedTagClient == null)
                    return false;
                return true;
            }, (p) => { 
                EditClientWd wd = new EditClientWd();
                var editVM = wd.DataContext as EditClientVM;
                editVM.New2.Tuoi= SelectedItemClient.Tuoi;
                editVM.New2.IDHanhKhach = SelectedItemClient.IDHanhKhach;
                editVM.New2.CCCD = SelectedItemClient.CCCD;
                editVM.New2.TenHanhKhach= SelectedItemClient.TenHanhKhach;
                editVM.New2.DiaChiHK = SelectedItemClient.DiaChiHK;
                editVM.New2.GioiTinh = SelectedItemClient.GioiTinh;
                editVM.New2.SDTHK = SelectedItemClient.SDTHK;
                editVM.New = editVM.New2;
                wd.ShowDialog();
                if(editVM.isEdit)
                {
                    int index = ListClient.IndexOf(SelectedItemClient);
                    HoTenHK.RemoveAt(index);
                    HoTenHK.Insert(index, editVM.New.TenHanhKhach);
                    var uc = SelectedTagClient as TagClientUC;
                    SelectedItemClient.TenHanhKhach = uc.TenHanhKhach.Text = editVM.New.TenHanhKhach;
                    SelectedItemClient.IDHanhKhach = uc.IDHanhKhach.Text = editVM.New.IDHanhKhach;
                    SelectedItemClient.Tuoi = uc.Tuoi.Text = editVM.New.Tuoi;
                    SelectedItemClient.CCCD = uc.CCCD.Text = editVM.New.CCCD;
                    SelectedItemClient.SDTHK = uc.SDT.Text = editVM.New.SDTHK;
                    SelectedItemClient.DiaChiHK = uc.DiaChi.Text = editVM.New.DiaChiHK;
                    SelectedItemClient.GioiTinh = uc.GioiTinh.Text = editVM.New.GioiTinh;
                }
            });
            DeleteClientCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagClient == null)
                    return false;
                return true;
            }, (p) => { 
                
            });
            //Staff
            SelectedItemStaff = new NHANVIEN();
            AddStaffCommand = new RelayCommand<StackPanel>((p) => { return true; }, (p) => {
                AddStaffWd wd = new AddStaffWd();
                wd.ShowDialog();
                var staffVM = wd.DataContext as AddStaffVM;
                if (staffVM.isAdd)
                {
                    ListStaff.Add(staffVM.ListNew[staffVM.index - 1]);
                    HoTenNV.Add(ListStaff.Last().HoTenNhanVien);
                    LoadDataStaff(p);
                }
            });
            EditStaffCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagStaff == null)
                    return false;
                return true;
            }, (p) => {
                EditStaffWd wd = new EditStaffWd();
                var editVM = wd.DataContext as EditStaffVM;
                editVM.New2.CCCDNV = SelectedItemStaff.CCCDNV;
                editVM.New2.HoTenNhanVien = SelectedItemStaff.HoTenNhanVien;
                editVM.New2.SoDienThoai = SelectedItemStaff.SoDienThoai;
                editVM.New2.NgaySinh = SelectedItemStaff.NgaySinh;
                editVM.New2.DiaChi = SelectedItemStaff.DiaChi;
                editVM.New2.GioiTinh = SelectedItemStaff.GioiTinh;
                editVM.New2.Luong = SelectedItemStaff.Luong;
                editVM.Luong = SelectedItemStaff.Luong.ToString();
                editVM.New = editVM.New2;
                wd.ShowDialog();
                if (editVM.isEdit)
                {
                    int index = ListStaff.IndexOf(SelectedItemStaff);
                    HoTenNV.RemoveAt(index);
                    HoTenNV.Insert(index,editVM.New.HoTenNhanVien);
                    var uc = SelectedTagStaff as TagStaffUC;
                    SelectedItemStaff.CCCDNV = uc.CCCD.Text = editVM.New.CCCDNV;
                    SelectedItemStaff.HoTenNhanVien = uc.HoTen.Text = editVM.New.HoTenNhanVien;
                    SelectedItemStaff.GioiTinh = uc.GioiTinh.Text = editVM.New.GioiTinh;
                    SelectedItemStaff.SoDienThoai = uc.SDT.Text = editVM.New.SoDienThoai;
                    SelectedItemStaff.DiaChi = uc.DiaChi.Text = editVM.New.DiaChi;
                    uc.NgaySinh.Text = editVM.New.NgaySinh.Value.ToString("dd/MM/yyyy");
                    SelectedItemStaff.NgaySinh = editVM.New.NgaySinh;
                    uc.Luong.Text = editVM.Luong;
                    SelectedItemStaff.Luong = editVM.New.Luong;
                }
            });
            DeleteStaffCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagStaff == null)
                    return false;
                return true;
            }, (p) => {
                ListStaff.Remove(SelectedItemStaff);
            });
            //Cashier
            SelectedItemCashier = new THUNGAN();
            AddCashierCommand = new RelayCommand<StackPanel>((p) => { return true; }, (p) => {
                AddCashierWd wd = new AddCashierWd();
                wd.ShowDialog();
                var addVM = wd.DataContext as AddCashierVM;
                if (addVM.isAdd)
                {
                    ListCashier.Add(addVM.ListNew[addVM.index - 1]);
                    HoTenTN.Add(ListCashier.Last().HoTen);
                    LoadDataCashier(p);
                }
            });
            EditCashierCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagCashier == null)
                    return false;
                return true;
            }, (p) => {
                EditCashierWd wd = new EditCashierWd();
                var editVM = wd.DataContext as EditCashierVM;
                editVM.New2.CCCDTN = SelectedItemCashier.CCCDTN;
                editVM.New2.HoTen = SelectedItemCashier.HoTen;
                editVM.New2.SoDienThoai = SelectedItemCashier.SoDienThoai;
                editVM.New2.NgaySinh = SelectedItemCashier.NgaySinh;
                editVM.New2.DiaChi = SelectedItemCashier.DiaChi;
                editVM.New2.GioiTinh = SelectedItemCashier.GioiTinh;
                editVM.New2.Luong = SelectedItemCashier.Luong;
                editVM.Luong = SelectedItemCashier.Luong.ToString();
                editVM.New = editVM.New2;
                wd.ShowDialog();
                if (editVM.isEdit)
                {
                    int index = ListCashier.IndexOf(SelectedItemCashier);
                    HoTenTN.RemoveAt(index);
                    HoTenTN.Insert(index, editVM.New.HoTen);
                    var uc = SelectedTagCashier as TagCashierUC;
                    SelectedItemCashier.CCCDTN = uc.CCCD.Text = editVM.New.CCCDTN;
                    SelectedItemCashier.HoTen = uc.HoTen.Text = editVM.New.HoTen;
                    SelectedItemCashier.GioiTinh = uc.GioiTinh.Text = editVM.New.GioiTinh;
                    SelectedItemCashier.SoDienThoai = uc.SDT.Text = editVM.New.SoDienThoai;
                    SelectedItemCashier.DiaChi = uc.DiaChi.Text = editVM.New.DiaChi;
                    uc.NgaySinh.Text = editVM.New.NgaySinh.Value.ToString("dd/MM/yyyy");
                    SelectedItemCashier.NgaySinh = editVM.New.NgaySinh;
                    uc.Luong.Text = editVM.Luong;
                    SelectedItemCashier.Luong = editVM.New.Luong;
                }
            });
            DeleteCashierCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagCashier == null)
                    return false;
                return true;
            }, (p) => {

            });
            //Bus
            SelectedItemBus = new XEKHACH();
            AddBusCommand = new RelayCommand<StackPanel>((p) => { return true; }, (p) => {
                AddBusWd wd = new AddBusWd();
                var BusVM = wd.DataContext as AddBusVM;
                BusVM.ListPhuXe = HoTenNV;
                BusVM.ListTaiXe = HoTenTX;
                BusVM.listTX = ListDriver;
                BusVM.listPX = ListStaff;
                wd.ShowDialog();
                if (BusVM.isAdd)
                {
                    ListBus.Add(BusVM.ListNew[BusVM.index - 1]);
                    BienSoXe.Add(ListBus.Last().BienSoXe);
                    LoadDataBus(p);
                }
            });
            EditBusCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagBus == null)
                    return false;
                return true;
            }, (p) => {
                EditBusWd wd = new EditBusWd();
                var editVM = wd.DataContext as EditBusVM;
                editVM.ListPhuXe = HoTenNV;
                editVM.ListTaiXe = HoTenTX;
                editVM.listTX = ListDriver;
                editVM.listPX = ListStaff;
                editVM.New2.NHANVIEN = SelectedItemBus.NHANVIEN;
                editVM.New2.TAIXE = SelectedItemBus.TAIXE;
                editVM.New2.SoGhe = SelectedItemBus.SoGhe;
                editVM.New2.CCCDNV = SelectedItemBus.CCCDNV;
                editVM.New2.CCCDTX = SelectedItemBus.CCCDTX;
                editVM.New2.BienSoXe = SelectedItemBus.BienSoXe;
                editVM.New2.LoaiXe = SelectedItemBus.LoaiXe;
                editVM.New2.TinhTrang = SelectedItemBus.TinhTrang;
                editVM.TaiXe = SelectedItemBus.TAIXE.TenTaiXe;
                editVM.PhuXe = SelectedItemBus.NHANVIEN.HoTenNhanVien;
                editVM.New = editVM.New2;
                wd.ShowDialog();
                if (editVM.isEdit)
                {
                    var uc = SelectedTagBus as TagBusUC;
                    SelectedItemBus.BienSoXe = uc.BienSoXe.Text = editVM.New.BienSoXe;
                    SelectedItemBus.LoaiXe = uc.LoaiXe.Text = editVM.New.LoaiXe;
                    SelectedItemBus.CCCDTX = editVM.New.CCCDTX;
                    SelectedItemBus.CCCDNV = editVM.New.CCCDNV;
                    uc.SoGhe.Text = editVM.New.SoGhe.ToString();
                    SelectedItemBus.TinhTrang = uc.TinhTrang.Text = editVM.New.TinhTrang;
                    SelectedItemBus.SoGhe = editVM.New.SoGhe;
                    uc.TX.Text = editVM.New.TAIXE.TenTaiXe;
                    uc.PX.Text = editVM.New.NHANVIEN.HoTenNhanVien;
                    SelectedItemBus.NHANVIEN = editVM.New.NHANVIEN;
                    SelectedItemBus.TAIXE = editVM.New.TAIXE;
                }
            });
            DeleteBusCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagBus == null)
                    return false;
                return true;
            }, (p) => {
                
            });
            //Route
            SelectedItemRoute = new TUYENXE();
            AddRouteCommand = new RelayCommand<StackPanel>((p) => { return true; }, (p) => 
            { 
                AddRouteWd wd = new AddRouteWd(); 
                var RouteVM = wd.DataContext as AddRouteVM;
                RouteVM.BenXe = BenXe;
                RouteVM.listBX = ListBusStation;
                wd.ShowDialog();
                if (RouteVM.isAdd)
                {
                    ListRoute.Add(RouteVM.ListNew[RouteVM.index - 1]);
                    IDTuyenXe.Add(ListRoute.Last().IDTuyenXe);
                    LoadDataRoute(p);
                }
            });
            EditRouteCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagRoute == null)
                    return false;
                return true;
            }, (p) => {
                EditRouteWd wd = new EditRouteWd();
                var editVM = wd.DataContext as EditRouteVM;
                editVM.BenXe = BenXe;
                editVM.listBX = ListBusStation;
                editVM.New2.BENXE1 = SelectedItemRoute.BENXE1;
                editVM.New2.BENXE = SelectedItemRoute.BENXE;
                editVM.New2.IDTuyenXe = SelectedItemRoute.IDTuyenXe;
                editVM.New2.IDBenXeXuatPhat = SelectedItemRoute.IDBenXeXuatPhat;
                editVM.New2.IDBenKetThuc = SelectedItemRoute.IDBenKetThuc;
                editVM.BenXeXP = SelectedItemRoute.BENXE1.TenBenXe;
                editVM.BenXeDD = SelectedItemRoute.BENXE.TenBenXe;
                editVM.New2.GioXuatPhat = SelectedItemRoute.GioXuatPhat;
                editVM.New2.ThoiGianDuKien = SelectedItemRoute.ThoiGianDuKien;
                editVM.GioDD = Convert.ToDateTime(SelectedItemRoute.ThoiGianDuKien.ToString());
                editVM.GioXP = Convert.ToDateTime(SelectedItemRoute.GioXuatPhat.ToString());
                editVM.New = editVM.New2;
                wd.ShowDialog();
                if (editVM.isEdit)
                {
                    var uc = SelectedTagRoute as TagRouteUC;
                    SelectedItemRoute.IDTuyenXe = uc.IDTuyenXe.Text = editVM.New.IDTuyenXe;
                    uc.BenXeXP.Text = editVM.New.BENXE1.TenBenXe;
                    uc.BenXeDD.Text = editVM.New.BENXE.TenBenXe;
                    uc.GioXP.Text = editVM.New.GioXuatPhat.ToString();
                    uc.GioDD.Text = editVM.New.ThoiGianDuKien.ToString();
                    SelectedItemRoute.BENXE1 = editVM.New.BENXE1;
                    SelectedItemRoute.BENXE = editVM.New.BENXE;
                    SelectedItemRoute.IDBenXeXuatPhat = editVM.New.IDBenXeXuatPhat;
                    SelectedItemRoute.IDBenKetThuc = editVM.New.IDBenKetThuc;
                    SelectedItemRoute.GioXuatPhat = editVM.New.GioXuatPhat;
                    SelectedItemRoute.ThoiGianDuKien = editVM.New.ThoiGianDuKien;
                }
            });
            DeleteRouteCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagRoute == null)
                    return false;
                return true;
            }, (p) => { });
            //Driver
            SelectedItemDriver = new TAIXE();
            AddDriverCommand = new RelayCommand<StackPanel>((p) => { return true; }, (p) => { 
                AddDriverWd wd = new AddDriverWd(); 
                wd.ShowDialog();
                var driverVM = wd.DataContext as AddDriverVM;
                if (driverVM.isAdd)
                {
                    ListDriver.Add(driverVM.ListNew[driverVM.index - 1]);
                    HoTenTX.Add(ListDriver.Last().TenTaiXe);
                    LoadDataDriver(p);
                }
            });
            EditDriverCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagDriver == null)
                    return false;
                return true;
            }, (p) => {
                EditDriverWd wd = new EditDriverWd();
                var editVM = wd.DataContext as EditDriverVM;
                editVM.New2.CCCDTX = SelectedItemDriver.CCCDTX;
                editVM.New2.TenTaiXe = SelectedItemDriver.TenTaiXe;
                editVM.New2.DiaChi = SelectedItemDriver.DiaChi;
                editVM.New2.SoDienThoai = SelectedItemDriver.SoDienThoai;
                editVM.New2.NgaySinh = SelectedItemDriver.NgaySinh;
                editVM.New2.BangLai = SelectedItemDriver.BangLai;
                editVM.New2.Luong = SelectedItemDriver.Luong;
                editVM.Luong = SelectedItemDriver.Luong.ToString();
                editVM.New = editVM.New2;
                wd.ShowDialog();
                if (editVM.isEdit)
                {
                    int index = ListDriver.IndexOf(SelectedItemDriver);
                    HoTenTX.RemoveAt(index);
                    HoTenTX.Insert(index, editVM.New.TenTaiXe);
                    var uc = SelectedTagDriver as TagDriverUC;
                    SelectedItemDriver.TenTaiXe = uc.HoTen.Text = editVM.New.TenTaiXe;
                    SelectedItemDriver.CCCDTX = uc.CCCD.Text = editVM.New.CCCDTX;
                    uc.NgaySinh.Text = editVM.New.NgaySinh.Value.ToString("dd/MM/yyyy");
                    SelectedItemDriver.DiaChi = uc.DiaChi.Text = editVM.New.DiaChi;
                    SelectedItemDriver.SoDienThoai = uc.SDT.Text = editVM.New.SoDienThoai;
                    SelectedItemDriver.BangLai = uc.BangLai.Text = editVM.New.BangLai;
                    SelectedItemDriver.NgaySinh = editVM.New.NgaySinh;
                    uc.Luong.Text = editVM.New.Luong.ToString();
                    SelectedItemDriver.Luong = editVM.New.Luong;
                }
            });
            DeleteDriverCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagDriver == null)
                    return false;
                return true;
            }, (p) => { 
               
            });
            //Bus Station
            SelectedItemBusStation = new BENXE();
            AddBusStationCommand = new RelayCommand<StackPanel>((p) => { return true; }, (p) => {
                AddBusStationWd wd = new AddBusStationWd();
                wd.ShowDialog();
                var busstationVM = wd.DataContext as AddBusStationVM;
                if (busstationVM.isAdd)
                {
                    ListBusStation.Add(busstationVM.ListNew[busstationVM.index - 1]);
                    BenXe.Add(ListBusStation.Last().TenBenXe);
                    LoadDataBusStation(p);
                }
            });
            EditBusStationCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagBusStation == null)
                    return false;
                return true;
            }, (p) => {
                EditBusStationWd wd = new EditBusStationWd();
                var editVM = wd.DataContext as EditBusStationVM;
                editVM.New2.TenBenXe = SelectedItemBusStation.TenBenXe;
                editVM.New2.SoDienThoaiBen = SelectedItemBusStation.SoDienThoaiBen;
                editVM.New2.IDBenXe = SelectedItemBusStation.IDBenXe;
                editVM.New2.DiaChi = SelectedItemBusStation.DiaChi;
                editVM.New = editVM.New2;
                wd.ShowDialog();
                if (editVM.isEdit)
                {
                    int index = ListBusStation.IndexOf(SelectedItemBusStation);
                    BenXe.RemoveAt(index);
                    BenXe.Insert(index,editVM.New.TenBenXe);
                    var uc = SelectedTagBusStation as TagBusStationUC;
                    SelectedItemBusStation.TenBenXe = uc.TenBenXe.Text = editVM.New.TenBenXe;
                    SelectedItemBusStation.IDBenXe = uc.ID.Text = editVM.New.IDBenXe;
                    SelectedItemBusStation.DiaChi = uc.DiaChi.Text = editVM.New.DiaChi;
                    SelectedItemBusStation.SoDienThoaiBen = uc.SDT.Text = editVM.New.SoDienThoaiBen;
                }
            });
            DeleteBusStationCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagBusStation == null)
                    return false;
                return true;
            }, (p) => {
                
            });
            //Schedule
            SelectedItemSchedule = new LICHTRINH();
            AddScheduleCommand = new RelayCommand<StackPanel>((p) => { return true; }, (p) => {
                AddScheduleWd wd = new AddScheduleWd();
                var addVM = wd.DataContext as AddScheduleVM;
                addVM.BienSoXe = BienSoXe;
                addVM.IDTuyenXe = IDTuyenXe;
                addVM.listXK = ListBus;
                addVM.listTX = ListRoute;
                wd.ShowDialog();
                if (addVM.isAdd)
                {
                    ListSchedule.Add(addVM.ListNew[addVM.index - 1]);
                    IDLichTrinh.Add(ListSchedule.Last().IDLICHTRINH);
                    LoadDataSchedule(p);
                }
            });
            EditScheduleCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagSchedule == null)
                    return false;
                return true;
            }, (p) => {
                EditScheduleWd wd = new EditScheduleWd();
                var editVM = wd.DataContext as EditScheduleVM;
                editVM.BienSoXe = BienSoXe;
                editVM.IDTuyenXe = IDTuyenXe;
                editVM.listXK = ListBus;
                editVM.listTX = ListRoute;
                editVM.New2.IDLICHTRINH = SelectedItemSchedule.IDLICHTRINH;
                editVM.New2.BienSoXe = SelectedItemSchedule.BienSoXe;
                editVM.New2.IDTuyenXe = SelectedItemSchedule.IDTuyenXe;
                editVM.New2.GiaVe = SelectedItemSchedule.GiaVe;
                editVM.New2.NgayXuatPhat = SelectedItemSchedule.NgayXuatPhat;
                editVM.New2.TUYENXE = SelectedItemSchedule.TUYENXE;
                editVM.New2.XEKHACH = SelectedItemSchedule.XEKHACH;
                editVM.GiaVe = SelectedItemSchedule.GiaVe.ToString();
                editVM.New = editVM.New2;
                wd.ShowDialog();
                if (editVM.isedit)
                {
                    var uc = SelectedTagSchedule as TagScheduleUC;
                    SelectedItemSchedule.IDLICHTRINH = uc.ID.Text = editVM.New.IDLICHTRINH;
                    SelectedItemSchedule.BienSoXe = uc.BienSoXe.Text = editVM.New.BienSoXe;
                    uc.BenXuatPhat.Text = editVM.New.TUYENXE.BENXE1.TenBenXe;
                    uc.BenKetThuc.Text = editVM.New.TUYENXE.BENXE.TenBenXe;
                    uc.GiaVe.Text = editVM.New.GiaVe.ToString();
                    DateTime ngay = (DateTime)editVM.New.NgayXuatPhat;
                    DateTime time = ngay.Add((TimeSpan)editVM.New.TUYENXE.GioXuatPhat);
                    uc.ThoiGianXuatPhat.Text = time.ToString();
                    uc.ThoiGianDuKien.Text = editVM.New.TUYENXE.ThoiGianDuKien.ToString();
                    SelectedItemSchedule.IDTuyenXe = editVM.New.IDTuyenXe;
                    SelectedItemSchedule.GiaVe = editVM.New.GiaVe;
                    SelectedItemSchedule.NgayXuatPhat = editVM.New.NgayXuatPhat;
                    SelectedItemSchedule.TUYENXE = editVM.New.TUYENXE;
                    SelectedItemSchedule.XEKHACH = editVM.New.XEKHACH;
                }
            });
            //Receipt
            AddReceiptCommand = new RelayCommand<StackPanel>((p) => { return true; }, (p) => {
                AddReceiptWd wd = new AddReceiptWd();
                var addVM = wd.DataContext as AddReceiptVM;
                addVM.LHanhKhach = HoTenHK;
                addVM.LThuNgan = HoTenTN;
                addVM.LLichTrinh = IDLichTrinh;
                addVM.listG = ListSeat;
                addVM.listHK = ListClient;
                addVM.listTN = ListCashier;
                addVM.listLT = ListSchedule;
                wd.ShowDialog();
                if (addVM.isAdd)
                {
                    ListReceipt.Add(addVM.ListNew[addVM.index - 1]);
                    LoadDataReceipt(p);
                }
            });
            EditReceiptCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagReceipt == null)
                    return false;
                return true;
            }, (p) => {
                EditReceiptWd wd = new EditReceiptWd();
                var editVM = wd.DataContext as EditReceiptVM;
                editVM.LHanhKhach = HoTenHK;
                editVM.LThuNgan = HoTenTN;
                editVM.LLichTrinh = IDLichTrinh;
                List<string> listG = new List<string>();
                foreach (var gh in ListSeat)
                    if (gh.TINHTRANG == false || gh.IDGhe == SelectedItemReceipt.IDGhe)
                        listG.Add(gh.IDGhe);
                editVM.LGhe = listG;
                editVM.listG = ListSeat;
                editVM.listHK = ListClient;
                editVM.listTN = ListCashier;
                editVM.listLT = ListSchedule;
                editVM.New2.IDBienLai = SelectedItemReceipt.IDBienLai;
                editVM.New2.IDGhe = SelectedItemReceipt.IDGhe;
                editVM.New2.GiamGia = SelectedItemReceipt.GiamGia;
                editVM.New2.NgayMua = SelectedItemReceipt.NgayMua;
                editVM.New2.ThuNgan = SelectedItemReceipt.ThuNgan;
                editVM.New2.IDHanhKhach = SelectedItemReceipt.IDHanhKhach;
                editVM.New2.HANHKHACH = SelectedItemReceipt.HANHKHACH;
                editVM.New2.GHE = SelectedItemReceipt.GHE;
                editVM.New2.THUNGAN1 = SelectedItemReceipt.THUNGAN1;
                editVM.GiaVe = SelectedItemReceipt.GHE.LICHTRINH.GiaVe.ToString();
                editVM.IDLichTrinh = SelectedItemReceipt.GHE.IDLICHTRINH;
                editVM.ThuNgan = SelectedItemReceipt.THUNGAN1.HoTen;
                editVM.HanhKhach = SelectedItemReceipt.HANHKHACH.TenHanhKhach;
                editVM.New = editVM.New2;
                wd.ShowDialog();
                if (editVM.isEdit)
                {
                    var uc = SelectedTagReceipt as TagReceiptUC;
                    SelectedItemReceipt.IDBienLai = uc.IDBienLai.Text = editVM.New.IDBienLai;
                    SelectedItemReceipt.IDHanhKhach = editVM.New.IDHanhKhach;
                    uc.IDLichTrinh.Text = editVM.New.GHE.IDLICHTRINH;
                    uc.TenHanhKhach.Text = editVM.New.HANHKHACH.TenHanhKhach;
                    uc.IDGhe.Text = editVM.New.IDGhe;
                    uc.NgayMua.Text = editVM.New.NgayMua?.ToString("dd/MM/yyyy");
                    uc.ThuNgan.Text = editVM.New.THUNGAN1.HoTen;
                    uc.GiaVe.Text = editVM.New.GHE.LICHTRINH.GiaVe.ToString();
                    uc.MaGiamGia.Text = editVM.New.GiamGia.ToString();
                    SelectedItemReceipt.IDGhe = editVM.New.IDGhe;
                    SelectedItemReceipt.GiamGia = editVM.New.GiamGia;
                    SelectedItemReceipt.NgayMua = editVM.New.NgayMua;
                    SelectedItemReceipt.ThuNgan = editVM.New.ThuNgan;
                    SelectedItemReceipt.GHE = editVM.New.GHE;
                    SelectedItemReceipt.THUNGAN1 = editVM.New.THUNGAN1;
                    SelectedItemReceipt.HANHKHACH = editVM.New.HANHKHACH;
                }
            });
            //UserControlCommand
            SelectTagClient = new RelayCommand<UserControl>((p) => { return true; }, (p) =>
            {
                if (SelectedTagClient != null)
                {
                    SelectedTagClient.Opacity = 0.8;
                }
                var uc = p as TagClientUC;
               foreach (var client in ListClient)
                    if(uc.IDHanhKhach.Text == client.IDHanhKhach)
                        SelectedItemClient = client;
                p.Opacity = 1;
                SelectedTagClient = p;
            });
            SelectTagStaff = new RelayCommand<UserControl>((p) => { return true; }, (p) =>
            {
                if (SelectedTagStaff != null)
                {
                    SelectedTagStaff.Opacity = 0.8;
                }
                var uc = p as TagStaffUC;
                foreach (var staff in ListStaff)
                    if (uc.CCCD.Text == staff.CCCDNV)
                        SelectedItemStaff = staff;
                p.Opacity = 1;
                SelectedTagStaff = p;
            });
            SelectTagDriver = new RelayCommand<UserControl>((p) => { return true; }, (p) =>
            {
                if (SelectedTagDriver != null)
                {
                    SelectedTagDriver.Opacity = 0.8;
                }
                var uc = p as TagDriverUC;
                foreach(var driver in ListDriver)
                    if(uc.CCCD.Text == driver.CCCDTX)
                        SelectedItemDriver = driver;
                p.Opacity = 1;
                SelectedTagDriver = p;
            });
            SelectTagBusStation = new RelayCommand<UserControl>((p) => { return true; }, (p) =>
            {
                if (SelectedTagBusStation != null)
                {
                    SelectedTagBusStation.Opacity = 0.8;
                }
                var uc = p as TagBusStationUC;
                foreach (var busstation in ListBusStation)
                    if (busstation.IDBenXe == uc.ID.Text)
                        SelectedItemBusStation = busstation;
                p.Opacity = 1;
                SelectedTagBusStation = p;
            });
            SelectTagBus = new RelayCommand<UserControl>((p) => { return true; }, (p) =>
            {
                if (SelectedTagBus != null)
                {
                    SelectedTagBus.Opacity = 0.7;
                }
                var uc = p as TagBusUC;
                foreach(var bus in ListBus)
                {
                    if (bus.BienSoXe == uc.BienSoXe.Text)
                        SelectedItemBus = bus;
                }
                p.Opacity = 1;
                SelectedTagBus = p;
            });
            SelectTagRoute = new RelayCommand<UserControl>((p) => { return true; }, (p) =>
            {
                if (SelectedTagRoute != null)
                {
                    SelectedTagRoute.Opacity = 0.7;
                }
                var uc = p as TagRouteUC;
                foreach(var route in ListRoute)
                {
                    if (route.IDTuyenXe == uc.IDTuyenXe.Text)
                        SelectedItemRoute = route;
                }
                p.Opacity = 1;
                SelectedTagRoute = p;
            });
            SelectTagSchedule = new RelayCommand<UserControl>((p) => { return true; }, (p) =>
            {
                if (SelectedTagSchedule != null)
                {
                    SelectedTagSchedule.Opacity = 0.8;
                }
                var uc = p as TagScheduleUC;
                foreach (var schedule in ListSchedule)
                {
                    if (schedule.IDLICHTRINH == uc.ID.Text)
                        SelectedItemSchedule = schedule;
                }
                p.Opacity = 1;
                SelectedTagSchedule = p;
            });
            SelectTagCashier = new RelayCommand<UserControl>((p) => { return true; }, (p) =>
            {
                if (SelectedTagCashier != null)
                {
                    SelectedTagCashier.Opacity = 0.8;
                }
                var uc = p as TagCashierUC;
                foreach (var cashier in ListCashier)
                    if (uc.CCCD.Text == cashier.CCCDTN)
                        SelectedItemCashier = cashier;
                p.Opacity = 1;
                SelectedTagCashier = p;
            });
            SelectTagReceipt = new RelayCommand<UserControl>((p) => { return true; }, (p) =>
            {
                if (SelectedTagReceipt != null)
                {
                    SelectedTagReceipt.Opacity = 0.8;
                }
                var uc = p as TagReceiptUC;
                foreach (BIENLAI bl in ListReceipt)
                {
                    if (bl.IDBienLai == uc.IDBienLai.Text)
                        SelectedItemReceipt = bl;
                }
                p.Opacity = 1;
                SelectedTagReceipt = p;
            });
            //Search Command
            SearchClient = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                MainWindow mw = p as MainWindow;
                mw.ucContainerClient.Children.Clear();
                string TenHK = mw.STenHK.Text;
                string MaHK = mw.SMaHK.Text;
                foreach (HANHKHACH hk in ListClient)
                {
                    int ok1 = 0, ok2 = 0, ok3 = 0;
                    if ((TenHK == null || TenHK == "") && (MaHK == null && MaHK == "")) ok1 = 1;
                    if ((TenHK == null || TenHK == null)) ok2 = -1;
                    else if (hk.TenHanhKhach.Contains(TenHK)) ok2 = 1;
                    if ((MaHK == null && MaHK == "")) ok3 = -1;
                    else if (hk.IDHanhKhach.Contains(MaHK)) ok3 = 1;
                    if (ok1 == 1 || (ok2 == 1 && ok3 == 1) || (ok2 == 1 && ok3 == -1) || (ok2 == -1 && ok3 == 1))
                    {
                        var uc = new TagClientUC();
                        uc.TenHanhKhach.Text = hk.TenHanhKhach;
                        uc.IDHanhKhach.Text = hk.IDHanhKhach;
                        uc.GioiTinh.Text = hk.GioiTinh;
                        uc.Tuoi.Text = hk.Tuoi;
                        uc.SDT.Text = hk.SDTHK;
                        uc.DiaChi.Text = hk.DiaChiHK;
                        uc.CCCD.Text = hk.CCCD;
                        mw.ucContainerClient.Children.Add(uc);
                    }
                }
                SelectedTagClient = null;
            });
            SearchDriver = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                MainWindow mw = p as MainWindow;
                mw.ucContainerDriver.Children.Clear();
                string TenTX = mw.STenTX.Text;
                foreach (TAIXE tx in ListDriver)
                {
                    if (TenTX == null || TenTX == "" || (tx.TenTaiXe.Contains(TenTX)))
                    {
                        var uc = new TagDriverUC();
                        uc.HoTen.Text = tx.TenTaiXe;
                        uc.CCCD.Text = tx.CCCDTX;
                        uc.NgaySinh.Text = tx.NgaySinh.Value.ToString("dd/MM/yyyy");
                        uc.BangLai.Text = tx.BangLai;
                        uc.DiaChi.Text = tx.DiaChi;
                        uc.SDT.Text = tx.SoDienThoai;
                        uc.Luong.Text = tx.Luong.ToString();
                        mw.ucContainerDriver.Children.Add(uc);
                    }
                }
                SelectedTagDriver = null;
            });
            SearchStaff = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                MainWindow mw = p as MainWindow;
                mw.ucContainerStaff.Children.Clear();
                string TenPX = mw.STenPX.Text;
                foreach (NHANVIEN nv in ListStaff)
                {

                    if ((TenPX == null || TenPX == "") || (nv.HoTenNhanVien.Contains(TenPX)))
                    {
                        var uc = new TagStaffUC();
                        uc.HoTen.Text = nv.HoTenNhanVien;
                        uc.CCCD.Text = nv.CCCDNV;
                        uc.GioiTinh.Text = nv.GioiTinh;
                        uc.SDT.Text = nv.SoDienThoai;
                        uc.DiaChi.Text = nv.DiaChi;
                        uc.NgaySinh.Text = nv.NgaySinh.Value.ToString("dd/MM/yyyy");
                        uc.Luong.Text = nv.Luong.ToString();
                        mw.ucContainerStaff.Children.Add(uc);
                    }
                }
                SelectedTagStaff = null;
            });
            SearchBus = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                MainWindow mw = p as MainWindow;
                mw.ucContainerBus.Children.Clear();
                string BienSX = mw.SBienSX.Text;
                string TenTX = mw.STenTX_Bus.Text;
                string TTX = "";
                foreach (XEKHACH xk in ListBus)
                {
                    foreach (TAIXE tx in ListDriver)
                    {
                        if (xk.CCCDTX == tx.CCCDTX)
                            TTX = tx.TenTaiXe;
                    }
                    int ok1 = 0, ok2 = 0, ok3 = 0;
                    if ((BienSX == null || BienSX == "") && (TenTX == null && TenTX == "")) ok1 = 1;
                    if ((BienSX == null || BienSX == null)) ok2 = -1;
                    else if (xk.BienSoXe.Contains(BienSX)) ok2 = 1;
                    if ((TenTX == null && TenTX == "")) ok3 = -1;
                    else if (TTX.Contains(TenTX)) ok3 = 1;
                    if (ok1 == 1 || (ok2 == 1 && ok3 == 1) || (ok2 == 1 && ok3 == -1) || (ok2 == -1 && ok3 == 1))
                    {
                        var uc = new TagBusUC();
                        uc.BienSoXe.Text = xk.BienSoXe;
                        uc.LoaiXe.Text = xk.LoaiXe;
                        uc.TX.Text = xk.TAIXE.TenTaiXe;
                        uc.PX.Text = xk.NHANVIEN.HoTenNhanVien;
                        uc.SoGhe.Text = xk.SoGhe.ToString();
                        uc.TinhTrang.Text = xk.TinhTrang;
                        mw.ucContainerBus.Children.Add(uc);
                    }
                }
                SelectedTagBus = null;
            });
            SearchBusStation = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                MainWindow mw = p as MainWindow;
                mw.ucContainerBusStation.Children.Clear();
                string TenBX = mw.STenBX.Text;
                string DiaCHi = mw.SDiaChi.Text;
                foreach (BENXE bx in ListBusStation)
                {
                    int ok1 = 0, ok2 = 0, ok3 = 0;
                    if ((TenBX == null || TenBX == "") && (DiaCHi == null && DiaCHi == "")) ok1 = 1;
                    if ((TenBX == null || TenBX == null)) ok2 = -1;
                    else if (bx.TenBenXe.Contains(TenBX)) ok2 = 1;
                    if ((DiaCHi == null && DiaCHi == "")) ok3 = -1;
                    else if (bx.DiaChi.Contains(DiaCHi)) ok3 = 1;
                    if (ok1 == 1 || (ok2 == 1 && ok3 == 1) || (ok2 == 1 && ok3 == -1) || (ok2 == -1 && ok3 == 1))
                    {
                        var uc = new TagBusStationUC();
                        uc.TenBenXe.Text = bx.TenBenXe;
                        uc.ID.Text = bx.IDBenXe;
                        uc.DiaChi.Text = bx.DiaChi;
                        uc.SDT.Text = bx.SoDienThoaiBen;
                        mw.ucContainerBusStation.Children.Add(uc);
                    }
                }
                SelectedTagBusStation = null;
            });
            SearchRoute = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                MainWindow mw = p as MainWindow;
                mw.ucContainerRoute.Children.Clear();
                string bxxp = mw.SBenXP.SelectedValue?.ToString();
                string bxdd = mw.SBenDD.SelectedValue?.ToString();
                foreach (TUYENXE tx in ListRoute)
                {
                    int null1 = 0, null2 = 0;
                    if (bxxp == null) null1 = 1;
                    if(bxdd == null) null2 = 1;
                    if (bxxp == tx.BENXE1.TenBenXe) null1 = 2;
                    if (bxdd == tx.BENXE.TenBenXe) null2 = 2;
                    if((null1 ==1 && null2 == 1) || (null1 == 2 && null2 == 1) || (null1 == 1&&null2 ==2) || (null1 ==2 && null2 == 2))
                    {
                        var uc = new TagRouteUC();
                        uc.IDTuyenXe.Text = tx.IDTuyenXe;
                        uc.BenXeXP.Text = tx.BENXE1.TenBenXe;
                        uc.BenXeDD.Text = tx.BENXE.TenBenXe;
                        uc.GioXP.Text = tx.GioXuatPhat.ToString();
                        uc.GioDD.Text = tx.ThoiGianDuKien.ToString();
                        mw.ucContainerRoute.Children.Add(uc);
                    }
                }
                SelectedTagRoute = null;
            });
            SearchSchedule = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                MainWindow mw = p as MainWindow;
                mw.ucContainerSchedule.Children.Clear();
                string bxxp = mw.SBenXp.SelectedValue?.ToString();
                string bxdd = mw.SBenKt.SelectedValue?.ToString();
                string ngXP = mw.NgayXP.SelectedDate?.ToShortDateString();
                foreach (LICHTRINH lt in ListSchedule)
                {
                    int null1 = 0, null2 = 0, null3 = 0;
                    if (bxxp == null) null1 = 1;
                    if (bxdd == null) null2 = 1;
                    if (ngXP == null) null3 = 1;
                    if (bxxp == lt.TUYENXE.BENXE1.TenBenXe) null1 = 2;
                    if (bxdd == lt.TUYENXE.BENXE.TenBenXe) null2 = 2;
                    if (ngXP == lt.NgayXuatPhat?.ToShortDateString()) null3 = 2;
                    if ((null1 == 1 && null2 == 1 && null3 == 1) || (null1 == 2 && null2 == 1 && null3 == 1) || (null1 == 1 && null2 == 2 && null3 == 1) || (null1 == 1 && null2 == 1 && null3 == 2)
                    || (null1 == 2 && null2 == 2 && null3 == 1) || (null1 == 2 && null2 == 1 && null3 == 2) || (null1 == 1 && null2 == 2 && null3 == 2) || (null1 == 2 && null2 == 2 && null3 == 2))
                    {
                        var uc = new TagScheduleUC();
                        uc.BienSoXe.Text = lt.BienSoXe;
                        uc.BenXuatPhat.Text = lt.TUYENXE.BENXE1.TenBenXe;
                        uc.BenKetThuc.Text = lt.TUYENXE.BENXE.TenBenXe;
                        DateTime ngay = (DateTime)lt.NgayXuatPhat;
                        DateTime time = ngay.Add((TimeSpan)lt.TUYENXE.GioXuatPhat);
                        uc.ThoiGianXuatPhat.Text = time.ToString();
                        uc.ThoiGianDuKien.Text = lt.TUYENXE.ThoiGianDuKien.ToString();
                        uc.GiaVe.Text = lt.GiaVe.ToString();
                        uc.ID.Text = lt.IDLICHTRINH;
                        mw.ucContainerSchedule.Children.Add(uc);
                    }
                }
                SelectedTagSchedule = null;
            });
            SearchCashier = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                MainWindow mw = p as MainWindow;
                mw.ucContainerCashier.Children.Clear();
                string TenPX = mw.STenTN.Text;
                foreach (THUNGAN nv in ListCashier)
                {

                    if ((TenPX == null || TenPX == "") || (nv.HoTen.Contains(TenPX)))
                    {
                        var uc = new TagCashierUC();
                        uc.HoTen.Text = nv.HoTen;
                        uc.CCCD.Text = nv.CCCDTN;
                        uc.GioiTinh.Text = nv.GioiTinh;
                        uc.SDT.Text = nv.SoDienThoai;
                        uc.DiaChi.Text = nv.DiaChi;
                        uc.NgaySinh.Text = nv.NgaySinh.Value.ToString("dd/MM/yyyy");
                        uc.Luong.Text = nv.Luong.ToString();
                        mw.ucContainerCashier.Children.Add(uc);
                    }
                }
                SelectedTagCashier = null;
            });
            SearchReceipt = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                MainWindow mw = p as MainWindow;
                mw.ucContainerReceipt.Children.Clear();
                string TenHK = mw.STenHK_BL.Text;
                string IDLT = mw.SMaLT.SelectedValue?.ToString();
                foreach (BIENLAI bl in ListReceipt)
                {
                    int null1 = 0; int null2 = 0;
                    if (TenHK == "" || TenHK == null) null1 = 1;
                    if (IDLT == null) null2 = 1;
                    if (bl.HANHKHACH.TenHanhKhach.Contains(TenHK)) null1 = 2;
                    if (IDLT == bl.GHE.IDLICHTRINH) null2 = 2;
                    if((null1 == 1 && null2 ==1) || (null1 == 2 && null2 == 1) || (null1 == 1 && null2 == 2)|| (null1 == 2 && null2 == 2))
                    {
                        var uc = new TagReceiptUC();
                        uc.IDBienLai.Text = bl.IDBienLai;
                        uc.IDLichTrinh.Text = bl.GHE.IDLICHTRINH;
                        uc.TenHanhKhach.Text = bl.HANHKHACH.TenHanhKhach;
                        uc.IDGhe.Text = bl.IDGhe;
                        uc.NgayMua.Text = bl.NgayMua?.ToString("dd/MM/yyyy");
                        uc.ThuNgan.Text = bl.THUNGAN1.HoTen;
                        uc.GiaVe.Text = bl.GHE.LICHTRINH.GiaVe.ToString();
                        uc.MaGiamGia.Text = bl.GiamGia.ToString();
                        mw.ucContainerReceipt.Children.Add(uc);
                    }
                }
                SelectedTagReceipt = null;
            });
        }
        private void LoadDataClient(StackPanel sp)
        {
            sp.Children.Clear();
            foreach (HANHKHACH hk in ListClient)
            {
                var uc = new TagClientUC();
                uc.TenHanhKhach.Text = hk.TenHanhKhach;
                uc.IDHanhKhach.Text = hk.IDHanhKhach;
                uc.GioiTinh.Text = hk.GioiTinh;
                uc.Tuoi.Text = hk.Tuoi;
                uc.SDT.Text = hk.SDTHK;
                uc.DiaChi.Text = hk.DiaChiHK;
                uc.CCCD.Text = hk.CCCD;
                sp.Children.Add(uc);
            }
        }
        private void LoadDataStaff(StackPanel sp)
        {
            sp.Children.Clear();
            foreach (NHANVIEN nv in ListStaff)
            {
                var uc = new TagStaffUC();
                uc.HoTen.Text = nv.HoTenNhanVien;
                uc.CCCD.Text = nv.CCCDNV;
                uc.GioiTinh.Text = nv.GioiTinh;
                uc.SDT.Text = nv.SoDienThoai;
                uc.DiaChi.Text = nv.DiaChi;
                uc.NgaySinh.Text = nv.NgaySinh.Value.ToString("dd/MM/yyyy");
                uc.Luong.Text = nv.Luong.ToString();
                sp.Children.Add(uc);
            }

        }
        private void LoadDataDriver(StackPanel sp)
        {
            sp.Children.Clear();
            foreach (TAIXE tx in ListDriver)
            {
                var uc = new TagDriverUC();
                uc.HoTen.Text = tx.TenTaiXe;
                uc.CCCD.Text = tx.CCCDTX;
                uc.NgaySinh.Text = tx.NgaySinh.Value.ToString("dd/MM/yyyy");
                uc.BangLai.Text = tx.BangLai;
                uc.DiaChi.Text = tx.DiaChi;
                uc.SDT.Text = tx.SoDienThoai;
                uc.Luong.Text = tx.Luong.ToString();
                sp.Children.Add(uc);
            }
        }
        private void LoadDataBus(StackPanel sp)
        {
            sp.Children.Clear();
            foreach (XEKHACH xk in ListBus)
            {
                var uc = new TagBusUC();
                uc.BienSoXe.Text = xk.BienSoXe;
                uc.LoaiXe.Text = xk.LoaiXe;
                uc.TX.Text = xk.TAIXE.TenTaiXe;
                uc.PX.Text = xk.NHANVIEN.HoTenNhanVien;
                uc.SoGhe.Text = xk.SoGhe.ToString();
                uc.TinhTrang.Text = xk.TinhTrang;
                sp.Children.Add(uc);
            }
        }
        private void LoadDataBusStation(StackPanel sp)
        {
            sp.Children.Clear();
            foreach (BENXE bx in ListBusStation)
            {
                var uc = new TagBusStationUC();
                uc.TenBenXe.Text = bx.TenBenXe;
                uc.ID.Text =bx.IDBenXe;
                uc.DiaChi.Text = bx.DiaChi;
                uc.SDT.Text = bx.SoDienThoaiBen;
                sp.Children.Add(uc);
            }
        }
        private void LoadDataRoute(StackPanel sp)
        {
            sp.Children.Clear();
            foreach (TUYENXE tx in ListRoute)
            {
                var uc = new TagRouteUC();
                uc.IDTuyenXe.Text = tx.IDTuyenXe;
                uc.BenXeXP.Text = tx.BENXE1.TenBenXe;
                uc.BenXeDD.Text = tx.BENXE.TenBenXe;
                uc.GioXP.Text = tx.GioXuatPhat.ToString();
                uc.GioDD.Text = tx.ThoiGianDuKien.ToString();
                sp.Children.Add(uc);
            }
        }
        private void LoadDataSchedule(StackPanel sp)
        {
            sp.Children.Clear();
            foreach(var lt in ListSchedule)
            {
                var uc = new TagScheduleUC();
                uc.BienSoXe.Text = lt.BienSoXe;
                uc.BenXuatPhat.Text = lt.TUYENXE.BENXE1.TenBenXe;
                uc.BenKetThuc.Text = lt.TUYENXE.BENXE.TenBenXe;
                DateTime ngay = (DateTime)lt.NgayXuatPhat;
                DateTime time = ngay.Add((TimeSpan)lt.TUYENXE.GioXuatPhat); 
                uc.ThoiGianXuatPhat.Text = time.ToString();
                uc.ThoiGianDuKien.Text = lt.TUYENXE.ThoiGianDuKien.ToString();
                uc.GiaVe.Text = lt.GiaVe.ToString();
                uc.ID.Text = lt.IDLICHTRINH;
                sp.Children.Add(uc);
            }
        }
        private void LoadDataCashier(StackPanel sp)
        {
            sp.Children.Clear();
            foreach (THUNGAN nv in ListCashier)
            {
                var uc = new TagCashierUC();
                uc.HoTen.Text = nv.HoTen;
                uc.CCCD.Text = nv.CCCDTN;
                uc.GioiTinh.Text = nv.GioiTinh;
                uc.SDT.Text = nv.SoDienThoai;
                uc.DiaChi.Text = nv.DiaChi;
                uc.NgaySinh.Text = nv.NgaySinh.Value.ToString("dd/MM/yyyy");
                uc.Luong.Text = nv.Luong.ToString();
                sp.Children.Add(uc);
            }

        }
        private void LoadDataReceipt(StackPanel sp)
        {
            sp.Children.Clear();
            foreach (BIENLAI bl in ListReceipt)
            {
                var uc = new TagReceiptUC();
                uc.IDBienLai.Text = bl.IDBienLai;
                uc.IDLichTrinh.Text = bl.GHE.IDLICHTRINH;
                uc.TenHanhKhach.Text = bl.HANHKHACH.TenHanhKhach;
                uc.IDGhe.Text = bl.IDGhe;
                uc.NgayMua.Text = bl.NgayMua?.ToString("dd/MM/yyyy");
                uc.ThuNgan.Text = bl.THUNGAN1.HoTen;
                uc.GiaVe.Text = bl.GHE.LICHTRINH.GiaVe.ToString();
                uc.MaGiamGia.Text = bl.GiamGia.ToString(); 
                sp.Children.Add(uc);
            }

        }
    }
}
