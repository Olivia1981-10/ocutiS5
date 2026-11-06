using Microsoft.Extensions.DependencyInjection;
using ocutiS5.Repositories;
namespace ocutiS5;

    public partial class App : Application
    {
        public static PersonRepository _personRepo { get; set; }
        public App(PersonRepository repo)
        {
            InitializeComponent();
            _personRepo = repo;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new Views.vPersona()));
        }
    }