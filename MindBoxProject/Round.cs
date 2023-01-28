using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator
{
	public class Round : Figure
	{
		private readonly double _radius;
		public Round(double radius) : base(radius)
		{
			_radius = radius;
		}
		public override double Area()
		{
			return Math.PI * Math.Pow(_radius, 2);
		}
	}
}
