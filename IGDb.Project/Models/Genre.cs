using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IGDb.Project.Models;

[Table("genres")]
public class Genre
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required] 
    public string GenreName { get; set; }
    
    [Required] 
    public string GenreDefaultImage { get; set; }
}