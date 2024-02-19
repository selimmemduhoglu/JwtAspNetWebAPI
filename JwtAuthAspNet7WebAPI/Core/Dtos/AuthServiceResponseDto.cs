using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace JwtAuthAspNet7WebAPI.Core.Dtos
{
    public class AuthServiceResponseDto
    {
        public bool IsSucceed { get; set; }
        public string Message { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string RereshToken { get; set; }
    }
}
