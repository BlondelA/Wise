using Newtonsoft.Json;

namespace Wize.Models
{
    public class CodeModalitePedagogiqueViewModel
    {
        //TEXT (5,5)
        [JsonProperty(PropertyName = "code-medalite-pedagogique")]
        public string code { get; set; } 
    }
}
