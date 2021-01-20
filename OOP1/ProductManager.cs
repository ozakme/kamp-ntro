using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
           
        }

        public void Uptade(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
       
        
        
        /* public int Topla(int sayi1, int sayi2)
        {//sistemde tutulur daha sonra çarp bölme vs.. kullanılabilir
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1, int sayi2)
        {//sistemde tutulmaz sadece yazılır bırakılır
            Console.WriteLine(sayi1 + sayi2); 
        }*/

    }
}
