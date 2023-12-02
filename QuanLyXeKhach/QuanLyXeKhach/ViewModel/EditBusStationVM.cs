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
    public class EditBusStationVM : BaseViewModel
    {
        public bool isEdit;
        private BENXE _new;
        public BENXE New { get => _new; set { _new = value; OnPropertyChanged(); } }
        public ICommand closeCommand { get; set; }
        public ICommand editCommand { get; set; }
        public EditBusStationVM()
        {
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
