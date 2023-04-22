using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptInfo.Models
{
    internal class GeneralInfo : ViewModels.Base.BaseViewModel
    {
        public double? MarketCapUsd { get; set; } 
        public double? ExchangeVolume { get; set; } 
        public ushort Assets { get; set; } 
        public ushort Exchanges { get; set; }
        public int Markets { get; set; } 

        public string DominateCurrency { get; set; } 
        public float  DomIndex { get; set; } 
    }
}
