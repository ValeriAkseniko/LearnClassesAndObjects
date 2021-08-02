using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnClassesAndObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnClassesAndObjects.GlobalInterfaces;
using LearnClassesAndObjects.TypeProduct;

namespace LearnClassesAndObjects.Tests
{
    [TestClass()]
    public class ProductServiceTests
    {
        [TestMethod("Print")]
        public void PrintTestEmpty()
        {
            IProductService service = new ProductService();
            List<BaseProduct> baseList = new List<BaseProduct>();
            service.Print(baseList);
        }

        [TestMethod("Print")]
        public void PrintTestNull()
        {
            IProductService service = new ProductService();
            service.Print(null);
        }

        [TestMethod("Print")]
        public void PrintTest()
        {
            IProductService service = new ProductService();
            List<BaseProduct> baseList = new List<BaseProduct>();
            BaseProduct baseProduct = new BaseProduct();
            baseList.Add(baseProduct);
            service.Print(baseList);
        }

        [TestMethod("SortByPrice")]
        public void SortByPriceTest()
        {
            IProductService service = new ProductService();
            List<BaseProduct> baseProducts = new List<BaseProduct>();

            BaseProduct product1 = new BaseProduct();
            BaseProduct product2 = new BaseProduct();
            BaseProduct product3 = new BaseProduct();

            product1.Price = 105;
            product2.Price = 106;
            product3.Price = 107;

            baseProducts.Add(product1);
            baseProducts.Add(product2);
            baseProducts.Add(product3);


            service.SortByPrice(baseProducts);

            List<BaseProduct> standart = new List<BaseProduct>();
            standart.Add(product3);
            standart.Add(product2);
            standart.Add(product1);

            for (int i = 0; i < standart.Count; i++)
            {
                Assert.IsTrue(standart[i] == baseProducts[i]);
            }
        }

        [TestMethod("SortByPrice")]
        public void SortByPriceTestEmpty()
        {
            IProductService service = new ProductService();
            List<BaseProduct> baseProducts = new List<BaseProduct>();

            service.SortByPrice(baseProducts);
            
            Assert.IsTrue(baseProducts.Count == 0);
        }

        [TestMethod("SortByPrice")]
        public void SortByPriceTestNull()
        {
            IProductService service = new ProductService();

            service.SortByPrice(null);
        }

        [TestMethod()]
        public void SortByWeightTestNull()
        {
            IProductService service = new ProductService();

            service.SortByWeight(null);
        }

        [TestMethod()]
        public void SortByWeightTestEmpty()
        {
            IProductService service = new ProductService();
            List<SolidProduct> solidProducts = new List<SolidProduct>();
            
            service.SortByWeight(solidProducts);
        }

        [TestMethod()]
        public void SortByWeightTest()
        {
            IProductService service = new ProductService();
            List<SolidProduct> solidProducts = new List<SolidProduct>();

            SolidProduct product1 = new SolidProduct();
            SolidProduct product2 = new SolidProduct();
            SolidProduct product3 = new SolidProduct();

            product1.Weight = 105;
            product2.Weight = 106;
            product3.Weight = 107;

            solidProducts.Add(product1);
            solidProducts.Add(product2);
            solidProducts.Add(product3);


            service.SortByWeight(solidProducts);

            List<SolidProduct> standart = new List<SolidProduct>();
            standart.Add(product3);
            standart.Add(product2);
            standart.Add(product1);

            for (int i = 0; i < standart.Count; i++)
            {
                Assert.IsTrue(standart[i] == solidProducts[i]);
            }
        }

