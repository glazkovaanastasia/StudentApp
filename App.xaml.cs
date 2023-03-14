namespace StudentApp;

public partial class App : Application
{
    public const string DATABASE_NAME = "student.db";
    public static Repository database;
    public static Repository Database
    {
        get
        {
            if (database == null)
            {
                database = new Repository(
                    Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
            }
            return database;
        }
    }
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
    protected override void OnStart()
    {
    }
    protected override void OnSleep()
    {
    }
    protected override void OnResume()
    {
    }
}

