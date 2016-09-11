using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Use_Case
{
    class Lijn
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        private Point midpunt;

        public int X1 { get { return x1; } }

        public int Y1 { get { return y1; } }

        public int X2 { get { return x2; } }

        public int Y2 { get { return y2; } }
        
        public Point Midpunt { get { return midpunt; } }
        public Lijn(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            midpunt = BerekenMiddelpunt(x1, y1, x2, y2);
        }

        public Point BerekenMiddelpunt(int x1, int y1, int x2, int y2)
        {
            int midx = (x2 + x1) / 2;
            int midy = (y2 + y1) / 2;
            Point midpunt = new Point(midx, midy);
            return midpunt;
        }
    }
}