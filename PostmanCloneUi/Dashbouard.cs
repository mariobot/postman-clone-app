using PostmanCloneLibrary;

namespace PostmanCloneUi;

public partial class Dashbouard : Form
{
    private readonly IApiAccess api = new ApiAccess();

    public Dashbouard()
    {
        InitializeComponent();
    }

    private async void callApi_ClickAsync(object sender, EventArgs e)
    {
        systemStatus.Text = "Calling API...";
        resultsText.Text = string.Empty;

        // Validate the API URL

        if (!api.IsValidUrl(apiText.Text))
        {
            systemStatus.Text = "Invalid URL";
            return;
        }

        try
        {
            resultsText.Text = await api.CallApi(apiText.Text);
            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            resultsText.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
    }
}
