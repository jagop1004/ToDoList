using Microsoft.EntityFrameworkCore;

namespace ToDoListBackend.Services
{
    public class DatabaseManagment: DbContext
    {
        private readonly DbContextOptions _sqlConnection;

        public DbSet<Models.Board> Boards { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<Models.User> Users { get; set; }

        public DatabaseManagment(DbContextOptions<DatabaseManagment> options) :base(options)
        {
            _sqlConnection = options;
        }

    }


}
