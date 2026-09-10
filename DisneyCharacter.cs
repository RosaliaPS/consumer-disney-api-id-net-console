using System.Text.Json.Serialization;

namespace ConsumerDisneyIdApi
{
    public class DisneyCharacter
    {
        [JsonPropertyName("_id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; } = "";
    }

    public class DisneyResponse
    {
        [JsonPropertyName("data")]
        public DisneyCharacter? Data { get; set; }
    }
}