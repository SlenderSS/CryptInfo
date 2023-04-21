using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptInfo.Models.Assets
{
    internal class AssetMarketsCollection : ObservableCollection<AssetMarketsCollection>
    {
        [JsonProperty("data")]
        public ObservableCollection<AssetMarketData>Data { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}
