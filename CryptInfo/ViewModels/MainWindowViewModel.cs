using CryptInfo.Infrastructure.Commands;
using CryptInfo.Models;
using CryptInfo.Models.Assets;
using CryptInfo.Models.Exchanges;
using CryptInfo.Models.Markets;
using CryptInfo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace CryptInfo.ViewModels
{
    internal class MainWindowViewModel : Base.BaseViewModel
    {

        #region Title
        private string _title = "CryptCurrencyInfo";
        public string Title { get => _title; set => Set(ref _title, value); }
        #endregion
        #region Current view
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }
        #endregion



        public readonly CryptService CryptService;


        private GeneralInfo _generalInfo;
        public GeneralInfo GeneralInfo { get => _generalInfo; set { Set(ref _generalInfo, value); OnPropertyChanged(); } }


        private MarketsCollection _markets;
        public MarketsCollection MarketsCol { get => _markets; set { Set(ref _markets, value); OnPropertyChanged(); } }

        private AssetsCollection _assets;
        public AssetsCollection AssetsCol { get => _assets; set { Set(ref _assets, value); OnPropertyChanged(); } }


        private ExchangeCollection _exchanges;
        public ExchangeCollection ExchangesCol { get => _exchanges; set { Set(ref _exchanges, value); OnPropertyChanged(); } }

        #region Commands

        public ICommand HomeCommand { get; set; }
        public ICommand MarketsCommand { get; set; }

        #endregion



        private void Home(object obj) => CurrentView = new HomeViewModel(CryptService, GeneralInfo);
        private void Markets(object obj) => CurrentView = new MarketsViewModel(CryptService);



        public MainWindowViewModel()
        {
            #region Commands
            HomeCommand = new LambdaCommand(Home);
            MarketsCommand = new LambdaCommand(Markets);

            #endregion

            CryptService = new CryptService();
            GeneralInfo = new GeneralInfo();

            Task.Run(async () =>
            {
                AssetsCol = await CryptService.GetData<AssetsCollection>(CryptService.BASE_URL, "assets");
                MarketsCol = await CryptService.GetData<MarketsCollection>(CryptService.BASE_URL, "markets");
                ExchangesCol = await CryptService.GetData<ExchangeCollection>(CryptService.BASE_URL, "exchanges");


                GeneralInfo.Exchanges = (ushort)ExchangesCol.Data.Count;
                GeneralInfo.ExchangeVolume = ExchangesCol.Data.Sum(x => x.VolumeUsd);


                GeneralInfo.Markets = MarketsCol.Data.Count;

                GeneralInfo.Assets = (ushort)AssetsCol.Data.Count();
                GeneralInfo.MarketCapUsd = AssetsCol.Data.Sum(x => x.MarketCapUsd);

                var domAsset = AssetsCol.Data.FirstOrDefault();
                GeneralInfo.DominateCurrency = domAsset.Symbol;
                GeneralInfo.DomIndex = (float)((domAsset.MarketCapUsd / GeneralInfo.MarketCapUsd) * 100);

            }).Wait();



            CurrentView = new HomeViewModel(CryptService, GeneralInfo);
        }
    }
}
