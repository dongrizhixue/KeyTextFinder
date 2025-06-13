namespace KeyTextFinder
{
    partial class FormKeywordDeleter
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
            btnSelectFile = new Button();
            groupBox1 = new GroupBox();
            rtxtFilePath = new RichTextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            rtxtKeyword = new RichTextBox();
            btnDelete = new Button();
            label2 = new Label();
            btnSaveKeyword = new Button();
            btnReadKeyword = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(351, 88);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(75, 23);
            btnSelectFile.TabIndex = 0;
            btnSelectFile.Text = "选中文件";
            btnSelectFile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtxtFilePath);
            groupBox1.Controls.Add(btnSelectFile);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 126);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "选中文件";
            // 
            // rtxtFilePath
            // 
            rtxtFilePath.Location = new Point(68, 22);
            rtxtFilePath.Name = "rtxtFilePath";
            rtxtFilePath.Size = new Size(702, 60);
            rtxtFilePath.TabIndex = 1;
            rtxtFilePath.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 0;
            label1.Text = "文件路径";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnReadKeyword);
            groupBox2.Controls.Add(btnSaveKeyword);
            groupBox2.Controls.Add(rtxtKeyword);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 126);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "选中文件";
            // 
            // rtxtKeyword
            // 
            rtxtKeyword.Location = new Point(92, 22);
            rtxtKeyword.Name = "rtxtKeyword";
            rtxtKeyword.Size = new Size(678, 60);
            rtxtKeyword.TabIndex = 1;
            rtxtKeyword.Text = "";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(351, 88);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "执行";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 25);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 0;
            label2.Text = "删除的关键字";
            // 
            // btnSaveKeyword
            // 
            btnSaveKeyword.AutoSize = true;
            btnSaveKeyword.Location = new Point(152, 88);
            btnSaveKeyword.Name = "btnSaveKeyword";
            btnSaveKeyword.Size = new Size(138, 27);
            btnSaveKeyword.TabIndex = 2;
            btnSaveKeyword.Text = "保存关键字到配置文件";
            btnSaveKeyword.UseVisualStyleBackColor = true;
            // 
            // btnReadKeyword
            // 
            btnReadKeyword.AutoSize = true;
            btnReadKeyword.Location = new Point(0, 88);
            btnReadKeyword.Name = "btnReadKeyword";
            btnReadKeyword.Size = new Size(138, 27);
            btnReadKeyword.TabIndex = 3;
            btnReadKeyword.Text = "从配置文件读取关键字";
            btnReadKeyword.UseVisualStyleBackColor = true;
            // 
            // FormKeywordDeleter
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormKeywordDeleter";
            Text = "按关键字删除";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelectFile;
        private GroupBox groupBox1;
        private Label label1;
        private RichTextBox rtxtFilePath;
        private GroupBox groupBox2;
        private RichTextBox rtxtKeyword;
        private Button btnDelete;
        private Label label2;
        private Button btnReadKeyword;
        private Button btnSaveKeyword;
    }
}