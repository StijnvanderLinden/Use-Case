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
        UseCaseForm UseCase;
        Graphics blad;
        Pen p;
        Pen r;
        SolidBrush b;
        Point point1;
        Point point2;
        int i = 0;
        int j = 0;
        int x1, x2, y1, y2;
        int selected;
        Font myFont;
        Select select;
        List<bool> actors;
        List<string> text;
        List<Lijn> lijnen;
        List<Usecase> usecases;

        public Form1()
        {
            InitializeComponent();
            blad = pictureBox.CreateGraphics();
            p = new Pen(Color.Black, 2);
            r = new Pen(Color.Red, 2);
            b = new SolidBrush(Color.Black);
            pictureBox.BackColor = Color.White;
            myFont = new Font("Arial", 8);
            select = new Select();
            actors = new List<bool> { false, false, false };
            text = new List<string> { null, null, null };
            lijnen = new List<Lijn>();
            usecases = new List<Usecase>();
        }

        private void btActor_Click(object sender, EventArgs e)
        {
            if (actors[0])
            {
                if (actors[1])
                {
                    if (actors[2])
                    {
                        MessageBox.Show("Kan geen Actors toevoegen.");
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
                //Create
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
                        lijnen.Add(new Lijn(x1, y1, x2, y2));
                    }
                }
                //Use Case
                else
                {
                    UseCase = new UseCaseForm(this);
                    point1 = new Point(muis.X, muis.Y);
                    point2 = new Point(muis.X + 150, muis.Y + 70);
                    UseCase.Show();
                    blad.DrawEllipse(p, muis.X, muis.Y, 150, 70);
                }
            }

            //Select
            else
            {
                if (usecases.Count() > 0)
                {
                    j = 0;
                    foreach (Usecase usecase in usecases)
                    {
                        if (muis.X > usecase.Point1.X && muis.X < usecase.Point2.X && muis.Y > usecase.Point1.Y && muis.Y < usecase.Point2.Y)
                        {
                            UseCase.txtNaam.Text = usecases[j].Naam;
                            UseCase.txtSamenvatting.Text = usecases[j].Samenvatting;
                            UseCase.txtActor.Text = usecases[j].Actor;
                            UseCase.txtAannamen.Text = usecases[j].Aannamen;
                            UseCase.txtBeschrijving.Text = usecases[j].Beschrijving;
                            UseCase.txtUitzondering.Text = usecases[j].Uitzonderingen;
                            UseCase.txtResultaat.Text = usecases[j].Resultaat;
                            UseCase.Show();
                            j++;
                        }
                    }

                    //Kan zijn dat er nog geen lijnen zijn of je klikt te ver van lijn
                    try
                    {
                        selected = select.SelectLijn(muis.X, muis.Y, lijnen);
                        blad.DrawLine(r, lijnen[selected].X1, lijnen[selected].Y1, lijnen[selected].X2, lijnen[selected].Y2);
                    }
                    catch
                    {
                        //Lijn verschuiven
                        //if (select.Lijnen[selected - 1][0] < select.Lijnen[selected - 1][2])
                        //{
                        //    select.Lijnen[selected - 1][0] = muis.X + (select.Lijnen[selected - 1][2] + select.Lijnen[selected - 1][0]);
                        //    select.Lijnen[selected - 1][2] = muis.X - (select.Lijnen[selected - 1][2] + select.Lijnen[selected - 1][0]);
                        //}
                        //else
                        //{
                        //    select.Lijnen[selected - 1][0] = muis.X - (select.Lijnen[selected - 1][2] + select.Lijnen[selected - 1][0]);
                        //    select.Lijnen[selected - 1][2] = muis.X + (select.Lijnen[selected - 1][2] + select.Lijnen[selected - 1][0]);
                        //}

                        //if (select.Lijnen[selected - 1][1] < select.Lijnen[selected - 1][3])
                        //{
                        //    select.Lijnen[selected - 1][1] = muis.Y + (select.Lijnen[selected - 1][1] + select.Lijnen[selected - 1][3]);
                        //    select.Lijnen[selected - 1][3] = muis.Y - (select.Lijnen[selected - 1][1] + select.Lijnen[selected - 1][3]);
                        //}
                        //else
                        //{
                        //    select.Lijnen[selected - 1][1] = muis.Y - (select.Lijnen[selected - 1][1] + select.Lijnen[selected - 1][3]);
                        //    select.Lijnen[selected - 1][3] = muis.Y + (select.Lijnen[selected - 1][1] + select.Lijnen[selected - 1][3]);
                        //}
                        //pictureBox.Invalidate();
                    }
                }
            }
        }
        private void btClear_Click(object sender, EventArgs e)
        {
            blad.Clear(Color.White);
            lijnen.Clear();
            usecases.Clear();
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
            try
            {
                lijnen.RemoveAt(selected);
                pictureBox.Invalidate();
            }
            catch
            {

            }
        }

        private void btRemoveLines_Click(object sender, EventArgs e)
        {
            lijnen.Clear();
            pictureBox.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                foreach (Lijn lijn in lijnen)
                {
                    blad.DrawLine(p, lijn.X1, lijn.Y1, lijn.X2, lijn.Y2);
                }

                foreach(Usecase usecase in usecases)
                {
                    blad.DrawString(usecase.Naam, myFont, b, usecase.Point1.X + 20, usecase.Point1.Y + 25);
                }
            }
            catch
            {

            }

        }
        public void VoegUseCaseToe(UseCaseForm form)
        {
            Usecase usecase = new Usecase(form.txtNaam.Text, form.txtSamenvatting.Text, form.txtActor.Text, form.txtAannamen.Text, form.txtBeschrijving.Text, form.txtUitzondering.Text, form.txtResultaat.Text, point1, point2);
            usecases.Add(usecase);
        }

        public void DeleteUseCase()
        {
            usecases.RemoveAt(j - 1);
            UseCase = new UseCaseForm(this);
            UseCase.Hide();
            pictureBox.Invalidate();
        }
    }
}