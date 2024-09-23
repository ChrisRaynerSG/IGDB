using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IGDb.Project.Models;

[Table("company_contact_details")]
public class CompanyContactDetails
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("contact_details_id")]
    public long Id { get; set; }
    
    [Column("phone_number1")]
    public string PhoneNumber1 { get; set; }
    
    [Column("phone_number2")]
    public string PhoneNumber2 { get; set; }
    
    [Column("support_email")]
    [Required]
    public string SupportEmail { get; set; }
    
    [Column("sales_email")]
    public string SalesEmail { get; set; }
    
    
}