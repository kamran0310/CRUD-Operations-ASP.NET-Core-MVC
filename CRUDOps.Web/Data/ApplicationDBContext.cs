using CRUDOps.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUDOps.Web.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
