namespace CVForms.Controls
{
    partial class cvImageBox
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
            label1 = new Label();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)imageBox1).BeginInit();
            SuspendLayout();
            // 
            // imageBox1
            // 
            imageBox1.BorderStyle = BorderStyle.FixedSingle;
            imageBox1.Location = new Point(14, 102);
            imageBox1.Name = "imageBox1";
            imageBox1.Size = new Size(251, 255);
            imageBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox1.TabIndex = 2;
            imageBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 65);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(171, 19);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Open File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // cvImageBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(imageBox1);
            Name = "cvImageBox";
            Size = new Size(277, 371);
            ((System.ComponentModel.ISupportInitialize)imageBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private Label label1;
        private Button button1;
        private OpenFileDialog openFileDialog1;
    }
}
