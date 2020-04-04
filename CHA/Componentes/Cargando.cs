using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHA.Componentes
{
    /// <summary>
    /// Representa un circulo de colores que lo puede personalizar a tu gusto.
    /// </summary>
    public partial class Cargando : UserControl
    {
        private List<string> texto = new List<string>();
        private Timer textotime = new Timer();
        private int ocultartime = 0;
        /// <summary>
        /// Lista de colores que tendra el cargando(por defecto hay 3 colores y es obligatorio tener uno).
        /// </summary>
        public List<Color> ColoresCargando { get; set; }
        /// <summary>
        /// Agrega un texto al cargando, si no quieres texto dejalo vacio.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]

        [Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
        public List<string> Texto
        {
            get
            {
                return texto;
            }
            set { texto = value; }
        }
        /// <summary>
        /// Representa el color del texto.
        /// </summary>
        public Color ColorTexto { get { return label1.ForeColor; } set { this.label1.ForeColor = value; } }
        /// <summary>
        /// Representa el Intervalo que durará cada listado del Texto.
        /// </summary>
        public int IntervaloTexto { get { return this.textotime.Interval; } set { this.textotime.Interval = value; } }
        /// <summary>
        /// Representa el tiempo que durara el cargando.
        /// </summary>
        public int IntervaloOcultarCargando { get { return ocultartime; } set { ocultartime = value; } }
        int color_ = 0;
        int text_ = 0;
        public Cargando()
        {
            this.textotime.Enabled = true;
            this.textotime.Tick += new System.EventHandler(this.Textotime_Tick);
            InitializeComponent();
            ColoresCargando = new List<Color>();
            ColorTexto = new Color();


            label1.ForeColor = ColorTexto;
            ColoresCargando.Add(Color.FromArgb(0, 150, 136));
            ColoresCargando.Add(Color.FromArgb(0, 188, 212));
            ColoresCargando.Add(Color.FromArgb(63, 81, 181));
            ColoresCargando.Add(Color.FromArgb(156, 39, 176));
            bunifuCircleProgressbar1.ProgressColor = ColoresCargando[0];
            color.Start();
        }
        int dir = 1;
        int i = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (IntervaloOcultarCargando != 0 && i == IntervaloOcultarCargando - 1000)
            {
                this.Dispose();
            }
            i += 10;
            if (bunifuCircleProgressbar1.Value == 100)
            {
                dir = -1;
                bunifuCircleProgressbar1.animationIterval = 5;
                SwictColor();
            }
            else if (bunifuCircleProgressbar1.Value == 10)
            {
                dir = +1;
                bunifuCircleProgressbar1.animationIterval = 2;
                SwictColor();
            }
            bunifuCircleProgressbar1.Value += dir;

        }
        void SwictColor()
        {
            bunifuColorTransition1.Color1 = ColoresCargando[color_];
            if (color_ < ColoresCargando.Count - 1)
                color_++;
            else
                color_ = 0;
            bunifuColorTransition1.Color1 = ColoresCargando[color_];
            color.Start();
        }

        private void Color_Tick(object sender, EventArgs e)
        {
            try
            {
                if (ColoresCargando.Count > 0)
                {
                    bunifuColorTransition1.Color1 = ColoresCargando[color_];
                    if (bunifuColorTransition1.ProgessValue < 80)
                    {
                        bunifuColorTransition1.ProgessValue++;
                        bunifuCircleProgressbar1.ProgressColor = bunifuColorTransition1.Value;
                    }
                    else
                    {
                        color.Stop();
                        bunifuColorTransition1.Color1 = bunifuColorTransition1.Color2;
                        bunifuColorTransition1.ProgessValue = 0;
                    }
                }
                else
                {
                    ColoresCargando.Add(Color.FromArgb(0, 150, 136));
                    MessageBox.Show("Debes de asignar al menos un color", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception error)
            {
                ColoresCargando.Add(Color.FromArgb(0, 150, 136));
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Textotime_Tick(object sender, EventArgs e)
        {
            try
            {
                label1.Text = (Texto.Count > 0) ? Texto[text_] : "";
                if (Texto.Count - 1 > text_)
                {
                    text_++;
                }
                else if (Texto.Count == text_)
                    textotime.Stop();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
