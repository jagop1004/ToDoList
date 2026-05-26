using Microsoft.VisualBasic;

namespace ToDoListBackend.Models
{
    public class Tasks: IDataStructure
    {
        public int Id { get; set; }
        public Boards Board { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public ToDoListStatus Status { get; set; }
        public int AssignedTo { get; set; }


        public Tasks() 
        {
            Title = "title";
            Description = "description";
            DueDate = new DateTime();
            IsCompleted = false;
            Status = ToDoListStatus.NotStarted;
            AssignedTo = 0;
        }
        public Tasks(string title, string description, DateTime dueDate, int assignedTo)
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
