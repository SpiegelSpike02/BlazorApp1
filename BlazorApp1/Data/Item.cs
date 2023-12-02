using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OfficeOpenXml.Attributes;

namespace BlazorApp1.Data;

public class Item
{
    [DisplayName("商品编码"), Key]
    public required string ProductCode { get; set; }
    [DisplayName("品名")]
    public string? ProductName { get; set; }
    [DisplayName("规格")]
    public string? Specs { get; set; }
    [DisplayName("厂家")]
    public string? ProducerName { get; set; }
    [DisplayName("单位")]
    public string? Unit { get; set; }
    [DisplayName("批号")]
    public string? BatchCode { get; set; }
    [EpplusTableColumn(NumberFormat = "yyyy-MM-dd", Header = "有效日期"), Column(TypeName = "date")]
    public DateTime ValidityDate { get; set; }
    [EpplusTableColumn(NumberFormat = "yyyy-MM-dd", Header = "生产日期"), Column(TypeName = "date")]
    public DateTime ProductionDate { get; set; }
    public int Number { get; set; }
    public List<Record>? Records { get; set; }
}
