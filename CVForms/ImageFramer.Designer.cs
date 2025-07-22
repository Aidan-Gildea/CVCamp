namespace CVForms
{
    partial class ImageFramer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rotate1 = new Controls.Rotate();
            SuspendLayout();
            // 
            // rotate1
            // 
            rotate1.Location = new Point(12, 12);
            rotate1.Name = "rotate1";
            rotate1.Size = new Size(1162, 545);
            rotate1.TabIndex = 0;
            // 
            // ImageFramer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 461);
            Controls.Add(rotate1);
            Name = "ImageFramer";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Controls.Rotate rotate1;
    }
}
