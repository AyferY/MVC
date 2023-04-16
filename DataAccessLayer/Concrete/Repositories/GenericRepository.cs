using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class  //Generic repository T değeri alacak. IRepository'den alacak ve
        // T değeri class olmalı diye şart koyuyorum.
    {

        Context c = new Context();   //Context sınıfından bir nesne türetiyoruz.

        DbSet<T> _object;  // Bizim T değerine karşılık gelen sınıfı tutuyor.

        //T değerine karşılık gelen sınıfı nasıl bulucaz?T değeri writer, heading vs olabilir.
        //Bunun için bir Constructor method oluşturuyoruz.

        public GenericRepository()
        {
            _object = c.Set<T>();  //T değeri dışarıdan ne gelirse gelsin _objext T tipinde ayarlanır.
                                   //Bu sayede dışarıdan Heading geliyorsa Heading kullanılır.
        }


        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();    //iste halinde dönmesi istendiği için böyle.
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();  // verdiğimde filter değerine göre _object'i listeleyip dönderir.
        }

        public void Update(T p)
        {
  
            c.SaveChanges();
        }
    }
}
