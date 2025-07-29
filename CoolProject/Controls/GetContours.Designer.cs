namespace CoolProject.Controls
{
    partial class GetContours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetContours));
            inputBox1 = new InputBox();
            inputBox2 = new InputBox();
            outputBox1 = new OutputBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // inputBox1
            // 
            inputBox1.BorderStyle = BorderStyle.FixedSingle;
            inputBox1.CurrentImage = (Emgu.CV.Mat)resources.GetObject("inputBox1.CurrentImage");
            inputBox1.Location = new Point(14, 16);
            inputBox1.Margin = new Padding(3, 2, 3, 2);
            inputBox1.MaximumSize = new Size(189, 206);
            inputBox1.MinimumSize = new Size(189, 206);
            inputBox1.Name = "inputBox1";
            inputBox1.Size = new Size(189, 206);
            inputBox1.TabIndex = 0;
            // 
            // inputBox2
            // 
            inputBox2.BorderStyle = BorderStyle.FixedSingle;
            inputBox2.CurrentImage = (Emgu.CV.Mat)resources.GetObject("inputBox2.CurrentImage");
            inputBox2.Location = new Point(234, 16);
            inputBox2.Margin = new Padding(3, 2, 3, 2);
            inputBox2.MaximumSize = new Size(189, 206);
            inputBox2.MinimumSize = new Size(189, 206);
            inputBox2.Name = "inputBox2";
            inputBox2.Size = new Size(189, 206);
            inputBox2.TabIndex = 1;
            // 
            // outputBox1
            // 
            outputBox1.BorderStyle = BorderStyle.FixedSingle;
            outputBox1.CurrentImage = (Emgu.CV.Mat)resources.GetObject("outputBox1.CurrentImage");
            outputBox1.Location = new Point(495, 16);
            outputBox1.Name = "outputBox1";
            outputBox1.Size = new Size(189, 206);
            outputBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(495, 262);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(189, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(495, 244);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 4;
            label1.Text = "ChainApproxMethods";
            // 
            // button1
            // 
            button1.Location = new Point(59, 304);
            button1.Name = "button1";
            button1.Size = new Size(89, 23);
            button1.TabIndex = 5;
            button1.Text = "ChooseColor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(120, 337);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(42, 23);
            numericUpDown1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 340);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 7;
            label2.Text = "Thickness";
            // 
            // button2
            // 
            button2.Location = new Point(545, 333);
            button2.Name = "button2";
            button2.Size = new Size(89, 23);
            button2.TabIndex = 8;
            button2.Text = "GetContours";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(438, 102);
            label3.Name = "label3";
            label3.Size = new Size(40, 32);
            label3.TabIndex = 9;
            label3.Text = "->";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 244);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 11;
            label5.Text = "input";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(290, 244);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 12;
            label6.Text = "background";
            // 
            // GetContours
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(outputBox1);
            Controls.Add(inputBox2);
            Controls.Add(inputBox1);
            Name = "GetContours";
            Size = new Size(704, 405);
            Load += GetContours_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private InputBox inputBox1;
        private InputBox inputBox2;
        private OutputBox outputBox1;
        private ComboBox comboBox1;
        private Label label1;
        private ColorDialog colorDialog1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Button button2;
        private Label label3;
        private Label label5;
        private Label label6;
    }
}
