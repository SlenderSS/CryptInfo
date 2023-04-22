using CryptInfo.Models.Assets;
using CryptInfo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptInfo.ViewModels
{
    internal class AssetsViewModel :Base.BaseViewModel
    {
        public readonly CryptService CryptService;

        private AssetsCollection _assets;
        public AssetsCollection AssetsCol { get => _assets; set { Set(ref _assets, value); OnPropertyChanged(); } }


        public AssetsViewModel(CryptService cryptService, AssetsCollection assetsCollection)
        {
            CryptService = cryptService;
            AssetsCol = assetsCollection;

        }

    }
}
