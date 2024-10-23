using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachininigCalculatorLibary
{
    public class ToolMilling : BaseRotatingTool
    {
        //inputs
        public int numberOfTeeth { get; set; }
        public double feedRatePerTooth { get; set; }

        public double millingWidth { get; set; }
        public double millingDepth { get; set; }

        //outputs
        public double feedPerMinuteMilling { get; set; }

        public double volmetricEfficency { get; set; }

        public void CalculateFeedPerMinuteMilling(double feedRatePerTooth, int numberOfTeeth, int revolutions)
        {
            feedPerMinuteMilling = (int)(feedRatePerTooth * numberOfTeeth * revolutions);
        }

        public void CalculateVolmetricEfficency(double feedPerMinuteMilling, double millingWidth, double millingDepth)
        {
            volmetricEfficency = (int)(feedPerMinuteMilling * millingWidth * millingDepth / 1000);
        }
    }
}
