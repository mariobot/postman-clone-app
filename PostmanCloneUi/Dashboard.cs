using System.Collections.ObjectModel;
using PostmanCloneModels;

namespace PostmanCloneUi;

public partial class Dashboard : Form
{
    public ObservableCollection<Request> Requests { get; set; } = new();

    public Dashboard()
    {
        InitializeComponent();
        NewTab();
    }

    private void NewTab()
    {
        Guid index = Guid.NewGuid();
        RequestTab requestTab = new(null, index);
        requestTab.tree_AddItem += tree_AddItem;
        TabPage page = new TabPage("New");
        page.Name = index.ToString();
        page.Controls.Add(requestTab);
        tabControl1.TabPages.Add(page);
        tabControl1.SelectedTab = page;
    }

    private void treeRequests_DoubleClick(object sender, EventArgs e)
    {
        var item = treeRequests.SelectedNode;
        if (item != null)
        {
            Request? request = item.Tag as Request;

            if (request != null)
            {
                Guid index = request.Id;
                string tabName = index.ToString();

                // Check if the tab already exists
                TabPage? existingTab = tabControl1.TabPages.Cast<TabPage>().FirstOrDefault(tab => tab.Name == tabName);

                if (existingTab != null)
                {
                    // Select the existing tab
                    tabControl1.SelectedTab = existingTab;
                }
                else
                {
                    // Create a new tab
                    RequestTab requestTab = new(request, request.Id);
                    requestTab.tree_AddItem += tree_AddItem;
                    TabPage page = new TabPage(request.Title)
                    {
                        Name = tabName
                    };
                    page.Controls.Add(requestTab);
                    tabControl1.TabPages.Add(page);
                    tabControl1.SelectedTab = page;
                }
            }
        }
    }

    public void tree_AddItem(object? sender, CustomEventArgs e)
    {
        if (Requests.Where(x => x.Id == e.Request.Id).Count() > 0)
        {
            Requests.Remove(Requests.First(x => x.Id == e.Request.Id));
            Requests.Add(e.Request);

            TreeNode node = treeRequests.Nodes.Cast<TreeNode>().FirstOrDefault(x => x.Tag == e.Request);
            if (node != null)
            {
                node.Text = $"{e.Request.Method} {e.Request.Title}";
                node.ToolTipText = e.Request.Method;
                node.Tag = e.Request;
            }
        }
        else
        {
            TreeNode node = new TreeNode
            {
                Text = $"{e.Request.Method} {e.Request.Title}",
                ToolTipText = e.Request.Method,
                Tag = e.Request,
            };

            treeRequests.Nodes.Add(node);

            Requests.Add(e.Request);
        }
    }

    private void btnNewTab_Click(object sender, EventArgs e) => NewTab();
}
