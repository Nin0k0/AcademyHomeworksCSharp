 namespace Homework_18;
 public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ShopId { get; set; }

        public Product(int id, string name, double price, int shopId)
            {
                Id = id;
                Name = name;
                Price = price;
                ShopId = shopId;
            }
}

