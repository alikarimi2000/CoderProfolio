using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _00.Framework.Domain
{
    public interface IRepository<TKEY,T> where T: class
    {
        T Get(TKEY id);
        void Creat(T entity);
        bool Exisit(Expression<Func<T, bool>> exception);
        void SaveChange();
        List<T> GetAll();

    }
}
