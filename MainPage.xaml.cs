﻿using Craiyon.Net;

namespace Barker_AI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
    }
    
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

    private void cvImages_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {

    }
}