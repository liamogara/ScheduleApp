using ScheduleApp.Data;

namespace ScheduleApp
{
    public partial class App : Application
    {
        public static EventList EventList { get; private set; }

        public App( EventList eventList)
        {
            InitializeComponent();

            EventList = eventList;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}