using La3bni.Repository;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class La3bniContext : IdentityDbContext<ApplicationUser>
    {
        public La3bniContext(DbContextOptions<La3bniContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(EntityConfiguration<>).Assembly);
            base.OnModelCreating(builder);
        }
    }
}