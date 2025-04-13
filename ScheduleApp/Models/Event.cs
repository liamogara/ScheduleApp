using SQLite;


namespace ScheduleApp.Models
{
    [Table("schedule")]
    public class Event
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; } = "No description.";
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
