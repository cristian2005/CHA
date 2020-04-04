using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHA.Componentes
{
    public partial class Dialogos : Form
    {
        public Dialogos(Color color)
        {
            InitializeComponent();
            this.bunifuCards1.BackColor = color;
            this.BackColor = color;
        }

        private void Dialogos_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

        private void BunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            icon_delad.Start();
            icon_delad.Enabled = true;
        }
        public bool bOk, bQuestion;

        private void BunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Btnsi_Click(object sender, EventArgs e)
        {

        }

        private void Btnno_Click(object sender, EventArgs e)
        {

        }

        private void Btnok_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Icon_delad_Tick(object sender, EventArgs e)
        {
            icon.Enabled = false;
            btncerrar.Visible = true;
            icon_delad.Stop();
            panelOk.Visible = bOk;
            panelQuestion.Visible = bQuestion;
            if (!bOk)
            {
                icon.Image = Properties.Resources.dT9rd798c;
            }
        }
    }
}
