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
            imageBox1 = new ImageBox();
            comboBox1 = new ComboBox();
            imageBox2 = new ImageBox();
            imageBox3 = new ImageBox();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // imageBox1
            // 
            imageBox1.BorderStyle = BorderStyle.FixedSingle;
            imageBox1.Location = new Point(18, 17);
            imageBox1.Name = "imageBox1";
            imageBox1.Size = new Size(339, 385);
            imageBox1.TabIndex = 0;
            imageBox1.TextIsEnabled = false;
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
            // imageBox2
            // 
            imageBox2.BorderStyle = BorderStyle.FixedSingle;
            imageBox2.Location = new Point(540, 17);
            imageBox2.Name = "imageBox2";
            imageBox2.Size = new Size(337, 385);
            imageBox2.TabIndex = 2;
            imageBox2.TextIsEnabled = false;
            // 
            // imageBox3
            // 
            imageBox3.BorderStyle = BorderStyle.FixedSingle;
            imageBox3.Location = new Point(1048, 17);
            imageBox3.Name = "imageBox3";
            imageBox3.Size = new Size(338, 385);
            imageBox3.TabIndex = 3;
            imageBox3.TextIsEnabled = false;
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
            // Math
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(imageBox3);
            Controls.Add(imageBox2);
            Controls.Add(comboBox1);
            Controls.Add(imageBox1);
            Name = "Math";
            Size = new Size(1482, 573);
            Load += Math_Load;
            ResumeLayout(false);
        }

        #endregion

        private ImageBox imageBox1;
        private ComboBox comboBox1;
        private ImageBox imageBox2;
        private ImageBox imageBox3;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}
