namespace ScheduleApp;

public partial class SchedulePage : ContentPage
{
	public SchedulePage()
	{
		InitializeComponent();
        eventList.ItemsSource = App.EventList.GetAllEvents();
    }

    private void OnDelete(object sender, EventArgs e)
    {
        Button button = (Button)sender;

        App.EventList.Delete((int)button.BindingContext);

        eventList.ItemsSource = App.EventList.GetAllEvents();
    }

    private void OnBackToMenu(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}