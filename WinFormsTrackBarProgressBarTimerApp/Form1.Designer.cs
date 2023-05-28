namespace WinFormsTrackBarProgressBarTimerApp
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
            components = new System.ComponentModel.Container();
            redTrackBar = new TrackBar();
            redLabel = new Label();
            greenTrackBar = new TrackBar();
            greenLabel = new Label();
            blueTrackBar = new TrackBar();
            blueLabel = new Label();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)redTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blueTrackBar).BeginInit();
            SuspendLayout();
            // 
            // redTrackBar
            // 
            redTrackBar.LargeChange = 10;
            redTrackBar.Location = new Point(12, 21);
            redTrackBar.Maximum = 255;
            redTrackBar.Name = "redTrackBar";
            redTrackBar.Size = new Size(326, 45);
            redTrackBar.SmallChange = 5;
            redTrackBar.TabIndex = 0;
            redTrackBar.TickFrequency = 20;
            redTrackBar.Scroll += trackBar1_Scroll;
            // 
            // redLabel
            // 
            redLabel.AutoSize = true;
            redLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            redLabel.Location = new Point(387, 21);
            redLabel.Name = "redLabel";
            redLabel.Size = new Size(71, 30);
            redLabel.TabIndex = 1;
            redLabel.Text = "label1";
            // 
            // greenTrackBar
            // 
            greenTrackBar.LargeChange = 10;
            greenTrackBar.Location = new Point(12, 101);
            greenTrackBar.Maximum = 255;
            greenTrackBar.Name = "greenTrackBar";
            greenTrackBar.Size = new Size(326, 45);
            greenTrackBar.SmallChange = 5;
            greenTrackBar.TabIndex = 0;
            greenTrackBar.TickFrequency = 20;
            greenTrackBar.Scroll += trackBar1_Scroll;
            // 
            // greenLabel
            // 
            greenLabel.AutoSize = true;
            greenLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            greenLabel.Location = new Point(387, 101);
            greenLabel.Name = "greenLabel";
            greenLabel.Size = new Size(71, 30);
            greenLabel.TabIndex = 1;
            greenLabel.Text = "label1";
            // 
            // blueTrackBar
            // 
            blueTrackBar.LargeChange = 10;
            blueTrackBar.Location = new Point(12, 177);
            blueTrackBar.Maximum = 255;
            blueTrackBar.Name = "blueTrackBar";
            blueTrackBar.Size = new Size(326, 45);
            blueTrackBar.SmallChange = 5;
            blueTrackBar.TabIndex = 0;
            blueTrackBar.TickFrequency = 20;
            blueTrackBar.Scroll += trackBar1_Scroll;
            // 
            // blueLabel
            // 
            blueLabel.AutoSize = true;
            blueLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            blueLabel.Location = new Point(387, 177);
            blueLabel.Name = "blueLabel";
            blueLabel.Size = new Size(71, 30);
            blueLabel.TabIndex = 1;
            blueLabel.Text = "label1";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(31, 275);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(427, 49);
            progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(502, 290);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(729, 33);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 4;
            label1.Text = "0";
            // 
            // button2
            // 
            button2.Location = new Point(630, 29);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 373);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Controls.Add(blueLabel);
            Controls.Add(greenLabel);
            Controls.Add(redLabel);
            Controls.Add(blueTrackBar);
            Controls.Add(greenTrackBar);
            Controls.Add(redTrackBar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)redTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)blueTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar redTrackBar;
        private Label redLabel;
        private TrackBar greenTrackBar;
        private Label greenLabel;
        private TrackBar blueTrackBar;
        private Label blueLabel;
        private ProgressBar progressBar1;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Button button2;
    }
}