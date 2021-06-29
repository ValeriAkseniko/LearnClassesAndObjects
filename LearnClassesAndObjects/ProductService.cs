using LearnClassesAndObjects.TypeProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects
{
    class ProductService
    {
        public void Print(List<BaseProduct> listProducts)
        {
            for (int i = 0; i < listProducts.Count; i++)
            {
                Console.WriteLine(listProducts[i].GetInfo());
            }
        }
        public void SortByPrice(List<BaseProduct> listProducts)
        {
            if (listProducts == null)
            {
                return;
            }
            BaseProduct blank;
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
        public void SortByWeight(List<SolidProduct> listProducts)
        {
            if (listProducts == null)
            {
                return;
            }
            SolidProduct blank;
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
        public void SortByName(List<BaseProduct> listProducts)
        {
            if (listProducts == null)
            {
                return;
            }
            BaseProduct blank;
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
        public BaseProduct MaxPrice(List<BaseProduct> listProducts)
        {
            if (listProducts == null)
            {
                return null;
            }
            if (listProducts.Count == 0)
            {
                return null;
            }
            BaseProduct Result = listProducts[0];
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (Result.Price < listProducts[i].Price)
                {
                    Result = listProducts[i];
                }
            }
            return Result;
        }
        public BaseProduct MinPrice(List<BaseProduct> listProducts)
        {
            if (listProducts == null)
            {
                return null;
            }
            if (listProducts.Count == 0)
            {
                return null;
            }
            BaseProduct Result = listProducts[0];
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (Result.Price > listProducts[i].Price)
                {
                    Result = listProducts[i];
                }
            }
            return Result;
        }
        public BaseProduct MaxCalories(List<BaseProduct> listProducts)
        {
            if (listProducts == null)
            {
                return null;
            }
            if (listProducts.Count == 0)
            {
                return null;
            }
            BaseProduct Result = listProducts[0];
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (Result.Calories < listProducts[i].Calories)
                {
                    Result = listProducts[i];
                }
            }
            return Result;
        }
        public BaseProduct MinCalories(List<BaseProduct> listProducts)
        {
            if (listProducts == null)
            {
                return null;
            }
            if (listProducts.Count == 0)
            {
                return null;
            }
            BaseProduct Result = listProducts[0];
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (Result.Calories > listProducts[i].Calories)
                {
                    Result = listProducts[i];
                }
            }
            return Result;
        }
        public SolidProduct MaxWeight(List<SolidProduct> listProducts)
        {
            if (listProducts == null)
            {
                return null;
            }
            if (listProducts.Count == 0)
            {
                return null;
            }
            SolidProduct Result = listProducts[0];
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (Result.Weight < listProducts[i].Weight)
                {
                    Result = listProducts[i];
                }
            }
            return Result;
        }
        public SolidProduct MinWeight(List<SolidProduct> listProducts)
        {
            if (listProducts == null)
            {
                return null;
            }
            if (listProducts.Count == 0)
            {
                return null;
            }
            SolidProduct Result = listProducts[0];
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
