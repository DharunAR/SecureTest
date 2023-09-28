using SecureTest.Services;

namespace SecureTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<ITokenCache, TokenCacheService>();
            MainPage = new AppShell();
        }
    }
}
