using System;

namespace MyTrys3
{
    class Program
    {
        static void Main(string[] args)
        {
            //categoryıd = 1 ==> Elektronik
            //categoryıd = 2 ==> Mobilya
            //categoryıd = 3 ==> Oyuncak
            //categoryıd = 4 ==> Oto Aksesuar

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 1;
            product1.Category = "Elektronik";
            product1.ProductName = "Klavye";
            product1.StockAmount = 1000;
            product1.Price = 499.99;

            Product product2 = new Product();
            product2.Id = 2;
            product2.CategoryId = 2;
            product2.Category = "Mobilya";
            product2.ProductName = "Masa";
            product2.StockAmount = 100;
            product2.Price = 1499.99;

            Product product3 = new Product();
            product3.Id = 3;
            product3.CategoryId = 3;
            product3.Category = "Oyuncak";
            product3.ProductName = "Peluş Ayıcık";
            product3.StockAmount = 350;
            product3.Price = 99.90;

            Product product4 = new Product();
            product4.Id = 4;
            product4.CategoryId = 4;
            product4.Category = "Oto Aksesuar";
            product4.ProductName = "Lastik";
            product4.StockAmount = 60;
            product4.Price = 999.88;

            Product product5 = new Product();
            product5.Id = 5;
            product5.CategoryId = 3;
            product5.Category = "Oyuncak";
            product5.ProductName = "Barbie Oyuncak";
            product5.StockAmount = 1250;
            product5.Price = 199.99;

            Product product6 = new Product();
            product6.Id = 6;
            product6.CategoryId = 4;
            product6.Category = "Oto Aksesuar";       
            product6.ProductName = "Jant";
            product6.StockAmount = 360;
            product6.Price = 500.00;

            Product product7 = new Product();
            product7.Id = 7;
            product7.CategoryId = 2;
            product7.Category = "Mobilya";
            product7.ProductName = "Sandalye";
            product7.StockAmount = 150;
            product7.Price = 250.00;

            Product product8 = new Product();
            product8.Id = 8;
            product8.CategoryId = 1;
            product8.Category = "Elektronik";
            product8.ProductName = "Monitör";
            product8.StockAmount = 50;
            product8.Price = 2999.99;

            ProductManager products = new ProductManager();
            products.Add(product1);
            products.Delete(product2);
            products.Rename(product3);
            products.Update(product4);
            products.Add(product5);
            products.Delete(product6);
            products.Rename(product7);
            products.Update(product8);


            Console.WriteLine("---------ÜRÜNLER---------");

            Product[] productsList = new Product[]
      {
                product1,
                product2,
                product3,
                product4,
                product5,
                product6,
                product7,
                product8
      };

            foreach (var product in productsList)
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("**************************************************************************");
            Product[] products1 = new Product[] {product1,product8 };

            Console.WriteLine("ELEKTRONİK KATEGORİSİ");

            foreach (var product in products1)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("**************************************************************************");
            Product[] products2 = new Product[] { product2, product7 };

            Console.WriteLine("MOBİLYA KATEGORİSİ");

            foreach (var product in products2)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("**************************************************************************");
            Product[] products3 = new Product[] { product3, product5 };

            Console.WriteLine("OYUNCAK KATEGORİSİ");

            foreach (var product in products3)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("**************************************************************************");
            Product[] products4 = new Product[] { product4, product6 };

            Console.WriteLine("OTO AKSESUAR KATEGORİSİ");

            foreach (var product in products4)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
 
}
