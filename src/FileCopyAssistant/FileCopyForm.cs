using OfficeOpenXml;

namespace FileCopyAssistant
{
    public partial class FileCopyForm : Form
    {
        private string sourceFolder = "";
        private string destinationFolder = "";
        private string excelFilePath = "";

        public FileCopyForm()
        {
            InitializeComponent();
        }

        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    sourceFolder = folderDialog.SelectedPath;
                    txtSource.Text = sourceFolder;
                }
            }
        }

        private void btnBrowseExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    excelFilePath = openFileDialog.FileName;
                    txtExcel.Text = excelFilePath;
                }
            }
        }

        private void btnBrowseDestination_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    destinationFolder = folderDialog.SelectedPath;
                    txtDestination.Text = destinationFolder;
                }
            }
        }

        private void btnCopyFiles_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sourceFolder) || string.IsNullOrEmpty(destinationFolder) || string.IsNullOrEmpty(excelFilePath))
            {
                MessageBox.Show("Please select all required paths.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                FileInfo fileInfo = new FileInfo(excelFilePath);
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();
                    if (worksheet == null)
                    {
                        MessageBox.Show("No worksheet found in Excel file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int rowCount = worksheet.Dimension.Rows;
                    progressBar.Minimum = 0;
                    progressBar.Maximum = rowCount;
                    progressBar.Value = 0;

                    for (int row = 1; row <= rowCount; row++)
                    {
                        string fileName = worksheet.Cells[row, 1].Value?.ToString().Trim();
                        string innerFolder = worksheet.Cells[row, 2].Value?.ToString().Trim(); // Get inner folder name

                        if (!string.IsNullOrEmpty(fileName) && !string.IsNullOrEmpty(innerFolder))
                        {
                            string sourcePath = Path.Combine(sourceFolder, fileName);
                            string innerDestinationFolder = Path.Combine(destinationFolder, innerFolder);
                            string destinationPath = Path.Combine(innerDestinationFolder, fileName);

                            if (!Directory.Exists(innerDestinationFolder))
                            {
                                Directory.CreateDirectory(innerDestinationFolder);
                            }

                            if (File.Exists(sourcePath))
                            {
                                File.Copy(sourcePath, destinationPath, true);
                            }
                        }
                        progressBar.Value = row;

                        int percentage = (int)((double)row / rowCount * 100);
                        lblProgress.Text = $"Progress: {percentage}%";  
                    }
                    MessageBox.Show("Files copied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


