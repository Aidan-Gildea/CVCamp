namespace CoolProject.Controls
{
    partial class DilateErode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DilateErode));
            inputBox1 = new InputBox();
            outputBox1 = new OutputBox();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // inputBox1
            // 
            inputBox1.BorderStyle = BorderStyle.FixedSingle;
            inputBox1.CurrentImage = (Emgu.CV.Mat)resources.GetObject("inputBox1.CurrentImage");
            inputBox1.Location = new Point(17, 14);
            inputBox1.Margin = new Padding(3, 2, 3, 2);
            inputBox1.MaximumSize = new Size(189, 206);
            inputBox1.MinimumSize = new Size(189, 206);
            inputBox1.myParent = null;
            inputBox1.Name = "inputBox1";
            inputBox1.Size = new Size(189, 206);
            inputBox1.TabIndex = 0;
            // 
            // outputBox1
            // 
            outputBox1.BorderStyle = BorderStyle.FixedSingle;
            outputBox1.CurrentImage = (Emgu.CV.Mat)resources.GetObject("outputBox1.CurrentImage");
            outputBox1.Location = new Point(315, 13);
            outputBox1.myParent = null;
            outputBox1.Name = "outputBox1";
            outputBox1.Size = new Size(189, 207);
            outputBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(212, 106);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(97, 23);
            comboBox1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Location = new Point(212, 77);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(34, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // DilateErode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            Controls.Add(outputBox1);
            Controls.Add(inputBox1);
            MaximumSize = new Size(521, 234);
            MinimumSize = new Size(521, 234);
            Name = "DilateErode";
            Size = new Size(519, 232);
            Load += DilateErode_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private InputBox inputBox1;
        private OutputBox outputBox1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
    }
}
