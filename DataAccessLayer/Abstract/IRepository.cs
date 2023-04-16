using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> //T senin type'ın demektir. T değerin ne olursa aşağıda onlar çalışır.
    {
        List<T> List();

        void Insert(T p);
        void Update(T p);
        void Delete(T p);

        List<T> List(Expression<Func<T, bool>> filter);  // Şartlı listeleme yapmak için kullanılır.
    }
}
