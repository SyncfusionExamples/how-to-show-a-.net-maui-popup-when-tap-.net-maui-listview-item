namespace PopupMAUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	private void ListView_ItemTapped(object sender, Syncfusion.Maui.ListView.ItemTappedEventArgs e)
	{
		sfPopup.Show();
	}
}

