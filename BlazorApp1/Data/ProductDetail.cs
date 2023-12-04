using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data;

public class ProductDetail
{
    [Key]
    public required string Id { get; set; }
    public required string ProductId { get; set; }
    public required Product Product { get; set; }
    public required DateOnly ProductionDate { get; set; }
    public required DateOnly ValidityDate { get; set; }
    public List<Sale>? Sales { get; set; }
    public List<Purchase>? Purchases { get; set; }
    public int Number { get; set; }
}
