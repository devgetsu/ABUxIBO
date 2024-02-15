namespace Online.Marketplace.Entities.DTOs
{
    public class ProductDTO
    {
        public string Product_name { get; set; }
        public decimal Price { get; set; }
        public int Shop_id { get; set; }
        public int Category_id { get; set; }
        public int Customer_id { get; set; }
    }
}
