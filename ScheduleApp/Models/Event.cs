using SQLite;


namespace ScheduleApp.Models
{
    [Table("schedule")]
    public class Event
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }
        public string EventName { get; set; }
        public string EventLocation { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
