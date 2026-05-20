namespace ToDoListBackend.Functionality
{
    public class TaskManagment
    {
        public void CreateTask(string title, string description, DateTime dueDate, DataStructures.User assignedTo)
        {
            // Logic to create a new task
        }
        public DataStructures.Task GetTask(int taskId)
        {
            // Logic to retrieve a task by its ID
            return new DataStructures.Task();
        }

    }
}
