namespace FigureCalculator
{
	public class Figure : IFigure
	{
		private readonly double _dimension;
		public Figure(double dimension)
		{
			_dimension = dimension;
		}
		public virtual double Area()
		{
			return 0;
		}
	}
}