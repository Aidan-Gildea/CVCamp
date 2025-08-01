namespace CoolProject.Controls
{
    partial class BlurOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlurOperation));
            outputBox1 = new OutputBox();
            inputBox1 = new InputBox();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // outputBox1
            // 
            outputBox1.BorderStyle = BorderStyle.FixedSingle;
            outputBox1.CurrentImage = (Emgu.CV.Mat)resources.GetObject("outputBox1.CurrentImage");
            outputBox1.Location = new Point(374, 15);
            outputBox1.Margin = new Padding(3, 5, 3, 5);
            outputBox1.myParent = this;
            outputBox1.Name = "outputBox1";
            outputBox1.Size = new Size(216, 274);
            outputBox1.TabIndex = 0;
            // 
            // inputBox1
            // 
            inputBox1.BorderStyle = BorderStyle.FixedSingle;
            inputBox1.CurrentImage = (Emgu.CV.Mat)resources.GetObject("inputBox1.CurrentImage");
            inputBox1.Location = new Point(26, 15);
            inputBox1.MaximumSize = new Size(216, 274);
            inputBox1.MinimumSize = new Size(216, 274);
            inputBox1.myParent = this;
            inputBox1.Name = "inputBox1";
            inputBox1.Size = new Size(216, 274);
            inputBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(256, 157);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(99, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Location = new Point(304, 119);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(49, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // BlurOperation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            Controls.Add(inputBox1);
            Controls.Add(outputBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BlurOperation";
            Size = new Size(608, 317);
            Load += BlurOperation_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OutputBox outputBox1;
        private InputBox inputBox1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer timer1;
    }
}
