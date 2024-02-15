namespace Online.Marketplace.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Product_name { get; set; }
        public decimal Price { get; set; }
        public int Shop_id { get; set; }
        public int Category_id { get; set; }
        public int Customer_id { get; set; }
    }
}
