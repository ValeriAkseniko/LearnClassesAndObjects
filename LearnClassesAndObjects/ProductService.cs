using LearnClassesAndObjects.GlobalInterfaces;
using LearnClassesAndObjects.TypeProduct;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects
{
    public class ProductService : IProductService
    {
        public void Print(List<BaseProduct> listProducts)
        {
            if (listProducts == null)
            {
                return;
            }
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
            var maxPrice = listProducts.Max(p => p.Price);
            var result = listProducts.FirstOrDefault(p => p.Price == maxPrice);
            return result;
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
            var minPrice = listProducts.Min(p => p.Price);
            var result = listProducts.FirstOrDefault(p => p.Price == minPrice);
            return result;
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
            var maxCalories = listProducts.Max(c => c.Calories);
            var result = listProducts.FirstOrDefault(c => c.Calories == maxCalories);
            return result;
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
            var minCalories = listProducts.Min(c => c.Calories);
            var result = listProducts.FirstOrDefault(c => c.Calories == minCalories);
            return result;
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
            var maxWeight = listProducts.Max(w => w.Weight);
            var result = listProducts.FirstOrDefault(w => w.Weight == maxWeight);
            return result;
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
            var minWeight = listProducts.Max(w => w.Weight);
            var result = listProducts.FirstOrDefault(w => w.Weight == minWeight);
            return result;
        }

        public string ConvertToJson(List<BaseProduct> listProducts)
        {
            string json = JsonConvert.SerializeObject(listProducts);
            return json;
        }

        public List<BaseProduct> ConvertFromJson(string strJson)
        {
            List<BaseProduct> Products = JsonConvert.DeserializeObject<List<BaseProduct>>(strJson);
            return Products;
        }

        public void WriteToTxt(string writePath, List<BaseProduct> listProducts)
        {
            string json = ConvertToJson(listProducts);
            using (StreamWriter streamWriter = new StreamWriter(writePath, false, Encoding.Default))
            {
                streamWriter.Write(json);
            }
        }

        public List<BaseProduct> ReadFromTxt(string readPath)
        {
            using (StreamReader streamReader = new StreamReader(readPath))
            {
                List<BaseProduct> persons = new List<BaseProduct>();
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    persons = ConvertFromJson(line);
                }
                return persons;
            }
        }

    }
}
