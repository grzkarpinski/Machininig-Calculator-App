using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MachininigCalculatorLibary;

namespace MachiningCalculatorTests
{
    public class ToolMillingTests
    {
        [Fact]
        public void CalculateFeedPerMinuteMillingTest()
        {
            //Arrange
            ToolMilling toolMilling = new ToolMilling();
            toolMilling.feedRatePerTooth = 0.1;
            toolMilling.numberOfTeeth = 2;
            int revolutions = 1000;

            //Act
            toolMilling.CalculateFeedPerMinuteMilling(toolMilling.feedRatePerTooth, toolMilling.numberOfTeeth, revolutions);

            //Assert
            Assert.Equal(200, toolMilling.feedPerMinuteMilling);
        }

        [Fact]
        public void CalculateVolmetricEfficencyTest()
        {
            //Arrange
            ToolMilling toolMilling = new ToolMilling();
            toolMilling.feedPerMinuteMilling = 200;
            toolMilling.millingWidth = 10;
            toolMilling.millingDepth = 5;

            //Act
            toolMilling.CalculateVolmetricEfficency(toolMilling.feedPerMinuteMilling, toolMilling.millingWidth, toolMilling.millingDepth);

            //Assert
            Assert.Equal(10, toolMilling.volmetricEfficency);
        }
    }
}
