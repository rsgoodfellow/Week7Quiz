using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7Quiz
{
    internal class Program
    {
        class Shoppingcart
        {
            List<Shoppingcart> cart = new List<Shoppingcart>();
        }

        class Product
        {
            string ProductID;
            string ProductName;
            double Price;

            Shoppingcart Shoppingcart = new Shoppingcart();

            public void AddProduct(Product product)
            {
                Console.WriteLine("What is the product ID?");
                ProductID = Console.ReadLine();
                Console.WriteLine("What is the products price?");
                Price = Convert.ToDouble(Console.ReadLine());
            }

            public void RemoveProduct(string productID)
            {
                Console.WriteLine("What is the product ID?");
                ProductID = Console.ReadLine();
                RemoveProduct(productID);
            }
            static void Main(string[] args)
            {
                int input = 0;
                while (input != 4)
                {
                    Console.WriteLine("Please select an option: ");
                    Console.WriteLine("1. Add a product to the cart");
                    Console.WriteLine("2. Remove a product from the cart");
                    Console.WriteLine("3. Calculate the total price of the cart");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine();
                    input = Convert.ToInt32(Console.ReadLine());

                    switch (input)
                    {
                        case 1:
                            break;
                        case 2:
                        case 3:
                        case 4:
                            break;
                    }
                }

            }
        }
    }
}
