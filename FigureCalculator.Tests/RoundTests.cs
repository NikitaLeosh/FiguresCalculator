using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator.Tests
{
	public class RoundTests
	{
		[Fact]
		public void Round_Area_ReturnsDouble()
		{
			//Arrange
			Round round = new(4);
			//Act
			var area = round.Area();
			//Assert
			area.Should().BeOfType(typeof(double));
			area.Should().BeApproximately(50.27, 0.4);
		}
	}
}
