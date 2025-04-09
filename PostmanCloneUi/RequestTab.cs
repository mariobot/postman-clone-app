using PostmanCloneLibrary;
using PostmanCloneModels;

namespace PostmanCloneUi
{
    public partial class RequestTab : UserControl
    {
        private readonly IApiAccess api = new ApiAccess();
        private Request RequestItem { get; set; }
        public HttpAction action { get; set; }

        /// <summary>
        /// Constructor for the RequestTab
        /// </summary>
        /// <param name="request">The request.</param>
        public RequestTab(Request? request, Guid? index)
        {
            InitializeComponent();
            httpSelection.SelectedIndex = 0;

            if (request != null)
            {
                apiText.Text = request.Url;
                textBody.Text = request.Body;
                httpSelection.SelectedItem = request.Method;
                callData.SelectedTab = bodyTab;
                bodyTab.Focus();

                RequestItem = new Request
                {
                    Id = request.Id,
                    Url = request.Url,
                    Body = request.Body,
                    Method = request.Method,
                    Title = request.Title,
                };
            }
            else
            {
                RequestItem = new Request
                {
                    Id = (Guid)index,
                    Url = string.Empty,
                    Body = string.Empty,
                    Method = string.Empty,
                    Title = string.Empty,
                };
            }
        }

        private async void btnGo_Click(object sender, EventArgs e)
        {
            systemStatus.Text = "Calling API...";
            resultsText.Text = string.Empty;

            // Validate the API URL

            if (!api.IsValidUrl(apiText.Text))
            {
                systemStatus.Text = "Invalid URL";
                return;
            }

            if (Enum.TryParse(httpSelection.SelectedItem!.ToString(), out HttpAction actionSelected) == false)
            {
                systemStatus.Text = "Invalid HTTP Verb";
                return;
            }

            action = actionSelected;

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

        public event EventHandler<CustomEventArgs> tree_AddItem;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse(httpSelection.SelectedItem!.ToString(), out HttpAction actionSelected) == false)
            {
                systemStatus.Text = "Invalid HTTP Verb";
                return;
            }

            RequestItem.Url = apiText.Text;
            RequestItem.Body = textBody.Text;
            RequestItem.Method = actionSelected.ToString();
            RequestItem.Title = apiText.Text;

            OnSaveItemClick(new CustomEventArgs(RequestItem));
        }

        protected virtual void OnSaveItemClick(CustomEventArgs e)
        {
            tree_AddItem?.Invoke(this, e);
        }
    }
}
