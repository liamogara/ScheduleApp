using ScheduleApp.Models;
using SQLite;

namespace ScheduleApp.Data
{
    public class EventList
    {
        private string _dbPath;
        private SQLiteConnection _conn;

        public EventList(string dbPath)
        {
            _dbPath = dbPath;
        }

        public void Init()
        {
            _conn = new SQLiteConnection(_dbPath);
            _conn.CreateTable<Event>();
        }

        public List<Event> GetAllEvents()
        {
            Init();
            return _conn.Table<Event>().ToList();
        }

        public void Add(Event ev)
        {
            _conn = new SQLiteConnection(_dbPath);
            _conn.Insert(ev);
        }

        public void Delete(int id)
        {
            _conn = new SQLiteConnection(_dbPath);
            _conn.Delete(new Event { Id = id });
        }

        public void Update(Event ev)
        {
            _conn = new SQLiteConnection(_dbPath);
            _conn.Update(ev);
        }

        public Event Request(int id)
        {
            _conn = new SQLiteConnection(_dbPath);
            var result = _conn.Query<Event>($"select * from schedule where id={id}").First();
            return result;
        }
    }
}
