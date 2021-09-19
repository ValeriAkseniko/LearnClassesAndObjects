using LearnClassesAndObjects.Models.Products;
using System.Collections.Generic;

namespace LearnClassesAndObjects.ServiceInterfaces
{
    public interface IProductService
    {
        void Print(List<BaseProduct> listProducts);
        void SortByPrice(List<BaseProduct> listProducts);
        void SortByWeight(List<SolidProduct> listProducts);
        void SortByName(List<BaseProduct> listProducts);
        BaseProduct MaxPrice(List<BaseProduct> listProducts);
        BaseProduct MinPrice(List<BaseProduct> listProducts);
        BaseProduct MaxCalories(List<BaseProduct> listProducts);
        BaseProduct MinCalories(List<BaseProduct> listProducts);
    }
}
