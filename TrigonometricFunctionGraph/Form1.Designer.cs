namespace TrigonometricFunctionGraph
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.MainTable = new System.Windows.Forms.TableLayoutPanel();
			this.DataTable = new System.Windows.Forms.TableLayoutPanel();
			this.clean_button = new System.Windows.Forms.Button();
			this.TopLabel = new System.Windows.Forms.Label();
			this.ParameterPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.ParameterPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.A_label = new System.Windows.Forms.Label();
			this.B_label = new System.Windows.Forms.Label();
			this.A_textBox = new System.Windows.Forms.TextBox();
			this.B_textBox = new System.Windows.Forms.TextBox();
			this.parameter_label = new System.Windows.Forms.Label();
			this.IntervalPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.interval_label = new System.Windows.Forms.Label();
			this.IntervalRadioPanel = new System.Windows.Forms.TableLayoutPanel();
			this.degree_radioButton = new System.Windows.Forms.RadioButton();
			this.radian_radioButton = new System.Windows.Forms.RadioButton();
			this.IntervalPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.small_a_label = new System.Windows.Forms.Label();
			this.small_b_label = new System.Windows.Forms.Label();
			this.small_a_textBox = new System.Windows.Forms.TextBox();
			this.small_b_textBox = new System.Windows.Forms.TextBox();
			this.AmountOfPointsPanel = new System.Windows.Forms.TableLayoutPanel();
			this.amount_of_points_label = new System.Windows.Forms.Label();
			this.amount_of_points_textBox = new System.Windows.Forms.TextBox();
			this.done_button = new System.Windows.Forms.Button();
			this.GraphPictureBox = new System.Windows.Forms.PictureBox();
			this.MainTable.SuspendLayout();
			this.DataTable.SuspendLayout();
			this.ParameterPanel1.SuspendLayout();
			this.ParameterPanel2.SuspendLayout();
			this.IntervalPanel1.SuspendLayout();
			this.IntervalRadioPanel.SuspendLayout();
			this.IntervalPanel2.SuspendLayout();
			this.AmountOfPointsPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GraphPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// MainTable
			// 
			resources.ApplyResources(this.MainTable, "MainTable");
			this.MainTable.Controls.Add(this.DataTable, 1, 0);
			this.MainTable.Controls.Add(this.GraphPictureBox, 0, 0);
			this.MainTable.Name = "MainTable";
			// 
			// DataTable
			// 
			resources.ApplyResources(this.DataTable, "DataTable");
			this.DataTable.Controls.Add(this.clean_button, 0, 5);
			this.DataTable.Controls.Add(this.TopLabel, 0, 0);
			this.DataTable.Controls.Add(this.ParameterPanel1, 0, 1);
			this.DataTable.Controls.Add(this.IntervalPanel1, 0, 2);
			this.DataTable.Controls.Add(this.AmountOfPointsPanel, 0, 3);
			this.DataTable.Controls.Add(this.done_button, 0, 4);
			this.DataTable.Name = "DataTable";
			// 
			// clean_button
			// 
			resources.ApplyResources(this.clean_button, "clean_button");
			this.clean_button.Name = "clean_button";
			this.clean_button.UseVisualStyleBackColor = true;
			this.clean_button.Click += new System.EventHandler(this.clean_button_Click);
			// 
			// TopLabel
			// 
			resources.ApplyResources(this.TopLabel, "TopLabel");
			this.TopLabel.Name = "TopLabel";
			// 
			// ParameterPanel1
			// 
			resources.ApplyResources(this.ParameterPanel1, "ParameterPanel1");
			this.ParameterPanel1.Controls.Add(this.ParameterPanel2, 0, 1);
			this.ParameterPanel1.Controls.Add(this.parameter_label, 0, 0);
			this.ParameterPanel1.Name = "ParameterPanel1";
			// 
			// ParameterPanel2
			// 
			resources.ApplyResources(this.ParameterPanel2, "ParameterPanel2");
			this.ParameterPanel2.Controls.Add(this.A_label, 0, 0);
			this.ParameterPanel2.Controls.Add(this.B_label, 0, 1);
			this.ParameterPanel2.Controls.Add(this.A_textBox, 1, 0);
			this.ParameterPanel2.Controls.Add(this.B_textBox, 1, 1);
			this.ParameterPanel2.Name = "ParameterPanel2";
			// 
			// A_label
			// 
			resources.ApplyResources(this.A_label, "A_label");
			this.A_label.Name = "A_label";
			// 
			// B_label
			// 
			resources.ApplyResources(this.B_label, "B_label");
			this.B_label.Name = "B_label";
			// 
			// A_textBox
			// 
			resources.ApplyResources(this.A_textBox, "A_textBox");
			this.A_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.A_textBox.Name = "A_textBox";
			// 
			// B_textBox
			// 
			resources.ApplyResources(this.B_textBox, "B_textBox");
			this.B_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.B_textBox.Name = "B_textBox";
			// 
			// parameter_label
			// 
			resources.ApplyResources(this.parameter_label, "parameter_label");
			this.parameter_label.Name = "parameter_label";
			// 
			// IntervalPanel1
			// 
			resources.ApplyResources(this.IntervalPanel1, "IntervalPanel1");
			this.IntervalPanel1.Controls.Add(this.interval_label, 0, 0);
			this.IntervalPanel1.Controls.Add(this.IntervalRadioPanel, 0, 1);
			this.IntervalPanel1.Controls.Add(this.IntervalPanel2, 0, 2);
			this.IntervalPanel1.Name = "IntervalPanel1";
			// 
			// interval_label
			// 
			resources.ApplyResources(this.interval_label, "interval_label");
			this.interval_label.Name = "interval_label";
			// 
			// IntervalRadioPanel
			// 
			resources.ApplyResources(this.IntervalRadioPanel, "IntervalRadioPanel");
			this.IntervalRadioPanel.Controls.Add(this.degree_radioButton, 0, 0);
			this.IntervalRadioPanel.Controls.Add(this.radian_radioButton, 1, 0);
			this.IntervalRadioPanel.Name = "IntervalRadioPanel";
			// 
			// degree_radioButton
			// 
			resources.ApplyResources(this.degree_radioButton, "degree_radioButton");
			this.degree_radioButton.Name = "degree_radioButton";
			this.degree_radioButton.TabStop = true;
			this.degree_radioButton.UseVisualStyleBackColor = true;
			this.degree_radioButton.CheckedChanged += new System.EventHandler(this.degree_radioButton_CheckedChanged);
			// 
			// radian_radioButton
			// 
			resources.ApplyResources(this.radian_radioButton, "radian_radioButton");
			this.radian_radioButton.Name = "radian_radioButton";
			this.radian_radioButton.TabStop = true;
			this.radian_radioButton.UseVisualStyleBackColor = true;
			this.radian_radioButton.CheckedChanged += new System.EventHandler(this.radian_radioButton_CheckedChanged);
			// 
			// IntervalPanel2
			// 
			resources.ApplyResources(this.IntervalPanel2, "IntervalPanel2");
			this.IntervalPanel2.Controls.Add(this.small_a_label, 0, 0);
			this.IntervalPanel2.Controls.Add(this.small_b_label, 2, 0);
			this.IntervalPanel2.Controls.Add(this.small_a_textBox, 1, 0);
			this.IntervalPanel2.Controls.Add(this.small_b_textBox, 3, 0);
			this.IntervalPanel2.Name = "IntervalPanel2";
			// 
			// small_a_label
			// 
			resources.ApplyResources(this.small_a_label, "small_a_label");
			this.small_a_label.Name = "small_a_label";
			// 
			// small_b_label
			// 
			resources.ApplyResources(this.small_b_label, "small_b_label");
			this.small_b_label.Name = "small_b_label";
			// 
			// small_a_textBox
			// 
			resources.ApplyResources(this.small_a_textBox, "small_a_textBox");
			this.small_a_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.small_a_textBox.Name = "small_a_textBox";
			// 
			// small_b_textBox
			// 
			resources.ApplyResources(this.small_b_textBox, "small_b_textBox");
			this.small_b_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.small_b_textBox.Name = "small_b_textBox";
			// 
			// AmountOfPointsPanel
			// 
			resources.ApplyResources(this.AmountOfPointsPanel, "AmountOfPointsPanel");
			this.AmountOfPointsPanel.Controls.Add(this.amount_of_points_label, 0, 0);
			this.AmountOfPointsPanel.Controls.Add(this.amount_of_points_textBox, 0, 1);
			this.AmountOfPointsPanel.Name = "AmountOfPointsPanel";
			// 
			// amount_of_points_label
			// 
			resources.ApplyResources(this.amount_of_points_label, "amount_of_points_label");
			this.amount_of_points_label.Name = "amount_of_points_label";
			// 
			// amount_of_points_textBox
			// 
			resources.ApplyResources(this.amount_of_points_textBox, "amount_of_points_textBox");
			this.amount_of_points_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.amount_of_points_textBox.Name = "amount_of_points_textBox";
			// 
			// done_button
			// 
			resources.ApplyResources(this.done_button, "done_button");
			this.done_button.Name = "done_button";
			this.done_button.UseVisualStyleBackColor = true;
			this.done_button.Click += new System.EventHandler(this.done_button_Click);
			// 
			// GraphPictureBox
			// 
			resources.ApplyResources(this.GraphPictureBox, "GraphPictureBox");
			this.GraphPictureBox.Name = "GraphPictureBox";
			this.GraphPictureBox.TabStop = false;
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.MainTable);
			this.Name = "MainForm";
			this.MainTable.ResumeLayout(false);
			this.DataTable.ResumeLayout(false);
			this.DataTable.PerformLayout();
			this.ParameterPanel1.ResumeLayout(false);
			this.ParameterPanel1.PerformLayout();
			this.ParameterPanel2.ResumeLayout(false);
			this.ParameterPanel2.PerformLayout();
			this.IntervalPanel1.ResumeLayout(false);
			this.IntervalPanel1.PerformLayout();
			this.IntervalRadioPanel.ResumeLayout(false);
			this.IntervalRadioPanel.PerformLayout();
			this.IntervalPanel2.ResumeLayout(false);
			this.IntervalPanel2.PerformLayout();
			this.AmountOfPointsPanel.ResumeLayout(false);
			this.AmountOfPointsPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.GraphPictureBox)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private TableLayoutPanel MainTable;
		private TableLayoutPanel DataTable;
		private Label TopLabel;
		private TableLayoutPanel ParameterPanel2;
		private Label A_label;
		private Label B_label;
		private TextBox A_textBox;
		private TextBox B_textBox;
		private TableLayoutPanel ParameterPanel1;
		private Label parameter_label;
		private TableLayoutPanel IntervalPanel1;
		private Label interval_label;
		private TableLayoutPanel IntervalRadioPanel;
		private RadioButton degree_radioButton;
		private RadioButton radian_radioButton;
		private TableLayoutPanel IntervalPanel2;
		private Label small_a_label;
		private Label small_b_label;
		private TextBox small_a_textBox;
		private TextBox small_b_textBox;
		private TableLayoutPanel AmountOfPointsPanel;
		private Label amount_of_points_label;
		private TextBox amount_of_points_textBox;
		private Button done_button;
		private PictureBox GraphPictureBox;
		private Button clean_button;
	}
}