using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace CryptInfo.Models.Assets
{
    internal class AssetsCollection : ViewModels.Base.BaseViewModel
    {
        [JsonProperty("data")]
        public ObservableCollection<AssetData> Data { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

    }
}
