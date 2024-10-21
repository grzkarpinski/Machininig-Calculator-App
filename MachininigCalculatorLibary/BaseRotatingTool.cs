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
        public int toolDiameter { get; set; }
        public int cuttingSpeed { get; set; }

        //outputs
        public int revolutions { get; set; }
        public int feed { get; set; }

        public void CalculateRevolutionsPerMinute( int Vc, int D)
        {
            revolutions = (int)Math.Round(1000 * Vc / (Math.PI * D));
        }
    }
}
