using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLApp.Domain;

namespace XMLApp.Application
{
    public class ProductConverter : ConverterBase
    {

        public IEnumerable<Product> FromProductModel(ProductModel model)
        {
            foreach (Food item in model.Foods)
            {
                yield return new Product() 
                {
                    Name = item.Name,
                    Price = item.Price, 
                    Description = item.Description,
                    Calories = item.Calories,
                };
            }
        }

    }
}
