namespace CoolProject
{
    partial class MainForm
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
            math1 = new CoolProject.Controls.Math();
            SuspendLayout();
            // 
            // math1
            // 
            math1.BorderStyle = BorderStyle.FixedSingle;
            math1.Location = new Point(12, 10);
            math1.Margin = new Padding(3, 2, 3, 2);
            math1.MaximumSize = new Size(722, 275);
            math1.MinimumSize = new Size(722, 275);
            math1.Name = "math1";
            math1.Size = new Size(722, 275);
            math1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 296);
            Controls.Add(math1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Controls.Math math1;
    }
}
