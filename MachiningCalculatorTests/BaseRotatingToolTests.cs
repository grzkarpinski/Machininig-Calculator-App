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
            tool.CuttingSpeed = 200;
            tool.ToolDiameter = 50;

            // Act
            tool.CalculateRevolutionsPerMinute(tool.CuttingSpeed, tool.ToolDiameter);

            // Assert
            Assert.Equal(1273, tool.Revolutions);
        }

        [Fact]
        public void CalculateRevolutionsPerMinuteDiameterIsDouble()
        {
            // Arrange
            BaseRotatingTool tool = new BaseRotatingTool();
            tool.CuttingSpeed = 200;
            tool.ToolDiameter = 20.5;

            // Act
            tool.CalculateRevolutionsPerMinute(tool.CuttingSpeed, tool.ToolDiameter);

            // Assert
            Assert.Equal(3105, tool.Revolutions);
        }
    }
}
