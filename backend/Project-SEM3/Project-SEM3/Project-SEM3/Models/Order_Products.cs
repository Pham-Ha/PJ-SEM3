namespace Project_SEM3.Models
{
    public class Order_Products
    {
        public int Id { get; set; }
        public int Order_Id { get; set; }
        public string Product_Type { get; set; }
        public int Quantity { get; set; }
        public int Product_Id { get; set; }

    }
}
