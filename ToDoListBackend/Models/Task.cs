namespace ToDoListBackend.Models
{
    public class Task: IDataStructure
    {
        public int Id { get; set; }
        public required int BoardId { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public ToDoListStatus Status { get; set; }
        public int AssignedTo { get; set; }
        public Task(int boardId, string title){
            BoardId = boardId;
            Title = title;
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
