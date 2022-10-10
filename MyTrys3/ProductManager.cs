using System;
using System.Collections.Generic;
using System.Text;

namespace MyTrys3
{
    class ProductManager
    {
        //Ürün ekleme
        public void Add(Product product)
        {
            Console.WriteLine(product.Category + " kategorisindeki " + product.ProductName + " isimli ürün ugulamaya eklendi!!!");
        }
        //Ürün silme
        public void Delete(Product product)
        {
            Console.WriteLine(product.Category + " kategorisindeki " + product.ProductName + " isimli ürün ugulamadan silindi!!!");
        }
        //Ürün değiştirme
        public void Rename(Product product)
        {
            Console.WriteLine(product.Category + " kategorisindeki " + product.ProductName + " isimli ürün değiştirilmiştir!!!");
        }
        //Ürün güncelleme
        public void Update(Product product)
        {
            Console.WriteLine(product.Category + " kategorisindeki " + product.ProductName + " isimli ürün güncellenmiştir!!!");
        }
    }
}
