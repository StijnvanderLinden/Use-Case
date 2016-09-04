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
        Pen p;
        int i = 0;
        int x1, x2, y1, y2;
        List<Image> Images = new List<Image>();

        public Form1()
        {
            InitializeComponent();
            blad = pictureBox.CreateGraphics();
            p = new Pen(Color.Black, 2);
            pictureBox.BackColor = Color.White;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (rbCreate.Checked)
            {
                MouseEventArgs muis = (MouseEventArgs)e;
                if (rbLine.Checked)
                {
                    
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
                        blad.DrawLine(p, x1, y1, x2, y2);
                        Image image = new Image("Line", x1, x2, y1, y2);
                        Images.Add(image);
                    }
                }
                else if (rbActor.Checked)
                {
                    x1 = muis.X;
                    y1 = muis.Y;
                    blad.DrawEllipse(p, x1 - 15, y1 - 30, 30, 30);
                    blad.DrawLine(p, x1, y1, x1, y1 + 40);
                    blad.DrawLine(p, x1, y1, x1 - 25, y1 + 25);
                    blad.DrawLine(p, x1, y1, x1 + 25, y1 + 25);
                    blad.DrawLine(p, x1, y1 + 40, x1 - 25, y1 + 65);
                    blad.DrawLine(p, x1, y1 + 40, x1 + 25, y1 + 65);
                    Image image = new Image("Actor", x1, y1);
                }
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            blad.Clear(Color.White);
        }

        private void btRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
