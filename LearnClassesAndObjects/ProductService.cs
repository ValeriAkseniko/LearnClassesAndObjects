using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects
{
    class ProductService
    {
        public void Print(List<Product> listProducts)
        {
            for (int i = 0; i < listProducts.Count; i++)
            {
                Console.WriteLine(listProducts[i].GetInfo());
            }
        }
        public void SortByPrice(List<Product> listProducts)
        {
            Product blank;
            for (int i = 0; i < listProducts.Count; i++)
            {
                for (int j = 0; j < listProducts.Count; j++)
                {
                    if (listProducts[i].Price > listProducts[j].Price)
                    {
                        blank = listProducts[i];
                        listProducts[i] = listProducts[j];
                        listProducts[j] = blank;
                    }
                }
            }
        }
        public void SortByWeight(List<Product> listProducts)
        {
            Product blank;
            for (int i = 0; i < listProducts.Count; i++)
            {
                for (int j = 0; j < listProducts.Count; j++)
                {
                    if (listProducts[i].Weight > listProducts[j].Weight)
                    {
                        blank = listProducts[i];
                        listProducts[i] = listProducts[j];
                        listProducts[j] = blank;
                    }
                }
            }
        }
        public void SortByName(List<Product> listProducts)
        {
            Product blank;
            for (int i = 0; i < listProducts.Count; i++)
            {
                for (int j = 0; j < listProducts.Count; j++)
                {
                    if (string.Compare(listProducts[i].Name,listProducts[j].Name)<0)
                    {
                        blank = listProducts[i];
                        listProducts[i] = listProducts[j];
                        listProducts[j] = blank;
                    }
                }
            }
        }
    }
}
