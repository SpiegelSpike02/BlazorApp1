namespace BlazorApp1;

public class Purchase
{
    public string? Id { get; set; }
    public decimal Price { get; set; }
    public string? Summary { get; set; }
    public required string ProductDetailId { get; set; }
    public required ProductDetail ProductDetail { get; set; }
    public required string ProviderId { get; set; }
    public required Provider Provider { get; set; }
}
