namespace ToDoListBackend.Functionality
{
    public static class TaskManagment
    {
        public static void CreateTask(string title, string description, DateTime dueDate, DataStructures.User assignedTo)
        {
            // Logic to create a new task
        }
        public static DataStructures.Task GetTask(int taskId)
        {
            // Logic to retrieve a task by its ID
            return new DataStructures.Task();
        }
        public static DataStructures.Task GetTask()
        {
            // Logic to retrieve all tasks
            return new DataStructures.Task();
        }
        public static DataStructures.Task[] GetAllTasks()
        {
            // Logic to retrieve all tasks
            return new DataStructures.Task[0];
        }

    }
}
