using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShopLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string info = "";
            var myDict = new Dictionary<string, Dictionary<string, double>>();

            while ((info = Console.ReadLine()) != "Revision")
            {
                string[] shopProductPrice = info.Split(", ").ToArray();
                string shop = shopProductPrice[0];
                string product = shopProductPrice[1];
                double price = double.Parse(shopProductPrice[2]);

                if (!myDict.ContainsKey(shop))
                {
                    myDict.Add(shop, new Dictionary<string, double>());
                    myDict[shop].Add(product, price);
                }
                else
                {
                    myDict[shop].Add(product, price);
                }
            }

            foreach (var shop in myDict.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in myDict[shop.Key])
                {
                    Console.Write("Product: ");
                    Console.Write($"{product.Key}, Price: {product.Value}");
                    Console.WriteLine();
                }
            }
        }
    }
}
