namespace PostmanCloneUi;

public partial class Dashbouard : Form
{
    public Dashbouard()
    {
        InitializeComponent();
    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        // Validate the API URL


        try
        {
            systemStatus.Text = "Calling API...";

            await Task.Delay(2000);

            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            resultsText.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
    }
}
