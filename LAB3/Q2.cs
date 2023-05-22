using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Q2
    {

        class Product
        {
            public string Name { get; set; }
            public double Cost { get; set; }
            public int Quantity { get; set; }

            public override string ToString()
            {
                return $"Name: {Name}, Cost: {Cost}, Quantity: {Quantity}";
            }
        }

        class Program
        {
            //static void Main(string[] args)
            //{
            //    ArrayList products = new ArrayList();


            //    products.Add(new Product { Name = "Product 1", Cost = 10.50, Quantity = 5 });
            //    products.Add(new Product { Name = "Product 2", Cost = 20.25, Quantity = 3 });
            //    products.Add(new Product { Name = "Product 3", Cost = 15.00, Quantity = 8 });
            //    products.Add(new Product { Name = "Product 4", Cost = 5.75, Quantity = 10 });
            //    products.Add(new Product { Name = "Product 5", Cost = 8.99, Quantity = 12 });


            //    foreach (Product product in products)
            //    {
            //        Console.WriteLine(product.ToString());
            //    }
            //}
        }
    }
}




