﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MachininigCalculatorLibary;

namespace MachiningCalculatorTests
{
    public class ToolDrillingTests
    {

        [Fact]
        public void CalculateFeedPerMinuteDrillingTest()
        {
            //Arrange
            ToolDrilling toolDrilling = new ToolDrilling();
            toolDrilling.FeedRatePerRevolution = 0.1;
            int revolutions = 100;

            //Act
            toolDrilling.CalculateFeedPerMinuteDrilling(toolDrilling.FeedRatePerRevolution, revolutions);

            //Assert
            Assert.Equal(10, toolDrilling.FeedPerMinuteDrilling);
        }
    }
}
