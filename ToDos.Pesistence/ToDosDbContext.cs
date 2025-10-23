using System;

using Microsoft.EntityFrameworkCore;
using ToDos.Application.Interfaces;
using ToDos.Domain;
using ToDos.Pesistence.EntityTypeConfiguration;

namespace ToDos.Pesistence
{
    public class ToDosDbContext : DbContext, IToDosDbContext
    {
        public DbSet<ToDo> ToDos {get;set;}
        public ToDosDbContext(DbContextOptions<ToDosDbContext> option)
             : base(option) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ToDoConfiguration());
            base.OnModelCreating(builder);
        }
        public Task<int> SaveChangesAsyns(CancellationToken cancellationToken)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
