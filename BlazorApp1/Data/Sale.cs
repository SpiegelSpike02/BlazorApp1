namespace BlazorApp1;

public class Sale
{
    public string? Id { get; set; }
    public decimal Price { get; set; }
    public string? Summary { get; set; }
    public required string ProductDetailId { get; set; }
    public required ProductDetail ProductDetail { get; set; }
    public required string ClientId { get; set; }
    public required Client Client { get; set; }
}
