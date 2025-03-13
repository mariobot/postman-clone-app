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

        HttpAction action;

        if (Enum.TryParse(httpSelection.SelectedItem!.ToString(), out action) == false)
        {
            systemStatus.Text = "Invalid HTTP Verb";
            return;
        }

        try
        {
            resultsText.Text = await api.CallApiAsync(apiText.Text, textBody.Text, action, true);
            callData.SelectedTab = resultsTab;
            resultsTab.Focus();

            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            resultsText.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
    }
}
