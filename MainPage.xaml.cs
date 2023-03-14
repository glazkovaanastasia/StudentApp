namespace StudentApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        StudentList.ItemsSource = App.Database.GetItems();
        base.OnAppearing();
    }
    // обработка нажатия элемента в списке
    private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Student selectedStudent = (Student)e.SelectedItem;
        MainPage StudentPage = new MainPage();
        StudentPage.BindingContext = selectedStudent;
        await Navigation.PushAsync(StudentPage);
    }
    // обработка нажатия кнопки добавления
    private async void CreateStudent(object sender, EventArgs e)
    {
        Student Student = new Student();
        MainPage StudentPage = new MainPage();
        StudentPage.BindingContext = Student;
        await Navigation.PushAsync(StudentPage);
    }
}


