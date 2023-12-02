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
        private List<string> Bus_BenXe = new List<string>();
        //List
        private ObservableCollection<HANHKHACH> _ListClient;
        private ObservableCollection<TAIXE> _ListDriver;
        private ObservableCollection<NHANVIEN> _ListStaff;
        private ObservableCollection<XEKHACH> _ListBus;
        private ObservableCollection<BENXE> _ListBusStation;
        public ObservableCollection<HANHKHACH> ListClient { get =>_ListClient;set { _ListClient = value; OnPropertyChanged(); } }
        public ObservableCollection<TAIXE> ListDriver { get => _ListDriver; set { _ListDriver = value; OnPropertyChanged(); } }
        public ObservableCollection<NHANVIEN> ListStaff { get => _ListStaff; set { _ListStaff = value; OnPropertyChanged(); } }
        public ObservableCollection<XEKHACH> ListBus { get => _ListBus; set { _ListBus = value; OnPropertyChanged(); } }
        public ObservableCollection<BENXE> ListBusStation { get => _ListBusStation; set { _ListBusStation = value; OnPropertyChanged(); } }
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
        public TAIXE SelectedItemDriver { get => _SelectedItemDriver; set { _SelectedItemDriver = value; /*OnPropertyChanged();*/ } }
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
            //Command Button Add, Edit, Delete
            //Client
            AddClientCommand = new RelayCommand<Object>((p) => { return true; }, (p) => { 
                AddClientWd wd = new AddClientWd(); 
                wd.ShowDialog();
                var clientVM = wd.DataContext as AddClientVM;
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
                editVM.New = SelectedItemClient;
                wd.ShowDialog();
                if(editVM.isEdit)
                {
                    int index = ListClient.IndexOf(SelectedItemClient);
                    ListClient.RemoveAt(index);
                    ListClient.Insert(index, editVM.New);
                    SelectedItemClient = editVM.New;
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
                editVM.New = SelectedItemStaff;
                wd.ShowDialog();
                if (editVM.isEdit)
                {
                    int index = ListStaff.IndexOf(SelectedItemStaff);
                    ListStaff.RemoveAt(index);
                    ListStaff.Insert(index, editVM.New);
                    SelectedItemStaff = editVM.New;
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
                var _BX = DataProvider.Ins.db.BENXEs.ToList();
                var _TX = DataProvider.Ins.db.TUYENXEs.ToList();
                bool isOk = false;
                foreach(BENXE bx in _BX)
                {
                    foreach(TUYENXE tx in _TX)
                    {
                        if (BusVM.ListNew[BusVM.index - 1].IDTuyenXe == tx.IDTuyenXe && tx.IDBenXeXuatPhat == bx.IDBenXe)
                        {
                            Bus_BenXe.Add(bx.TenBenXe);
                            isOk = true;
                            break;
                        }
                    }
                    if (isOk) break;
                }
            });
            EditBusCommand = new RelayCommand<Object>((p) => {
                if (SelectedItemBus == null)
                    return false;
                return true;
            }, (p) => {
                EditBusWd wd = new EditBusWd();
                var editVM = wd.DataContext as EditBusVM;
                editVM.New = SelectedItemBus;
                wd.ShowDialog();
                if (editVM.isEdit)
                {
                    int index = ListBus.IndexOf(SelectedItemBus);
                    ListBus.RemoveAt(index);
                    ListBus.Insert(index, editVM.New);
                    //Bus_BenXe.RemoveAt(index);
                    SelectedItemBus = editVM.New;
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
            AddRouteCommand = new RelayCommand<Object>((p) => { return true; }, (p) => { AddRouteWd wd = new AddRouteWd(); wd.ShowDialog(); });
            EditRouteCommand = new RelayCommand<Object>((p) => {
                if (SelectedItemRoute == null)
                    return false;
                return true;
            }, (p) => { });
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
                editVM.New = SelectedItemDriver;
                wd.ShowDialog();
                if (editVM.isEdit)
                {
                    int index = ListDriver.IndexOf(SelectedItemDriver);
                    ListDriver.RemoveAt(index);
                    ListDriver.Insert(index, editVM.New);
                    MessageBox.Show(SelectedItemDriver.SoDienThoai);
                    SelectedItemDriver = editVM.New;
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
                editVM.New = SelectedItemBusStation;
                wd.ShowDialog();
                if (editVM.isEdit)
                {
                    int index = ListBusStation.IndexOf(SelectedItemBusStation);
                    ListBusStation.RemoveAt(index);
                    ListBusStation.Insert(index, editVM.New);
                    SelectedItemBusStation = editVM.New;
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
