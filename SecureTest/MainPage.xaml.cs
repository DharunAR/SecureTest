using SecureTest.Services;

namespace SecureTest
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string url = "https://cmmobile.co.in/CMServiceAPI/auth/mobile";

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            var authResult = await WebAuthenticator.Default.AuthenticateAsync(new WebAuthenticatorOptions
            {
                Url = new Uri(url),
                CallbackUrl = new Uri("trimapp://")
            });

            string idToken = authResult.IdToken;
        }

        //private async void SecureGet(object sender, EventArgs e)
        //{
        //    var tt = DependencyService.Get<ITokenCache>();
        //    var kjfj = await tt?.GetIdTokenAsync();
        //    Console.WriteLine(kjfj);
        //}

        //private async void SecurePost(object sender, EventArgs e)
        //{
        //    string vals = "hdbvdv";
        //    var tt = DependencyService.Get<ITokenCache>();
        //    await tt?.SetIdTokenAsync(vals);
        //}
    }
}