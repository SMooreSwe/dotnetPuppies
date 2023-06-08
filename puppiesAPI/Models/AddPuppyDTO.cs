using System.ComponentModel.DataAnnotations;

public class AddPuppyDTO
{
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? BirthDate { get; set; }
    [Required]
    public string? Breed { get; set; }
}