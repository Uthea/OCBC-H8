using Microsoft.EntityFrameworkCore;

namespace Testing.Models
{
    public class ApiDbContext : DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
            
        }
        
    }
}