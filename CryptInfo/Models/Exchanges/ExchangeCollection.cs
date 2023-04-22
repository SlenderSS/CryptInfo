using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptInfo.Models.Exchanges
{
    internal class ExchangeCollection : ViewModels.Base.BaseViewModel
    {
        [JsonProperty("data")]
        public ObservableCollection<ExchangeData> Data { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}
