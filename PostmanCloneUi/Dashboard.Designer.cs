namespace PostmanCloneUi;

partial class Dashboard
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
        statusStrip1 = new StatusStrip();
        systemStatus = new ToolStripStatusLabel();
        treeRequests = new TreeView();
        tabControl1 = new TabControl();
        btnNewTab = new Button();
        statusStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // statusStrip1
        // 
        statusStrip1.BackColor = Color.White;
        statusStrip1.Items.AddRange(new ToolStripItem[] { systemStatus });
        statusStrip1.Location = new Point(0, 580);
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
        // treeRequests
        // 
        treeRequests.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        treeRequests.Location = new Point(12, 55);
        treeRequests.Name = "treeRequests";
        treeRequests.Size = new Size(237, 511);
        treeRequests.TabIndex = 9;
        treeRequests.DoubleClick += treeRequests_DoubleClick;
        // 
        // tabControl1
        // 
        tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        tabControl1.Location = new Point(267, 16);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(700, 550);
        tabControl1.TabIndex = 10;
        // 
        // btnNewTab
        // 
        btnNewTab.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnNewTab.Location = new Point(194, 16);
        btnNewTab.Name = "btnNewTab";
        btnNewTab.Size = new Size(55, 23);
        btnNewTab.TabIndex = 11;
        btnNewTab.Text = "New";
        btnNewTab.UseVisualStyleBackColor = true;
        btnNewTab.Click += btnNewTab_Click;
        // 
        // Dashboard
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(984, 606);
        Controls.Add(btnNewTab);
        Controls.Add(tabControl1);
        Controls.Add(treeRequests);
        Controls.Add(statusStrip1);
        Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(6);
        Name = "Dashboard";
        Text = "Postman Clone by MarioBot";
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel systemStatus;
    private TreeView treeRequests;
    private TabControl tabControl1;
    private Button btnNewTab;
}
