using CryptInfo.Infrastructure.Commands;
using CryptInfo.Models.Assets;
using CryptInfo.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace CryptInfo.ViewModels
{
    internal class AssetsViewModel :Base.BaseViewModel
    {
        public readonly CryptService CryptService;

        private readonly Action<string, AssetData> _action;

        private AssetsCollection _assets;
        public AssetsCollection AssetsCol { get => _assets; 
            set 
            {
                if(!(Set(ref _assets, value))) return;
                _AssetsCollection.Source = value?.Data;
                
                OnPropertyChanged(nameof(AssetsCollection)); 
            } 
        }








        #region Assets filter

        private CollectionViewSource _AssetsCollection = new CollectionViewSource();
        public ICollectionView AssetsCollection => _AssetsCollection?.View;


        private string _assetFilterText;

        public string AssetFilterText
        {
            get => _assetFilterText; set
            {
                if(!Set(ref _assetFilterText, value)) return;
                _AssetsCollection.View.Refresh();

            }
        }


        private void OnAssetFiltered(object sender, FilterEventArgs E)
        {
            if (!(E.Item is AssetData assetData)) return;

            var filterText = _assetFilterText;
            if (string.IsNullOrWhiteSpace(filterText)) return;

            if (assetData.Symbol.Contains(filterText)) return;
            if (assetData.Name.Contains(filterText)) return;

            E.Accepted = false;
        }
        #endregion



        public ICommand AssetDetailsCommand { get; set; }

        private void AssetDetails(object obj) => _action.Invoke("AD", SelectedAsset);

        public AssetData SelectedAsset { get; set; }

        public AssetsViewModel(CryptService cryptService, AssetsCollection assetsCollection, Action<string, AssetData> action)
        {
            AssetDetailsCommand = new LambdaCommand(AssetDetails);

            _action = action;
            CryptService = cryptService;
            AssetsCol = assetsCollection;


            _AssetsCollection.Filter += OnAssetFiltered; 
        }

    }
}
