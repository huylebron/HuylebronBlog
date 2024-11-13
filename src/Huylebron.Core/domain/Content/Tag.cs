using System . ComponentModel . DataAnnotations ;
using System . ComponentModel . DataAnnotations . Schema ;

namespace Huylebron.Core.domain.Content ;
[Table("Tags")]
public class Tag
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(100)]
    public required string Slug { get; set; }

    [Required]
    [MaxLength(100)]
    public required string Name { get; set; }
}
    
