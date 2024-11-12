using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MachininigCalculatorLibary;

namespace MachiningCalculatorTests
{
    public class BaseRotatingToolTests
    {
        [Fact]
        public void CalculateRevolutionsPerMinuteTest()
        {
            // Arrange
            BaseRotatingTool tool = new BaseRotatingTool();
            tool.cuttingSpeed = 200;
            tool.toolDiameter = 50;

            // Act
            tool.CalculateRevolutionsPerMinute(tool.cuttingSpeed, tool.toolDiameter);

            // Assert
            Assert.Equal(1273, tool.revolutions);
        }

        [Fact]
        public void CalculateRevolutionsPerMinuteDiameterIsDouble()
        {
            // Arrange
            BaseRotatingTool tool = new BaseRotatingTool();
            tool.cuttingSpeed = 200;
            tool.toolDiameter = 20.5;

            // Act
            tool.CalculateRevolutionsPerMinute(tool.cuttingSpeed, tool.toolDiameter);

            // Assert
            Assert.Equal(3105, tool.revolutions);
        }
    }
}
