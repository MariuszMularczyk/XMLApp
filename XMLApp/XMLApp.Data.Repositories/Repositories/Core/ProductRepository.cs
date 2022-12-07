using XMLApp.Domain;
using XMLApp.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLApp.Dictionaries;

namespace XMLApp.Data
{
    public class ProductRepository : Repository<Product, MainDatabaseContext>, IProductRepository
    {
        public ProductRepository(MainDatabaseContext context) : base(context)
        { }

        public List<ProductListDTO> GetAll()
        {
            return Context.Products.Select(x => new ProductListDTO()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Price = x.Price,
                Calories = x.Calories,
            }).ToList();
        }
       

    }
}
