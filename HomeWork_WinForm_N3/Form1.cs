namespace HomeWork_WinForm_N3
{
    public partial class Form1 : Form
    {
        //Задание 1
        //Написать приложение, которое отображает количество текста,
        //прочитанного из файла, с помощью ProgressBar.
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonRead_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(textBoxPath.Text, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                FileInfo processedFile = new FileInfo(textBoxPath.Text);
                progressBar1.Minimum = 0;
                progressBar1.Maximum = (int)processedFile.Length;
                progressBar1.Step = 1;
                for (int i = 0; i <= processedFile.Length; i++)
                {
                    labelFileSize.Text = i.ToString() + " байт";
                    progressBar1.PerformStep();
                    progressBar1.Value.ToString();
                    this.Update();
                    //Thread.Sleep(1);
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            labelFileSize.Text = "0 байт";
            progressBar1.Value = 0;
        }
    }
}