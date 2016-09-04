using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Case
{
    class Image
    {
        private string Naam;
        private int BeginX;
        private int BeginY;
        private int EindX;
        private int EindY;
        public Image(string naam, int beginx, int beginy, int eindx, int eindy)
        {
            Naam = naam;
            BeginX = beginx;
            BeginY = beginy;
            EindX = eindx;
            EindY = eindy;
        }

        public Image(string naam, int beginx, int beginy)
        {
            Naam = naam;
            BeginX = beginx;
            BeginY = beginy;
            EindX = beginx;
            EindY = beginy;
        }
    }
}