using System;
using System.Collections.Generic;
using System.Text;
using assignment_4.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using assignment_4.Controllers;

namespace assignment_4.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BlogUser> BlogUsers { get; set; }
    }
}