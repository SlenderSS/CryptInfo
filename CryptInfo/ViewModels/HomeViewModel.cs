using CryptInfo.Infrastructure.Commands;
using CryptInfo.Models;
using CryptInfo.Models.Assets;
using CryptInfo.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CryptInfo.ViewModels
{
    internal class HomeViewModel :Base.BaseViewModel
    {

        private CryptService CryptService;


        private ObservableCollection<AssetData> _topCryptocurrency;
        public ObservableCollection<AssetData> TopCryptocurrency { get => _topCryptocurrency; set { Set(ref _topCryptocurrency, value); OnPropertyChanged(); } }

        private GeneralInfo _generalInfo;
        public GeneralInfo GeneralInfo { get => _generalInfo; set { Set(ref _generalInfo, value); OnPropertyChanged(); } }

        public HomeViewModel()
        {

        }

        public HomeViewModel(CryptService cryptService, GeneralInfo generalInfo)
        {

            CryptService = cryptService;
            GeneralInfo = generalInfo;

            TopCryptocurrency = new ObservableCollection<AssetData>(Task.Run(async () =>
            {
                return await CryptService.GetData<AssetsCollection>(CryptService.BASE_URL, "assets", "?limit=10");

            }).Result.Data);


        }
    }
}
