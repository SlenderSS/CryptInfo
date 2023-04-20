using CryptInfo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptInfo.ViewModels
{
    internal class MainWindowViewModel : Base.BaseViewModel
    {
        public CryptService CryptService;
        public int MyProperty { get; set; }





        public MainWindowViewModel()
        {
            CryptService = new CryptService();


        }
    }
}
