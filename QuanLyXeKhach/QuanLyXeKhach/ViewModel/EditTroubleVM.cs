using QuanLyXeKhach.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace QuanLyXeKhach.ViewModel
{
    public class EditTroubleVM:BaseViewModel
    {
        public bool isEdit = false;
        private string _NgayXayRa;
        private List<string> _li_TinhTrang;

        public List<string> Li_TinhTrang { get => _li_TinhTrang; set { _li_TinhTrang = value; OnPropertyChanged(); } }
        public string NgayXayRa { get => _NgayXayRa; set { _NgayXayRa = value; OnPropertyChanged(); } }
        private SUCO _new;
        private SUCO _new2;
        public SUCO New { get => _new; set { _new = value; OnPropertyChanged(); } }
        public SUCO New2 { get => _new2; set { _new2 = value; OnPropertyChanged(); } }
        public ICommand editCommand { get; set; }
        public ICommand closeCommand { get; set; }

        public EditTroubleVM()
        {
            New2 = new SUCO();
            Li_TinhTrang = new List<string>() { "Đang sửa chữa", "Đã sửa chữa", "Đã hủy" };
            editCommand = new RelayCommand<Window>((p) => {
                return true;
            }, (p) =>
            {
                isEdit = true;
                p.Close();
            });
            closeCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                isEdit = false;
                p.Close();
            });
        }
    }
}
