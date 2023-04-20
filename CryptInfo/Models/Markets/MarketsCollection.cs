using Newtonsoft.Json;

namespace CryptInfo.Models.Markets
{
    internal class MarketsCollection
    {
        [JsonProperty("data")]
        public MarketData[] Data { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}
