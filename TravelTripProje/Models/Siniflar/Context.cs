using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelTripProje.Models.Siniflar
{
    public class Context : DbContext
    {
       public DbSet <Admin> admins { get; set; }
       public DbSet <AdresBlog> adresBlogs { get; set; }
       public DbSet <Blog> blogs { get; set; }
       public DbSet <Hakkimizda> hakkimizdas { get; set; }
       public DbSet <İletisim> iletisims { get; set; }
       public DbSet <Yorumlar> yorumlars { get; set; }
       
    }
}