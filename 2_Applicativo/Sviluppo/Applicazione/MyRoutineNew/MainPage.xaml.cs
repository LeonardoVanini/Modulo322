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
            MainCS.PerImpostazioni(Navigation);
        }
        private void test2(object sender, EventArgs e)
        {
            MainCS.PerProfilo(Navigation);
        }
        private void test3(object sender, EventArgs e)
        {
            MainCS.PerRoutine(Navigation);
        }
        private void test4(object sender, EventArgs e)
        {
            MainCS.PerStatistiche(Navigation);
        }

        
    }

}
