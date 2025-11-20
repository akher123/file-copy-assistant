namespace FileCopyAssistant
{
    partial class FileCopyForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnBrowseSource = new Button();
            txtSource = new TextBox();
            txtExcel = new TextBox();
            btnBrowseExcel = new Button();
            txtDestination = new TextBox();
            btnBrowseDestination = new Button();
            btnCopyFiles = new Button();
            progressBar = new ProgressBar();
            lblProgress = new Label();
            panelSource = new Panel();
            panelExcel = new Panel();
            panelDestination = new Panel();
            panelSource.SuspendLayout();
            panelExcel.SuspendLayout();
            panelDestination.SuspendLayout();
            SuspendLayout();
            // 
            // btnBrowseSource
            // 
            btnBrowseSource.BackColor = Color.DodgerBlue;
            btnBrowseSource.ForeColor = Color.White;
            btnBrowseSource.Location = new Point(10, 50);
            btnBrowseSource.Name = "btnBrowseSource";
            btnBrowseSource.Size = new Size(213, 43);
            btnBrowseSource.TabIndex = 0;
            btnBrowseSource.Text = "Browse Source";
            btnBrowseSource.UseVisualStyleBackColor = false;
            btnBrowseSource.Click += btnBrowseSource_Click;
            // 
            // txtSource
            // 
            txtSource.Location = new Point(10, 10);
            txtSource.Name = "txtSource";
            txtSource.ReadOnly = true;
            txtSource.Size = new Size(740, 31);
            txtSource.TabIndex = 1;
            // 
            // txtExcel
            // 
            txtExcel.Location = new Point(10, 10);
            txtExcel.Name = "txtExcel";
            txtExcel.ReadOnly = true;
            txtExcel.Size = new Size(740, 31);
            txtExcel.TabIndex = 3;
            // 
            // btnBrowseExcel
            // 
            btnBrowseExcel.BackColor = Color.CornflowerBlue;
            btnBrowseExcel.ForeColor = Color.White;
            btnBrowseExcel.Location = new Point(10, 50);
            btnBrowseExcel.Name = "btnBrowseExcel";
            btnBrowseExcel.Size = new Size(213, 43);
            btnBrowseExcel.TabIndex = 2;
            btnBrowseExcel.Text = "Browse Excel";
            btnBrowseExcel.UseVisualStyleBackColor = false;
            btnBrowseExcel.Click += btnBrowseExcel_Click;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(10, 10);
            txtDestination.Name = "txtDestination";
            txtDestination.ReadOnly = true;
            txtDestination.Size = new Size(740, 31);
            txtDestination.TabIndex = 5;
            // 
            // btnBrowseDestination
            // 
            btnBrowseDestination.BackColor = Color.MediumSeaGreen;
            btnBrowseDestination.ForeColor = Color.White;
            btnBrowseDestination.Location = new Point(10, 50);
            btnBrowseDestination.Name = "btnBrowseDestination";
            btnBrowseDestination.Size = new Size(213, 43);
            btnBrowseDestination.TabIndex = 4;
            btnBrowseDestination.Text = "Browse Destination";
            btnBrowseDestination.UseVisualStyleBackColor = false;
            btnBrowseDestination.Click += btnBrowseDestination_Click;
            // 
            // btnCopyFiles
            // 
            btnCopyFiles.BackColor = Color.Crimson;
            btnCopyFiles.ForeColor = Color.White;
            btnCopyFiles.Location = new Point(30, 450);
            btnCopyFiles.Name = "btnCopyFiles";
            btnCopyFiles.Size = new Size(220, 50);
            btnCopyFiles.TabIndex = 6;
            btnCopyFiles.Text = "Copy Files";
            btnCopyFiles.UseVisualStyleBackColor = false;
            btnCopyFiles.Click += btnCopyFiles_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(30, 510);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(760, 30);
            progressBar.TabIndex = 7;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(30, 545);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(115, 25);
            lblProgress.TabIndex = 8;
            lblProgress.Text = "Progress: 0%";
            // 
            // panelSource
            // 
            panelSource.BorderStyle = BorderStyle.FixedSingle;
            panelSource.Controls.Add(txtSource);
            panelSource.Controls.Add(btnBrowseSource);
            panelSource.Location = new Point(30, 40);
            panelSource.Name = "panelSource";
            panelSource.Size = new Size(760, 100);
            panelSource.TabIndex = 11;
            // 
            // panelExcel
            // 
            panelExcel.BorderStyle = BorderStyle.FixedSingle;
            panelExcel.Controls.Add(txtExcel);
            panelExcel.Controls.Add(btnBrowseExcel);
            panelExcel.Location = new Point(30, 150);
            panelExcel.Name = "panelExcel";
            panelExcel.Size = new Size(760, 100);
            panelExcel.TabIndex = 10;
            // 
            // panelDestination
            // 
            panelDestination.BorderStyle = BorderStyle.FixedSingle;
            panelDestination.Controls.Add(txtDestination);
            panelDestination.Controls.Add(btnBrowseDestination);
            panelDestination.Location = new Point(30, 260);
            panelDestination.Name = "panelDestination";
            panelDestination.Size = new Size(760, 100);
            panelDestination.TabIndex = 9;
            // 
            // FileCopyForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(820, 600);
            Controls.Add(lblProgress);
            Controls.Add(progressBar);
            Controls.Add(btnCopyFiles);
            Controls.Add(panelDestination);
            Controls.Add(panelExcel);
            Controls.Add(panelSource);
            Name = "FileCopyForm";
            Text = "File Copy Assistant";
            panelSource.ResumeLayout(false);
            panelSource.PerformLayout();
            panelExcel.ResumeLayout(false);
            panelExcel.PerformLayout();
            panelDestination.ResumeLayout(false);
            panelDestination.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowseSource;
        private TextBox txtSource;
        private TextBox txtExcel;
        private Button btnBrowseExcel;
        private TextBox txtDestination;
        private Button btnBrowseDestination;
        private Button btnCopyFiles;
        private ProgressBar progressBar;
        private Label lblProgress;
        private Panel panelSource;
        private Panel panelExcel;
        private Panel panelDestination;
    }

}
