using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator
{
	public class Triangle : Figure
	{
		private double[] sides;
		public Triangle(double ab, double bc, double ca) : base(0)
		{
			sides = new double[] { ab, bc, ca };
		}
		public override double Area()
		{
			//Find half-perimeter;
			double P = sides.Sum() / 2;
			//Find the triangle square using Heron's formula
			double result = Math.Sqrt(P * (P - sides[0]) * (P - sides[1]) * (P - sides[2]));
			return result;
		}
		public bool IsRight()
		{
			Array.Sort(sides);// locating the longest side to use it as hypotenuse of possible right triangle
			double HypotenuseSquared = Math.Round(Math.Pow(sides[2], 2), 5);
			double SumOfCatetsSquared = Math.Round(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2), 5);
			return HypotenuseSquared == SumOfCatetsSquared; // Decide if the triangle is right using Pyphagor's theorem.
		}
	}
}
