using System.Net;
using System.Text.Json.Serialization;

namespace RazorPagesPractice.Entities.Responses
{
    public class Response
    {
        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
        [JsonIgnore]
        public string Reason { get; set; } = "No information provided";
    }
}
