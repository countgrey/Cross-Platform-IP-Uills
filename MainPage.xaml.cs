namespace IPUills;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnPingClicked(object sender, EventArgs e)
    {
        IpAddressOperations.Address = IpAddressText.Text;
        TextBox.Text = PingSomething.PingCurrentAddress();
    }
}
