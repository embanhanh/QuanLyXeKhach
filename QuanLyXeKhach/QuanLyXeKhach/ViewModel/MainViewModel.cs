using QuanLyXeKhach.AddWindow;
using QuanLyXeKhach.EditWindow;
using QuanLyXeKhach.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLyXeKhach.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        //List join
        public List<string> Route_BXXP = new List<string>();
        public List<string> Route_BXDD = new List<string>();
        //List
        private ObservableCollection<HANHKHACH> _ListClient;
        private ObservableCollection<TAIXE> _ListDriver;
        private ObservableCollection<NHANVIEN> _ListStaff;
        private ObservableCollection<XEKHACH> _ListBus;
        private ObservableCollection<BENXE> _ListBusStation;
        private ObservableCollection<TUYENXE> _ListRoute;
        public ObservableCollection<HANHKHACH> ListClient { get =>_ListClient;set { _ListClient = value; OnPropertyChanged(); } }
        public ObservableCollection<TAIXE> ListDriver { get => _ListDriver; set { _ListDriver = value; OnPropertyChanged(); } }
        public ObservableCollection<NHANVIEN> ListStaff { get => _ListStaff; set { _ListStaff = value; OnPropertyChanged(); } }
        public ObservableCollection<XEKHACH> ListBus { get => _ListBus; set { _ListBus = value; OnPropertyChanged(); } }
        public ObservableCollection<BENXE> ListBusStation { get => _ListBusStation; set { _ListBusStation = value; OnPropertyChanged(); } }
        public ObservableCollection<TUYENXE> ListRoute { get => _ListRoute; set { _ListRoute = value; OnPropertyChanged(); } }
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
        public MainViewModel()
        {
            //Load MainWindow
            LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) => 
            {
                if(p == null)
                    return;
                p.Hide();
                LoginWindow lg = new LoginWindow();
                lg.ShowDialog();
                var lgVM = lg.DataContext as LoginViewModel;
                if (lgVM == null)
                    return;
                if (lgVM.isLogin)
                {
                    p.Show();
                }
                else
                    p.Close(); 
            });
            //Load Data
            ListClient = new ObservableCollection<HANHKHACH>(DataProvider.Ins.db.HANHKHACHes);
            ListDriver = new ObservableCollection<TAIXE>(DataProvider.Ins.db.TAIXEs);
            ListStaff = new ObservableCollection<NHANVIEN>(DataProvider.Ins.db.NHANVIENs);
            ListBusStation = new ObservableCollection<BENXE>(DataProvider.Ins.db.BENXEs);
            ListBus = new ObservableCollection<XEKHACH>(DataProvider.Ins.db.XEKHACHes);
            ListRoute = new ObservableCollection<TUYENXE>(DataProvider.Ins.db.TUYENXEs);
            //Command Button Add, Edit, Delete
            //Client
            AddClientCommand = new RelayCommand<Object>((p) => { return true; }, (p) => { 
                AddClientWd wd = new AddClientWd(); 
                var clientVM = wd.DataContext as AddClientVM;
                
                wd.ShowDialog();
                if (clientVM.isAdd)
                    ListClient.Add(clientVM.ListNew[clientVM.index-1]);
            });
            EditClientCommand = new RelayCommand<ListView>((p) => {
                if (SelectedItemClient == null)
                    return false;
                return true;
            }, (p) => { 
                EditClientWd wd = new EditClientWd();
                var editVM = wd.DataContext as EditClientVM;
                editVM.New2.SoHieuGhe = SelectedItemClient.SoHieuGhe;
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
                    ListClient.RemoveAt(index);
                    SelectedItemClient = new HANHKHACH();
                    SelectedItemClient.SDTHK = editVM.New.SDTHK;
                    SelectedItemClient.DiaChiHK = editVM.New.DiaChiHK;
                    SelectedItemClient.CCCD = editVM.New.CCCD;
                    SelectedItemClient.IDHanhKhach = editVM.New.IDHanhKhach;
                    SelectedItemClient.TenHanhKhach = editVM.New.TenHanhKhach;
                    SelectedItemClient.GioiTinh = editVM.New.GioiTinh;
                    SelectedItemClient.Tuoi = editVM.New.Tuoi;
                    SelectedItemClient.SoHieuGhe = editVM.New.SoHieuGhe; 
                    ListClient.Insert(index, SelectedItemClient);
                }
            });
            DeleteClientCommand = new RelayCommand<Object>((p) => {
                if (SelectedItemClient == null)
                    return false;
                return true;
            }, (p) => { 
                ListClient.Remove(SelectedItemClient);
            });
            //Staff
            AddStaffCommand = new RelayCommand<Object>((p) => { return true; }, (p) => {
                AddStaffWd wd = new AddStaffWd();
                wd.ShowDialog();
                var staffVM = wd.DataContext as AddStaffVM;
                if (staffVM.isAdd)
                    ListStaff.Add(staffVM.ListNew[staffVM.index - 1]);
            });
            EditStaffCommand = new RelayCommand<Object>((p) => {
                if (SelectedItemStaff == null)
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
                editVM.New = editVM.New2;
                wd.ShowDialog();
                if (editVM.isEdit)
                {
                    int index = ListStaff.IndexOf(SelectedItemStaff);
                    ListStaff.RemoveAt(index);
                    SelectedItemStaff = new NHANVIEN();
                    SelectedItemStaff.CCCDNV = editVM.New.CCCDNV;
                    SelectedItemStaff.HoTenNhanVien = editVM.New.HoTenNhanVien;
                    SelectedItemStaff.SoDienThoai= editVM.New.SoDienThoai;
                    SelectedItemStaff.NgaySinh= editVM.New.NgaySinh;
                    SelectedItemStaff.DiaChi= editVM.New.DiaChi;
                    SelectedItemStaff.GioiTinh= editVM.New.GioiTinh;
                    ListStaff.Insert(index, SelectedItemStaff);
                }
            });
            DeleteStaffCommand = new RelayCommand<Object>((p) => {
                if (SelectedItemStaff == null)
                    return false;
                return true;
            }, (p) => {
                ListStaff.Remove(SelectedItemStaff);
            });
            //Bus
            AddBusCommand = new RelayCommand<Object>((p) => { return true; }, (p) => {
                AddBusWd wd = new AddBusWd();
                wd.ShowDialog();
                var BusVM = wd.DataContext as AddBusVM;
                if (BusVM.isAdd)
                    ListBus.Add(BusVM.ListNew[BusVM.index - 1]);
            });
            EditBusCommand = new RelayCommand<Object>((p) => {
                if (SelectedItemBus == null)
                    return false;
                return true;
            }, (p) => {
                EditBusWd wd = new EditBusWd();
                var editVM = wd.DataContext as EditBusVM;
                editVM.New2.SoGhe = SelectedItemBus.SoGhe;
                editVM.New2.CCCDNV = SelectedItemBus.CCCDNV;
                editVM.New2.CCCDTX = SelectedItemBus.CCCDTX;
                editVM.New2.BienSoXe = SelectedItemBus.BienSoXe;
                editVM.New2.LoaiXe = SelectedItemBus.LoaiXe;
                editVM.New2.TinhTrang = SelectedItemBus.TinhTrang;
                editVM.New = editVM.New2;
                wd.ShowDialog();
                if (editVM.isEdit)
                {
                    int index = ListBus.IndexOf(SelectedItemBus);
                    ListBus.RemoveAt(index);
                    SelectedItemBus = new XEKHACH();
                    SelectedItemBus.SoGhe = editVM.New.SoGhe;
                    SelectedItemBus.CCCDTX = editVM.New.CCCDTX;
                    SelectedItemBus.CCCDNV = editVM.New.CCCDNV;
                    SelectedItemBus.BienSoXe = editVM.New.BienSoXe;
                    SelectedItemBus.LoaiXe = editVM.New.LoaiXe;
                    SelectedItemBus.TinhTrang = editVM.New.TinhTrang;
                    ListBus.Insert(index, SelectedItemBus);
                }
            });
            DeleteBusCommand = new RelayCommand<Object>((p) => {
                if (SelectedItemBus == null)
                    return false;
                return true;
            }, (p) => {
                ListBus.Remove(SelectedItemBus);
            });
            //Route
            AddRouteCommand = new RelayCommand<Object>((p) => { return true; }, (p) => 
            { 
                AddRouteWd wd = new AddRouteWd(); 
                wd.ShowDialog();
                var RouteVM = wd.DataContext as AddRouteVM;
                if (RouteVM.isAdd)
                    ListRoute.Add(RouteVM.ListNew[RouteVM.index - 1]);
                var _BX = DataProvider.Ins.db.BENXEs.ToList();
                foreach (BENXE bx in _BX)
                {
                    if (ListRoute.Last().IDBenXeXuatPhat == bx.IDBenXe)
                    {
                        Route_BXXP.Add(bx.TenBenXe);
                        break;
                    }
                }
                foreach (BENXE bx in _BX)
                {
                    if (ListRoute.Last().IDBenKetThuc == bx.IDBenXe)
                    {
                        Route_BXDD.Add(bx.TenBenXe);
                        break;
                    }
                }
            });
            EditRouteCommand = new RelayCommand<Object>((p) => {
                if (SelectedItemRoute == null)
                    return false;
                return true;
            }, (p) => {
                EditRouteWd wd = new EditRouteWd();
                var editVM = wd.DataContext as EditRouteVM;
                editVM.New2.IDTuyenXe = SelectedItemRoute.IDTuyenXe;
                editVM.BenXeXP = SelectedItemRoute.BENXE1.TenBenXe;
                editVM.BenXeDD = SelectedItemRoute.BENXE.TenBenXe;
                editVM.NgayXP = (DateTime)SelectedItemRoute.ThoiGianXuatPhat;
                editVM.NgayDD = (DateTime)SelectedItemRoute.ThoiGianKetThuc;
                editVM.GioXP = (DateTime)SelectedItemRoute.ThoiGianXuatPhat;
                editVM.GioDD = (DateTime)SelectedItemRoute?.ThoiGianKetThuc;
                editVM.New = editVM.New2;
                wd.ShowDialog();
                if (editVM.isEdit)
                {
                    int index = ListRoute.IndexOf(SelectedItemRoute);
                    ListRoute.RemoveAt(index);
                    SelectedItemRoute = new TUYENXE();
                    SelectedItemRoute.IDTuyenXe = editVM.New.IDTuyenXe;
                    SelectedItemRoute.ThoiGianXuatPhat = editVM.New.ThoiGianXuatPhat;
                    SelectedItemRoute.ThoiGianKetThuc = editVM.New.ThoiGianKetThuc;
                    SelectedItemRoute.IDBenXeXuatPhat = editVM.New.IDBenXeXuatPhat;
                    SelectedItemRoute.IDBenKetThuc = editVM.New.IDBenKetThuc;
                    SelectedItemRoute.BENXE1 = editVM.New.BENXE1;
                    SelectedItemRoute.BENXE = editVM.New.BENXE;  
                    ListRoute.Insert(index, SelectedItemRoute);
                    Route_BXXP.RemoveAt(index);
                    Route_BXDD.RemoveAt(index);
                }
            });
            DeleteRouteCommand = new RelayCommand<Object>((p) => {
                if (SelectedItemRoute == null)
                    return false;
                return true;
            }, (p) => { });
            //Driver
            AddDriverCommand = new RelayCommand<Object>((p) => { return true; }, (p) => { 
                AddDriverWd wd = new AddDriverWd(); 
                wd.ShowDialog();
                var driverVM = wd.DataContext as AddDriverVM;
                if (driverVM.isAdd)
                    ListDriver.Add(driverVM.ListNew[driverVM.index - 1]);
            });
            EditDriverCommand = new RelayCommand<Object>((p) => {
                if (SelectedItemDriver == null)
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
                editVM.New = editVM.New2;
                wd.ShowDialog();
                if (editVM.isEdit)
                {
                    int index = ListDriver.IndexOf(SelectedItemDriver);
                    ListDriver.RemoveAt(index);
                    SelectedItemDriver = new TAIXE();
                    SelectedItemDriver.CCCDTX = editVM.New.CCCDTX;
                    SelectedItemDriver.TenTaiXe = editVM.New.TenTaiXe;
                    SelectedItemDriver.DiaChi = editVM.New.DiaChi;
                    SelectedItemDriver.SoDienThoai = editVM.New.SoDienThoai;
                    SelectedItemDriver.NgaySinh = editVM.New.NgaySinh;
                    SelectedItemDriver.BangLai = editVM.New.BangLai;
                    ListDriver.Insert(index, SelectedItemDriver);
                }
            });
            DeleteDriverCommand = new RelayCommand<Object>((p) => {
                if (SelectedItemDriver == null)
                    return false;
                return true;
            }, (p) => { 
                ListDriver.Remove(SelectedItemDriver);
            });
            //Bus Station
            AddBusStationCommand = new RelayCommand<Object>((p) => { return true; }, (p) => {
                AddBusStationWd wd = new AddBusStationWd();
                wd.ShowDialog();
                var busstationVM = wd.DataContext as AddBusStationVM;
                if (busstationVM.isAdd)
                    ListBusStation.Add(busstationVM.ListNew[busstationVM.index - 1]);
            });
            EditBusStationCommand = new RelayCommand<Object>((p) => {
                if (SelectedItemBusStation == null)
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
                    ListBusStation.RemoveAt(index);
                    SelectedItemBusStation = new BENXE();
                    SelectedItemBusStation.TenBenXe = editVM.New.TenBenXe;
                    SelectedItemBusStation.SoDienThoaiBen = editVM.New.SoDienThoaiBen;
                    SelectedItemBusStation.DiaChi = editVM.New.DiaChi;
                    SelectedItemBusStation.IDBenXe = editVM.New.IDBenXe;
                    ListBusStation.Insert(index, SelectedItemBusStation);
                }
            });
            DeleteBusStationCommand = new RelayCommand<Object>((p) => {
                if (SelectedItemBusStation == null)
                    return false;
                return true;
            }, (p) => {
                ListBusStation.Remove(SelectedItemBusStation);
            });
        }
    }
}
