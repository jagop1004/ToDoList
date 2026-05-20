namespace ToDoListBackend.DataStructures
{
    public class Board
    {
        public string Name { get; set; }
        public User[] Users { get; set; }
        public Task[] Tasks { get; set; }

        public Board()
        {
            Name = "name";
            Users = new User[0];
            Tasks = new Task[0];
        }

        public Board(string name, User[] users, Task[] tasks)
        {
            Name = name;
            Users = users;
            Tasks = tasks;
        }
    }
}
