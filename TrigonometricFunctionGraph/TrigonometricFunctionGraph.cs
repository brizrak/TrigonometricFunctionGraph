using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrigonometricFunctionGraph
{
	class TrigonometricFunctionGraph
	{
		public double A;
		public double B;
		public Int32[] interval = new Int32[] { 0, 0 };
		public UInt32 amount_of_points;

		public TrigonometricFunctionGraph()
		{

		}

		public bool DataInput(string A, string B, string small_a, string small_b, string amount_of_points, byte radio_checker)
		{

			if (A == "" || B == "" || small_a == "" || small_b == "" || amount_of_points == "" || radio_checker == 2)
			{
				MessageBox.Show(
					"Заполнены не все поля",
					"Ошибка",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);

				return false;
			}

			try
			{
				this.A = Convert.ToDouble(A);
				this.B = Convert.ToDouble(B);

				if (radio_checker == 0)
				{
					this.interval[0] = (int)(Convert.ToDouble(small_a) / 57.2956);
					this.interval[1] = (int)(Convert.ToDouble(small_b) / 57.2956);
				}
				else
				{
					this.interval[0] = Convert.ToInt32(small_a);
					this.interval[1] = Convert.ToInt32(small_b);
				}

				this.amount_of_points = Convert.ToUInt32(amount_of_points);
			}
			catch (System.FormatException)
			{
				MessageBox.Show(
					"Введены некорректные данные",
					"Ошибка",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
				return false;
			}

			return true;
		}

		public void GraphDraw(PictureBox GraphPictureBox)
		{
			Graphics graphics = GraphPictureBox.CreateGraphics();
			Pen pen = new Pen(Color.DodgerBlue, 3f);
			Point[] points = new Point[this.amount_of_points];

			int step = (int)((this.interval[1] - this.interval[0]) / this.amount_of_points);
			int j = this.interval[0];

			for (int i = 0; i < points.Length; i += 1, j += step)
			{
				points[i] = new Point(j, (int)(this.A * Math.Sin(this.B * (double)j / 50) * 70 + 260));
			}

			graphics.DrawLines(pen, points);
		}
	}
}
