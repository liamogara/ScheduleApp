using ScheduleApp.Models;

namespace ScheduleApp;

public partial class EventPage : ContentPage
{
	public EventPage()
	{
		InitializeComponent();
        BindingContext = this;
    }

    private void OnEventSubmitted(object sender, EventArgs e)
    {
        if (EventNameEntry.Text!=null && EventLocationEntry.Text!=null)
        {
            EventArea.IsVisible = false;
            BackToMenuButton.IsVisible = true;
            EventSubmittedLabel.Text = "Event added!";
            EventSubmittedLabel.TextColor = Colors.Green;


            App.EventList.Add(new Event
            {
                EventName = EventNameEntry.Text,
                EventLocation = EventLocationEntry.Text,
                Date = DatePicker.Date,
                StartTime = StartTimePicker.Time,
                EndTime = EndTimePicker.Time
            });
        }
        else
        {
            EventSubmittedLabel.Text = "Please fill in all fields.";

            EventSubmittedLabel.TextColor = Colors.Red;
        }
    }

    private void OnBackToMenu(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}