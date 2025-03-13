using PostmanCloneLibrary;

namespace PostmanCloneUi;

public partial class Dashbouard : Form
{
    private readonly IApiAccess api = new ApiAccess();

    public Dashbouard()
    {
        InitializeComponent();
        httpSelection.SelectedIndex = 0;
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
            callData.SelectedTab = resultsTab;

            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            resultsText.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
    }
}
