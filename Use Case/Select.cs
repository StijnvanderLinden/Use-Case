using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Case
{
    class Select
    {
        private List<List<int>> lijnen = new List<List<int>>();

        public Select()
        {
        }
        public List<List<int>> Lijnen
        {
            get
            {
                return lijnen;
            }

            set
            {
                lijnen = value;
            }
        }
        //public int SelectLijn(int x1, int y2)
        //{
        //    foreach(List<int> list in lijnen)
        //    {
                
        //    }
        //}
    }
}
