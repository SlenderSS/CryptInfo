using CryptInfo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptInfo.ViewModels
{
    class MarketsViewModel :Base.BaseViewModel
    {
        private CryptService _cryptService;

        public MarketsViewModel(CryptService cryptService)
        {
            _cryptService = cryptService;


        }
    }
}
