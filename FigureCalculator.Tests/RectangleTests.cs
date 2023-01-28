using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator.Tests
{
	public class RectangleTests
	{
		[Fact]
		public void Rectangle_Area_ReturnsDouble()
		{
			//Arrange
			Rectangle rect = new(2, 3);
			//Act
			var area = rect.Area();
			//Assert
			area.Should().BeOfType(typeof(double));
			area.Should().Be(6);
		}
	}
}
