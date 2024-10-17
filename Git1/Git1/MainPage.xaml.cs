using Android.Content.Res;

namespace Git1
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        
    }

    private async void Estadistica(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new messi());

    }

    private async void Estadistica1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new messi());

    }
}
