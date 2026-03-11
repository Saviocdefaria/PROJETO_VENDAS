using Microsoft.EntityFrameworkCore;
using PROJETO_VENDAS.Models;


namespace PROJETO_VENDAS.Data
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options) : base(options)
        {
        }
        protected SalesWebMvcContext()
        {
        }

        public DbSet<Department> Departments { get; set; }
       public  DbSet<Seller> Sellers { get; set; }
       public DbSet<SalesRecord> SalesRecords { get; set; }


    }
}
