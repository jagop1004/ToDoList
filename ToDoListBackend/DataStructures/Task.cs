using Microsoft.VisualBasic;

namespace ToDoListBackend.DataStructures
{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public ToDoListStatus Status { get; set; }
        public User AssignedTo { get; set; }

        public Task() 
        {
            Title = "title";
            Description = "description";
            DueDate = new DateTime();
            IsCompleted = false;
            Status = ToDoListStatus.NotStarted;
            AssignedTo = new User();
        }
        public Task(string title, string description, DateTime dueDate, User assignedTo)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = false;
            Status = ToDoListStatus.NotStarted;
            AssignedTo = assignedTo;
        }

    }

    public enum ToDoListStatus
    {
        NotStarted,
        InProgress,
        Completed,
        OnHold
    }
}
