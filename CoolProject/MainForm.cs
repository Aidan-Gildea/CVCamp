using CoolProject.Controls;

namespace CoolProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Add(new Controls.Math());
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string val = Microsoft.VisualBasic.Interaction.InputBox("Please enter deletion index", "Delete", "Default value", -1, -1);
            if (!string.IsNullOrEmpty(val))
            {
                if (int.TryParse(val, out int index) && index >= 0 && index < flowLayoutPanel2.Controls.Count)
                {
                    flowLayoutPanel2.Controls.RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("Invalid index. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Add(new Controls.InRange());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Add(new Controls.ConvertColorSpace());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Add(new Controls.BlurOperation());
        }
    }
}
