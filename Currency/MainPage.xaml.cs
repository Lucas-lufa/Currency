namespace Currency;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		Money money = new Money();
	}

    private void plus1_Clicked(object sender, EventArgs e, Money money)
    {
		money.AddCents(100);
    }
}

