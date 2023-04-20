using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace CryptInfo.Models.Markets
{
    internal class MarketsCollection : ViewModels.Base.BaseViewModel
    {
        [JsonProperty("data")]
        public ObservableCollection<MarketData> Data { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}
