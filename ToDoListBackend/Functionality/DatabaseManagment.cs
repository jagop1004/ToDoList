using Microsoft.EntityFrameworkCore;

namespace ToDoListBackend.Functionality
{
    public class DatabaseManagment: DbContext
    {
        private readonly DbContextOptions _sqlConnection;

        public DbSet<Models.Boards> Boards { get; set; }
        public DbSet<Models.Tasks> Tasks { get; set; }
        public DbSet<Models.Users> Users { get; set; }

        public DatabaseManagment(DbContextOptions<DatabaseManagment> options) :base(options)
        {
            _sqlConnection = options;
        }

    }


}
