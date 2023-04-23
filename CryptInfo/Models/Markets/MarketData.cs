using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptInfo.Models.Markets
{
    internal class MarketData : ViewModels.Base.BaseViewModel
    {
        [JsonProperty("exchangeId")]
        public string ExchangeId { get; set; }
       
        [JsonProperty("baseSymbol")]
        public string BaseSymbol { get; set; }
      
        [JsonProperty("baseId")]
        public string BaseId { get; set; }
        
        [JsonProperty("quoteSymbol")]
        public string QuoteSymbol { get; set; }
        
        [JsonProperty("quoteId")]
        public string QuoteId { get; set; }             

        [JsonProperty("priceUsd")]
        public double? PriceUsd { get; set; }

        [JsonProperty("volumeUsd24Hr")]
        public double? VolumeUsd24Hr { get; set; }

        
    }
}
