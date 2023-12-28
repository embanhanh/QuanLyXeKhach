using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeKhach.ViewModel
{
    public class TuyenXe:BaseViewModel
    {
        private string _ID;
        private string _BenDau;
        private string _BenCuoi;
        private string _tgxp;
        private string _tgdk;
        private string _count;
        private string _countGhe;
        public string ID { get => _ID; set { _ID = value; OnPropertyChanged(); } }
        public string BenDau { get => _BenDau; set { _BenDau = value; OnPropertyChanged(); } }
        public string BenCuoi { get => _BenCuoi; set { _BenCuoi = value; OnPropertyChanged(); } }
        public string tgxp { get => _tgxp; set { _tgxp = value; OnPropertyChanged(); } }
        public string tgdk { get => _tgdk; set { _tgdk = value; OnPropertyChanged(); } }
        public string count { get => _count; set { _count = value; OnPropertyChanged(); } }
        public string countGhe { get => _countGhe; set { _countGhe = value; OnPropertyChanged(); } }
    }
}
