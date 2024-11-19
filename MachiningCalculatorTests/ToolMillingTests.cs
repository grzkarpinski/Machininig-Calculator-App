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
            toolMilling.FeedRatePerTooth = 0.1;
            toolMilling.NumberOfTeeth = 2;
            int revolutions = 1000;

            //Act
            toolMilling.CalculateFeedPerMinuteMilling(toolMilling.FeedRatePerTooth, toolMilling.NumberOfTeeth, revolutions);

            //Assert
            Assert.Equal(200, toolMilling.FeedPerMinuteMilling);
        }

        [Fact]
        public void CalculateVolmetricEfficencyTest()
        {
            //Arrange
            ToolMilling toolMilling = new ToolMilling();
            toolMilling.FeedPerMinuteMilling = 200;
            toolMilling.MillingWidth = 10;
            toolMilling.MillingDepth = 5;

            //Act
            toolMilling.CalculateVolmetricEfficency(toolMilling.FeedPerMinuteMilling, toolMilling.MillingWidth, toolMilling.MillingDepth);

            //Assert
            Assert.Equal(10, toolMilling.VolmetricEfficency);
        }
    }
}
