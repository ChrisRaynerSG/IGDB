using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IGDb.Project.Models;

[Table("games")]
public class Game
{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("game_id")]
    public long Id { get; set; }
        
    [Required]
    [MaxLength(100)]
    [Column("name")]
    public string Name { get; set; }
        
    [Required]
    [Column("description")]
    public string Description { get; set; }
    
    [Required]
    [ForeignKey("genres")]
    [Column("genre")]
    public Genre Genre { get; set; }
    
    [Column("image")]
    public string Image { get; set; }
    
    [Required]
    [Column("age_rating")]
    public string AgeRating { get; set; }
    
    [Required]
    [ForeignKey("companies")]
    [Column("publisher")]
    public Company Publisher{ get; set; }
    
    [Required]
    [ForeignKey("companies")]
    [Column("developer")]
    public Company Developer { get; set; }
        
        
    [Column("release_date")]
    public DateTime ReleaseDate { get; set; }
        
    [Required]
    [Column("is_published")]
    public bool IsPublished { get; set; }
    
}