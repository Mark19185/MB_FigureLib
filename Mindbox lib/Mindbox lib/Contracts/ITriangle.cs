using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox_lib.Contracts
{
    public interface ITriangle  
    {
        public List<double> Sides { get; }
        public bool IsRightTriangle();
        public bool IsRectangular();
    }
}
