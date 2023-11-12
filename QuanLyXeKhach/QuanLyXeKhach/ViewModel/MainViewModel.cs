using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuanLyXeKhach.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private bool isShow = false;
        public ICommand AddClientCommand { get; set; }
        public ICommand AddStaffCommand { get; set; }
        public ICommand AddBusCommand { get; set; }
        public ICommand AddRouteCommand { get; set; }
        public ICommand AddTicketCommand { get; set; }
        public MainViewModel()
        {
            if (!isShow)
            {
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();
                isShow = true;
            }

            AddClientCommand = new RelayCommand<Object>((p) => { return true; }, (p) => { AddClientWd wd = new AddClientWd(); wd.ShowDialog(); });
            AddStaffCommand = new RelayCommand<Object>((p) => { return true; }, (p) => { AddStaffWd wd = new AddStaffWd(); wd.ShowDialog(); });
            AddBusCommand = new RelayCommand<Object>((p) => { return true; }, (p) => { AddBusWd wd = new AddBusWd(); wd.ShowDialog(); });
            AddRouteCommand = new RelayCommand<Object>((p) => { return true; }, (p) => { AddRouteWd wd = new AddRouteWd(); wd.ShowDialog(); });
            AddTicketCommand = new RelayCommand<Object>((p) => { return true; }, (p) => { AddTicketWd wd = new AddTicketWd(); wd.ShowDialog(); });
        }
    }
}
