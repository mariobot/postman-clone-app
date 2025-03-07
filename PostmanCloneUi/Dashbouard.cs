using PostmanCloneLibrary;

namespace PostmanCloneUi;

public partial class Dashbouard : Form
{
    private readonly ApiAccess api = new();

    public Dashbouard()
    {
        InitializeComponent();
    }

    private async void callApi_ClickAsync(object sender, EventArgs e)
    {
        // Validate the API URL


        try
        {
            systemStatus.Text = "Calling API...";

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
