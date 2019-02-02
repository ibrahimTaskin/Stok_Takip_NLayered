using NLayer.DAL.Abstract;
using NLayer.DAL.Concrete;
using NLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer.BLL.Abstract;

namespace NLayer.BLL.Concrete
{
    /*işlemlerimizi iş katmanında yaparız.
    Veritabanında gelen listeler/veriler aşağıdaki şartlara uyuyor mu?
    Kuralları bu katmanda belirleriz.*/
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        //dependency injection ile new yapmadan enjekte ediyoruz.
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            //İş kuralları ile ilgili kodlar buraya yazılır.
            return _productDal.GetAll();
        }

        public List<Product> GetProductByCategory(int categoryId)
        {
            return _productDal.GetAll(p=>p.CategoryId==categoryId);
        }

        public List<Product> GetProductByProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public void Update(Product product)
        {
           _productDal.Update(product);
        }
    }
}
