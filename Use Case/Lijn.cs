using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Case
{
    class Lijn
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        private List<int> middelpunt;

        public int X1
        {
            get
            {
                return x1;
            }
        }

        public int Y1
        {
            get
            {
                return y1;
            }
        }

        public int X2
        {
            get
            {
                return x2;
            }
        }

        public int Y2
        {
            get
            {
                return y2;
            }
        }

        public List<int> Middelpunt
        {
            get
            {
                return middelpunt;
            }

            set
            {
                middelpunt = value;
            }
        }

        public Lijn(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            middelpunt = BerekenMiddelpunt(x1, y1, x2, y2);
        }

        public List<int> BerekenMiddelpunt(int x1, int y1, int x2, int y2)
        {
            int midx = x2 - x1;
            int midy = y2 - y1;

            if(midx < 0)
            {
                midx = midx * (-1);
            }

            if(midy < 0)
            {
                midy = midy * (-1);
            }

            return new List<int> { midx, midy };
            
        }
    }
}
