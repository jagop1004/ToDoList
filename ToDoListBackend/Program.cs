using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
//conection string creation
string? db_server = Environment.GetEnvironmentVariable("DB_SERVER");
string? db_port = Environment.GetEnvironmentVariable("DB_PORT");
string? db_database = Environment.GetEnvironmentVariable("DB_DATABASE");
string? db_password = Environment.GetEnvironmentVariable("DB_PASSWORD");
string? conectionString = $"Server={db_server},{db_port};Database={db_database};TrustServerCertificate=True;User Id=sa;Password={db_password}";
if (db_server == null || db_port == null || db_database == null ||  db_password == null)
{
    conectionString = builder.Configuration.GetConnectionString("Default");
}
//builder init
builder.Services.AddDbContext<ToDoListBackend.Services.DatabaseManagment>(options =>
        options.UseSqlServer(conectionString));
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
    var dbContext = scope.ServiceProvider.GetRequiredService<ToDoListBackend.Services.DatabaseManagment>();
    // Ensures the database is created and does migrations
    dbContext.Database.Migrate();
}

app.Run();
