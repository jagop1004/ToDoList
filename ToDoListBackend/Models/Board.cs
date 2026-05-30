namespace ToDoListBackend.Models
{
    public class Board : IDataStructure
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<User> Users { get; set; } = new List<User>();
        public List<Task> Tasks { get; set; } = new List<Task>();
        public Board(string name) {
            Name = name;
        }

   }
}
