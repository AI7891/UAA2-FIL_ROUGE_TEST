using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Starter_CleanArch_UAA2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Starter_CleanArch_UAA2.Infrastructure.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<NewsLetterSample> NewsLetterSamples { get; set; }

        /*Initiating CTOR : Dependencies Injection */
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        /*Configuration settings*/
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            /*Authomated in real time configuration Addition*/
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
