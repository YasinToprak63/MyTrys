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

            string elektronik = "ELEKTRONİK KATEGORİSİ";
            string mobilya = "MOBİLYA KATEGORİSİ";
            string oyuncak = "OYUNCAK KATEGORİSİ";
            string otoAksesuar = "OTO AKSESUAR KATEGORİSİ";

            Product product1 = new Product()
            {
                Id = 1,
                CategoryId = 1,
                Category = "ELEKTRONİK",
                ProductName = "Klavye",
                StockAmount = 1000,
                Price = 499.99           
            };

            Product product2 = new Product()
            {
                Id = 2,
                CategoryId = 2,
                Category = "MOBİLYA",
                ProductName = "Masa",
                StockAmount = 100,
                Price = 1499.99
            };
           
            Product product3 = new Product() 
            {
                Id = 3,
                CategoryId = 3,
                Category = "OYUNCAK",
                ProductName = "Peluş Ayıcık",
                StockAmount = 350,
                Price = 99.90
            };
          
            Product product4 = new Product() 
            {
                Id = 4,
                CategoryId = 4,
                Category = "OTO AKSESUAR",
                ProductName = "Lastik",
                StockAmount = 60,
                Price = 999.98
            };
           
            Product product5 = new Product() 
            {
                Id = 5,
                CategoryId = 3,
                Category = "OYUNCAK",
                ProductName = "Barbie Oyuncak",
                StockAmount = 1250,
                Price = 1999.99
            };
          
            Product product6 = new Product() 
            {
                Id = 6,
                CategoryId = 4,
                Category = "OTO AKSESUAR",
                ProductName = "Jant",
                StockAmount = 360,
                Price = 500.00
            };
            
            Product product7 = new Product() 
            {
                Id = 7,
                CategoryId = 2,
                Category = "MOBİLYA",
                ProductName = "Sandalye",
                StockAmount = 150,
                Price = 250.00
            };
           
            Product product8 = new Product() 
            {
                Id = 8,
                CategoryId = 1,
                Category = "ELEKTRONİK",
                ProductName = "Monitör",
                StockAmount = 50,
                Price = 2999.99
            };


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

            Console.WriteLine(elektronik);

            foreach (var product in products1)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("**************************************************************************");
            Product[] products2 = new Product[] { product2, product7 };

            Console.WriteLine(mobilya);

            foreach (var product in products2)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("**************************************************************************");
            Product[] products3 = new Product[] { product3, product5 };

            Console.WriteLine(oyuncak);

            foreach (var product in products3)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("**************************************************************************");
            Product[] products4 = new Product[] { product4, product6 };

            Console.WriteLine(otoAksesuar);

            foreach (var product in products4)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
 
}
