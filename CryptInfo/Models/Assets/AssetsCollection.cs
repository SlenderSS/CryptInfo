using Newtonsoft.Json;

namespace CryptInfo.Models.Assets
{
    internal class AssetsCollection
    {
        [JsonProperty("data")]
        public AssetData[] Data { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

    }
}
