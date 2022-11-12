using Craiyon.Net;

namespace Barker_AI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
    }

    //OnAppearing Method that will only load its contents once
    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (cvImages.ItemsSource == null)
        {
            cvImages.ItemsSource = App.GetAllFiles();
        }
    }

    private async void btnClickMe_Clicked(object sender, EventArgs e)
    {
        var serv = new CraiyonService();
        string mainDir = FileSystem.Current.AppDataDirectory;
        string filePath = Path.Combine(mainDir, edtPrompt.Text);
        await serv.DownloadGalleryAsync(edtPrompt.Text, filePath);
        cvImages.ItemsSource= App.GetAllFiles();
        cvImages.IsVisible= true;
    }
}