using SecureTest.Services;

namespace SecureTest
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void SecureGet(object sender, EventArgs e)
        {
            var tt = DependencyService.Get<ITokenCache>();
            var kjfj = tt?.GetIdTokenAsync();
            kjfj.Wait();
            Console.WriteLine(kjfj);
        }

        private void SecurePost(object sender, EventArgs e)
        {
            string vals = "hdbvdv";
            var tt = DependencyService.Get<ITokenCache>();
           var yy =  tt?.SetIdTokenAsync(vals);
            yy.Wait();
        }
    }
}