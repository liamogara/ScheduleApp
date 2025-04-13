using Plugin.Maui.Calendar.Models;
using ScheduleApp.Data;
using ScheduleApp.Models;

namespace ScheduleApp;

public partial class CalendarPage : ContentPage
{
    public EventCollection Events { get; set; }
    public DateTime ShownDate { get; private set; } = DateTime.Now;

    public CalendarPage()
	{
        Events = new EventCollection();

        PopulateEvents();
        InitializeComponent();

        Calendar.ShownDate = ShownDate;

        BindingContext = this;
    }

    private void PopulateEvents()
    {
        var eventList = new Dictionary<DateTime, List<EventModel>>();

        foreach (var Event in App.EventList.GetAllEvents())
        {

            if (!eventList.ContainsKey(Event.Date))
            {
                eventList.Add(Event.Date, new List<EventModel>());
            }

            String startMin = Event.StartTime.Minutes > 9 ? $"{Event.StartTime.Minutes}" : $"0{Event.StartTime.Minutes}";
            String startTime = Event.StartTime.Hours > 12 ? $"{Event.StartTime.Hours % 12}:{startMin} PM" : $"{Event.StartTime.Hours}:{startMin} AM";

            String endMin = Event.EndTime.Minutes > 9 ? $"{Event.EndTime.Minutes}" : $"0{Event.EndTime.Minutes}";
            String endTime = Event.EndTime.Hours > 12 ? $"{Event.EndTime.Hours % 12}:{endMin} PM" : $"{Event.EndTime.Hours}:{endMin} AM";

            eventList[Event.Date].Add(
                new EventModel()
                {
                    Name = Event.Name, Location = Event.Location, Description = Event.Description, StartTime = startTime, EndTime = endTime
                });
        }

        foreach (var Date in eventList.Keys)
        {
            Events.Add(Date, eventList[Date]);
        }
    }
    private void OnBackToMenu(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}