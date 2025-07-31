namespace CoolProject.Controls
{
    partial class InputBox
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
            imageBox1 = new Emgu.CV.UI.ImageBox();
            openFileDialog1 = new OpenFileDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)imageBox1).BeginInit();
            SuspendLayout();
            // 
            // imageBox1
            // 
            imageBox1.BorderStyle = BorderStyle.FixedSingle;
            imageBox1.Location = new Point(17, 55);
            imageBox1.Name = "imageBox1";
            imageBox1.Size = new Size(185, 195);
            imageBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox1.TabIndex = 2;
            imageBox1.TabStop = false;
            imageBox1.Click += imageBox1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(130, 20);
            button1.Name = "button1";
            button1.Size = new Size(72, 29);
            button1.TabIndex = 6;
            button1.Text = "Get";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(107, 28);
            comboBox1.TabIndex = 7;
            comboBox1.DropDown += comboBox1_DropDown;
            comboBox1.DropDownClosed += comboBox1_DropDownClosed;
            // 
            // InputBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(imageBox1);
            MaximumSize = new Size(216, 274);
            MinimumSize = new Size(216, 274);
            Name = "InputBox";
            Size = new Size(214, 272);
            Load += InputBox_Load;
            ((System.ComponentModel.ISupportInitialize)imageBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private ComboBox comboBox1;
    }
}
