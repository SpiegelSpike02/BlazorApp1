namespace BlazorApp1.Shared
{
    using OfficeOpenXml.Attributes;
    using System.ComponentModel;

    public class InventoryItem
    {
        [DisplayName("供应商")]
        public string? ProviderName { get; set; }
        [DisplayName("供应商编码")]
        public string? ProviderCode { get; set; }
        [DisplayName("品名")]
        public string? ProductName { get; set; }
        [DisplayName("商品编号")]
        public string? ProductCode { get; set; }
        [DisplayName("规格")]
        public string? Specs { get; set; }
        [DisplayName("厂家")]
        public string? ProducerName { get; set; }
        [DisplayName("单位")]
        public string? Unit { get; set; }
        [DisplayName("数量")]
        public int? Number { get; set; }
        [DisplayName("批号")]
        public string? BatchCode { get; set; }
        [EpplusTableColumn(NumberFormat = "yyyy-MM-dd", Header = "保质日期")]
        public DateTime ValidityDate { get; set; }
    }
}