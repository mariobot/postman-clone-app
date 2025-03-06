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
        resultsLablel = new Label();
        statusStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // formHeader
        // 
        formHeader.AutoSize = true;
        formHeader.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        formHeader.Location = new Point(25, 24);
        formHeader.Name = "formHeader";
        formHeader.Size = new Size(275, 47);
        formHeader.TabIndex = 0;
        formHeader.Text = "Postman Clonoe";
        // 
        // apiLabel
        // 
        apiLabel.AutoSize = true;
        apiLabel.Location = new Point(25, 93);
        apiLabel.Name = "apiLabel";
        apiLabel.Size = new Size(53, 32);
        apiLabel.TabIndex = 1;
        apiLabel.Text = "API:";
        // 
        // apiText
        // 
        apiText.BorderStyle = BorderStyle.FixedSingle;
        apiText.Location = new Point(77, 93);
        apiText.Name = "apiText";
        apiText.Size = new Size(571, 39);
        apiText.TabIndex = 2;
        // 
        // callApi
        // 
        callApi.Location = new Point(654, 93);
        callApi.Name = "callApi";
        callApi.Size = new Size(82, 39);
        callApi.TabIndex = 3;
        callApi.Text = "Go";
        callApi.UseVisualStyleBackColor = true;
        callApi.Click += callApi_Click;
        // 
        // resultsText
        // 
        resultsText.BackColor = Color.White;
        resultsText.BorderStyle = BorderStyle.FixedSingle;
        resultsText.Location = new Point(25, 214);
        resultsText.Multiline = true;
        resultsText.Name = "resultsText";
        resultsText.ReadOnly = true;
        resultsText.ScrollBars = ScrollBars.Both;
        resultsText.Size = new Size(711, 398);
        resultsText.TabIndex = 4;
        // 
        // statusStrip1
        // 
        statusStrip1.Items.AddRange(new ToolStripItem[] { systemStatus });
        statusStrip1.Location = new Point(0, 635);
        statusStrip1.BackColor = Color.White;
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(784, 26);
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
        // resultsLablel
        // 
        resultsLablel.AutoSize = true;
        resultsLablel.Location = new Point(25, 160);
        resultsLablel.Name = "resultsLablel";
        resultsLablel.Size = new Size(88, 32);
        resultsLablel.TabIndex = 6;
        resultsLablel.Text = "Results";
        // 
        // Dashbouard
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(784, 661);
        Controls.Add(resultsLablel);
        Controls.Add(statusStrip1);
        Controls.Add(resultsText);
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
    private Label resultsLablel;
    private ToolStripStatusLabel systemStatus;
}
