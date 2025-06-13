namespace KeyTextFinder
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void 按关键字搜索ToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            FormKeywordMatcher from = new();
            from.Show();
        }

        private void 按关键字删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKeywordDeleter form = new();
            form.Show();
        }
    }
}
