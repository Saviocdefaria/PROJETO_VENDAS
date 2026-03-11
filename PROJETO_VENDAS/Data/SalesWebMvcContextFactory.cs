using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PROJETO_VENDAS.Data
{
    public class SalesWebMvcContextFactory : IDesignTimeDbContextFactory<SalesWebMvcContext>
    {
        public SalesWebMvcContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SalesWebMvcContext>();

            optionsBuilder.UseMySql(
                "server=localhost;database=vendas;user=root;password=l2vrpb00d",
                ServerVersion.AutoDetect("server=localhost;database=vendas;user=root;password=l2vrpb00d")
            );

            return new SalesWebMvcContext(optionsBuilder.Options);
        }
    }
}