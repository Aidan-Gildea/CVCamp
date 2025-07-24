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
            imageBox1.Location = new Point(15, 41);
            imageBox1.Margin = new Padding(3, 2, 3, 2);
            imageBox1.Name = "imageBox1";
            imageBox1.Size = new Size(162, 147);
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
            button1.Location = new Point(114, 15);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(63, 22);
            button1.TabIndex = 6;
            button1.Text = "Get";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(14, 14);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(94, 23);
            comboBox1.TabIndex = 7;
            comboBox1.DropDown += comboBox1_DropDown;
            comboBox1.DropDownClosed += comboBox1_DropDownClosed;
            // 
            // InputBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(imageBox1);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(189, 206);
            MinimumSize = new Size(189, 206);
            Name = "InputBox";
            Size = new Size(187, 204);
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
