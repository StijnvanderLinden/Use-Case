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
        Font myFont = new Font("Arial", 14);
        Select select = new Select();
        List<bool> actors = new List<bool> { false, false, false };
        List<string> text = new List<string> { null, null, null };

        public Form1()
        {
            InitializeComponent();
            blad = pictureBox.CreateGraphics();
            p = new Pen(Color.Black, 2);
            pictureBox.BackColor = Color.White;
        }

        
        
        private void btActor_Click(object sender, EventArgs e)
        {
            if (actors[0])
            {
                if (actors[1])
                {
                    if (actors[2])
                    {
                        MessageBox.Show("Kan niet meer Actors toevoegen.");
                    }
                    else
                    {
                        Actor3.Visible = true;
                        actors[2] = true;
                        lbActor3.Text = txtInsert.Text;
                        lbActor3.Visible = Enabled;
                    }
                }
                else
                {
                    Actor2.Visible = true;
                    actors[1] = true;
                    lbActor2.Text = txtInsert.Text;
                    lbActor2.Visible = Enabled;
                }
            }
            else
            {
                Actor1.Visible = true;
                actors[0] = true;
                lbActor1.Text = txtInsert.Text;
                lbActor1.Visible = Enabled;
            }
        }

        private void btRemoveActor_Click(object sender, EventArgs e)
        {
            if (rbActor1.Checked)
            {
                Actor1.Visible = false;
                actors[0] = false;
                lbActor1.Visible = false;
            }
            else if (rbActor2.Checked)
            {
                Actor2.Visible = false;
                actors[1] = false;
                lbActor2.Visible = false;
            }
            else if (rbActor3.Checked)
            {
                Actor3.Visible = false;
                actors[2] = false;
                lbActor3.Visible = false;
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
                        Lijn lijn = new Lijn(x1, y1, x2, y2);
                        select.Lijnen.Add(new List<int> { x1, y1, x2, y2 });
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
            select.Lijnen.Clear();
            actors.Insert(0, false);
            actors.Insert(1, false);
            actors.Insert(2, false);
            Actor1.Visible = false;
            Actor2.Visible = false;
            Actor3.Visible = false;
            lbActor1.Visible = false;
            lbActor2.Visible = false;
            lbActor3.Visible = false;
        }

        private void btRemove_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (List<int> list in select.Lijnen)
            {
                blad.DrawLine(p, list[0], list[1], list[2], list[3]);
            }
        }
    }
}