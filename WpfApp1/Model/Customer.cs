using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model.Base;

namespace WpfApp1.Model
{
    public class Customer : ModelBase
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("birthDate")]
        public DateTime BirthDate { get; set; } = DateTime.Now;

        [JsonProperty("brithPlace")]
        public string BirthPlace { get; set; }

        [JsonProperty("issueDate")]
        public DateTime IssueDate { get; set; } = DateTime.Now;

        [JsonProperty("expiryDate")]
        public DateTime ExpiryDate { get; set; } = DateTime.Now;

        [JsonProperty("issuePlace")]
        public string IssuePlace { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("checkInDate")]
        public DateTime CheckInDate { get; set; } = DateTime.Now;

        [JsonProperty("checkOutDate")]
        public DateTime? CheckOutDate { get; set; }

        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        [JsonIgnore]
        public string AddressDisplay
            => $"Line 1 : {AddressLine1}{Environment.NewLine}" +
               $"Line 2 :{AddressLine2}{Environment.NewLine}" +
               $"City 2 :{City}{Environment.NewLine}" +
               $"Country:{Country}";

        [JsonIgnore]
        public string IdentityDisplay
            => $"{Identity}{Environment.NewLine}" +
               $"Issue Date : {IssueDate:dd/MM/yyyy}{Environment.NewLine}" +
               $"Expiry Date: {ExpiryDate:dd/MM/yyyy}{Environment.NewLine}" +
               $"Issue Place: {IssuePlace}";

        [JsonIgnore]
        public string CheckInDateDisplay => $"{CheckInDate:dd/MM/yyyy HH:mm:ss}";

        [JsonIgnore]
        public string CheckOutDateDisplay => $"{CheckOutDate:dd/MM/yyyy HH:mm:ss}";

        [JsonIgnore]
        public string BirthDateDisplay => $"{BirthDate:dd/MM/yyyy}";

        [JsonIgnore]
        public string RoomName { get; set; }
    }
}