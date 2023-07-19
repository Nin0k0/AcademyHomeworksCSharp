namespace Homework_18;

public class Shop
{
    public int ShopId { get; set; }
    public string Name { get; set; }

    public Shop(int shopId, string name)
    {
        ShopId = shopId;
        Name = name;
    }
}