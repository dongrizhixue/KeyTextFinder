namespace KeyTextFinder
{
    partial class FormKeywordMatcher
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
            btnStart = new Button();
            rtxtFilePath = new RichTextBox();
            lblFilePath = new Label();
            lblKeyWord = new Label();
            txtKeyWrod = new TextBox();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 0;
            btnStart.Text = "开始";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // rtxtFilePath
            // 
            rtxtFilePath.Location = new Point(93, 41);
            rtxtFilePath.Name = "rtxtFilePath";
            rtxtFilePath.Size = new Size(695, 98);
            rtxtFilePath.TabIndex = 1;
            rtxtFilePath.Text = "";
            // 
            // lblFilePath
            // 
            lblFilePath.AutoSize = true;
            lblFilePath.Location = new Point(31, 44);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(56, 17);
            lblFilePath.TabIndex = 2;
            lblFilePath.Text = "文件路径";
            // 
            // lblKeyWord
            // 
            lblKeyWord.AutoSize = true;
            lblKeyWord.Location = new Point(103, 15);
            lblKeyWord.Name = "lblKeyWord";
            lblKeyWord.Size = new Size(80, 17);
            lblKeyWord.TabIndex = 3;
            lblKeyWord.Text = "提取的关键字";
            // 
            // txtKeyWrod
            // 
            txtKeyWrod.Location = new Point(189, 12);
            txtKeyWrod.Name = "txtKeyWrod";
            txtKeyWrod.Size = new Size(300, 23);
            txtKeyWrod.TabIndex = 4;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtKeyWrod);
            Controls.Add(lblKeyWord);
            Controls.Add(lblFilePath);
            Controls.Add(rtxtFilePath);
            Controls.Add(btnStart);
            Name = "FormMain";
            Text = "根据关键字筛选文本";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private RichTextBox rtxtFilePath;
        private Label lblFilePath;
        private Label lblKeyWord;
        private TextBox txtKeyWrod;
    }
}
