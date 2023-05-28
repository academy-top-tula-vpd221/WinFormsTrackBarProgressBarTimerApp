namespace WinFormsTrackBarProgressBarTimerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            redLabel.Text = redTrackBar.Value.ToString();
            greenLabel.Text = greenTrackBar.Value.ToString();
            blueLabel.Text = blueTrackBar.Value.ToString();

            this.BackColor = Color.FromArgb(redTrackBar.Value,
                                            greenTrackBar.Value,
                                            blueTrackBar.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for(int i = progressBar1.Minimum; i <= progressBar1.Maximum; i++)
            //{
            //    progressBar1.Value = i;
            //    Thread.Sleep(50);
            //}
            progressBar1.Maximum = 1000;
            progressBar1.Value = progressBar1.Minimum;
            progressBar1.Step = 1;
            for (int i = progressBar1.Minimum; i <= progressBar1.Maximum; i++)
            {
                progressBar1.Increment(1);
                Task.Delay(5).Wait();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            if (timer1.Enabled)
                timer1.Stop();
            else
                timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = (Int32.Parse(label1.Text) + 1).ToString();
        }
    }
}