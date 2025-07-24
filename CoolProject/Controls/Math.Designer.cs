namespace CoolProject.Controls
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
            selectionBox1 = new SelectionBox();
            selectionBox2 = new SelectionBox();
            selectionBox3 = new SelectionBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // selectionBox1
            // 
            selectionBox1.BorderStyle = BorderStyle.FixedSingle;
            selectionBox1.Location = new Point(19, 18);
            selectionBox1.MaximumSize = new Size(218, 276);
            selectionBox1.MinimumSize = new Size(218, 276);
            selectionBox1.Name = "selectionBox1";
            selectionBox1.Size = new Size(218, 276);
            selectionBox1.TabIndex = 0;
            // 
            // selectionBox2
            // 
            selectionBox2.BorderStyle = BorderStyle.FixedSingle;
            selectionBox2.Location = new Point(264, 18);
            selectionBox2.MaximumSize = new Size(218, 276);
            selectionBox2.MinimumSize = new Size(218, 276);
            selectionBox2.Name = "selectionBox2";
            selectionBox2.Size = new Size(218, 276);
            selectionBox2.TabIndex = 1;
            // 
            // selectionBox3
            // 
            selectionBox3.BorderStyle = BorderStyle.FixedSingle;
            selectionBox3.Location = new Point(584, 18);
            selectionBox3.MaximumSize = new Size(218, 276);
            selectionBox3.MinimumSize = new Size(218, 276);
            selectionBox3.Name = "selectionBox3";
            selectionBox3.Size = new Size(218, 276);
            selectionBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(505, 126);
            label1.Name = "label1";
            label1.Size = new Size(56, 60);
            label1.TabIndex = 3;
            label1.Text = "=";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(354, 319);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
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
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(selectionBox3);
            Controls.Add(selectionBox2);
            Controls.Add(selectionBox1);
            MaximumSize = new Size(825, 366);
            MinimumSize = new Size(825, 366);
            Name = "Math";
            Size = new Size(823, 364);
            Load += Math_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SelectionBox selectionBox1;
        private SelectionBox selectionBox2;
        private SelectionBox selectionBox3;
        private Label label1;
        private ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
