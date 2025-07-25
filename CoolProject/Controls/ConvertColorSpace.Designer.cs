namespace CoolProject.Controls
{
    partial class ConvertColorSpace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertColorSpace));
            inputBox1 = new InputBox();
            outputBox1 = new OutputBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // inputBox1
            // 
            inputBox1.BorderStyle = BorderStyle.FixedSingle;
            inputBox1.CurrentImage = (Emgu.CV.Mat)resources.GetObject("inputBox1.CurrentImage");
            inputBox1.Location = new Point(18, 18);
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
            outputBox1.Location = new Point(356, 18);
            outputBox1.Name = "outputBox1";
            outputBox1.Size = new Size(189, 206);
            outputBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(52, 238);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(394, 238);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(247, 110);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 4;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // ConvertColorSpace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(outputBox1);
            Controls.Add(inputBox1);
            MaximumSize = new Size(569, 283);
            MinimumSize = new Size(569, 283);
            Name = "ConvertColorSpace";
            Size = new Size(567, 281);
            Load += ConvertColorSpace_Load;
            ResumeLayout(false);
        }

        #endregion

        private InputBox inputBox1;
        private OutputBox outputBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}
