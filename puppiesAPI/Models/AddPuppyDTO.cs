using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class AddPuppyDTO
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    [Required]
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [Required]
    [JsonPropertyName("birthdate")]
    public string? BirthDate { get; set; }
    [Required]
    [JsonPropertyName("breed")]
    public string? Breed { get; set; }
}