namespace CoolProject
{
    partial class MainForm
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
            splitContainer1 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            AddTabButton = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel2);
            splitContainer1.Size = new Size(721, 694);
            splitContainer1.SplitterDistance = 105;
            splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(AddTabButton);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(105, 694);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // AddTabButton
            // 
            AddTabButton.Location = new Point(3, 3);
            AddTabButton.Name = "AddTabButton";
            AddTabButton.Size = new Size(75, 23);
            AddTabButton.TabIndex = 0;
            AddTabButton.Text = "Math";
            AddTabButton.UseVisualStyleBackColor = true;
            AddTabButton.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(3, 32);
            button2.Name = "button2";
            button2.Size = new Size(131, 23);
            button2.TabIndex = 2;
            button2.Text = "ColorSpaceConverter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 61);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // button3
            // 
            button3.Location = new Point(3, 90);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "InRange";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(3, 119);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "blur";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(3, 148);
            button5.Name = "button5";
            button5.Size = new Size(98, 26);
            button5.TabIndex = 5;
            button5.Text = "videocapture";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(3, 180);
            button6.Name = "button6";
            button6.Size = new Size(99, 23);
            button6.TabIndex = 6;
            button6.Text = "GetContours";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(612, 694);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 694);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button AddTabButton;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
