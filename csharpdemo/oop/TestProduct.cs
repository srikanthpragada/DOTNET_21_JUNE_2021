using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.oop
{
    class Product
    {
        private String name;
        private int price, qoh;
        private static double taxrate = 7.5;

        public static double GetTaxRate()
        {
            return taxrate;
        }

        // Constructor 
        public Product(String n, int p)
        {
            name = n;
            price = p;
            qoh = 0;
        }
        // Methods 
        public void Print()
        {
            Console.WriteLine($"{name} - {price} - {qoh}");
        }

        public void Purchase(int qty)
        {
            qoh += qty;
        }

        // Readonly property 
        public double NetPrice
        {
            get
            {
                return this.price + this.price * taxrate / 100;
            }
        }

    }
    class TestProduct
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Product.GetTaxRate());

            Product p1 = new Product("PowerBeats Pro", 21500);    // Object 
            p1.Purchase(5);
            p1.Purchase(10);
            p1.Print();
            Console.WriteLine(p1.NetPrice);
        }
    }
}
