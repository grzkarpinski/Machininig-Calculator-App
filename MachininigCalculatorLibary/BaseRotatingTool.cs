using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachininigCalculatorLibary
{
    public class BaseRotatingTool
    {
        //inputs
        public double ToolDiameter { get; set; }
        public int CuttingSpeed { get; set; }

        //outputs
        public int Revolutions { get; set; }
        public int Feed { get; set; }

        public void CalculateRevolutionsPerMinute( int cuttingSpeed, double toolDiameter)
        {
            Revolutions = (int)Math.Round(1000 * cuttingSpeed / (Math.PI * toolDiameter));
        }
    }
}
