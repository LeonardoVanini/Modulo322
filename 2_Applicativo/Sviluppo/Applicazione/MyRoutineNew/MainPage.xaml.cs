namespace MyRoutineNew
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
        private void test1(object sender, EventArgs e)
        {
            PerImpostazioni();
        }
        private void test2(object sender, EventArgs e)
        {
            PerProfilo();
        }
        private void test3(object sender, EventArgs e)
        {
            PerRoutine();
        }
        private void test4(object sender, EventArgs e)
        {
            PerStatistiche();
        }

        private async void PerImpostazioni()
        {
            await Navigation.PushAsync(new Impostazioni());
        }
        private async void PerProfilo()
        {
            await Navigation.PushAsync(new Profilo());
        }
        private async void PerRoutine()
        {
            await Navigation.PushAsync(new Routine());
        }
        private async void PerStatistiche()
        {
            await Navigation.PushAsync(new Statistiche());
        }
    }

}
