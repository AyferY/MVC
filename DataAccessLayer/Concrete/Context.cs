using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        //property türü dbset olacak ve dbset türünün entity katmanında verdiğin tablolar olacaktır.
        //Bu başka bir katmanda olduğu için DataAccessLayer katmanına EntityLayer katmanını reference vermen lazım.
        //About projemde yer alan sınıfın ismidir. Abouts ise DB'ye yansıyacak olan tablonun ismidir.

        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
