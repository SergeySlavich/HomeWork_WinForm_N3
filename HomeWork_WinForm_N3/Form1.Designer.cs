namespace HomeWork_WinForm_N3
{
    partial class Form1
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
            progressBar1 = new ProgressBar();
            labelTitle = new Label();
            labelFileSize = new Label();
            buttonRead = new Button();
            textBoxPath = new TextBox();
            buttonOK = new Button();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(37, 108);
            progressBar1.Margin = new Padding(3, 4, 3, 4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(810, 31);
            progressBar1.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(53, 29);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(177, 20);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Прогресс чтения файла:";
            // 
            // labelFileSize
            // 
            labelFileSize.AutoSize = true;
            labelFileSize.Location = new Point(802, 29);
            labelFileSize.Name = "labelFileSize";
            labelFileSize.Size = new Size(45, 20);
            labelFileSize.TabIndex = 2;
            labelFileSize.Text = "0 байт";
            // 
            // buttonRead
            // 
            buttonRead.Location = new Point(37, 157);
            buttonRead.Margin = new Padding(3, 4, 3, 4);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(122, 31);
            buttonRead.TabIndex = 4;
            buttonRead.Text = "Прочитать";
            buttonRead.UseVisualStyleBackColor = true;
            buttonRead.Click += buttonRead_Click;
            // 
            // textBoxPath
            // 
            textBoxPath.Location = new Point(236, 26);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new Size(560, 27);
            textBoxPath.TabIndex = 5;
            textBoxPath.Text = "test.txt";
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(753, 159);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 7;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 211);
            Controls.Add(buttonOK);
            Controls.Add(textBoxPath);
            Controls.Add(buttonRead);
            Controls.Add(labelFileSize);
            Controls.Add(labelTitle);
            Controls.Add(progressBar1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label labelTitle;
        private Label labelFileSize;
        private Button buttonRead;
        private TextBox textBoxPath;
        private Button buttonOK;
    }
}