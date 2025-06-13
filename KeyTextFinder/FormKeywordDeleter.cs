using System.Globalization;
using System.Windows.Forms;

namespace KeyTextFinder
{
    public partial class FormKeywordDeleter : Form
    {
        private readonly string keyWordConfigFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "keyWordConfig.txt");
        public FormKeywordDeleter()
        {
            InitializeComponent();
            btnSelectFile.Click += BtnSelectFile_Click;
            btnDelete.Click += BtnDelete_Click;
            btnReadKeyword.Click += BtnReadKeyword_Click;
            btnSaveKeyword.Click += BtnSaveKeyword_Click;
        }

        private void BtnSaveKeyword_Click(object? sender, EventArgs e)
        {
            File.WriteAllLines(keyWordConfigFilePath, rtxtKeyword.Lines);
            MessageBox.Show("保存成功");
        }


        private void BtnReadKeyword_Click(object? sender, EventArgs e)
        {
            if (!File.Exists(keyWordConfigFilePath))
            {
                MessageBox.Show("关键字配置文件不存在。", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            rtxtKeyword.LoadFile(keyWordConfigFilePath, RichTextBoxStreamType.PlainText);
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {

            string[] deleteKeys = [.. rtxtKeyword.Lines
                .Where(line => !string.IsNullOrWhiteSpace(line)) // 过滤掉空行
                .Select(line => line.Trim())];
            string filePath = rtxtFilePath.Text;

            if (!File.Exists(filePath))
            {
                MessageBox.Show("文件不存在。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                List<string> filteredLines = [];
                bool deleteMode = false;
                foreach (string line in lines)
                {
                    if (string.IsNullOrEmpty(line.Trim()))
                    {
                        continue;
                    }
                    try
                    {
                        if (deleteMode)
                        {
                            if (TryParseDateTime(line, out _))
                            {
                                deleteMode = false;
                                continue;
                            }
                        }
                        if (ContainsAnyKeyword(line, deleteKeys))
                        {
                            deleteMode = true;
                            continue;
                        }
                        filteredLines.Add(line);
                    }
                    catch (Exception ex)
                    {

                        throw;
                    }
                }
                // Create the output directory if it doesn't exist
                string outputDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "file");
                Directory.CreateDirectory(outputDirectory);

                // Generate a unique file name using the current date and time
                string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                string outputFile = Path.Combine(outputDirectory, $"matched_lines_{timestamp}.txt");

                // Write the matched lines to a file
                File.WriteAllLines(outputFile, filteredLines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static bool ContainsAnyKeyword(string line, string[] deleteKeys, bool ignoreCase = true)
        {
            if (deleteKeys == null || deleteKeys.Length == 0)
                return false;

            StringComparison comparison = ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;
            return deleteKeys.Any(key => line.Contains(key, comparison));
        }
        private static bool TryParseDateTime(string line, out DateTime dateTime)
        {
            string format = "yyyy-MM-dd HH:mm:ss,fff";
            int endIndex = line.IndexOf(' ', 20); // 假设日期时间在前20个字符内

            if (endIndex != -1)
            {
                string dateString = line.Substring(0, endIndex);
                return DateTime.TryParseExact(dateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);
            }

            dateTime = default;
            return false;
        }
        private void BtnSelectFile_Click(object? sender, EventArgs e)
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
            }
            else
            {
                MessageBox.Show("未选择文件。", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
