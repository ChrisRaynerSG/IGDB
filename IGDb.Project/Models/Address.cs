using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IGDb.Project.Models;

[Table("addresses")]
public class Address
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("address_id")]
    public long Id { get; set; }
    
    [Required]
    [Column("address_line_1")]
    public string AddressLine1 { get; set; }
    
    [Required]
    [Column("address_line_2")]
    public string AddressLine2 { get; set; }
    
    [Column("address_line_3")]
    public string AddressLine3 { get; set; }
    
    [Column("city")]
    [Required]
    public string City { get; set; }
    
    [Required]
    [Column("postal_code")]
    public string PostalCode { get; set; }
    
    [Required]
    [Column("country")]
    public string Country { get; set; }
}