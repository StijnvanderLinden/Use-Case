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
    public partial class UseCaseForm : Form
    {
        Form1 form1 = new Form1();

        public UseCaseForm(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }
        
        private void btOK_Click(object sender, EventArgs e)
        {
            form1.VoegUseCaseToe(this);
            Hide();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            form1.DeleteUseCase();
        }
    }
}
