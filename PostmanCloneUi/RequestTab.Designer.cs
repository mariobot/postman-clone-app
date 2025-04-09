namespace PostmanCloneUi
{
    partial class RequestTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            systemStatus = new ToolStripStatusLabel();
            callData = new TabControl();
            bodyTab = new TabPage();
            textBody = new TextBox();
            resultsTab = new TabPage();
            resultsText = new TextBox();
            httpSelection = new ComboBox();
            apiText = new TextBox();
            apiLabel = new Label();
            btnGo = new Button();
            btnSave = new Button();
            statusStrip1 = new StatusStrip();
            callData.SuspendLayout();
            bodyTab.SuspendLayout();
            resultsTab.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // systemStatus
            // 
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(0, 17);
            // 
            // callData
            // 
            callData.Controls.Add(bodyTab);
            callData.Controls.Add(resultsTab);
            callData.Font = new Font("Segoe UI", 8F);
            callData.Location = new Point(3, 59);
            callData.Name = "callData";
            callData.SelectedIndex = 0;
            callData.Size = new Size(686, 425);
            callData.TabIndex = 12;
            // 
            // bodyTab
            // 
            bodyTab.Controls.Add(textBody);
            bodyTab.Location = new Point(4, 22);
            bodyTab.Name = "bodyTab";
            bodyTab.Padding = new Padding(3);
            bodyTab.Size = new Size(678, 399);
            bodyTab.TabIndex = 0;
            bodyTab.Text = "Body";
            bodyTab.UseVisualStyleBackColor = true;
            // 
            // textBody
            // 
            textBody.Dock = DockStyle.Fill;
            textBody.Font = new Font("Segoe UI", 8F);
            textBody.Location = new Point(3, 3);
            textBody.Multiline = true;
            textBody.Name = "textBody";
            textBody.Size = new Size(672, 393);
            textBody.TabIndex = 0;
            // 
            // resultsTab
            // 
            resultsTab.Controls.Add(resultsText);
            resultsTab.Location = new Point(4, 22);
            resultsTab.Name = "resultsTab";
            resultsTab.Padding = new Padding(3);
            resultsTab.Size = new Size(678, 399);
            resultsTab.TabIndex = 1;
            resultsTab.Text = "Results";
            resultsTab.UseVisualStyleBackColor = true;
            // 
            // resultsText
            // 
            resultsText.BackColor = Color.White;
            resultsText.BorderStyle = BorderStyle.FixedSingle;
            resultsText.Dock = DockStyle.Fill;
            resultsText.Font = new Font("Segoe UI", 8F);
            resultsText.Location = new Point(3, 3);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ReadOnly = true;
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(672, 393);
            resultsText.TabIndex = 4;
            // 
            // httpSelection
            // 
            httpSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            httpSelection.Font = new Font("Segoe UI", 8F);
            httpSelection.FormattingEnabled = true;
            httpSelection.Items.AddRange(new object[] { "GET", "POST", "PUT", "PATCH", "DELETE" });
            httpSelection.Location = new Point(39, 16);
            httpSelection.Name = "httpSelection";
            httpSelection.Size = new Size(110, 21);
            httpSelection.TabIndex = 11;
            // 
            // apiText
            // 
            apiText.BorderStyle = BorderStyle.FixedSingle;
            apiText.Font = new Font("Segoe UI", 8F);
            apiText.Location = new Point(155, 16);
            apiText.Name = "apiText";
            apiText.Size = new Size(423, 22);
            apiText.TabIndex = 10;
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Font = new Font("Segoe UI", 8F);
            apiLabel.Location = new Point(7, 19);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(26, 13);
            apiLabel.TabIndex = 9;
            apiLabel.Text = "API:";
            // 
            // btnGo
            // 
            btnGo.Font = new Font("Segoe UI", 8F);
            btnGo.Location = new Point(584, 14);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(45, 23);
            btnGo.TabIndex = 13;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(635, 14);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(47, 23);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip1.Location = new Point(0, 483);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(692, 22);
            statusStrip1.TabIndex = 16;
            statusStrip1.Text = "statusStrip1";
            // 
            // RequestTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(statusStrip1);
            Controls.Add(btnSave);
            Controls.Add(btnGo);
            Controls.Add(callData);
            Controls.Add(httpSelection);
            Controls.Add(apiText);
            Controls.Add(apiLabel);
            Name = "RequestTab";
            Size = new Size(692, 505);
            callData.ResumeLayout(false);
            bodyTab.ResumeLayout(false);
            bodyTab.PerformLayout();
            resultsTab.ResumeLayout(false);
            resultsTab.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl callData;
        private TabPage bodyTab;
        private TextBox textBody;
        private TabPage resultsTab;
        private TextBox resultsText;
        private ComboBox httpSelection;
        private TextBox apiText;
        private Label apiLabel;
        private Button btnGo;
        private Button btnSave;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel systemStatus;
    }
}