        [TestMethod()]
        public void SortByNameTest()
        {
            IProductService service = new ProductService();
            List<BaseProduct> baseProducts = new List<BaseProduct>();

            BaseProduct product1 = new BaseProduct();
            BaseProduct product2 = new BaseProduct();
            BaseProduct product3 = new BaseProduct();

            product1.Name = "A";
            product1.Name = "B";
            product1.Name = "C";

            baseProducts.Add(product3);
            baseProducts.Add(product2);
            baseProducts.Add(product1);
            
            service.SortByName(baseProducts);

            List<BaseProduct> standart = new List<BaseProduct>();

            baseProducts.Add(product1);
            baseProducts.Add(product2);
            baseProducts.Add(product3);

            for (int i = 0; i < standart.Count; i++)
            {
                Assert.IsTrue(standart[i] == baseProducts[i]);
            }
        }
        
        [TestMethod()]
        public void SortByNameTestEmpty()
        {
            IProductService service = new ProductService();
            List<BaseProduct> baseProducts = new List<BaseProduct>();
            
            service.SortByName(baseProducts);
            
            Assert.IsTrue(baseProducts.Count == 0);
        }
        
        [TestMethod()]
        public void SortByNameTestNull()
        {
            IProductService service = new ProductService();

            service.SortByName(null);

        }

        [TestMethod()]
        public void MaxPriceTestNull()
        {
            IProductService service = new ProductService();

            BaseProduct result = service.MaxPrice(null);
            Assert.IsTrue(result == null);
        }

        [TestMethod()]
        public void MaxPriceTestEmpty()
        {
            IProductService service = new ProductService();
            List<BaseProduct> baseProducts = new List<BaseProduct>();


            BaseProduct result = service.MaxPrice(baseProducts);
            Assert.IsTrue(result == null);
        }

        [TestMethod()]
        public void MaxPriceTest()
        {
            IProductService service = new ProductService();
            List<BaseProduct> baseProducts = new List<BaseProduct>();

            BaseProduct product1 = new BaseProduct();
            BaseProduct product2 = new BaseProduct();

            product1.Price = 100;
            product2.Price = 1;
            
            baseProducts.Add(product1);
            baseProducts.Add(product2);

            BaseProduct result = service.MaxPrice(baseProducts);
            Assert.IsTrue(result == product1);
        }

        [TestMethod()]
        public void MinPriceTestNull()
        {
            IProductService service = new ProductService();

            BaseProduct result = service.MinPrice(null);
            Assert.IsTrue(result == null);
        }

        [TestMethod()]
        public void MinPriceTestEmpty()
        {
            IProductService service = new ProductService();
            List<BaseProduct> baseProducts = new List<BaseProduct>();


            BaseProduct result = service.MinPrice(baseProducts);
            Assert.IsTrue(result == null);
        }

        [TestMethod()]
        public void MinPriceTest()
        {
            IProductService service = new ProductService();
            List<BaseProduct> baseProducts = new List<BaseProduct>();

            BaseProduct product1 = new BaseProduct();
            BaseProduct product2 = new BaseProduct();

            product1.Price = 100;
            product2.Price = 1;

            baseProducts.Add(product1);
            baseProducts.Add(product2);

            BaseProduct result = service.MinPrice(baseProducts);
            Assert.IsTrue(result == product2);
        }

        [TestMethod()]
        public void MaxCaloriesTest()
        {
            IProductService service = new ProductService();
            List<BaseProduct> baseProducts = new List<BaseProduct>();

            BaseProduct product1 = new BaseProduct();
            BaseProduct product2 = new BaseProduct();

            product1.Calories = 100;
            product2.Calories = 1;

            baseProducts.Add(product1);
            baseProducts.Add(product2);

            BaseProduct result = service.MaxCalories(baseProducts);
            Assert.IsTrue(result == product1);
        }
    

        [TestMethod()]
        public void MinCaloriesTest()
        {
            IProductService service = new ProductService();
            List<BaseProduct> baseProducts = new List<BaseProduct>();

            BaseProduct product1 = new BaseProduct();
            BaseProduct product2 = new BaseProduct();

            product1.Calories = 100;
            product2.Calories = 1;

            baseProducts.Add(product1);
            baseProducts.Add(product2);

            BaseProduct result = service.MinCalories(baseProducts);
            Assert.IsTrue(result == product2);
        }

    }
}