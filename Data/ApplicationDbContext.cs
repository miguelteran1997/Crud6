using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CRUD6.Data;

namespace CRUD6.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CRUD6.Data.Manufacturers> Manufacturers { get; set; }
        public DbSet<CRUD6.Data.Cars> Cars { get; set; }
    }
}
