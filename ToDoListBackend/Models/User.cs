namespace ToDoListBackend.Models
{
    public class User: IDataStructure
    {
        public int Id { get; set; }
        public required string? Name { get; set; }
        public required string? Email { get; set; }

        public List<Board> Boards { get; set; } = new List<Board>();
        public User(){}
        public User(string name, string email){
            Name = name;
            Email = email;
        }
    }
}
