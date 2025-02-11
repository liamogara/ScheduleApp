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
        EventArea.IsVisible = false;
        BackToMenuButton.IsVisible = true;
        EventSubmittedLabel.Text = "Event added!";

        App.EventList.Add(new Event
        {
            EventName = EventNameEntry.Text,
            EventLocation = EventLocationEntry.Text,
            StartDate = StartDatePicker.Date,
            EndDate = EndDatePicker.Date
        });
    }

    private void OnBackToMenu(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}