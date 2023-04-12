namespace BugApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private async void btnsubmit_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("", "bug button 4 clicked", "OK");

    }

    private void btnclear_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("", "bug button 1 clicked", "OK");

    }

    private void btnpreviousorder_Clicked(object sender, EventArgs e)
    {
       
                DisplayAlert("", "bug button 2 clicked", "OK");
         
    }

    private void btnpendingorder_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("", "bug button 3 clicked", "OK");

    }
}

