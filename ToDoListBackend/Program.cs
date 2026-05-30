
using Microsoft.EntityFrameworkCore;
using ToDoListBackend.Functionality;

var builder = WebApplication.CreateBuilder(args);
//conection string creation
string db_server = Environment.GetEnvironmentVariable("DB_SERVER");
string db_port = Environment.GetEnvironmentVariable("DB_PORT");
string db_database = Environment.GetEnvironmentVariable("DB_DATABASE");
string db_password = Environment.GetEnvironmentVariable("DB_PASSWORD");
string conectionString = $"Server={db_server},{db_port};Database={db_database};TrustServerCertificate=True;User Id=sa;Password={db_password}";
if (db_server == null || db_port == null || db_database == null ||  db_password == null)
{
    conectionString = builder.Configuration.GetConnectionString("Default");
}
//builder init
builder.Services.AddDbContext<DatabaseManagment>(options =>
        options.UseSqlServer(conectionString));
builder.Services.AddScoped<IToDoManagment, ToDoManagment>();
builder.Services.AddControllers();
//api documentation
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// api documentation init
app.MapOpenApi();
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// Initialize the database
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<DatabaseManagment>();
    // Ensures the database is created and does migrations
    dbContext.Database.Migrate();
#region Mock Data
    // if (!dbContext.Boards.Any())
    // {
    //     // Seed initial data in correct order: create user -> board -> task
    //     var user = new ToDoListBackend.Models.Users(name: "John Doe", email: "test@email.com");
    //     dbContext.Users.Add(user);
    //     dbContext.SaveChanges();
    //
    //     var board = new ToDoListBackend.Models.Boards(
    //             name: "Default Board",
    //             users: new List<ToDoListBackend.Models.Users> { user },
    //             tasks: new List<ToDoListBackend.Models.Tasks>()
    //             );
    //     dbContext.Boards.Add(board);
    //     dbContext.SaveChanges();
    //
    //     var task = new ToDoListBackend.Models.Tasks(
    //             title: "Sample Task",
    //             description: "This is a sample task.",
    //             dueDate: DateTime.Now.AddDays(7),
    //             assignedTo: user.Id
    //             );
    //     task.Board = board; // associate task with the existing board
    //     dbContext.Tasks.Add(task);
    //     dbContext.SaveChanges();
    // }
#endregion

}

app.Run();
