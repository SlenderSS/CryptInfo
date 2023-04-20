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
       
        [JsonProperty("rank")]
        public int? Rank { get; set; }
     
        [JsonProperty("baseSymbol")]
        public string BaseSymbol { get; set; }
      
        [JsonProperty("baseId")]
        public string BaseId { get; set; }
        
        [JsonProperty("quoteSymbol")]
        public string QuoteSymbol { get; set; }
        
        [JsonProperty("quoteId")]
        public string QuoteId { get; set; }
              
        [JsonProperty("priceQuote")]
        public decimal? PriceQuote { get; set; }

        [JsonProperty("priceUsd")]
        public decimal? PriceUsd { get; set; }

        [JsonProperty("volumeUsd24Hr")]
        public double? VolumeUsd24Hr { get; set; }

        [JsonProperty("percentExchangeVolume")]
        public decimal? PercentExchangeVolume { get; set; }

        [JsonProperty("tradesCount24Hr")]
        public int? TradesCount24Hr { get; set; }

        [JsonProperty("updated")]
        public long? Updated { get; set; }
    }
}
