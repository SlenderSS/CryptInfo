using CryptInfo.Infrastructure.Commands;
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


        private string _title = "CryptCurrencyInfo";
        public string Title { get => _title; set => Set(ref _title, value); }




        public CryptService CryptService;
        


        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand MarketsCommand { get; set; }



        private void Home(object obj) => CurrentView = new HomeViewModel(CryptService);
        private void Markets(object obj) => CurrentView = new MarketsViewModel(CryptService);



        public MainWindowViewModel()
        {

            HomeCommand = new LambdaCommand(Home);
            MarketsCommand = new LambdaCommand(Markets);

            CryptService = new CryptService();

            CurrentView = new HomeViewModel(CryptService);
        }
    }
}
