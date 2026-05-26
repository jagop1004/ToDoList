namespace ToDoListBackend.Models
{
    public class Boards : IDataStructure
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Users> Users { get; set; }
        public List<Tasks> Tasks { get; set; }

        public Boards()
        {
            Name = "name";
        }

        public Boards(string name, List<Users> users, List<Tasks> tasks)
        {
            Name = name;
            Users = users;
            Tasks = tasks;
        }
    }
}
