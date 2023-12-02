using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data;

public class Product
{
    [Key]
    public required string ProductCode { get; set; }
    public required string ProductName { get; set; }
    public string? Specs { get; set; }
    public string? ProducerName { get; set; }
    public string? Unit { get; set; }
}
