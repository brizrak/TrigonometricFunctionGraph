using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TrigonometricFunctionGraph
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Text = "Trigonometric Function Graph";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1000, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

		TrigonometricFunctionGraph graph = new TrigonometricFunctionGraph();
		byte radio_checker = 2;

		private void done_button_Click(object sender, EventArgs e)
		{
			if (graph.DataInput(this.A_textBox.Text, this.B_textBox.Text, this.small_a_textBox.Text, this.small_b_textBox.Text,
				this.amount_of_points_textBox.Text, this.radio_checker))
			{
				graph.GraphDraw(GraphPictureBox);
			}
		}

		private void degree_radioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.radio_checker = 0;
		}

		private void radian_radioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.radio_checker = 1;
		}

		private void clean_button_Click(object sender, EventArgs e)
		{
			GraphPictureBox.Image = null;
		}
	}
}