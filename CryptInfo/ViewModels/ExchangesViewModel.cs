using CryptInfo.Models.Assets;
using CryptInfo.Models.Exchanges;
using CryptInfo.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CryptInfo.ViewModels
{
    class ExchangesViewModel :Base.BaseViewModel
    {



        private ObservableCollection<ExchangeData> _exchanges;
        public ObservableCollection<ExchangeData> Exchanges 
        { 
            get => _exchanges; 
            set 
            {

                if (!(Set(ref _exchanges, value))) return;   
                _ExchangesCollection.Source = value;
                OnPropertyChanged(nameof(ExchangesCollection));
            } 
        }



        #region Exchanges filter

        private CollectionViewSource _ExchangesCollection = new CollectionViewSource();
        public ICollectionView ExchangesCollection => _ExchangesCollection?.View;


        private string _exchangeFilterText;

        public string ExchangeFilterText
        {
            get => _exchangeFilterText; set
            {
                if (!Set(ref _exchangeFilterText, value)) return;
                _ExchangesCollection.View.Refresh();

            }
        }


        private void OnExchangesFiltered(object sender, FilterEventArgs E)
        {
            if (!(E.Item is ExchangeData assetData)) return;

            var filterText = _exchangeFilterText;
            if (string.IsNullOrWhiteSpace(filterText)) return;

            if (assetData.ExchangeId.Contains(filterText)) return;
            if (assetData.Name.Contains(filterText)) return;


            if (assetData.ExchangeUrl.Contains(filterText)) return;

            E.Accepted = false;
        }
        #endregion

        public ExchangesViewModel()
        {

        }
        public ExchangesViewModel(ExchangeCollection exchanges)
        {
            Exchanges = exchanges.Data;


            _ExchangesCollection.Filter += OnExchangesFiltered;


        }
    }
}
