using PetAdoption.Mobile.Pages;

namespace PetAdoption.Mobile
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //Check if onboarding shown already
            // If this is the first time (Onboarding not shown), Move to Onboarding Page
            // else move to home page

            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");


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
    }
}