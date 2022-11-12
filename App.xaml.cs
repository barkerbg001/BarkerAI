namespace Barker_AI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage();
	}

	public static List<string> GetAllFiles()
	{
        string mainDir = FileSystem.Current.AppDataDirectory;
        var paths = Directory.GetDirectories(mainDir).ToList();

        var filepaths = new List<string>();
        foreach (var path in paths)
        {
            filepaths.AddRange(Directory.GetFiles(path));
        }
        
        return filepaths.OrderByDescending(f => File.GetCreationTime(f)).ToList();
    }
}
