using Microsoft.EntityFrameworkCore;

namespace DbOperationWithEF.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {

        }
    }
}
