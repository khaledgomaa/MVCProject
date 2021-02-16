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
            builder.Entity<BookingTeam>().HasKey(b => new { b.ApplicationUserId, b.BookingId });
            builder.Entity<PlaygroundRate>().HasKey(s => new { s.ApplicationUserId, s.PlaygroundId });
            base.OnModelCreating(builder);
        }
    }
}