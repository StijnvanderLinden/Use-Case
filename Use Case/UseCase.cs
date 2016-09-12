using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Use_Case
{
    class Usecase
    {
        private string naam;
        private string samenvatting;
        private string actor;
        private string aannamen;
        private string beschrijving;
        private string uitzonderingen;
        private string resultaat;
        private Point point1;
        private Point point2;

        public string Naam { get { return naam; } set { naam = value; } }
        public string Samenvatting { get { return samenvatting; } set { samenvatting = value; } }
        public string Actor { get { return actor; } set { actor = value; } }
        public string Aannamen { get { return aannamen; } set { aannamen = value; } }
        public string Beschrijving { get { return beschrijving; } set { beschrijving = value; } }
        public string Uitzonderingen { get { return uitzonderingen; } set { uitzonderingen = value; } }
        public string Resultaat { get { return resultaat; } set { resultaat = value; } }
        public Point Point1 { get { return point1; } set { point1 = value; } }
        public Point Point2 { get { return point2; } set { point2 = value; } }

        public Usecase(string naam, string samenvatting, string actor, string aannamen, string beschrijving, string uitzonderingen, string resultaat, Point point1, Point point2)
        {
            this.naam = naam;
            this.samenvatting = samenvatting;
            this.actor = actor;
            this.aannamen = aannamen;
            this.beschrijving = beschrijving;
            this.uitzonderingen = uitzonderingen;
            this.resultaat = resultaat;
            this.point1 = point1;
            this.point2 = point2;
        }
    }

    
}
