using FigureCalculator;
using FluentAssertions;

namespace FigureCalculator.Tests
{
	public class TriangleTests
	{
		[Fact]
		public void Triangle_Area_returnsDouble()
		{
			//Arrange
			Triangle triangle = new(3, 4, 5);
			//Act
			var area = triangle.Area();
			//Assert
			area.Should().BeOfType(typeof(double));
			area.Should().BeApproximately(6, 0.5);
		}
		[Fact]
		public void Triangle_IsRight_returnsBool()
		{
			//Arrange
			Triangle triangleRight = new(3, 4, 5);
			Triangle triangleNotRight = new(4, 5, 6);
			//Act
			var resultRight = triangleRight.IsRight();
			var resultNotRight = triangleNotRight.IsRight();
			//Assert
			resultRight.Should().BeTrue();
			resultNotRight.Should().BeFalse();
		}
	}
}