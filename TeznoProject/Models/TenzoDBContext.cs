using Microsoft.EntityFrameworkCore;

namespace TeznoProject.Models
{
    public class TenzoDBContext:DbContext
    {
        public DbSet <Slider> Sliders{ get; set; }

        public DbSet <Product> Products{ get; set; }

        public DbSet  <New>News { get; set; }


        public DbSet <Offer>Offers{ get; set; }

        public TenzoDBContext(DbContextOptions opt) : base(opt)
        {

        }

    }

   
}
