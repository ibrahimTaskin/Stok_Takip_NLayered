using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NLayer.Entities.Abstract;

namespace NLayer.DAL.Abstract
{
    //her yerde kullanmak adına işlemleri repository e aldık.
    public interface IEntityRepository<T> where T:class ,IEntity,new()
    //bu interface i kullanmak için IEntity imzası gerekir.
    {
        //kullanıcı isterse filtre uygulayabilir.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
