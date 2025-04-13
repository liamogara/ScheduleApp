using ScheduleApp.Models;

namespace ScheduleApp;

public partial class UpdatePage : ContentPage
{
    private int id;
    public UpdatePage(int eventId)
    {
        InitializeComponent();
        BindingContext = this;
        id = eventId;

        Event oldEvent = App.EventList.Request(id);
        EventNameEntry.Placeholder = oldEvent.Name;
        EventLocationEntry.Placeholder = oldEvent.Location;
        EventDescriptionEntry.Placeholder = oldEvent.Description;
    }

    private void OnEventSubmitted(object sender, EventArgs e)
    {
        if (EventNameEntry.Text != null && EventLocationEntry.Text != null)
        {
            EventArea.IsVisible = false;
            EventSubmittedLabel.Text = "Event updated!";
            EventSubmittedLabel.TextColor = Colors.Green;

            Event updatedEvent = new Event { Id = id };
            updatedEvent.Name = EventNameEntry.Text;
            updatedEvent.Location = EventLocationEntry.Text;
            updatedEvent.Description = EventDescriptionEntry.Text;
            updatedEvent.Date = DatePicker.Date;
            updatedEvent.StartTime = StartTimePicker.Time;
            updatedEvent.EndTime = EndTimePicker.Time;

            App.EventList.Update(updatedEvent);
        }
        else
        {
            EventSubmittedLabel.Text = "Please fill in all required fields.";

            EventSubmittedLabel.TextColor = Colors.Red;
        }
    }

    private void OnBackToEventListPage(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EventListPage());
    }
}