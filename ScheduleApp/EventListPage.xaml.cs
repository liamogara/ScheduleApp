namespace ScheduleApp;

public partial class EventListPage : ContentPage
{
	public EventListPage()
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

    private void OnUpdate(object sender, EventArgs e)
    {
        Button button = (Button)sender;

        Navigation.PushAsync(new UpdatePage((int)button.BindingContext));

        eventList.ItemsSource = App.EventList.GetAllEvents();
    }

    private void OnAddEventChosen(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddEventPage());
    }
}