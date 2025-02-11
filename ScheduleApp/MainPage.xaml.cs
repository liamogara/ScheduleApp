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
            Navigation.PushAsync(new EventPage());
        }

        private void OnViewScheduleChosen(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SchedulePage());
        }
    }

}
