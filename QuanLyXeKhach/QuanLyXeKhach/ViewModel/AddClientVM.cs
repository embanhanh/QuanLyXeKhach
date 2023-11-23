using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyXeKhach.ViewModel
{
    public class AddClientVM:BaseViewModel
    {
        public ICommand closeCommand { get; set; }

        public AddClientVM() 
        {
            closeCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                p.Close();
            });
        }
    }
}
