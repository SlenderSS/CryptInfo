using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptInfo.Models.Assets
{
    class AssetMarkets
    {
        [JsonProperty("data")]
        public AssetMarketData[] Data { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}
