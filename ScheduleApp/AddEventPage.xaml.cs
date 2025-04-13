using ScheduleApp.Models;

namespace ScheduleApp;

public partial class AddEventPage : ContentPage
{
	public AddEventPage()
	{
		InitializeComponent();
        BindingContext = this;
    }

    private void OnEventSubmitted(object sender, EventArgs e)
    {
        if (EventNameEntry.Text!=null && EventLocationEntry.Text!=null)
        {
            EventArea.IsVisible = false;
            EventSubmittedLabel.Text = "Event added!";
            EventSubmittedLabel.TextColor = Colors.Green;


            App.EventList.Add(new Event
            {
                Name = EventNameEntry.Text,
                Location = EventLocationEntry.Text,
                Description = EventDescriptionEntry.Text,
                Date = DatePicker.Date,
                StartTime = StartTimePicker.Time,
                EndTime = EndTimePicker.Time
            });
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