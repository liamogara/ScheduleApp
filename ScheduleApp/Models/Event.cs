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
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
