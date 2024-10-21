using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachininigCalculatorLibary
{
    public class ToolDrilling: BaseRotatingTool
    {
        //inputs
        public double feedRatePerRevolution { get; set; }

        //outputs
        public int feedPerMinuteDrilling { get; set; }

        public void CalculateFeedPerMinuteDrilling(double feedRatePerRevolution, int revolutions)
        {
            feedPerMinuteDrilling = (int)(feedRatePerRevolution * revolutions);
        }
    }
}
