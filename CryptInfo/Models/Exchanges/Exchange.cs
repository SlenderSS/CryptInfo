using Newtonsoft.Json;


namespace CryptInfo.Models.Exchanges
{
    internal class Exchange : ViewModels.Base.BaseViewModel
    {
        [JsonProperty("data")]
        public ExchangeData Data { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}
