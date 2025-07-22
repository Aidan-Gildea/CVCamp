namespace CVForms.Controls
{
    partial class Rotate
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
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // imageBox1
            // 
            imageBox1.BorderStyle = BorderStyle.FixedSingle;
            imageBox1.Location = new Point(22, 20);
            imageBox1.Name = "imageBox1";
            imageBox1.Size = new Size(340, 393);
            imageBox1.TabIndex = 0;
            imageBox1.TextIsEnabled = false;
            // 
            // comboBox1
            // 
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Rotate 90", "Rotate -90", "NOT", "Flip over X", "Flip over Y" });
            comboBox1.Location = new Point(387, 203);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // imageBox2
            // 
            imageBox2.BorderStyle = BorderStyle.FixedSingle;
            imageBox2.Location = new Point(562, 20);
            imageBox2.Name = "imageBox2";
            imageBox2.Size = new Size(339, 393);
            imageBox2.TabIndex = 2;
            imageBox2.TextIsEnabled = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Rotate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(imageBox2);
            Controls.Add(comboBox1);
            Controls.Add(imageBox1);
            Name = "Rotate";
            Size = new Size(930, 436);
            Load += Rotate_Load;
            ResumeLayout(false);
        }

        #endregion

        private ImageBox imageBox1;
        private ComboBox comboBox1;
        private ImageBox imageBox2;
        private System.Windows.Forms.Timer timer1;
    }
}
