namespace Project_SEM3.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sku { get; set; }
        public decimal Price { get; set; }
        public int type { get; set; }
        public int Medicine_type { get; set; }
        public int Machine_type { get; set; }
        public string Details { get; set; }
        public int Quantity { get; set; }
        public int User_Id { get; set; }
        public int Cat_Id { get; set; }

    }
}
