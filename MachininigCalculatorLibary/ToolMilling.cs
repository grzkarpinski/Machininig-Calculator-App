using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachininigCalculatorLibary
{
    public class ToolMilling : BaseRotatingTool
    {
        public int NumberOfTeeth { get; set; }
        public double FeedRatePerTooth { get; set; }

        public double MillingWidth { get; set; }
        public double MillingDepth { get; set; }

        public double FeedPerMinuteMilling { get; set; }

        public double VolmetricEfficency { get; set; }

        public void CalculateFeedPerMinuteMilling(double feedRatePerTooth, int numberOfTeeth, int revolutions)
        {
            FeedPerMinuteMilling = (int)(feedRatePerTooth * numberOfTeeth * revolutions);
        }

        public void CalculateVolmetricEfficency(double feedPerMinuteMilling, double millingWidth, double millingDepth)
        {
            VolmetricEfficency = (int)(feedPerMinuteMilling * millingWidth * millingDepth / 1000);
        }
    }
}
