using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Data;

public class Purchase
{
    public required string Id { get; set; }
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; } 
     public DateOnly Date { get; set; }
    public string? Summary { get; set; }
    public required string ProductDetailId { get; set; }
    public required ProductDetail ProductDetail { get; set; }
    public required string ProviderId { get; set; }
    public required Provider Provider { get; set; }
    public int Number { get; set; }
}
