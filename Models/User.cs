namespace DailyRoutineApp.Models
{
    public class User
    {
        public int Id {get;set;}
        public string Username {get;set;} = string.Empty;
        public byte[] PasswordHash {get;set;} = Array.Empty<byte>();
        public byte[] PasswordSalt {get;set;} = Array.Empty<byte>();

        // Navigation property
        public ICollection<TodoItem> TodoItems { get; set; } = new List<TodoItem>();
    }
}