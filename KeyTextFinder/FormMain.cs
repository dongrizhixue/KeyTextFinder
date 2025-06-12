using Microsoft.VisualBasic.Devices;

namespace KeyTextFinder
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            btnStart.Click += BtnStart_Click;
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Title = "选择一个文件",
                Filter = "所有文件 (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                rtxtFilePath.Text = filePath;
                try
                {
                    HashSet<string> matchedLines = [];
                    foreach (string line in File.ReadLines(filePath))
                    {
                        if (line.Contains(txtKeyWrod.Text))
                        {
                            matchedLines.Add(line);
                        }
                    }
                    // Create the output directory if it doesn't exist
                    string outputDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "file");
                    Directory.CreateDirectory(outputDirectory);

                    // Generate a unique file name using the current date and time
                    string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                    string outputFile = Path.Combine(outputDirectory, $"matched_lines_{timestamp}.txt");

                    // Write the matched lines to a file
                    File.WriteAllLines(outputFile, matchedLines);

                    MessageBox.Show($"匹配结果已保存到: {outputFile}", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"读取文件时发生错误: {ex}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("未选择文件。", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
