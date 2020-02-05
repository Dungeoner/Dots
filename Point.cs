using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dots
{
    struct Point
    {
        private int _CoordX;
        private int _CoordY;
        public int CoordX
        {
            get
            {
                return _CoordX;
            }
            set
            {
                _CoordX = value;
            }
        }
        public int CoordY
        {
            get
            {
                return _CoordY;
            }
            set
            {
                _CoordY = value;
            }
        }

    }
}
