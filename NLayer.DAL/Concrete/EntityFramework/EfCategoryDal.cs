using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer.DAL.Abstract;
using NLayer.Entities.Concrete;
using NLayer.Entities.Concrete.EntityFramework;

namespace NLayer.DAL.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {
    }
}
