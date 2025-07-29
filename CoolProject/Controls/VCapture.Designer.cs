namespace CoolProject.Controls
{
    partial class VCapture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VCapture));
            imageBox1 = new Emgu.CV.UI.ImageBox();
            outputBox1 = new OutputBox();
            button1 = new Button();
            slider1 = new Slider();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)imageBox1).BeginInit();
            SuspendLayout();
            // 
            // imageBox1
            // 
            imageBox1.BorderStyle = BorderStyle.FixedSingle;
            imageBox1.Location = new Point(22, 23);
            imageBox1.Name = "imageBox1";
            imageBox1.Size = new Size(294, 206);
            imageBox1.SizeMode = PictureBoxSizeMode.Zoom;
            imageBox1.TabIndex = 2;
            imageBox1.TabStop = false;
            // 
            // outputBox1
            // 
            outputBox1.BorderStyle = BorderStyle.FixedSingle;
            outputBox1.CurrentImage = (Emgu.CV.Mat)resources.GetObject("outputBox1.CurrentImage");
            outputBox1.Location = new Point(351, 23);
            outputBox1.Name = "outputBox1";
            outputBox1.Size = new Size(189, 206);
            outputBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(423, 250);
            button1.Name = "button1";
            button1.Size = new Size(117, 38);
            button1.TabIndex = 4;
            button1.Text = "Capture Frame";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // slider1
            // 
            slider1.BorderStyle = BorderStyle.FixedSingle;
            slider1.Location = new Point(22, 250);
            slider1.MaximumSize = new Size(219, 78);
            slider1.MaxValue = 50;
            slider1.MinimumSize = new Size(219, 78);
            slider1.MinValue = -50;
            slider1.Name = "slider1";
            slider1.Size = new Size(219, 78);
            slider1.TabIndex = 5;
            slider1.Title = "Exposure";
            slider1.Value = -5;
            slider1.InputChanged += slider1_InputChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(295, 261);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "VideoCapture";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // VCapture
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(checkBox1);
            Controls.Add(slider1);
            Controls.Add(button1);
            Controls.Add(outputBox1);
            Controls.Add(imageBox1);
            MaximumSize = new Size(584, 345);
            MinimumSize = new Size(584, 345);
            Name = "VCapture";
            Size = new Size(582, 343);
            Load += VCapture_Load;
            ((System.ComponentModel.ISupportInitialize)imageBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private OutputBox outputBox1;
        private Button button1;
        private Slider slider1;
        private CheckBox checkBox1;
    }
}
