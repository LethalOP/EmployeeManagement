using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public class empdbcontext:DbContext

    {
        public empdbcontext(DbContextOptions<empdbcontext> options) : base(options)
        {

        }
        public DbSet<employees> Employs { get; set; }
    }
}
