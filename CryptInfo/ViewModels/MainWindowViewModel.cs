using CryptInfo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CryptInfo.ViewModels
{
    internal class MainWindowViewModel : Base.BaseViewModel
    {
        private string _title = "CryptCurrencyInfo";

        public string Title { get => _title; set => Set(ref _title, value); }




        public CryptService CryptService;
        public int MyProperty { get; set; }





        public MainWindowViewModel()
        {
            


            CryptService = new CryptService();


        }
    }
}
