using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator
{
	public class Rectangle : Figure
	{
		private readonly double _length;
		private readonly double _width;
		public Rectangle(double length, double width) : base(0)
		{
			_length = length;
			_width = width;
		}
		public override double Area()
		{
			return _length * _width;
		}
	}
}
