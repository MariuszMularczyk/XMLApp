using XMLApp.Application.Abstraction;
using XMLApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using XMLApp.Data;
using XMLApp.Dictionaries;

namespace XMLApp.Application
{
    public interface IProductService : IService
    {
        void Add(ProductAddVM model);
        List<ProductListDTO> GetProducts();
        ProductEditVM GetProduct(int id);
        void Edit(ProductEditVM model);
        void Delete(int id);
    }
}