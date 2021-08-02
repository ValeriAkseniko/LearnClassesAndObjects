using LearnClassesAndObjects.TypeProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects.GlobalInterfaces
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
