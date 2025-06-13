namespace KeyTextFinder
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            功能ToolStripMenuItem = new ToolStripMenuItem();
            按关键字搜索ToolStripMenuItem = new ToolStripMenuItem();
            按关键字删除ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 功能ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 功能ToolStripMenuItem
            // 
            功能ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 按关键字搜索ToolStripMenuItem, 按关键字删除ToolStripMenuItem });
            功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
            功能ToolStripMenuItem.Size = new Size(44, 21);
            功能ToolStripMenuItem.Text = "功能";
            // 
            // 按关键字搜索ToolStripMenuItem
            // 
            按关键字搜索ToolStripMenuItem.Name = "按关键字搜索ToolStripMenuItem";
            按关键字搜索ToolStripMenuItem.Size = new Size(180, 22);
            按关键字搜索ToolStripMenuItem.Text = "按关键字搜索";
            按关键字搜索ToolStripMenuItem.Click += 按关键字搜索ToolStripMenuItem_Click;
            // 
            // 按关键字删除ToolStripMenuItem
            // 
            按关键字删除ToolStripMenuItem.Name = "按关键字删除ToolStripMenuItem";
            按关键字删除ToolStripMenuItem.Size = new Size(180, 22);
            按关键字删除ToolStripMenuItem.Text = "按关键字删除";
            按关键字删除ToolStripMenuItem.Click += 按关键字删除ToolStripMenuItem_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "筛选文本";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 功能ToolStripMenuItem;
        private ToolStripMenuItem 按关键字搜索ToolStripMenuItem;
        private ToolStripMenuItem 按关键字删除ToolStripMenuItem;
    }
}