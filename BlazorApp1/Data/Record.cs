using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Data;

public class Record
{
    [Key]
    public required string OperationCode { get; set; }
    public Operation OperationName { get; set; }
    [Column(TypeName = "date")]
    public DateTime OperationDate { get; set; }
    public int OperationNumber { get; set; }
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
    public string? Summary { get; set; }
    public required Item OperationItem { get; set; }
}
