using System;

namespace RateProduct
{
    class Program
    {
        public static Shop Myshop = new Shop();
        static void Main(string[] args)
        {
            do
            {
                DisplayMenu();
                int checkpress = Convert.ToInt32(Console.ReadLine());

                if (checkpress==0)
                {
                    break;
                }

                switch (checkpress)
                {
                    case 1:
                        Myshop.AddProduct();
                        break;

                    case 2:
                        delete();
                        break;

                    case 3:
                        Search();
                        break;

                    case 4:
                        Myshop.ShowAll();
                        break;

                    case 5:
                        Myshop.ShowRate();
                        break;

                    case 6:
                        Myshop.Sort();
                        break;

                    default:
                        continue;
                }
            } while (true);
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("press/1: add product");
            Console.WriteLine("press/2: delete product");
            Console.WriteLine("press/3: search product");
            Console.WriteLine("press/4: show all of product");
            Console.WriteLine("press/5: view rate of product");
            Console.WriteLine("press/6: sort products");
            Console.WriteLine("press/0: close");
        }

        public static void delete()
        {
            Console.Write("enter name to delete: ");
            string name = Console.ReadLine();
            Myshop.DeleteProductByName(name);
        }

        public static void Search()
        {
            Console.Write("price from: ");
            double pri1 = Myshop.MustNumber();

            Console.Write("price to: ");
            double pri2 = Myshop.MustNumber();

            Myshop.SearchProduct(pri1,pri2);
        }
    }
}
