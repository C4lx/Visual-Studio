using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace cobra
{
    class Food
    {
        public Point Location { get; private set; }

        public void CreateFood()
        {
            Random rnd = new Random();
            Location = new Point(rnd.Next(0, 27), rnd.Next(0, 27));
        }
    }
}
