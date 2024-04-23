using Newtonsoft.Json;
using RazorPagesPractice.Entities.Entities;
using RazorPagesPractice.Entities.Responses;

namespace RazorPagesPractice.UI.Models
{
    public class TransactionViewModel : Response
    {
        public int AccountId { get; set; }
        [JsonProperty("transactions")]
        public List<TransactionResponseEntity> TransactionResponseEntities { get; set; }
        public string Status { get; set; }
        public string Tref { get; set; }
    }
}