using Newtonsoft.Json;

namespace CryptInfo.Models.Assets
{
    internal class AssetsCollection : ViewModels.Base.BaseViewModel
    {
        [JsonProperty("data")]
        public AssetData[] Data { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

    }
}
