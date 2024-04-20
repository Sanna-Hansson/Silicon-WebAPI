using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class SubscriberEntity
{
    [Required]
    [Key]
    public string Email { get; set; } = null!;


}
