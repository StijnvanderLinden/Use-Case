using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Case
{
    public partial class Form1 : Form
    {

        Graphics blad;
        Pen lijn;
        int i = 0;
        int x1, x2, y1, y2;
        public Form1()
        {
            InitializeComponent();
            blad = pictureBox.CreateGraphics();
            lijn = new Pen(Color.Black, 2);
            pictureBox.BackColor = Color.White;
        }
        
        private void pictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs muis = (MouseEventArgs)e;
            if (i == 0)
            {
                i++;
                x1 = muis.X;
                y1 = muis.Y;
            }
            else
            {
                i--;
                x2 = muis.X;
                y2 = muis.Y;
                blad.DrawLine(lijn, x1, y1, x2, y2);
            }
            
        }
    }
}
