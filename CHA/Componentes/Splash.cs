using Bunifu.Framework.UI;
using BunifuAnimatorNS;
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
    /// <summary>
    /// Representa un formulario con animación temporal.
    /// </summary>
    public partial class Splash : Form
    {
        /// <summary>
        /// Ocurre cuando se termina la animación de los colores.
        /// </summary>
        public delegate void Mydelegate(Form Splash);
        /// <summary>
        /// Ocurre cuando se termina la animación de los colores.
        /// </summary>
        public event Mydelegate SplashTerminado;
        /// <summary>
        /// Listados de los colores de la animación.
        /// </summary>
        public List<Color> Colores { get; set; }
        public Splash()
        {
            Colores = new List<Color>();
            Colores.Add(Color.FromArgb(0, 158, 71));
            Colores.Add(Color.FromArgb(112, 191, 83));
            Colores.Add(Color.FromArgb(216, 155, 40));
            Colores.Add(Color.FromArgb(217, 102, 41));
            Colores.Add(Color.FromArgb(217, 102, 41));
            Colores.Add(Color.FromArgb(235, 83, 104));
            Colores.Add(Color.FromArgb(223, 128, 255));
            Colores.Add(Color.FromArgb(112, 48, 160));
            Colores.Add(Color.FromArgb(107, 122, 187));
            Colores.Add(Color.FromArgb(95, 136, 176));
            Colores.Add(Color.FromArgb(70, 175, 227));
            Colores.Add(Color.FromArgb(0, 158, 71));
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        int curcolor = 0;
        int loop = 0;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = false;
                if (curcolor < Colores.Count - 1)
                {
                    this.BackColor = BunifuColorTransition.getColorScale(loop, Colores[curcolor], Colores[curcolor + 1]);
                    if (loop < 100)
                    {
                        loop++;
                    }
                    else
                    {
                        loop = 0;
                        curcolor++;
                    }
                    timer1.Enabled = true;
                }
                else
                {
                    OnCerrarSplash();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error\n" + error.Message);
            }
        }
        /// <summary>
        /// Ocurre cuando se termina la animación de los colores.
        /// </summary>
        protected virtual void OnCerrarSplash()
        {
            SplashTerminado?.Invoke(this);
        }

        private void Ocultar_MandarForm(Control form)
        {
            if (form != null)
            {
                //bunifuTransition1.ShowSync(this, false, BunifuAnimatorNS.Animation.HorizSlideAndRotate);
                this.Hide();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {

            if (timer1.Enabled == true)
            {
                this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            }
        }

        private void BunifuTransition1_AnimationCompleted(object sender, AnimationCompletedEventArg e)
        {

        }

        private void BunifuTransition1_AllAnimationsCompleted(object sender, EventArgs e)
        {

        }
    }
}
