using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachininigCalculatorLibary
{
    public class ToolDrilling: BaseRotatingTool
    {
        public double FeedRatePerRevolution { get; set; }

        public int FeedPerMinuteDrilling { get; set; }

        public void CalculateFeedPerMinuteDrilling(double feedRatePerRevolution, int revolutions)
        {
            FeedPerMinuteDrilling = (int)(feedRatePerRevolution * revolutions);
        }
    }
}
