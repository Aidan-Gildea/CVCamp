namespace CoolProject.Controls
{
    partial class InRange
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InRange));
            inputBox1 = new InputBox();
            outputBox1 = new OutputBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label10 = new Label();
            label11 = new Label();
            slider1 = new Slider();
            slider2 = new Slider();
            slider3 = new Slider();
            slider4 = new Slider();
            slider5 = new Slider();
            slider6 = new Slider();
            SuspendLayout();
            // 
            // inputBox1
            // 
            inputBox1.BorderStyle = BorderStyle.FixedSingle;
            inputBox1.CurrentImage = (Emgu.CV.Mat)resources.GetObject("inputBox1.CurrentImage");
            inputBox1.Enabled = false;
            inputBox1.Location = new Point(22, 42);
            inputBox1.Margin = new Padding(3, 2, 3, 2);
            inputBox1.MaximumSize = new Size(189, 206);
            inputBox1.MinimumSize = new Size(189, 206);
            inputBox1.Name = "inputBox1";
            inputBox1.Size = new Size(189, 206);
            inputBox1.TabIndex = 0;
            // 
            // outputBox1
            // 
            outputBox1.BorderStyle = BorderStyle.FixedSingle;
            outputBox1.CurrentImage = (Emgu.CV.Mat)resources.GetObject("outputBox1.CurrentImage");
            outputBox1.Enabled = false;
            outputBox1.Location = new Point(308, 42);
            outputBox1.Name = "outputBox1";
            outputBox1.Size = new Size(189, 206);
            outputBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 132);
            label1.Name = "label1";
            label1.Size = new Size(33, 25);
            label1.TabIndex = 2;
            label1.Text = "->";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(96, 15);
            label2.Name = "label2";
            label2.Size = new Size(38, 25);
            label2.TabIndex = 3;
            label2.Text = "Src";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(370, 15);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 4;
            label3.Text = "Result";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "HSV", "BGR" });
            comboBox1.Location = new Point(216, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(85, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(78, 267);
            label10.Name = "label10";
            label10.Size = new Size(74, 15);
            label10.TabIndex = 18;
            label10.Text = "LowerBound";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(358, 267);
            label11.Name = "label11";
            label11.Size = new Size(74, 15);
            label11.TabIndex = 19;
            label11.Text = "UpperBound";
            // 
            // slider1
            // 
            slider1.BorderStyle = BorderStyle.FixedSingle;
            slider1.Location = new Point(8, 299);
            slider1.MaximumSize = new Size(219, 78);
            slider1.MaxValue = 10;
            slider1.MinimumSize = new Size(219, 78);
            slider1.Name = "slider1";
            slider1.Size = new Size(219, 78);
            slider1.TabIndex = 20;
            slider1.Title = "label1";
            slider1.Value = 0;
            // 
            // slider2
            // 
            slider2.BorderStyle = BorderStyle.FixedSingle;
            slider2.Location = new Point(8, 383);
            slider2.MaximumSize = new Size(219, 78);
            slider2.MaxValue = 10;
            slider2.MinimumSize = new Size(219, 78);
            slider2.Name = "slider2";
            slider2.Size = new Size(219, 78);
            slider2.TabIndex = 21;
            slider2.Title = "label1";
            slider2.Value = 0;
            // 
            // slider3
            // 
            slider3.BorderStyle = BorderStyle.FixedSingle;
            slider3.Location = new Point(8, 467);
            slider3.MaximumSize = new Size(219, 78);
            slider3.MaxValue = 10;
            slider3.MinimumSize = new Size(219, 78);
            slider3.Name = "slider3";
            slider3.Size = new Size(219, 78);
            slider3.TabIndex = 22;
            slider3.Title = "label1";
            slider3.Value = 0;
            // 
            // slider4
            // 
            slider4.BorderStyle = BorderStyle.FixedSingle;
            slider4.Location = new Point(293, 299);
            slider4.MaximumSize = new Size(219, 78);
            slider4.MaxValue = 10;
            slider4.MinimumSize = new Size(219, 78);
            slider4.Name = "slider4";
            slider4.Size = new Size(219, 78);
            slider4.TabIndex = 23;
            slider4.Title = "label1";
            slider4.Value = 0;
            // 
            // slider5
            // 
            slider5.BorderStyle = BorderStyle.FixedSingle;
            slider5.Location = new Point(293, 383);
            slider5.MaximumSize = new Size(219, 78);
            slider5.MaxValue = 10;
            slider5.MinimumSize = new Size(219, 78);
            slider5.Name = "slider5";
            slider5.Size = new Size(219, 78);
            slider5.TabIndex = 24;
            slider5.Title = "label1";
            slider5.Value = 0;
            // 
            // slider6
            // 
            slider6.BorderStyle = BorderStyle.FixedSingle;
            slider6.Location = new Point(293, 467);
            slider6.MaximumSize = new Size(219, 78);
            slider6.MaxValue = 10;
            slider6.MinimumSize = new Size(219, 78);
            slider6.Name = "slider6";
            slider6.Size = new Size(219, 78);
            slider6.TabIndex = 25;
            slider6.Title = "label1";
            slider6.Value = 0;
            // 
            // InRange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(slider6);
            Controls.Add(slider5);
            Controls.Add(slider4);
            Controls.Add(slider3);
            Controls.Add(slider2);
            Controls.Add(slider1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(outputBox1);
            Controls.Add(inputBox1);
            MaximumSize = new Size(535, 577);
            MinimumSize = new Size(535, 577);
            Name = "InRange";
            Size = new Size(533, 575);
            Load += InRange_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private InputBox inputBox1;
        private OutputBox outputBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private Label label10;
        private Label label11;
        private Slider slider1;
        private Slider slider2;
        private Slider slider3;
        private Slider slider4;
        private Slider slider5;
        private Slider slider6;
    }
}
