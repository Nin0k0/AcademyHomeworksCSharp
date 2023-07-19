using System.Globalization;
using Homework_18;
var rnd = new Random();
var shops = new List<Shop>()
{
    new Shop(1,"LARIANEBI"),
    new Shop(2,"ORIANEBI"),
    new Shop(3, "FANCY MALL"),
    new Shop(4, "THRIFT SHOP"),
    new Shop(5,"MARKET")
};

var products = new List<Product>()
{
   
    new Product(6,"TROUSERS",rnd.Next(400),1),
    new Product(7,"GLASSES",rnd.Next(1000),2),
    new Product(8,"SULGUNI",rnd.Next(10),3),
    new Product(9,"COCA-COLA",rnd.Next(10),385),
    new Product(10,"PEPSI",rnd.Next(10),5),
    new Product(11,"FANTA",rnd.Next(10),1),
    new Product(12,"COOKIES",rnd.Next(10),2),
    new Product(13,"SOCKS",rnd.Next(10),3),
    new Product(14,"BEER",99.99,4),
    new Product(15,"WINE",rnd.Next(10),5),


    new Product(16,"NOODLES",rnd.Next(40),1),
    new Product(17,"WATCH",rnd.Next(1000),2),

    new Product(193,"SOCKS",rnd.Next(10),3),
    new Product(114,"BEER",99.99,7),
    new Product(167,"WINE",rnd.Next(10),9),


    new Product(146,"NOODLES",rnd.Next(40),1),
    new Product(177,"WATCH",rnd.Next(1000),2)
};


var productsTwo = new List<Product>()
{
    new Product(1, "CHEESE", rnd.Next(100), 1),
    new Product(2, "CAR TOY", rnd.Next(1000), 2),
    new Product(3, "BREAD", rnd.Next(5), 3),
    new Product(4, "KHINKALI", rnd.Next(20), 4),
    new Product(5, "T-SHIRT", rnd.Next(100), 5),
};


//foreach (var prod in products)
//{
//    Console.WriteLine($"{prod.Name} - {prod.Price}");
//}


#region UNION

var all = products.Union(productsTwo).ToList();

//foreach (var product in all)
//{
//    Console.WriteLine($"{product.Name} - {product.Price}");
//}

var all2 = (from prod in products
        select prod)
    .Union(from prod in productsTwo
        select prod)
    .ToList();
//Console.WriteLine();
//foreach (var prod in all2)
//{
//    Console.WriteLine($"{prod.Name} - {prod.Price}");
//}
#endregion




#region JOIN

var innerJoin = products.Join(shops,
    prod => prod.ShopId ,
    shop => shop.ShopId,
    (prod, shop) => new
    {
        ShopName = shop.Name,
        ProductName = prod.Name

    });

var queryInnerJoin = from prod in products

                                    join shop in shops
                                    on prod.ShopId equals shop.ShopId
                                    select new
                                    {
                                        ShopName = shop.Name,
                                        ProductName = prod.Name

                                    };

//foreach (var item in innerJoin)
//{
//    Console.WriteLine($"{item.ProductName} is in {item.ShopName}");
//}

//foreach (var item in queryInnerJoin)
//{
//    Console.WriteLine($"{item.ProductName} is in {item.ShopName}");
//}
#endregion


#region GROUP JOIN

var groupJoin = shops.GroupJoin(products, 
    shop => shop.ShopId, 
    prod => prod.ShopId,     
    (shop, prods) => new 
    {
        shopName = shop.Name,
         prods
    });

//foreach (var item in groupJoin)
//{
//    Console.WriteLine($"{item.shopName}");
//    Console.WriteLine();
//    foreach (var itemProd in item.prods)
//    {
//        Console.WriteLine($"      {itemProd.Name}");
//    }
//}
#endregion


#region GROUP BY

var groupByShopIds =
    from prod in products
    group prod by prod.ShopId into newItem
    orderby newItem.Key
    select newItem;

//newItem იქნება IGrouping<int,Product> ტიპის;


//foreach (var item in groupByShopIds)
//{
//    Console.WriteLine(item.Key);
//    foreach (var itemProd in item)
//    {
//        Console.WriteLine($"      {itemProd.Name}");
//    }
//}
#endregion


#region GROUP BY Multiple Property

var groupedByMultiple =
    from prod
        in products
    group prod by new
    {
        prod.Name,
        prod.Price
    } into groupedNewItem
    select groupedNewItem;


//foreach (var item in groupedByMultiple)
//{
//    Console.WriteLine(item.Key.Name);
//    Console.WriteLine(item.Key.Price);
//    foreach (var prod in item)
//    {
//        Console.WriteLine($"                     {prod.ShopId}");
//    }
//}
#endregion



#region GROUPBY MUltiple + aggregatemethod

var groupedByMultiplWithAggregate =
    from prod
        in products
    group prod by new
    {
        prod.Name,
        prod.Price
    } into groupedNewItem
    select new
    {
     groupedNewItem.Key,
     CountItems = groupedNewItem.Count(x=> x.Price == groupedNewItem.Key.Price)

    };


//ლუდს ჰარდად გავუწერე და იმუშავა ქაუნთი ორი წამომიღო 

//foreach (var item in groupedByMultiplWithAggregate)
//{
//    Console.WriteLine(item.Key.Name);
//    Console.WriteLine(item.Key.Price);

//    Console.WriteLine($"            {item.CountItems}");


//}

#endregion