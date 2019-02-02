using NLayer.Entities.Concrete;
using NLayer.Entities.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer.DAL.Abstract;
using System.Linq.Expressions;

namespace NLayer.DAL.Concrete.EntityFramework
{
    //veritabanı işlemleri bu katmandan yapılır. (select/update/add/delete vb.)
    public class EfProductDal: EfEntityRepositoryBase<Product,NorthwindContext> ,IProductDal
    {
        
    }
}
