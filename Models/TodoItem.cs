namespace DailyRoutineApp.Models
{
    public class TodoItem
    {
        public int Id {get;set;}
        public string Description {get;set;} = string.Empty;
        public bool IsCompleted {get;set;}
        public DateTime CreatedAt {get;set;}
        public DateTime CompletedAt {get;set;}
        public int UserId {get;set;}
        public User User {get;set;} = new User();

    }
}