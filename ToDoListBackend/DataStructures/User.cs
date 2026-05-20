namespace ToDoListBackend.DataStructures
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public User()
        {
            Name = "name";
            Email = "email";
        }
        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
