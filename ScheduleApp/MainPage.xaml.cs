namespace ScheduleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAddEventChosen(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddEventPage());
        }

        private void OnViewEventListChosen(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EventListPage());
        }

        private void OnViewScheduleChosen(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CalendarPage());
        }
    }

}
