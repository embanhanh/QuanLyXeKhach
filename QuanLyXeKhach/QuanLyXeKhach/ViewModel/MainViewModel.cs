using QuanLyXeKhach.AddWindow;
using QuanLyXeKhach.EditWindow;
using QuanLyXeKhach.Model;
using QuanLyXeKhach.UserControlFolder;
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
        //UserControl
        private UserControl SelectedTagClient = null;
        private UserControl SelectedTagStaff = null;
        private UserControl SelectedTagDriver = null;
        private UserControl SelectedTagBusStation = null;
        private UserControl SelectedTagBus = null;
        private UserControl SelectedTagRoute = null;
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
        //UserControlCommand
        public ICommand SelectTagClient { get; set; }
        public ICommand SelectTagStaff { get; set; }
        public ICommand SelectTagDriver { get; set; }
        public ICommand SelectTagBusStation { get; set; }
        public ICommand SelectTagBus { get; set; }
        public ICommand SelectTagRoute { get; set; }
        public MainViewModel()
        {
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
                foreach ( var client in ListClient)
                {
                    var uc = new TagClientUC();
                    uc.TenHanhKhach.Text = client.TenHanhKhach;
                    uc.IDHanhKhach.Text = client.IDHanhKhach;
                    uc.GioiTinh.Text = client.GioiTinh;
                    uc.Tuoi.Text = client.Tuoi;
                    uc.SDT.Text = client.SDTHK;
                    uc.DiaChi.Text = client.DiaChiHK;
                    uc.SoHieuGhe.Text = client.SoHieuGhe;
                    uc.CCCD.Text = client.CCCD;
                    mainWd.ucContainerClient.Children.Add(uc);
                }
                foreach(var staff in ListStaff)
                {
                    var uc = new TagStaffUC();
                    uc.HoTen.Text = staff.HoTenNhanVien;
                    uc.CCCD.Text = staff.CCCDNV;
                    uc.GioiTinh.Text = staff.GioiTinh;
                    uc.SDT.Text = staff.SoDienThoai;
                    uc.DiaChi.Text = staff.DiaChi;
                    uc.NgaySinh.Text = staff.NgaySinh.Value.ToString("dd/MM/yyyy");
                    mainWd.ucContainerStaff.Children.Add(uc);
                }
                foreach (var driver in ListDriver)
                {
                    var uc = new TagDriverUC();
                    uc.HoTen.Text = driver.TenTaiXe;
                    uc.CCCD.Text = driver.CCCDTX;
                    uc.NgaySinh.Text = driver.NgaySinh.Value.ToString("dd/MM/yyyy");
                    uc.BangLai.Text = driver.BangLai;
                    uc.DiaChi.Text = driver.DiaChi;
                    uc.SDT.Text = driver.SoDienThoai;
                    mainWd.ucContainerDriver.Children.Add(uc);
                }
                foreach (var busstation in ListBusStation)
                {
                    var uc = new TagBusStationUC();
                    uc.TenBenXe.Text = busstation.TenBenXe;
                    uc.ID.Text = busstation.IDBenXe;
                    uc.SDT.Text = busstation.SoDienThoaiBen;
                    uc.DiaChi.Text = busstation.DiaChi;
                    mainWd.ucContainerBusStation.Children.Add(uc);
                }
                foreach(var bus in ListBus)
                {
                    var uc = new TagBusUC();
                    uc.BienSoXe.Text = bus.BienSoXe;
                    uc.LoaiXe.Text = bus.LoaiXe;
                    uc.CCCDTX.Text = bus.CCCDTX;
                    uc.CCCDPX.Text = bus.CCCDNV;
                    uc.SoGhe.Text = bus.SoGhe.ToString();
                    uc.TinhTrang.Text = bus.TinhTrang;
                    mainWd.ucContainerBus.Children.Add(uc);
                }
                foreach(var route in ListRoute)
                {
                    var uc = new TagRouteUC();
                    uc.IDTuyenXe.Text = route.IDTuyenXe;
                    uc.BenXeXP.Text = route.BENXE1.TenBenXe;
                    uc.BenXeDD.Text = route.BENXE.TenBenXe;
                    uc.NgayXP.Text = route.ThoiGianXuatPhat.Value.ToString("dd/MM/yyyy");
                    uc.NgayDD.Text = route.ThoiGianKetThuc.Value.ToString("dd/MM/yyyy");
                    uc.GioXP.Text = route.ThoiGianXuatPhat.Value.ToString("T");
                    uc.GioDD.Text = route.ThoiGianKetThuc.Value.ToString("T");
                    mainWd.ucContainerRoute.Children.Add(uc);
                }
            });
            //Load Data
            ListClient = new ObservableCollection<HANHKHACH>(DataProvider.Ins.db.HANHKHACHes);
            for(int i = 0;i< ListClient.Count; i++)
            {

            }
            ListDriver = new ObservableCollection<TAIXE>(DataProvider.Ins.db.TAIXEs);
            ListStaff = new ObservableCollection<NHANVIEN>(DataProvider.Ins.db.NHANVIENs);
            ListBusStation = new ObservableCollection<BENXE>(DataProvider.Ins.db.BENXEs);
            ListBus = new ObservableCollection<XEKHACH>(DataProvider.Ins.db.XEKHACHes);
            ListRoute = new ObservableCollection<TUYENXE>(DataProvider.Ins.db.TUYENXEs);
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
                    var uc = new TagClientUC();
                    uc.TenHanhKhach.Text = ListClient.Last().TenHanhKhach;
                    uc.IDHanhKhach.Text = ListClient.Last().IDHanhKhach;
                    uc.GioiTinh.Text = ListClient.Last().GioiTinh;
                    uc.Tuoi.Text = ListClient.Last().Tuoi;
                    uc.SDT.Text = ListClient.Last().SDTHK;
                    uc.DiaChi.Text = ListClient.Last().DiaChiHK;
                    uc.SoHieuGhe.Text = ListClient.Last().SoHieuGhe;
                    uc.CCCD.Text = ListClient.Last().CCCD;
                    p.Children.Add(uc);
                }
            });
            EditClientCommand = new RelayCommand<ListView>((p) => {
                if (SelectedTagClient == null)
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
                    var uc = SelectedTagClient as TagClientUC;
                    SelectedItemClient.TenHanhKhach = uc.TenHanhKhach.Text = editVM.New.TenHanhKhach;
                    SelectedItemClient.IDHanhKhach = uc.IDHanhKhach.Text = editVM.New.IDHanhKhach;
                    SelectedItemClient.Tuoi = uc.Tuoi.Text = editVM.New.Tuoi;
                    SelectedItemClient.CCCD = uc.CCCD.Text = editVM.New.CCCD;
                    SelectedItemClient.SDTHK = uc.SDT.Text = editVM.New.SDTHK;
                    SelectedItemClient.SoHieuGhe = uc.SoHieuGhe.Text = editVM.New.SoHieuGhe;
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
                    var uc = new TagStaffUC();
                    uc.HoTen.Text = ListStaff.Last().HoTenNhanVien;
                    uc.CCCD.Text = ListStaff.Last().CCCDNV;
                    uc.GioiTinh.Text = ListStaff.Last().GioiTinh;
                    uc.SDT.Text = ListStaff.Last().SoDienThoai;
                    uc.DiaChi.Text = ListStaff.Last().DiaChi;
                    uc.NgaySinh.Text = ListStaff.Last().NgaySinh.Value.ToString("dd/MM/yyyy");
                    p.Children.Add(uc);
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
                editVM.New = editVM.New2;
                wd.ShowDialog();
                if (editVM.isEdit)
                {
                    var uc = SelectedTagStaff as TagStaffUC;
                    SelectedItemStaff.CCCDNV = uc.CCCD.Text = editVM.New.CCCDNV;
                    SelectedItemStaff.HoTenNhanVien = uc.HoTen.Text = editVM.New.HoTenNhanVien;
                    SelectedItemStaff.GioiTinh = uc.GioiTinh.Text = editVM.New.GioiTinh;
                    SelectedItemStaff.SoDienThoai = uc.SDT.Text = editVM.New.SoDienThoai;
                    SelectedItemStaff.DiaChi = uc.DiaChi.Text = editVM.New.DiaChi;
                    uc.NgaySinh.Text = editVM.New.NgaySinh.Value.ToString("dd/MM/yyyy");
                    SelectedItemStaff.NgaySinh = editVM.New.NgaySinh;

                }
            });
            DeleteStaffCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagStaff == null)
                    return false;
                return true;
            }, (p) => {
                ListStaff.Remove(SelectedItemStaff);
            });
            //Bus
            SelectedItemBus = new XEKHACH();
            AddBusCommand = new RelayCommand<StackPanel>((p) => { return true; }, (p) => {
                AddBusWd wd = new AddBusWd();
                wd.ShowDialog();
                var BusVM = wd.DataContext as AddBusVM;
                if (BusVM.isAdd)
                {
                    ListBus.Add(BusVM.ListNew[BusVM.index - 1]);
                    var uc = new TagBusUC();
                    uc.BienSoXe.Text = ListBus.Last().BienSoXe;
                    uc.LoaiXe.Text = ListBus.Last().LoaiXe;
                    uc.CCCDTX.Text = ListBus.Last().CCCDTX;
                    uc.CCCDPX.Text = ListBus.Last().CCCDNV;
                    uc.SoGhe.Text = ListBus.Last().SoGhe.ToString();
                    uc.TinhTrang.Text = ListBus.Last().TinhTrang;
                    p.Children.Add(uc);
                }
            });
            EditBusCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagBus == null)
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
                    var uc = SelectedTagBus as TagBusUC;
                    SelectedItemBus.BienSoXe = uc.BienSoXe.Text = editVM.New.BienSoXe;
                    SelectedItemBus.LoaiXe = uc.LoaiXe.Text = editVM.New.LoaiXe;
                    SelectedItemBus.CCCDTX = uc.CCCDTX.Text = editVM.New.CCCDTX;
                    SelectedItemBus.CCCDNV = uc.CCCDPX.Text = editVM.New.CCCDNV;
                    uc.SoGhe.Text = editVM.New.SoGhe.ToString();
                    SelectedItemBus.TinhTrang = uc.TinhTrang.Text = editVM.New.TinhTrang;
                    SelectedItemBus.SoGhe = editVM.New.SoGhe;
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
                wd.ShowDialog();
                var RouteVM = wd.DataContext as AddRouteVM;
                if (RouteVM.isAdd)
                {
                    ListRoute.Add(RouteVM.ListNew[RouteVM.index - 1]);
                    var uc = new TagRouteUC();
                    uc.IDTuyenXe.Text = ListRoute.Last().IDTuyenXe;
                    uc.BenXeXP.Text = ListRoute.Last().BENXE1.TenBenXe;
                    uc.BenXeDD.Text = ListRoute.Last().BENXE.TenBenXe;
                    uc.NgayXP.Text = ListRoute.Last().ThoiGianXuatPhat.Value.ToString("dd/MM/yyyy");
                    uc.NgayDD.Text = ListRoute.Last().ThoiGianKetThuc.Value.ToString("dd/MM/yyyy");
                    uc.GioXP.Text = ListRoute.Last().ThoiGianXuatPhat.Value.ToString("T");
                    uc.GioDD.Text = ListRoute.Last().ThoiGianKetThuc.Value.ToString("T");
                    p.Children.Add(uc);
                }
            });
            EditRouteCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagRoute == null)
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
                editVM.GioDD = (DateTime)SelectedItemRoute.ThoiGianKetThuc;
                editVM.New = editVM.New2;
                wd.ShowDialog();
                if (editVM.isEdit)
                {
                    var uc = SelectedTagRoute as TagRouteUC;
                    SelectedItemRoute.IDTuyenXe = uc.IDTuyenXe.Text = editVM.New.IDTuyenXe;
                    uc.BenXeXP.Text = editVM.New.BENXE1.TenBenXe;
                    uc.BenXeDD.Text = editVM.New.BENXE.TenBenXe;
                    uc.NgayXP.Text = editVM.New.ThoiGianXuatPhat.Value.ToString("dd/MM/yyyy");
                    uc.NgayDD.Text = editVM.New.ThoiGianKetThuc.Value.ToString("dd/MM/yyyy");
                    uc.GioXP.Text = editVM.New.ThoiGianXuatPhat.Value.ToString("T");
                    uc.GioDD.Text = editVM.New.ThoiGianKetThuc.Value.ToString("T");
                    SelectedItemRoute.BENXE1 = editVM.New.BENXE1;
                    SelectedItemRoute.BENXE = editVM.New.BENXE;
                    SelectedItemRoute.ThoiGianXuatPhat = editVM.New.ThoiGianXuatPhat;
                    SelectedItemRoute.ThoiGianKetThuc = editVM.New.ThoiGianKetThuc;
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
                    var uc = new TagDriverUC();
                    uc.HoTen.Text = ListDriver.Last().TenTaiXe;
                    uc.CCCD.Text = ListDriver.Last().CCCDTX;
                    uc.NgaySinh.Text = ListDriver.Last().NgaySinh.Value.ToString("dd/MM/yyyy");
                    uc.BangLai.Text = ListDriver.Last().BangLai;
                    uc.DiaChi.Text = ListDriver.Last().DiaChi;
                    uc.SDT.Text = ListDriver.Last().SoDienThoai;
                    p.Children.Add(uc);
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
                editVM.New = editVM.New2;
                wd.ShowDialog();
                if (editVM.isEdit)
                {
                    var uc = SelectedTagDriver as TagDriverUC;
                    SelectedItemDriver.TenTaiXe = uc.HoTen.Text = editVM.New.TenTaiXe;
                    SelectedItemDriver.CCCDTX = uc.CCCD.Text = editVM.New.CCCDTX;
                    uc.NgaySinh.Text = editVM.New.NgaySinh.Value.ToString("dd/MM/yyyy");
                    SelectedItemDriver.DiaChi = uc.DiaChi.Text = editVM.New.DiaChi;
                    SelectedItemDriver.SoDienThoai = uc.SDT.Text = editVM.New.SoDienThoai;
                    SelectedItemDriver.BangLai = uc.BangLai.Text = editVM.New.BangLai;
                    SelectedItemDriver.NgaySinh = editVM.New.NgaySinh;
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
                    var uc = new TagBusStationUC();
                    uc.TenBenXe.Text = ListBusStation.Last().TenBenXe;
                    uc.ID.Text = ListBusStation.Last().IDBenXe;
                    uc.DiaChi.Text = ListBusStation.Last().DiaChi;
                    uc.SDT.Text = ListBusStation.Last().SoDienThoaiBen;
                    p.Children.Add(uc);
                }
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
                    var uc = SelectedTagBusStation as TagBusStationUC;
                    SelectedItemBusStation.TenBenXe = uc.TenBenXe.Text = editVM.New.TenBenXe;
                    SelectedItemBusStation.IDBenXe = uc.ID.Text = editVM.New.IDBenXe;
                    SelectedItemBusStation.DiaChi = uc.DiaChi.Text = editVM.New.DiaChi;
                    SelectedItemBusStation.SoDienThoaiBen = uc.SDT.Text = editVM.New.SoDienThoaiBen;
                }
            });
            DeleteBusStationCommand = new RelayCommand<Object>((p) => {
                if (SelectedItemBusStation == null)
                    return false;
                return true;
            }, (p) => {
                
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
        }
    }
}
