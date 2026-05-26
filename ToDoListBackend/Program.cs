
using Microsoft.EntityFrameworkCore;
using ToDoListBackend.Functionality;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseManagment>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IToDoManagment, ToDoManagment>();

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    //Testing cases
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//Init the database managment
// Initialize the database
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<DatabaseManagment>();
    dbContext.Database.Migrate(); // Ensures the database is created and does migrations
    // Mock data for testing purposes, remove in production
    if (!dbContext.Boards.Any())
    {
        // Seed initial data in correct order: create user -> board -> task
        var user = new ToDoListBackend.Models.Users(name: "John Doe", email: "test@email.com");
        dbContext.Users.Add(user);
        dbContext.SaveChanges();

        var board = new ToDoListBackend.Models.Boards(
            name: "Default Board",
            users: new List<ToDoListBackend.Models.Users> { user },
            tasks: new List<ToDoListBackend.Models.Tasks>()
        );
        dbContext.Boards.Add(board);
        dbContext.SaveChanges();

        var task = new ToDoListBackend.Models.Tasks(
            title: "Sample Task",
            description: "This is a sample task.",
            dueDate: DateTime.Now.AddDays(7),
            assignedTo: user.Id
        );
        task.Board = board; // associate task with the existing board
        dbContext.Tasks.Add(task);
        dbContext.SaveChanges();
    }
}

app.Run();
