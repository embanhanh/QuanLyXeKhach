using LiveCharts;
using LiveCharts.Wpf;
using QuanLyXeKhach.AddWindow;
using QuanLyXeKhach.EditWindow;
using QuanLyXeKhach.Model;
using QuanLyXeKhach.UserControlFolder;
using Syncfusion.UI.Xaml.Charts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Security.Cryptography;
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
        //Chart
        bool isSelect;
        public ChartValues<double> _DoanhThu;
        public ChartValues<double> _ChiPhi;
        private List<string> _Lables;
        private ObservableCollection<string> _Years;
        private ObservableCollection<string> _Months;
        private string _year;
        private string _yearz;
        private string _month;
        public ICommand ChangeCharts { get; set; }
        public ICommand ChangeTopMonth { get; set; }
        public ICommand ChangeTopYear { get; set; }
        public List<string> Lables { get => _Lables; set { _Lables = value; OnPropertyChanged(); } }
        public ObservableCollection<string> Years { get => _Years; set { _Years = value; OnPropertyChanged(); } }
        public ObservableCollection<string> Months { get => _Months; set { _Months = value; OnPropertyChanged(); } }
        public string year { get => _year; set { _year = value; OnPropertyChanged(); } }
        public string yearz { get => _yearz; set { _yearz = value; OnPropertyChanged(); } }
        public string month { get => _month; set { _month = value; OnPropertyChanged(); } }
        public ChartValues<double> DoanhThu { get => _DoanhThu; set { _DoanhThu = value; OnPropertyChanged(); } }
        public ChartValues<double> ChiPhi { get => _ChiPhi; set { _ChiPhi = value; OnPropertyChanged(); } }
        //Account
        private string _ErrorMessageOldPassword;
        private string _ErrorMessagePassword;
        private string _pass1;
        private string _pass2;
        private string _oldpass;
        private string _Pass;
        private string _UserName;
        private string _FullName;
        private string _SDT;
        private string _Role;
        private string _HashPass;
        public string Pass { get => _Pass; set { _Pass = value; OnPropertyChanged(); } }
        public string HashPass { get => _HashPass; set { _HashPass = value; OnPropertyChanged(); } }
        public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }
        public string FullName { get => _FullName; set { _FullName = value; OnPropertyChanged(); } }
        public string SDT { get => _SDT; set { _SDT = value; OnPropertyChanged(); } }
        public string Role { get => _Role; set { _Role = value; OnPropertyChanged(); } }
        public string ErrorMessageOldPassword { get => _ErrorMessageOldPassword; set { _ErrorMessageOldPassword = value; OnPropertyChanged(); } }
        public string ErrorMessagePassword { get => _ErrorMessagePassword; set { _ErrorMessagePassword = value; OnPropertyChanged(); } }
        public string Pass1 { get => _pass1; set { _pass1 = value; OnPropertyChanged(); } }
        public string Pass2 { get => _pass2; set { _pass2 = value; OnPropertyChanged(); } }
        public string OldPass { get => _oldpass; set { _oldpass = value; OnPropertyChanged(); } }
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
        private ObservableCollection<TAIXE> _ListDriver;
        private ObservableCollection<NHANVIEN> _ListStaff;
        private ObservableCollection<XEKHACH> _ListBus;
        private ObservableCollection<BENXE> _ListBusStation;
        private ObservableCollection<TUYENXE> _ListRoute;
        private ObservableCollection<TuyenXe> _TopListRoute;
        private ObservableCollection<TuyenXe> _TopListRouteHK;
        private ObservableCollection<LICHTRINH> _ListSchedule;
        private ObservableCollection<THUNGAN> _ListCashier;
        private ObservableCollection<BIENLAI> _ListReceipt;
        private ObservableCollection<GHE> _ListSeat;
        public ObservableCollection<TAIXE> ListDriver { get => _ListDriver; set { _ListDriver = value; OnPropertyChanged(); } }
        public ObservableCollection<NHANVIEN> ListStaff { get => _ListStaff; set { _ListStaff = value; OnPropertyChanged(); } }
        public ObservableCollection<XEKHACH> ListBus { get => _ListBus; set { _ListBus = value; OnPropertyChanged(); } }
        public ObservableCollection<BENXE> ListBusStation { get => _ListBusStation; set { _ListBusStation = value; OnPropertyChanged(); } }
        public ObservableCollection<TUYENXE> ListRoute { get => _ListRoute; set { _ListRoute = value; OnPropertyChanged(); } }
        public ObservableCollection<TuyenXe> TopListRoute { get => _TopListRoute; set { _TopListRoute = value; OnPropertyChanged(); } }
        public ObservableCollection<TuyenXe> TopListRouteHK { get => _TopListRouteHK; set { _TopListRouteHK = value; OnPropertyChanged(); } }
        public ObservableCollection<LICHTRINH> ListSchedule { get => _ListSchedule; set { _ListSchedule = value; OnPropertyChanged(); } }
        public ObservableCollection<THUNGAN> ListCashier { get => _ListCashier; set { _ListCashier = value; OnPropertyChanged(); } }
        public ObservableCollection<BIENLAI> ListReceipt { get => _ListReceipt; set { _ListReceipt = value; OnPropertyChanged(); } }
        public ObservableCollection<GHE> ListSeat { get => _ListSeat; set { _ListSeat = value; OnPropertyChanged(); } }
        //SelectedItem
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
        public ICommand OldPasswordChangedCommand { get; set; }
        public ICommand OldPasswordEmpty { get; set; }
        public ICommand Password1ChangedCommand { get; set; }
        public ICommand Password2ChangedCommand { get; set; }
        public ICommand PasswordEmpty { get; set; }
        public ICommand ConfirmPass { get; set; }
        public ICommand LogoutCommand { get; set; }
        public ICommand AddAccountCommand { get; set; }
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
            TopListRoute = new ObservableCollection<TuyenXe>();
            TopListRouteHK = new ObservableCollection<TuyenXe>();
            Lables = new List<string> { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" };
            Months = new ObservableCollection<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", " 11", "12","Tất cả" };
            DoanhThu = new ChartValues<double> ();
            ChiPhi = new ChartValues<double> ();
            Years = new ObservableCollection<string> ();
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
                if (p == null)
                    return;
                p.Hide();
                LoginWindow lg = new LoginWindow();
                lg.ShowDialog();
                var lgVM = lg.DataContext as LoginViewModel;
                if (lgVM == null)
                    return;
                if (lgVM.isLogin)
                {
                    UserName = lgVM.Username;
                    Pass = lgVM.Password;
                    var tk = DataProvider.Ins.db.UserInfoes.Where(x => x.UserName == UserName).SingleOrDefault();
                    FullName = tk.FullName;
                    Role = tk.Roles;
                    SDT = tk.SDT;
                    for (int i = 0; i < UserName.Length; i++)
                        HashPass += "*";
                    //ShowChart(2023);
                    p.Show();
                }
                else
                    p.Close();
                var mainWd = p as MainWindow;
                //LoadDataClient(mainWd.ucContainerClient);
                LoadDataStaff(mainWd.ucContainerStaff);
                LoadDataDriver(mainWd.ucContainerDriver);
                LoadDataBusStation(mainWd.ucContainerBusStation);
                LoadDataBus(mainWd.ucContainerBus);
                LoadDataRoute(mainWd.ucContainerRoute);
                LoadDataSchedule(mainWd.ucContainerSchedule);
                LoadDataCashier(mainWd.ucContainerCashier);
                LoadDataReceipt(mainWd.ucContainerReceipt);
            });
            LogoutCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                p.Hide();
                LoginWindow lg = new LoginWindow();
                var vm = lg.DataContext as LoginViewModel;
                vm.isLogin = false;
                lg.ShowDialog();
                var lgVM = lg.DataContext as LoginViewModel;
                if (lgVM == null)
                    return;
                if (lgVM.isLogin)
                {
                    UserName = lgVM.Username;
                    Pass = lgVM.Password;
                    var tk = DataProvider.Ins.db.UserInfoes.Where(x => x.UserName == UserName).SingleOrDefault();
                    FullName = tk.FullName;
                    Role = tk.Roles;
                    SDT = tk.SDT;
                    HashPass = "";
                    for (int i = 0; i < UserName.Length; i++)
                        HashPass += "*";
                    p.Show();
                }
                else
                    p.Close();
            });
            //Load Data
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
            foreach (var bl in ListReceipt)
                if (!Years.Contains(bl.NgayMua.Value.Year.ToString()))
                    Years.Add(bl.NgayMua.Value.Year.ToString());
            ListSeat = new ObservableCollection<GHE>(DataProvider.Ins.db.GHEs);
            //Command Button Add, Edit, Delete
            //Charts
            ChangeCharts = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                ShowChart(int.Parse(year));
            });
            ChangeTopMonth = new RelayCommand<Object>((p) => { if (isSelect) return true; return false; }, (p) =>
            {
                if(month != "Tất cả" && isSelect == true)
                {
                    int monthh = int.Parse(month);
                    int yearr = int .Parse(yearz);
                    TopListRoute.Clear();
                    TopListRouteHK.Clear();
                    try
                    {
                        var Groups = (from tuyenxe in DataProvider.Ins.db.LICHTRINHs where tuyenxe.NgayXuatPhat.Value.Month == monthh && tuyenxe.NgayXuatPhat.Value.Year == yearr group tuyenxe by tuyenxe.IDTuyenXe into grouped orderby grouped.Count() descending select new { IDTuyenXe = grouped.Key, CountID = grouped.Count(),}).Take(5);
                        foreach (var gr in Groups)
                            foreach( var tx in ListRoute)
                                if(gr.IDTuyenXe == tx.IDTuyenXe)
                                {
                                    TuyenXe txe = new TuyenXe() { ID = tx.IDTuyenXe, BenDau = tx.BENXE1.TenBenXe,BenCuoi = tx.BENXE.TenBenXe,tgxp=tx.GioXuatPhat.Value.ToString(),tgdk = tx.ThoiGianDuKien.Value.ToString(),count = gr.CountID.ToString() };
                                    TopListRoute.Add(txe);
                                    break;
                                }
                        var GroupsJoin = (from lt in DataProvider.Ins.db.LICHTRINHs join gh in DataProvider.Ins.db.GHEs on lt.IDLICHTRINH equals gh.IDLICHTRINH
                                          where lt.NgayXuatPhat.Value.Month == monthh && lt.NgayXuatPhat.Value.Year == yearr && gh.TINHTRANG == true group new { LICHTRINH = lt,GHE = gh } by lt.IDTuyenXe into grouped 
                                          orderby grouped.Count() descending 
                                          select new { IDTuyenXe = grouped.Key, Count = grouped.Count(),}).Take(5);
                        foreach (var gr in GroupsJoin)
                            foreach (var tx in ListRoute)
                                if (gr.IDTuyenXe == tx.IDTuyenXe)
                                {
                                    TuyenXe txe = new TuyenXe() { ID = tx.IDTuyenXe, BenDau = tx.BENXE1.TenBenXe, BenCuoi = tx.BENXE.TenBenXe, tgxp = tx.GioXuatPhat.Value.ToString(), tgdk = tx.ThoiGianDuKien.Value.ToString(), countGhe = gr.Count.ToString() };
                                    TopListRouteHK.Add(txe);
                                    break;
                                }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (month == "Tất cả" && isSelect == true)
                {
                    int yearr = int.Parse(yearz);
                    TopListRoute.Clear();
                    TopListRouteHK.Clear();
                    try
                    {
                        var Groups = (from tuyenxe in DataProvider.Ins.db.LICHTRINHs where tuyenxe.NgayXuatPhat.Value.Year == yearr group tuyenxe by tuyenxe.IDTuyenXe into grouped orderby grouped.Count() descending select new { IDTuyenXe = grouped.Key, CountID = grouped.Count(), }).Take(5);
                        foreach (var gr in Groups)
                            foreach (var tx in ListRoute)
                                if (gr.IDTuyenXe == tx.IDTuyenXe)
                                {
                                    TuyenXe txe = new TuyenXe() { ID = tx.IDTuyenXe, BenDau = tx.BENXE1.TenBenXe, BenCuoi = tx.BENXE.TenBenXe, tgxp = tx.GioXuatPhat.Value.ToString(), tgdk = tx.ThoiGianDuKien.Value.ToString(), count = gr.CountID.ToString() };
                                    TopListRoute.Add(txe);
                                    break;
                                }
                        var GroupsJoin = (from lt in DataProvider.Ins.db.LICHTRINHs
                                          join gh in DataProvider.Ins.db.GHEs on lt.IDLICHTRINH equals gh.IDLICHTRINH
                                          where lt.NgayXuatPhat.Value.Year == yearr && gh.TINHTRANG == true
                                          group new { LICHTRINH = lt, GHE = gh } by lt.IDTuyenXe into grouped
                                          orderby grouped.Count() descending
                                          select new { IDTuyenXe = grouped.Key, Count = grouped.Count(), }).Take(5);
                        foreach (var gr in GroupsJoin)
                            foreach (var tx in ListRoute)
                                if (gr.IDTuyenXe == tx.IDTuyenXe)
                                {
                                    TuyenXe txe = new TuyenXe() { ID = tx.IDTuyenXe, BenDau = tx.BENXE1.TenBenXe, BenCuoi = tx.BENXE.TenBenXe, tgxp = tx.GioXuatPhat.Value.ToString(), tgdk = tx.ThoiGianDuKien.Value.ToString(), countGhe = gr.Count.ToString() };
                                    TopListRouteHK.Add(txe);
                                    break;
                                }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            });
            ChangeTopYear = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                isSelect = true;
            });
            //Account
            AddAccountCommand = new RelayCommand<StackPanel>((p) => { 
                if(Role=="Quản Lý")
                    return true;
                return false;
            }, (p) => {
                AddAccountWd wd = new AddAccountWd();
                var vm = wd.DataContext as AddAccountVM;
                vm.ListPhuXe = HoTenNV;
                vm.ListTaiXe = HoTenTX;
                vm.ListThuNgan = HoTenTN;
                wd.ShowDialog();
            });
            Password1ChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) =>
            {
                Pass1 = p.Password;
            });
            Password2ChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) =>
            {
                Pass2 = p.Password;
            });
            OldPasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) =>
            {
                OldPass = p.Password;
            });
            ConfirmPass = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                if (OldPass != Pass)
                    ErrorMessageOldPassword = "Mật khẩu không chính xác, vui lòng nhập lại.";
                if (Pass2 != Pass1)
                    ErrorMessagePassword = "Mật khẩu nhập lại không khớp, vui lòng nhập lại.";
                if(Pass1 == Pass2 && OldPass == Pass)
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    string pw = MD5Hash(Base64Encode(Pass1));
                    var x = DataProvider.Ins.db.UserInfoes.Where(k=> k.UserName == UserName).SingleOrDefault();
                    x.UserPassword = pw;
                    DataProvider.Ins.db.SaveChanges();
                    HashPass = pw;
                    var wd = p as MainWindow;
                    wd.OldPass.Password = "";
                    wd.Pass1.Password = "";
                    wd.Pass2.Password = "";
                }
            });
            OldPasswordEmpty = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                ErrorMessageOldPassword = "";
            });
            PasswordEmpty = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                ErrorMessagePassword = "";
            });
            //Staff
            SelectedItemStaff = new NHANVIEN();
            AddStaffCommand = new RelayCommand<StackPanel>((p) => { 
                if(Role == "Quản Lý")
                    return true;
                return false;
            }, (p) => {
                AddStaffWd wd = new AddStaffWd();
                var staffVM = wd.DataContext as AddStaffVM;
                staffVM.ListNew = ListStaff;
                wd.ShowDialog();
                if (staffVM.isAdd)
                {
                    HoTenNV.Add(ListStaff.Last().HoTenNhanVien);
                    LoadDataStaff(p);
                    SelectedTagStaff = null;
                }
            });
            EditStaffCommand = new RelayCommand<Window>((p) => {
                if (SelectedTagStaff != null && Role == "Quản Lý")
                    return true;
                return false;
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
                    DataProvider.Ins.db.SaveChanges();
                    var wd2 = p as MainWindow;
                    LoadDataStaff(wd2.ucContainerStaff);
                    LoadDataBus(wd2.ucContainerBus);
                    LoadDataSchedule(wd2.ucContainerSchedule);
                    LoadDataReceipt(wd2.ucContainerReceipt);
                }
            });
            DeleteStaffCommand = new RelayCommand<Window>((p) => {
                if (SelectedTagStaff != null && Role == "Quản Lý")
                    return true;
                return false;
            }, (p) => {
                int n = ListBus.Count;
                for (int i = 0; i < n; i++)
                    if (ListBus[i].CCCDNV == SelectedItemStaff.CCCDNV)
                    {
                        DeleteXeKhach(ListBus[i]);
                        break;
                    }
                DataProvider.Ins.db.NHANVIENs.Remove(SelectedItemStaff);
                DataProvider.Ins.db.SaveChanges();
                ListStaff.Remove(SelectedItemStaff);
                HoTenNV.Remove(SelectedItemStaff.HoTenNhanVien);
                var wd = p as MainWindow;
                LoadDataStaff(wd.ucContainerStaff);
                SelectedTagStaff = null;
                LoadDataBus(wd.ucContainerBus);
                SelectedTagBus = null;
                LoadDataSchedule(wd.ucContainerSchedule);
                SelectedTagSchedule = null;
                LoadDataReceipt(wd.ucContainerReceipt);
                SelectedTagReceipt = null;

            });
            //Cashier
            SelectedItemCashier = new THUNGAN();
            AddCashierCommand = new RelayCommand<StackPanel>((p) => {
                if (Role == "Quản Lý")
                    return true;
                return false;
            }, (p) => {
                AddCashierWd wd = new AddCashierWd();
                var addVM = wd.DataContext as AddCashierVM;
                addVM.ListNew = ListCashier;
                wd.ShowDialog();
                if (addVM.isAdd)
                {
                    HoTenTN.Add(ListCashier.Last().HoTen);
                    LoadDataCashier(p);
                    SelectedTagCashier = null;
                }
            });
            EditCashierCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagCashier != null && Role == "Quản Lý")
                    return true;
                return false;
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
                    DataProvider.Ins.db.SaveChanges();
                    var wd2 = p as MainWindow;
                    LoadDataCashier(wd2.ucContainerCashier);
                    LoadDataReceipt(wd2.ucContainerReceipt);

                }
            });
            DeleteCashierCommand = new RelayCommand<Window>((p) => {
                if (SelectedTagCashier != null && Role == "Quản Lý")
                    return true;
                return false;
            }, (p) => {
                try
                {
                    int n = ListReceipt.Count;
                    for (int i = 0; i < n; i++)
                        if (ListReceipt[i].ThuNgan == SelectedItemCashier.CCCDTN)
                        {
                            DataProvider.Ins.db.BIENLAIs.Remove(ListReceipt[i]);
                            ListReceipt.RemoveAt(i);
                            i--;
                            n--;
                        }
                    DataProvider.Ins.db.THUNGANs.Remove(SelectedItemCashier);
                    DataProvider.Ins.db.SaveChanges();

                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                ListCashier.Remove(SelectedItemCashier);
                HoTenTN.Remove(SelectedItemCashier.HoTen);
                var wd = p as MainWindow;
                LoadDataCashier(wd.ucContainerCashier);
                LoadDataReceipt(wd.ucContainerReceipt);
            });
            //Bus
            SelectedItemBus = new XEKHACH();
            AddBusCommand = new RelayCommand<StackPanel>((p) => {
                if (Role == "Quản Lý")
                    return true;
                return false;
            }, (p) => {
                AddBusWd wd = new AddBusWd();
                var BusVM = wd.DataContext as AddBusVM;
                BusVM.ListPhuXe = HoTenNV;
                BusVM.ListTaiXe = HoTenTX;
                BusVM.listTX = ListDriver;
                BusVM.listPX = ListStaff;
                BusVM.ListNew = ListBus;
                wd.ShowDialog();
                if (BusVM.isAdd)
                {
                    BienSoXe.Add(ListBus.Last().BienSoXe);
                    LoadDataBus(p);
                    SelectedTagBus = null;
                }
            });
            EditBusCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagBus != null && Role == "Quản Lý")
                    return true;
                return false;
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
                    DataProvider.Ins.db.SaveChanges();
                    var wd2 = p as MainWindow;
                    LoadDataBus(wd2.ucContainerBus);
                    LoadDataSchedule(wd2.ucContainerSchedule);
                    LoadDataReceipt(wd2.ucContainerReceipt);
                }
            });
            DeleteBusCommand = new RelayCommand<Window>((p) => {
                if (SelectedTagBus != null && Role == "Quản Lý")
                    return true;
                return false;
            }, (p) => {
                DeleteXeKhach(SelectedItemBus);
                var wd = p as MainWindow;
                LoadDataBus(wd.ucContainerBus);
                SelectedTagBus = null;
                LoadDataSchedule(wd.ucContainerSchedule);
                SelectedTagSchedule = null;
                LoadDataReceipt(wd.ucContainerReceipt);
                SelectedTagReceipt = null;
            });
            //Route
            SelectedItemRoute = new TUYENXE();
            AddRouteCommand = new RelayCommand<StackPanel>((p) => {
                if (Role == "Quản Lý")
                    return true;
                return false;
            }, (p) => 
            { 
                AddRouteWd wd = new AddRouteWd(); 
                var RouteVM = wd.DataContext as AddRouteVM;
                RouteVM.BenXe = BenXe;
                RouteVM.listBX = ListBusStation;
                RouteVM.ListNew = ListRoute;
                wd.ShowDialog();
                if (RouteVM.isAdd)
                {
                    IDTuyenXe.Add(ListRoute.Last().IDTuyenXe);
                    LoadDataRoute(p);
                    SelectedTagRoute = null;
                }
            });
            EditRouteCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagRoute != null && Role == "Quản Lý")
                    return true;
                return false;
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
                    DataProvider.Ins.db.SaveChanges();
                    var wd2 = p as MainWindow;
                    LoadDataRoute(wd2.ucContainerRoute);
                    LoadDataSchedule(wd2.ucContainerSchedule);
                    LoadDataReceipt(wd2.ucContainerReceipt);


                }
            });
            DeleteRouteCommand = new RelayCommand<Window>((p) => {
                if (SelectedTagRoute != null && Role == "Quản Lý")
                    return true;
                return false;
            }, (p) => {
                DeleteTuyenXe(SelectedItemRoute);
                var wd = p as MainWindow;
                LoadDataRoute(wd.ucContainerRoute);
                SelectedTagRoute = null;
                LoadDataSchedule(wd.ucContainerSchedule);
                SelectedTagSchedule = null;
                LoadDataReceipt(wd.ucContainerReceipt);
                SelectedTagReceipt = null;
            });
            //Driver
            SelectedItemDriver = new TAIXE();
            AddDriverCommand = new RelayCommand<StackPanel>((p) => {
                if (Role == "Quản Lý")
                    return true;
                return false;
            }, (p) => { 
                AddDriverWd wd = new AddDriverWd(); 
                var driverVM = wd.DataContext as AddDriverVM;
                driverVM.ListNew = ListDriver;
                wd.ShowDialog();
                if (driverVM.isAdd)
                {
                    HoTenTX.Add(ListDriver.Last().TenTaiXe);
                    LoadDataDriver(p);
                    SelectedTagDriver = null;
                }
            });
            EditDriverCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagDriver != null && Role == "Quản Lý")
                    return true;
                return false;
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
                    DataProvider.Ins.db.SaveChanges();
                    var wd2 = p as MainWindow;
                    LoadDataDriver(wd2.ucContainerDriver);
                    LoadDataBus(wd2.ucContainerBus);
                    LoadDataSchedule(wd2.ucContainerSchedule);
                    LoadDataReceipt(wd2.ucContainerReceipt);

                }
            });
            DeleteDriverCommand = new RelayCommand<Window>((p) => {
                if (SelectedTagDriver != null && Role == "Quản Lý")
                    return true;
                return false;
            }, (p) => { 
                int n = ListBus.Count;
                for(int i = 0; i < n;i++)
                    if (ListBus[i].CCCDTX == SelectedItemDriver.CCCDTX)
                    {
                        DeleteXeKhach(ListBus[i]);
                        break;
                    }
                DataProvider.Ins.db.TAIXEs.Remove(SelectedItemDriver);
                DataProvider.Ins.db.SaveChanges();
                ListDriver.Remove(SelectedItemDriver);
                HoTenTX.Remove(SelectedItemDriver.TenTaiXe);
                var wd = p as MainWindow;
                LoadDataDriver(wd.ucContainerDriver);
                SelectedTagDriver = null;
                LoadDataBus(wd.ucContainerBus);
                SelectedTagBus = null;
                LoadDataSchedule(wd.ucContainerSchedule);
                SelectedTagSchedule = null;
                LoadDataReceipt(wd.ucContainerReceipt);
                SelectedTagReceipt = null;
            });
            //Bus Station
            SelectedItemBusStation = new BENXE();
            AddBusStationCommand = new RelayCommand<StackPanel>((p) => {
                if (Role == "Quản Lý")
                    return true;
                return false;
            }, (p) => {
                AddBusStationWd wd = new AddBusStationWd();
                var busstationVM = wd.DataContext as AddBusStationVM;
                busstationVM.ListNew = ListBusStation;
                wd.ShowDialog();
                if (busstationVM.isAdd)
                {
                    BenXe.Add(ListBusStation.Last().TenBenXe);
                    LoadDataBusStation(p);
                    SelectedTagBusStation = null;
                }
            });
            EditBusStationCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagBusStation != null && Role == "Quản Lý")
                    return true;
                return false;
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
                    DataProvider.Ins.db.SaveChanges();
                    var wd2 = p as MainWindow;
                    LoadDataBusStation(wd2.ucContainerBusStation);
                    LoadDataRoute(wd2.ucContainerRoute);
                    LoadDataSchedule(wd2.ucContainerSchedule);
                    LoadDataReceipt(wd2.ucContainerReceipt);
                }
            });
            DeleteBusStationCommand = new RelayCommand<Window>((p) => {
                if (SelectedTagBusStation != null && Role == "Quản Lý")
                    return true;
                return false;
            }, (p) => {
                int n = ListRoute.Count;
                for(int i= 0; i < n; i++)
                    if (ListRoute[i].IDBenXeXuatPhat == SelectedItemBusStation.IDBenXe || ListRoute[i].IDBenKetThuc == SelectedItemBusStation.IDBenXe)
                    {
                        DeleteTuyenXe(ListRoute[i]);
                        n--;
                        i--;
                    }
                DataProvider.Ins.db.BENXEs.Remove(SelectedItemBusStation);
                DataProvider.Ins.db.SaveChanges();
                ListBusStation.Remove(SelectedItemBusStation);
                BenXe.Remove(SelectedItemBusStation.TenBenXe);
                var wd = p as MainWindow;
                LoadDataBusStation(wd.ucContainerBusStation);
                SelectedTagBusStation = null;
                LoadDataRoute(wd.ucContainerRoute);
                SelectedTagRoute = null;
                LoadDataSchedule(wd.ucContainerSchedule);
                SelectedTagSchedule = null;
                LoadDataReceipt(wd.ucContainerReceipt);
                SelectedTagReceipt = null;
            });
            //Schedule
            SelectedItemSchedule = new LICHTRINH();
            AddScheduleCommand = new RelayCommand<StackPanel>((p) => {
                if (Role == "Quản Lý")
                    return true;
                return false;
            }, (p) => {
                AddScheduleWd wd = new AddScheduleWd();
                var addVM = wd.DataContext as AddScheduleVM;
                addVM.BienSoXe = BienSoXe;
                addVM.IDTuyenXe = IDTuyenXe;
                addVM.listXK = ListBus;
                addVM.listTX = ListRoute;
                addVM.listG = ListSeat;
                addVM.ListNew = ListSchedule;
                wd.ShowDialog();
                if (addVM.isAdd)
                {
                    IDLichTrinh.Add(ListSchedule.Last().IDLICHTRINH);
                    LoadDataSchedule(p);
                    SelectedTagSchedule = null;
                }
            });
            EditScheduleCommand = new RelayCommand<Object>((p) => {
                if (SelectedTagSchedule != null && Role == "Quản Lý")
                    return true;
                return false;
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
                    DataProvider.Ins.db.SaveChanges();
                    var wd2 = p as MainWindow;
                    LoadDataSchedule(wd2.ucContainerSchedule);
                    LoadDataReceipt(wd2.ucContainerReceipt);
                }
            });
            DeleteScheduleCommand = new RelayCommand<Window>((p) => {
                if (SelectedTagSchedule != null && Role == "Quản Lý")
                    return true;
                return false;
            }, (p) => {
                DeleteLichTrinh(SelectedItemSchedule);
                var wd = p as MainWindow;
                LoadDataSchedule(wd.ucContainerSchedule);
                LoadDataReceipt(wd.ucContainerReceipt);
            });
            //Receipt
            AddReceiptCommand = new RelayCommand<StackPanel>((p) => {
                if (Role == "Quản Lý" || Role == "Thu Ngân")
                    return true;
                return false;
            }, (p) => {
                AddReceiptWd wd = new AddReceiptWd();
                var addVM = wd.DataContext as AddReceiptVM;
                addVM.LThuNgan = HoTenTN;
                addVM.LLichTrinh = IDLichTrinh;
                addVM.listG = ListSeat;
                addVM.listTN = ListCashier;
                addVM.listLT = ListSchedule;
                addVM.ListNew = ListReceipt;
                wd.ShowDialog();
                if (addVM.isAdd)
                {
                    if (!Years.Contains(ListReceipt.Last().NgayMua.Value.Year.ToString()))
                        Years.Add(ListReceipt.Last().NgayMua.Value.Year.ToString());
                    if(year!=null)
                        ShowChart(int.Parse(year));
                    LoadDataReceipt(p);
                    SelectedTagReceipt = null;
                }
            });
            DeleteReceiptCommand = new RelayCommand<Window>((p) => {
                if (SelectedTagReceipt != null && (Role == "Quản Lý" || Role == "Thu Ngân"))
                    return true;
                return false;
            }, (p) => {
                foreach (var gh in ListSeat)
                    if (gh.IDGhe == SelectedItemReceipt.IDGhe)
                        gh.TINHTRANG = false;
                DataProvider.Ins.db.BIENLAIs.Remove(SelectedItemReceipt);
                DataProvider.Ins.db.SaveChanges();
                ListReceipt.Remove(SelectedItemReceipt);
                if(year!=null)
                    ShowChart(int.Parse(year));
                var wd = p as MainWindow;
                LoadDataReceipt(wd.ucContainerReceipt);
                SelectedTagReceipt = null;
            });
            //UserControlCommand
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
                    if (bl.TenHanhKhach.Contains(TenHK)) null1 = 2;
                    if (IDLT == bl.GHE.IDLICHTRINH) null2 = 2;
                    if((null1 == 1 && null2 ==1) || (null1 == 2 && null2 == 1) || (null1 == 1 && null2 == 2)|| (null1 == 2 && null2 == 2))
                    {
                        var uc = new TagReceiptUC();
                        uc.IDBienLai.Text = bl.IDBienLai;
                        uc.SoDienThoai.Text = bl.GHE.IDLICHTRINH;
                        uc.TenHanhKhach.Text = bl.TenHanhKhach;
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
        //private void LoadDataClient(StackPanel sp)
        //{
        //    sp.Children.Clear();
        //    foreach (HANHKHACH hk in ListClient)
        //    {
        //        var uc = new TagClientUC();
        //        uc.TenHanhKhach.Text = hk.TenHanhKhach;
        //        uc.IDHanhKhach.Text = hk.IDHanhKhach;
        //        uc.GioiTinh.Text = hk.GioiTinh;
        //        uc.Tuoi.Text = hk.Tuoi;
        //        uc.SDT.Text = hk.SDTHK;
        //        uc.DiaChi.Text = hk.DiaChiHK;
        //        uc.CCCD.Text = hk.CCCD;
        //        sp.Children.Add(uc);
        //    }
        //}
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
                if (bl.NgayMua < DateTime.Now.AddDays(-3))
                    continue;
                string GiaVe = "";
                double GiaVee = (double)bl.GHE.LICHTRINH?.GiaVe;
                string GiaGoc = bl.GHE.LICHTRINH?.GiaVe.ToString();
                switch (bl.GiamGia)
                {
                    case "TREEM": GiaVe = (GiaVee * 0.5).ToString(); break;
                    case "TET": GiaVe = (GiaVee * 0.85).ToString(); break;
                    case "NGUOIGIA": GiaVe = (GiaVee * 0.6).ToString(); break;
                    case "KHONG": GiaVe = GiaGoc; break;
                    default: GiaVe = GiaGoc; break;
                }
                DateTime ngay = (DateTime)bl.GHE?.LICHTRINH?.NgayXuatPhat;
                DateTime time = ngay.Add((TimeSpan)bl.GHE?.LICHTRINH?.TUYENXE?.GioXuatPhat);
                var uc = new TagReceiptUC();
                uc.ThoiGianXuatPhat.Text = time.ToString();
                uc.BenDau.Text = bl.GHE.LICHTRINH?.TUYENXE?.BENXE1?.TenBenXe;
                uc.BenCuoi.Text = bl.GHE.LICHTRINH?.TUYENXE?.BENXE?.TenBenXe;
                uc.ThoiGianDuKien.Text = bl.GHE.LICHTRINH?.TUYENXE?.ThoiGianDuKien?.ToString();
                uc.IDBienLai.Text = bl.IDBienLai;
                uc.SoDienThoai.Text = bl.SoDienThoaiHK;
                uc.TenHanhKhach.Text = bl.TenHanhKhach;
                uc.IDGhe.Text = bl.IDGhe;
                uc.NgayMua.Text = bl.NgayMua?.ToString("dd/MM/yyyy");
                uc.ThuNgan.Text = bl.THUNGAN1?.HoTen;
                uc.GiaVe.Text = GiaVe;
                uc.MaGiamGia.Text = bl.GiamGia.ToString(); 
                sp.Children.Add(uc);
            }

        }
        private void DeleteLichTrinh(LICHTRINH lt)
        {
            try
            {
                int n = ListReceipt.Count;
                int m = ListSeat.Count;
                for (int i = 0; i < m; i++)
                    if (ListSeat[i].IDLICHTRINH == lt.IDLICHTRINH)
                    {
                        for (int j = 0; j < n; j++)
                            if (ListReceipt[j].IDGhe == ListSeat[i].IDGhe)
                            {
                                DataProvider.Ins.db.BIENLAIs.Remove(ListReceipt[j]);
                                ListReceipt.RemoveAt(j);
                                n--;
                                break;
                            }
                        DataProvider.Ins.db.GHEs.Remove(ListSeat[i]);
                        ListSeat.RemoveAt(i);
                        m--;
                        i--;
                    }
                DataProvider.Ins.db.LICHTRINHs.Remove(lt);
                DataProvider.Ins.db.SaveChanges();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            ListSchedule.Remove(lt);
            IDLichTrinh.Remove(lt.IDLICHTRINH);
        }
        private void DeleteXeKhach(XEKHACH xk)
        {
            try
            {
                int n = ListSchedule.Count;
                for (int i = 0; i < n; i++)
                    if (ListSchedule[i].BienSoXe == xk.BienSoXe)
                    {
                        DeleteLichTrinh(ListSchedule[i]);
                        i--;
                        n--;
                    }
                DataProvider.Ins.db.XEKHACHes.Remove(xk);
                DataProvider.Ins.db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ListBus.Remove(xk);
            BienSoXe.Remove(xk.BienSoXe);
        }
        private void DeleteTuyenXe(TUYENXE tx)
        {
            try
            {
                int n = ListSchedule.Count;
                for (int i = 0; i < n; i++)
                    if (ListSchedule[i].IDTuyenXe == tx.IDTuyenXe)
                    {
                        DeleteLichTrinh(ListSchedule[i]);
                        i--;
                        n--;
                    }
                DataProvider.Ins.db.TUYENXEs.Remove(tx);
                DataProvider.Ins.db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ListRoute.Remove(tx);
            IDTuyenXe.Remove(tx.IDTuyenXe);
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
        private void ShowChart(int year)
        {
            ChiPhi.Clear();
            DoanhThu.Clear();
            double SumSalary = 0;
            foreach(TAIXE tx in ListDriver)
            {
                SumSalary += (double)tx.Luong;
            }
            foreach (NHANVIEN tx in ListStaff)
            {
                SumSalary += (double)tx.Luong;
            }
            foreach (THUNGAN tx in ListCashier)
            {
                SumSalary += (double)tx.Luong;
            }
            for (int i = 1; i <= 12; i++)
            {
                if (year > DateTime.Now.Year) break;
                if (year == DateTime.Now.Year && i > DateTime.Now.Month) break;
                double sum = 0;
                foreach (var rc in ListReceipt)
                    if (rc.NgayMua.Value.Month == i && rc.NgayMua.Value.Year == year)
                    {
                        double GiaVee = (double)rc.GHE.LICHTRINH?.GiaVe;
                        switch (rc.GiamGia)
                        {
                            case "TREEM": GiaVee = (GiaVee * 0.5); break;
                            case "TET": GiaVee = (GiaVee * 0.85); break;
                            case "NGUOIGIA": GiaVee = (GiaVee * 0.6); break;
                            default:  break;
                        }
                        sum += GiaVee;
                    }
                DoanhThu.Add((double)sum);
                if (year == 2023)
                {
                    if (i >= 9) ChiPhi.Add(SumSalary);
                    else ChiPhi.Add(0.0);
                }
                else ChiPhi.Add(SumSalary);
            }
        }
    }
}
