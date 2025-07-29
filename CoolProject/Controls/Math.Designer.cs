namespace CoolProject.Controls
{
    partial class Math
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Math));
            inputBox1 = new InputBox();
            inputBox2 = new InputBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            outputBox1 = new OutputBox();
            TestTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // inputBox1
            // 
            inputBox1.BorderStyle = BorderStyle.FixedSingle;
            inputBox1.CurrentImage = (Emgu.CV.Mat)resources.GetObject("inputBox1.CurrentImage");
            inputBox1.Location = new Point(17, 14);
            inputBox1.Margin = new Padding(3, 2, 3, 2);
            inputBox1.MaximumSize = new Size(191, 208);
            inputBox1.MinimumSize = new Size(191, 208);
            inputBox1.Name = "inputBox1";
            inputBox1.Size = new Size(191, 208);
            inputBox1.TabIndex = 0;
            inputBox1.Load += inputBox1_Load;
            // 
            // inputBox2
            // 
            inputBox2.BorderStyle = BorderStyle.FixedSingle;
            inputBox2.CurrentImage = (Emgu.CV.Mat)resources.GetObject("inputBox2.CurrentImage");
            inputBox2.Location = new Point(231, 14);
            inputBox2.Margin = new Padding(3, 2, 3, 2);
            inputBox2.MaximumSize = new Size(191, 208);
            inputBox2.MinimumSize = new Size(191, 208);
            inputBox2.Name = "inputBox2";
            inputBox2.Size = new Size(191, 208);
            inputBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(442, 94);
            label1.Name = "label1";
            label1.Size = new Size(45, 47);
            label1.TabIndex = 3;
            label1.Text = "=";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(310, 239);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // outputBox1
            // 
            outputBox1.BorderStyle = BorderStyle.FixedSingle;
            outputBox1.CurrentImage = (Emgu.CV.Mat)resources.GetObject("outputBox1.CurrentImage");
            outputBox1.Location = new Point(504, 16);
            outputBox1.Name = "outputBox1";
            outputBox1.Size = new Size(189, 206);
            outputBox1.TabIndex = 5;
            // 
            // TestTimer
            // 
            TestTimer.Enabled = true;
            TestTimer.Tick += TestTimer_Tick;
            // 
            // Math
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(outputBox1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(inputBox2);
            Controls.Add(inputBox1);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(722, 275);
            MinimumSize = new Size(722, 275);
            Name = "Math";
            Size = new Size(720, 273);
            Load += Math_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private InputBox inputBox1;
        private InputBox inputBox2;
        private Label label1;
        private ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private OutputBox outputBox1;
        private System.Windows.Forms.Timer TestTimer;
    }
}
