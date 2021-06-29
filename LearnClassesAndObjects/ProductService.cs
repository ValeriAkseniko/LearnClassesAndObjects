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
                    if (string.Compare(listProducts[i].Name, listProducts[j].Name) < 0)
                    {
                        blank = listProducts[i];
                        listProducts[i] = listProducts[j];
                        listProducts[j] = blank;
                    }
                }
            }
        }
        public Product MaxPrice(List<Product> listProducts)
        {
            if (listProducts == null)
            {
                return null;
            }
            if (listProducts.Count == 0)
            {
                return null;
            }
            Product Result = listProducts[0];
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (Result.Price < listProducts[i].Price)
                {
                    Result = listProducts[i];
                }
            }
            return Result;
        }
        public Product MinPrice(List<Product> listProducts)
        {
            if (listProducts == null)
            {
                return null;
            }
            if (listProducts.Count == 0)
            {
                return null;
            }
            Product Result = listProducts[0];
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (Result.Price > listProducts[i].Price)
                {
                    Result = listProducts[i];
                }
            }
            return Result;
        }
        public Product MaxCalories(List<Product> listProducts)
        {
            if (listProducts == null)
            {
                return null;
            }
            if (listProducts.Count == 0)
            {
                return null;
            }
            Product Result = listProducts[0];
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (Result.Calories < listProducts[i].Calories)
                {
                    Result = listProducts[i];
                }
            }
            return Result;
        }
        public Product MinCalories(List<Product> listProducts)
        {
            if (listProducts == null)
            {
                return null;
            }
            if (listProducts.Count == 0)
            {
                return null;
            }
            Product Result = listProducts[0];
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (Result.Calories > listProducts[i].Calories)
                {
                    Result = listProducts[i];
                }
            }
            return Result;
        }
        public Product MaxWeight(List<Product> listProducts)
        {
            if (listProducts == null)
            {
                return null;
            }
            if (listProducts.Count == 0)
            {
                return null;
            }
            Product Result = listProducts[0];
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (Result.Weight < listProducts[i].Weight)
                {
                    Result = listProducts[i];
                }
            }
            return Result;
        }
        public Product MinWeight(List<Product> listProducts)
        {
            if (listProducts == null)
            {
                return null;
            }
            if (listProducts.Count == 0)
            {
                return null;
            }
            Product Result = listProducts[0];
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (Result.Weight > listProducts[i].Weight)
                {
                    Result = listProducts[i];
                }
            }
            return Result;
        }
       
    }
}
