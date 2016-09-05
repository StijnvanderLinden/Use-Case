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
        int j = 0;
        int x1, x2, y1, y2;
        Font myFont = new Font("Arial", 14);
        List<List<int>> lijnen = new List<List<int>>();
        List<int> Images = new List<int>();

        public Form1()
        {
            InitializeComponent();
            blad = pictureBox.CreateGraphics();
            p = new Pen(Color.Black, 2);
            pictureBox.BackColor = Color.White;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach(List<int> list in lijnen)
            {
                blad.DrawLine(p, list[0], list[1], list[2], list[3]);
            }
        }

        private void btActor_Click(object sender, EventArgs e)
        {
            if(j > 2)
            {
                MessageBox.Show("Kan niet meer Actors toevoegen.");
            }
            if(j == 2)
            {
                Actor3.Visible = true;
                j++;
                blad.DrawString(txtInsert.Text, myFont, Brushes.Black, 23, 510);
            }
            if(j == 1)
            {
                Actor2.Visible = true;
                j++;
                blad.DrawString(txtInsert.Text, myFont, Brushes.Black, 23, 330);
            }
            if(j == 0)
            {
                Actor1.Visible = true;
                j++;
                blad.DrawString(txtInsert.Text, myFont, Brushes.Black, 23, 140);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs muis = (MouseEventArgs)e;
            if (rbCreate.Checked)
            {
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
                        lijnen.Add(new List<int> { x1, y1, x2, y2 });
                    }
                }
                else
                {
                    x1 = muis.X;
                    y1 = muis.Y;
                }
            }

            else
            {
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            blad.Clear(Color.White);
            Images.Clear();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
