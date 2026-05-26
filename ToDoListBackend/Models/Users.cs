namespace ToDoListBackend.Models
{
    public class Users: IDataStructure
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Boards> Boards { get; set; } = new List<Boards>();

        public Users()
        {
            Name = "name";
            Email = "email";
        }
        public Users(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
