using Newtonsoft.Json;
using System;

namespace CryptInfo.Models.Assets
{
    internal class AssetHistoryData
    {
        [JsonProperty("priceUsd")]
        public string PriceUsd { get; set; }

        /// <summary>
        /// Timestamp in UNIX milliseconds.
        /// </summary>
        [JsonProperty("time")]
        public long? Time { get; set; }

        /// <summary>
        /// The available supply for trading.
        /// </summary>
        [JsonProperty("circulatingSupply")]
        public string CirculatingSupply { get; set; }

        /// <summary>
        /// The date.
        /// </summary>
        [JsonProperty("date")]
        public DateTimeOffset? Date { get; set; }
    }
}