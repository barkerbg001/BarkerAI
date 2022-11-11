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

        var docs = new List<string>();
        foreach (var path in paths)
        {
            docs.AddRange(Directory.GetFiles(path));
        }

        return docs;
    }
}
