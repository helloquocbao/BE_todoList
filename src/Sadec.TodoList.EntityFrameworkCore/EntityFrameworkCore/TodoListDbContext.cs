using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Sadec.TodoList.Authorization.Roles;
using Sadec.TodoList.Authorization.Users;
using Sadec.TodoList.MultiTenancy;
using Sadec.TodoList.Tasks;

namespace Sadec.TodoList.EntityFrameworkCore
{
    public class TodoListDbContext : AbpZeroDbContext<Tenant, Role, User, TodoListDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DbSet<Task> Tasks { get; set; }

        public TodoListDbContext(DbContextOptions<TodoListDbContext> options)
            : base(options)
        {
        }
    }
}
