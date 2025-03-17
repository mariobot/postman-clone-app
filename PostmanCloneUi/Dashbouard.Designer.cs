namespace PostmanCloneUi;

partial class Dashbouard
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        formHeader = new Label();
        apiLabel = new Label();
        apiText = new TextBox();
        callApi = new Button();
        resultsText = new TextBox();
        statusStrip1 = new StatusStrip();
        systemStatus = new ToolStripStatusLabel();
        httpSelection = new ComboBox();
        callData = new TabControl();
        bodyTab = new TabPage();
        textBody = new TextBox();
        resultsTab = new TabPage();
        treeRequests = new TreeView();
        statusStrip1.SuspendLayout();
        callData.SuspendLayout();
        bodyTab.SuspendLayout();
        resultsTab.SuspendLayout();
        SuspendLayout();
        // 
        // formHeader
        // 
        formHeader.AutoSize = true;
        formHeader.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        formHeader.Location = new Point(374, 9);
        formHeader.Name = "formHeader";
        formHeader.Size = new Size(254, 47);
        formHeader.TabIndex = 0;
        formHeader.Text = "Postman Clone";
        // 
        // apiLabel
        // 
        apiLabel.AutoSize = true;
        apiLabel.Location = new Point(255, 94);
        apiLabel.Name = "apiLabel";
        apiLabel.Size = new Size(53, 32);
        apiLabel.TabIndex = 1;
        apiLabel.Text = "API:";
        // 
        // apiText
        // 
        apiText.BorderStyle = BorderStyle.FixedSingle;
        apiText.Location = new Point(430, 91);
        apiText.Name = "apiText";
        apiText.Size = new Size(448, 39);
        apiText.TabIndex = 2;
        // 
        // callApi
        // 
        callApi.Location = new Point(884, 91);
        callApi.Name = "callApi";
        callApi.Size = new Size(82, 39);
        callApi.TabIndex = 3;
        callApi.Text = "Go";
        callApi.UseVisualStyleBackColor = true;
        callApi.Click += callApi_ClickAsync;
        // 
        // resultsText
        // 
        resultsText.BackColor = Color.White;
        resultsText.BorderStyle = BorderStyle.FixedSingle;
        resultsText.Dock = DockStyle.Fill;
        resultsText.Location = new Point(3, 3);
        resultsText.Multiline = true;
        resultsText.Name = "resultsText";
        resultsText.ReadOnly = true;
        resultsText.ScrollBars = ScrollBars.Both;
        resultsText.Size = new Size(697, 444);
        resultsText.TabIndex = 4;
        // 
        // statusStrip1
        // 
        statusStrip1.BackColor = Color.White;
        statusStrip1.Items.AddRange(new ToolStripItem[] { systemStatus });
        statusStrip1.Location = new Point(0, 635);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(984, 26);
        statusStrip1.TabIndex = 5;
        statusStrip1.Text = "statusStrip1";
        // 
        // systemStatus
        // 
        systemStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        systemStatus.Name = "systemStatus";
        systemStatus.Size = new Size(53, 21);
        systemStatus.Text = "Ready";
        // 
        // httpSelection
        // 
        httpSelection.DropDownStyle = ComboBoxStyle.DropDownList;
        httpSelection.FormattingEnabled = true;
        httpSelection.Items.AddRange(new object[] { "GET", "POST", "PUT", "PATCH", "DELETE" });
        httpSelection.Location = new Point(314, 91);
        httpSelection.Name = "httpSelection";
        httpSelection.Size = new Size(110, 40);
        httpSelection.TabIndex = 7;
        // 
        // callData
        // 
        callData.Controls.Add(bodyTab);
        callData.Controls.Add(resultsTab);
        callData.Location = new Point(255, 137);
        callData.Name = "callData";
        callData.SelectedIndex = 0;
        callData.Size = new Size(711, 478);
        callData.TabIndex = 8;
        // 
        // bodyTab
        // 
        bodyTab.Controls.Add(textBody);
        bodyTab.Location = new Point(4, 41);
        bodyTab.Name = "bodyTab";
        bodyTab.Padding = new Padding(3);
        bodyTab.Size = new Size(703, 433);
        bodyTab.TabIndex = 0;
        bodyTab.Text = "Body";
        bodyTab.UseVisualStyleBackColor = true;
        // 
        // textBody
        // 
        textBody.Dock = DockStyle.Fill;
        textBody.Location = new Point(3, 3);
        textBody.Multiline = true;
        textBody.Name = "textBody";
        textBody.Size = new Size(697, 427);
        textBody.TabIndex = 0;
        // 
        // resultsTab
        // 
        resultsTab.Controls.Add(resultsText);
        resultsTab.Location = new Point(4, 24);
        resultsTab.Name = "resultsTab";
        resultsTab.Padding = new Padding(3);
        resultsTab.Size = new Size(703, 450);
        resultsTab.TabIndex = 1;
        resultsTab.Text = "Results";
        resultsTab.UseVisualStyleBackColor = true;
        // 
        // treeRequests
        // 
        treeRequests.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        treeRequests.Location = new Point(12, 91);
        treeRequests.Name = "treeRequests";
        treeRequests.Size = new Size(237, 517);
        treeRequests.TabIndex = 9;
        treeRequests.DoubleClick += treeRequests_DoubleClick;
        // 
        // Dashbouard
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(984, 661);
        Controls.Add(treeRequests);
        Controls.Add(callData);
        Controls.Add(httpSelection);
        Controls.Add(statusStrip1);
        Controls.Add(callApi);
        Controls.Add(apiText);
        Controls.Add(apiLabel);
        Controls.Add(formHeader);
        Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(6);
        Name = "Dashbouard";
        Text = "Postman Clone by MarioBot";
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        callData.ResumeLayout(false);
        bodyTab.ResumeLayout(false);
        bodyTab.PerformLayout();
        resultsTab.ResumeLayout(false);
        resultsTab.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label formHeader;
    private Label apiLabel;
    private TextBox apiText;
    private Button callApi;
    private TextBox resultsText;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel systemStatus;
    private ComboBox httpSelection;
    private TabControl callData;
    private TabPage bodyTab;
    private TabPage resultsTab;
    private TextBox textBody;
    private TreeView treeRequests;
}
