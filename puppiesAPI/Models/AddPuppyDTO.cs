using System.ComponentModel.DataAnnotations;

public class AddPuppyDTO
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? BirthDate { get; set; }
    [Required]
    public string? Breed { get; set; }
}