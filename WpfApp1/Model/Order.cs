using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WpfApp1.Model.Base;

namespace WpfApp1.Model
{
    public class Order : ModelBase
    {
        [JsonProperty("orderLineIds")]
        public List<String> OrderLineIds { get; set; }

        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        [JsonProperty("roomId")]
        public string RoomId { get; set; }

        [JsonIgnore]
        public double Total { get; set; }
    }
}