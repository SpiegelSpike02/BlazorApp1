using System.ComponentModel.DataAnnotations;
using BlazorApp1.Data;

namespace BlazorApp1;

public class ProductDetail
{
    [Key]
    public required string Id { get; set; }
    public required string ProductId { get; set; }
    public required Product Product { get; set; }
    public required DateTime ProductionDate { get; set; }
    public required DateTime ValidityDate { get; set; }
    public required string BatchCode { get; set; }
    public List<Sale>? Sales { get; set; }
    public List<Purchase>? Purchases { get; set; }
    public int Number { get; set; }
}
