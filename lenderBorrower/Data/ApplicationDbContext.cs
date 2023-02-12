using lenderBorrower.Models;
using Microsoft.EntityFrameworkCore;

namespace lenderBorrower.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        { 

        }
        public DbSet<item> items { get; set; }
        
    }
}
