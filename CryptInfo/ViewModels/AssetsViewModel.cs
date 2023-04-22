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
    internal class AssetsViewModel :Base.BaseViewModel
    {
        public readonly CryptService CryptService;

        private readonly Action<string, AssetData> _action;

        private AssetsCollection _assets;
        public AssetsCollection AssetsCol { get => _assets; set { Set(ref _assets, value); OnPropertyChanged(); } }



        public ICommand AssetDetailsCommand { get; set; }

        private void AssetDetails(object obj) => _action.Invoke("AD", SelectedAsset);

        public AssetData SelectedAsset { get; set; }

        public AssetsViewModel(CryptService cryptService, AssetsCollection assetsCollection, Action<string, AssetData> action)
        {
            AssetDetailsCommand = new LambdaCommand(AssetDetails);

            _action = action;
            CryptService = cryptService;
            AssetsCol = assetsCollection;



        }

    }
}
