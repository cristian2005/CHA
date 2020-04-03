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
    public partial class AlertaForm : Form
    {
        public AlertaForm()
        {
            InitializeComponent();
        }
        private void Example_Load(object sender, EventArgs e)
        {
            this.Top = 20;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }
        int interval = 0;
        //Show transition
        private void Timer2_Tick(object sender, EventArgs e)
        {

        }

        private void Timer3_Tick(object sender, EventArgs e)
        {

        }
    }
}
