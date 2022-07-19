using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Sadec.TodoList.EntityFrameworkCore
{
    public static class TodoListDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TodoListDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TodoListDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
