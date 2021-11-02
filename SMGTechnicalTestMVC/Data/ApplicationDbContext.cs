using Microsoft.EntityFrameworkCore;
using SMGTechnicalTestMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMGTechnicalTestMVC.Data
{
    //ApplicationDbContext implements DbContext
    public class ApplicationDbContext : DbContext
    {
        //Constructor, pass DbContextoptions from ApplicationDbContext to the base class
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //Code to create an entity and to hold Dbset of models goes here
        public DbSet<Game> Games { get; set; }
    }
}
