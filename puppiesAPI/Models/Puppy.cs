using System.Text.Json.Serialization;

public class Puppy
{
    [JsonPropertyName("_id")]
    public string Id { get; set; } = "";
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("birthdate")]
    public string? BirthDate { get; set; }
    
    [JsonPropertyName("breed")]
    public string? Breed { get; set; }
}