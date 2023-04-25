using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DComtext
{
    public class Context:DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> option):base(option){ }
        public DbSet<category> categories { get; set; }
        public DbSet<product> products { get; set; }
        public DbSet<images> images { get; set; }


    }
}
