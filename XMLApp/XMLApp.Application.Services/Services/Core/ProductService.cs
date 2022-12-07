using XMLApp.Application.Abstraction;
using XMLApp.Data;
using XMLApp.Dictionaries;
using XMLApp.Domain;
using XMLApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Xml.Serialization;

namespace XMLApp.Application
{
    public class ProductService : ServiceBase, IProductService
    {

        public IProductRepository _productRepository { get; set; }
        public ProductConverter ProductConverter { get; set; }

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public virtual void Add(ProductAddVM model)
        {

            var serializer = new XmlSerializer(typeof(ProductModel));
            using (var stream = model.File.OpenReadStream())
            {
                var obj = (ProductModel)serializer.Deserialize(stream);
                _productRepository.AddRange(ProductConverter.FromProductModel(obj).ToList());
                _productRepository.Save();
            }
        }
        public virtual List<ProductListDTO>GetProducts()
        {
            return _productRepository.GetAll();
        }

        public virtual ProductEditVM GetProduct(int id) {

            Product product = _productRepository.GetSingle(x => x.Id == id);
            ProductEditVM model = new ProductEditVM()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Calories = product.Calories
            };
            return model;
        }
        public virtual void Edit(ProductEditVM model)
        {
            Product product = _productRepository.GetSingle(x => x.Id == model.Id);

            product.Name = model.Name;
            product.Description = model.Description;
            product.Price = model.Price;
            product.Calories = model.Calories;


            _productRepository.Edit(product);
            _productRepository.Save();
        }

        public virtual void Delete(int id)
        {
            Product product = _productRepository.GetSingle(x => x.Id == id);
            _productRepository.Delete(product);
            _productRepository.Save();
        }
 

    }
}
