using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDos.Domain;
   
namespace ToDos.Application.Interfaces
{   
    public interface IToDosDbContext 
    {
        DbSet<ToDo> ToDos { get; set; }
        Task<int> SaveChangesAsyns(CancellationToken cancellationToken);
    }
}
