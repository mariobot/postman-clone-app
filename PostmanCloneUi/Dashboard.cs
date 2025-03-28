using System.Collections.ObjectModel;
using PostmanCloneModels;

namespace PostmanCloneUi;

public partial class Dashboard : Form
{
    public ObservableCollection<Request> Requests { get; set; } = new();

    public Dashboard()
    {
        InitializeComponent();

        RequestTab requestTab = new RequestTab(null);
        requestTab.tree_AddItem += tree_AddItem;
        tabRequest.Controls.Add(requestTab);
        tabRequest.Text = "New";
        tabControl1.SelectedTab = tabRequest; 
    }

    private void treeRequests_DoubleClick(object sender, EventArgs e)
    {
        var item = treeRequests.SelectedNode;
        if (item != null)
        {
            Request? request = item.Tag as Request;

            if (request != null)
            {
                RequestTab requestTab = new RequestTab(request);
                requestTab.tree_AddItem += tree_AddItem;
                tabRequest.Controls.Add(requestTab);
                tabRequest.Text = request.Title;
                tabControl1.SelectedTab = tabRequest;
            }
        }
    }

    public void tree_AddItem(object? sender, CustomEventArgs e)
    {
        if (Requests.Where(x => x.Id == e.Request.Id).Count() > 0)
        {
            Requests.Remove(Requests.First(x => x.Id == e.Request.Id));
            Requests.Add(e.Request);
        }
        else
        {
            TreeNode node = new TreeNode
            {
                Text = $"{e.Request.Method} {e.Request.Title}",
                ToolTipText = e.Request.Title,
                Tag = e.Request,
            };

            treeRequests.Nodes.Add(node);

            Requests.Add(e.Request);
        }
    }
}
