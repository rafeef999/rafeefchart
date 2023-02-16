using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
namespace WebApplication2.data
{
    public class dbcontext
    {
        public dbcontext(DbContextOptions<dbcontext> options) : base(options)
        {

        }
        public DbSet<catagory> Catagories { get; set; }
    }
}
