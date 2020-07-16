using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

namespace RateProduct
{
    class Shop 
    {
        public List<Rate_Product> products = new List<Rate_Product>();
        public void AddProduct()
        {
            Rate_Product product = new Rate_Product();
            Console.Write("enter name: ");
            product.Name = Console.ReadLine();

            Console.Write("enter desciption: ");
            product.Desciption = Console.ReadLine();

            Console.Write("enter price: ");
            product.Price = SetPrice();

            for (int i=0; i<product.RateList.Length;i++)
            {
                Console.Write($"enter rate {i+1}: ");
                product.RateList[i] = this.SetValueRate();
            }
            product.SetAvg();

            products.Add(product);
        }

        public void DeleteProductByName(string name)
        {
            int indexProduct=products.FindIndex(
                    item=>item.Name==name
                );

            if (indexProduct >= 0)
            {
                products.RemoveAt(indexProduct);
            }

            else
            {
                Console.WriteLine($"not found {name}");
            }
        }

        public void ShowRate()
        {
            foreach (Rate_Product item in products)
            {
                Console.WriteLine($"{item.Name}: {item.AvgRate}");
            }
        }

        public void SearchProduct(double price1,double price2)
        {
            var results = products.FindAll(
                    delegate(Rate_Product product)
                    {
                        return product.Price >= price1 && product.Price <= price2;
                    }
                );
            if (results.Count!=0)
            {
                this.DisplayResults(results);
            }

            else
            {
                Console.WriteLine("not found");
            }
        }

        private void DisplayResults(List<Rate_Product> products)
        {
            foreach (Rate_Product item in products)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void ShowAll()
        {
            foreach (Rate_Product item in products)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public double MustNumber()
        {
            bool isNumeric;
            double n;
            do
            {
                isNumeric = double.TryParse(Console.ReadLine(), out n);
                if (!isNumeric)       
                    Console.WriteLine("not allow");
            } while (isNumeric == false);
            return n;
        }

        public double SetPrice()
        {
            bool checkprice = false;
            double price;
            do
            {
                price = this.MustNumber();
                if (price>0&&price<=100)
                    checkprice = true;
                else
                Console.WriteLine("is number but must from 0 to 100!!!");
            } while (checkprice==false);
            return price;
        }

        public int SetValueRate()
        {
            bool isInterger;
            int n;
            do
            {
                isInterger = int.TryParse(Console.ReadLine(), out n);
                if (!isInterger || n < 1 || n > 5) 
                {
                    Console.WriteLine("not allow!!!/ bettwen 1 to 5:");
                    isInterger = false;
                }
            } while (isInterger == false);
            return n;
        }

        public void Sort()
        {
            products.Sort();
        }
    }
}
