using System.Collections.ObjectModel;
using PostmanCloneLibrary;
using PostmanCloneModels;

namespace PostmanCloneUi;

public partial class Dashbouard : Form
{
    private readonly IApiAccess api = new ApiAccess();
    public ObservableCollection<Request> Requests { get; set; } = new();

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

            Request request = new Request
            {
                Id = Guid.NewGuid(),
                Url = apiText.Text,
                Body = textBody.Text,
                Method = action.ToString(),
                Title = $"{action} {apiText.Text}",
            };

            TreeNode node = new TreeNode
            {
                Text = $"{action} {apiText.Text}",
                ToolTipText = textBody.Text,
                Tag = request,
            };

            treeRequests.Nodes.Add(node);
            Requests.Add(request);
        }
        catch (Exception ex)
        {
            resultsText.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
    }

    private void treeRequests_DoubleClick(object sender, EventArgs e)
    {
        var item = treeRequests.SelectedNode;
        if (item != null) 
        {
            Request? request = item.Tag as Request;
            
            if (request != null)
            {
                apiText.Text = request.Url;
                textBody.Text = request.Body;
                httpSelection.SelectedItem = request.Method;
                callData.SelectedTab = bodyTab;
                bodyTab.Focus();
            }
        }
    }
}
