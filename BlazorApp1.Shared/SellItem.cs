namespace BlazorApp1.Shared
{
    using OfficeOpenXml.Attributes;
    using System.ComponentModel;

    public class SellItem
    {
        [EpplusTableColumn(NumberFormat = "yyyy-MM-dd", Header = "销售日期")]
        public DateTime SellDate { get; set; }
        [DisplayName("销售编号")]
        public string? SellCode { get; set; }
        [DisplayName("客户名称")]
        public string? ClientName { get; set; }
        [DisplayName("商品编号")]
        public string? ProductCode { get; set; }
        [DisplayName("商品名称")]
        public string? ProductName { get; set; }
        [DisplayName("商品规格")]
        public string? Specs { get; set; }
        [DisplayName("生产厂家")]
        public string? ProducerName { get; set; }
        [DisplayName("单位")]
        public string? Unit { get; set; }
        [DisplayName("销售数量")]
        public int? Number { get; set; }
        [DisplayName("商品批号")]
        public string? BatchCode { get; set; }
        [EpplusTableColumn(NumberFormat = "yyyy-MM-dd", Header = "有效日期")]
        public DateTime ValidityDate { get; set; }
        [EpplusTableColumn(NumberFormat = "yyyy-MM-dd", Header = "生产日期")]
        public DateTime ProductionDate { get; set; }
        [DisplayName("售价")]
        public decimal? RetailPrice { get; set; }
        [DisplayName("金额")]
        public decimal? TotalPrice { get; set; }
        [DisplayName("摘要")]
        public string? Summary { get; set; }
    }
}
