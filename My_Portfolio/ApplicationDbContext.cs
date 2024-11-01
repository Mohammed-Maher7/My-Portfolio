using Microsoft.EntityFrameworkCore;
using My_Portfolio.Model;

namespace My_Portfolio
{
    public class ApplicationDbContext :DbContext
    {
       public DbSet<SubmitionForm> submitionForms {  get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        { 
        }
    }

}
