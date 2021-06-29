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
        public List<Product> MaxPrice(List<Product> listProducts)
        {
            List<Product> Result = new List<Product>();
            Result.Add(listProducts[0]);
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (Result[0].Price < listProducts[i].Price)
                {
                    Result[0]= listProducts[i];
                }
            }
            return Result;
        }
        public List<Product> MinPrice(List<Product> listProducts)
        {
            List<Product> Result = new List<Product>();
            Result.Add(listProducts[0]);
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (Result[0].Price > listProducts[i].Price)
                {
                    Result[0] = listProducts[i];
                }
            }
            return Result;
        }
        public List<Product> MaxCalories(List<Product> listProducts)
        {
            List<Product> Result = new List<Product>();
            Result.Add(listProducts[0]);
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (Result[0].Calories < listProducts[i].Calories)
                {
                    Result[0] = listProducts[i];
                }
            }
            return Result;
        }
        public List<Product> MinCalories(List<Product> listProducts)
        {
            List<Product> Result = new List<Product>();
            Result.Add(listProducts[0]);
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (Result[0].Calories > listProducts[i].Calories)
                {
                    Result[0] = listProducts[i];
                }
            }
            return Result;
        }
        public List<Product> MaxWeight(List<Product> listProducts)
        {
            List<Product> Result = new List<Product>();
            Result.Add(listProducts[0]);
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (Result[0].Weight < listProducts[i].Weight)
                {
                    Result[0] = listProducts[i];
                }
            }
            return Result;
        }
        public List<Product> MinWeight(List<Product> listProducts)
        {
            List<Product> Result = new List<Product>();
            Result.Add(listProducts[0]);
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (Result[0].Weight > listProducts[i].Weight)
                {
                    Result[0] = listProducts[i];
                }
            }
            return Result;
        }
       
    }
}
