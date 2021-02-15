//Include This Library first
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Demo.Models
{
    //main class that’ll act as the model between your database connection and other classes
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options):base(options)
        {

        }

        //initialized DbSet type and give it the entity (Employee) -> DbSet is used to query and save instances of the entity, in this case the Employee.
        public DbSet<Employee> Employees { get; set; }





    }
}
