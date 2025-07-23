namespace CVForms.Controls
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            cvImageBox1 = new cvImageBox();
            cvImageBox2 = new cvImageBox();
            imageBox1 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)imageBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AND", "OR", "XOR" });
            comboBox1.Location = new Point(387, 187);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(128, 28);
            comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(932, 187);
            button1.Name = "button1";
            button1.Size = new Size(85, 79);
            button1.TabIndex = 4;
            button1.Text = "=";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // cvImageBox1
            // 
            cvImageBox1.BorderStyle = BorderStyle.FixedSingle;
            cvImageBox1.Location = new Point(32, 25);
            cvImageBox1.Name = "cvImageBox1";
            cvImageBox1.Size = new Size(281, 371);
            cvImageBox1.TabIndex = 5;
            // 
            // cvImageBox2
            // 
            cvImageBox2.BorderStyle = BorderStyle.FixedSingle;
            cvImageBox2.Location = new Point(588, 25);
            cvImageBox2.Name = "cvImageBox2";
            cvImageBox2.Size = new Size(281, 371);
            cvImageBox2.TabIndex = 6;
            // 
            // imageBox1
            // 
            imageBox1.BorderStyle = BorderStyle.FixedSingle;
            imageBox1.Location = new Point(1076, 109);
            imageBox1.Name = "imageBox1";
            imageBox1.Size = new Size(269, 287);
            imageBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox1.TabIndex = 2;
            imageBox1.TabStop = false;
            // 
            // Math
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(imageBox1);
            Controls.Add(cvImageBox2);
            Controls.Add(cvImageBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name = "Math";
            Size = new Size(1388, 451);
            Load += Math_Load;
            ((System.ComponentModel.ISupportInitialize)imageBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBox1;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private cvImageBox cvImageBox1;
        private cvImageBox cvImageBox2;
        private Emgu.CV.UI.ImageBox imageBox1;
    }
}
