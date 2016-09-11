using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Use_Case
{
    class Select
    {
        private List<List<int>> lijnen = new List<List<int>>();
        private List<Point> middelpunten = new List<Point>();
        private int x;
        private int y;
        private int currenti;
        public Select()
        {
            
        }
        public List<List<int>> Lijnen { get { return lijnen; } }
        public List<Point> Middelpunten { get { return middelpunten; } }

        public int SelectLijn(int x1, int y1)
        {
            int closestLine = 1000;
            double currentLine;
            bool range = false;
            int i = 0;
            foreach (Point point in middelpunten)
            {
                x = point.X - x1;
                y = point.Y - y1;
                if (x < 0)
                {
                    x = x * (-1);
                }
                if (y < 0)
                {
                    y = y * (-1);
                }

                currentLine = Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2));
                if (currentLine < 30)
                {
                    if (currentLine < closestLine)
                    {
                        closestLine = Convert.ToInt32(currentLine);
                        currenti = i;
                        range = true;
                    }
                }
                i++;
            }
            if (!range)
            {
                return lijnen.Count();
            }
            else
            {
                return currenti;
            }
            
        }
    }
}