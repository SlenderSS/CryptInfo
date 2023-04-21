using CryptInfo.Infrastructure.Commands;
using CryptInfo.Models.Assets;
using CryptInfo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptInfo.ViewModels
{
    internal class HomeViewModel :Base.BaseViewModel
    {

        private CryptService _cryptService;
        public AssetsCollection TopCryptocurrency { get; set; }



        public HomeViewModel()
        {

        }

        public HomeViewModel(CryptService CryptService):this()
        {

            _cryptService = CryptService;

            Task.Run(() =>
            {
                while (true) { 

                }
            })
            
        }
    }
}
