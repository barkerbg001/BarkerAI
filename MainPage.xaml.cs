using Craiyon.Net;

namespace Barker_AI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        cvImages.ItemsSource = App.GetAllFiles();
    }

    private async void btnClickMe_Clicked(object sender, EventArgs e)
    {
        var serv = new CraiyonService(1);
        string mainDir = FileSystem.Current.AppDataDirectory;
        string filePath = Path.Combine(mainDir, edtPrompt.Text);
        await serv.DownloadGalleryAsync(edtPrompt.Text, filePath);
        cvImages.ItemsSource= App.GetAllFiles();
        cvImages.IsVisible= true;
    }
}

