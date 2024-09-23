using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace IGDb.Project.Models;

[Table("companies")]
public class Company
{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("company_id")]
    public long CompanyId { get; set; }
    
    [Column("name")]
    [Required]
    public string Name { get; set; }
    
    [Column("description")]
    [Required]
    public string Description { get; set; }
    
    [Column("address")]
    [Required]
    [ForeignKey("addresses")]
    public Address Address { get; set; }
    
    [Column("contact_information")]
    [Required]
    [ForeignKey("company_contact_details")]
    public CompanyContactDetails CompanyContactDetails { get; set; }
    
}