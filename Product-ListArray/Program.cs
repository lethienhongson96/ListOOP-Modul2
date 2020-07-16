using System;
using System.Collections;
using System.Collections.Generic;

namespace Product_ListArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var Products = new List<Product_Demo>();
            var p = new Product_Demo(2, "IPhone 7", 200, "USA");
            Products.Add(p);

            var arrayProducts = new Product_Demo[]
            {
                new Product_Demo(4, "Glaxy 7", 500, "Viet Nam"),
                new Product_Demo(5, "Glaxy 8", 700, "Viet Nam"),
            };
            //add nhieu object
            Products.AddRange(arrayProducts);
            Console.WriteLine(Products[1].ToString("name"));
            //tim vi tri cua object theo ten
            Console.WriteLine(Products[Products.FindIndex(x=>x.Name== "Glaxy 8")]);
            //sap xep theo method mac dinh(theo gia) Sort()
            Products.Sort();
            foreach (Product_Demo product in Products)
            {
                Console.WriteLine(product.ToString("name"));
            }

            Console.WriteLine("---------------------------");
            //sap xep theo cai dat rieng(id)
            Products.Sort(
                (p1, p2) => {
                    if (p1.ID > p2.ID)
                        return 1;
                    else if (p1.ID == p2.ID)
                        return 0;
                    return 0;
                }
            );

            foreach (Product_Demo product in Products)
            {
                Console.WriteLine(product.ToString("name"));
            }
        }
    }
}
