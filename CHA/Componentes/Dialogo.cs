using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHA.Componentes
{
    /// <summary>
    /// Tipo de alerta, si es success, tipo pregunta, tipo advertencia o tipo error.
    /// </summary>
    public enum Tipo
    {
        Completado,
        Pregunta,
        Advertencia,
        Error
    }
    /// <summary>
    /// Enumeracion para los botones
    /// </summary>
    public enum Boton
    {
        Ok,
        SiNo,
        Cancelar,
        Aceptar
    }
    /// <summary>
    /// Enumeracion que es el resultado del botón
    /// </summary>
    public enum Resultado_Boton
    {
        Ok,
        Si,
        No,
        Aceptar,
        Cancelar
    }
    /// <summary>
    /// Clase estática que muestra un cuadro de dialogo personalizado.
    /// </summary>
    public class Dialogo
    {
        /// <summary>
        /// Declarando variable a utilizar
        /// </summary>
        private static Dialogos dialogo;
        private static bool bpersonalizado = false;
        private static string click_boton_personalizado = null;
        private static Timer timer1;
        private static int a = 0;
        private static int interval = 1;
        private static Tipo tipo_global;
        private static System.Media.SoundPlayer snd;
        private static Resultado_Boton Resultado_boton;

        /// <summary>
        /// Cambia el color del cuadro de dialogo, por defecto es blanco
        /// </summary>
        public static Color Color_Form = Color.White;
        /// <summary>
        /// Cambia el color del titulo del cuadro de dialogo, por defecto es negro
        /// </summary>
        public static Color Color_titulo = Color.Black;
        /// <summary>
        /// Cambia el color del boton de cerrar el cuadro de dialogo, por defecto es negro
        /// </summary>
        public static Color Color_boton_Cerrar = Color.Black;
        /// <summary>
        /// Cambia el color de la descripción del cuadro de dialogo, por defecto es negro
        /// </summary>
        public static Color Color_descripcion = Color.Black;
        /// <summary>
        /// Indica si el cuadro de dialogo tendra sonido al tipo de alerta, por defecto es verdadero
        /// </summary>
        public static bool Sonido = true;
        /// <summary>
        /// Indica el icono que tendra el cuadro de dialogo
        /// </summary>
        public static Icon icono;
        /// <summary>
        /// Crea una alerta personalizado con los parámetros indicados.
        /// </summary>
        /// <param name="descripcion">Parámetro necesario para mostrar un mensaje al cuadro de diálogo.</param>
        /// <param name="titulo">Parámetro necesario para mostrar un titulo al cuadro de diálogo.</param>


        public static void Mostrar(string descripcion, string titulo)
        {
            Mostrar(descripcion, titulo, Tipo.Completado, Boton.Aceptar, Boton.Aceptar.ToString());
        }
        /// <summary>
        /// Crea una alerta personalizado con los parámetros indicados.
        /// </summary>
        /// <param name="descripcion">Parámetro necesario para mostrar un mensaje al cuadro de diálogo.</param>
        /// <param name="titulo">Parámetro necesario para mostrar un titulo al cuadro de diálogo.</param>
        /// <param name="tipo">Parámetro Para saber que tipo será el cuadro de diálogo</param>
        /// <param name="boton">Parámetro Para saber que tipo de botón de será el cuadro de diálogo</param>
        /// <returns>Devuelve el boton del parámetro especificado.</returns>
        public static Resultado_Boton Mostrar(string descripcion, string titulo, Tipo tipo, Boton boton)
        {
            Mostrar(descripcion, titulo, tipo, boton, boton.ToString());
            return Resultado_boton;
        }
        /// <summary>
        /// Crea una alerta personalizado con los parámetros indicados.
        /// </summary>
        /// <param name="descripcion">Parámetro necesario para mostrar un mensaje al cuadro de diálogo.</param>
        /// <param name="titulo">Parámetro necesario para mostrar un titulo al cuadro de diálogo.</param>
        /// <param name="tipo">Parámetro Para saber que tipo será el cuadro de diálogo</param>
        /// <param name="boton">Parámetro Para saber que tipo de botón de será el cuadro de diálogo</param>
        /// <param name="boton_personalizado">Cadena que quiere que muestre el botón, si es de tipo pregunta el botón a sustituir seria el "Sí"</param>
        /// <param name="boton_negativo">Parametro no obligatorio, que es para el botón "No"</param>
        /// <returns>Devuelve el boton_personalizado del parámetro especificado.</returns>
        public static string Mostrar(string descripcion, string titulo, Tipo tipo, Boton boton, string boton_personalizado, string boton_negativo = null)
        {
            dialogo = new Dialogos(Color_Form);
            dialogo.Icon = icono;
            tipo_global = tipo;
            dialogo.lblmensaje.ForeColor = Color_descripcion;
            dialogo.lbltitulo.ForeColor = Color_titulo;
            dialogo.btncerrar.ForeColor = Color_boton_Cerrar;
            switch (tipo)
            {
                case Tipo.Completado:
                    dialogo.lbltitulo.Text = titulo;
                    dialogo.lblmensaje.Text = descripcion;
                    dialogo.icon_delad.Interval = 3500;
                    if (dialogo.BackColor == Color.White)
                    {
                        dialogo.icon.Image = Properties.Resources.Success1__2_;
                    }
                    else
                        dialogo.icon.Image = Properties.Resources.Success1;
                    dialogo.bOk = true;
                    dialogo.bQuestion = false;
                    dialogo.btnok.Text = boton_personalizado;
                    dialogo.btnok.Activecolor = Color.FromArgb(119, 180, 63);
                    dialogo.btnok.OnHovercolor = Color.FromArgb(139, 210, 63);
                    dialogo.btnok.Normalcolor = Color.FromArgb(119, 180, 63);
                    dialogo.bunifuCards1.color = dialogo.btnok.Normalcolor;

                    interval = 1100;
                    break;
                case Tipo.Pregunta:
                    dialogo.lbltitulo.Text = titulo;
                    dialogo.lblmensaje.Text = descripcion;
                    dialogo.icon_delad.Interval = 3200;
                    if (dialogo.BackColor == Color.White)
                    {

                        dialogo.icon.Image = Properties.Resources.pregunta1;
                    }
                    else
                        dialogo.icon.Image = Properties.Resources.dT9rd798c;

                    dialogo.bOk = false;
                    dialogo.btnsi.Click += new System.EventHandler(Btnsi_Click);
                    dialogo.btnno.Click += new System.EventHandler(Btnsi_Click);
                    dialogo.btncerrar.Enabled = false;
                    dialogo.bQuestion = true;
                    if (boton_negativo == null)
                    {
                        dialogo.btnsi.Text = "Si";
                        dialogo.btnno.Text = "No";
                    }
                    else
                    {
                        dialogo.btnsi.Text = boton_personalizado;
                        dialogo.btnno.Text = boton_negativo;
                        bpersonalizado = true;
                    }
                    dialogo.bunifuCards1.color = Color.FromArgb(6, 6, 3);

                    break;
                case Tipo.Advertencia:
                    dialogo.lbltitulo.Text = titulo;
                    dialogo.lblmensaje.Text = descripcion;
                    dialogo.icon_delad.Interval = 3000;
                    if (dialogo.BackColor == Color.White)
                        dialogo.icon.Image = CHA.Properties.Resources.Warning1;
                    else
                        dialogo.icon.Image = Properties.Resources.warning11;
                    dialogo.bOk = true;
                    dialogo.bQuestion = false;
                    dialogo.btnok.Text = boton_personalizado;
                    dialogo.icon.Location = new System.Drawing.Point(115, 83);
                    dialogo.icon.Size = new System.Drawing.Size(200, 120);
                    dialogo.btnok.OnHovercolor = Color.FromArgb(241, 209, 98);
                    dialogo.btnok.Normalcolor = Color.FromArgb(246, 214, 64);
                    dialogo.btnok.Activecolor = Color.FromArgb(241, 209, 98);
                    dialogo.bunifuCards1.color = dialogo.btnok.Normalcolor;
                    break;
                case Tipo.Error:
                    dialogo.lbltitulo.Text = titulo;
                    dialogo.lblmensaje.Text = descripcion;
                    dialogo.icon_delad.Interval = 1300;
                    dialogo.icon.Image = Properties.Resources.x1;
                    dialogo.bOk = true;
                    dialogo.bQuestion = false;
                    dialogo.btnok.Text = boton_personalizado;
                    dialogo.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    dialogo.icon.Location = new System.Drawing.Point(115, 83);
                    dialogo.icon.Size = new System.Drawing.Size(200, 120);
                    dialogo.btnok.OnHovercolor = Color.FromArgb(242, 69, 69);
                    dialogo.btnok.Normalcolor = Color.FromArgb(246, 32, 32);
                    dialogo.btnok.Activecolor = Color.Red;
                    dialogo.bunifuCards1.color = dialogo.btnok.Normalcolor;

                    break;
                default:
                    break;
            }
            if (Sonido)
            {
                //Timer
                timer1 = new Timer();
                timer1.Enabled = true;
                timer1.Tick += new EventHandler(Tiempo);
                timer1.Interval = interval;
                timer1.Start();
            }
            dialogo.ShowDialog();

            return click_boton_personalizado;
        }
        private static void Btnsi_Click(object sender, EventArgs e)
        {
            var boton = sender as Bunifu.Framework.UI.BunifuFlatButton;
            if (!bpersonalizado)
            {
                if (boton.Text == "Si")
                {
                    Resultado_boton = Resultado_Boton.Si;
                }
                else
                    Resultado_boton = Resultado_Boton.No;
            }
            else
            {
                click_boton_personalizado = boton.Text;
            }
            dialogo.Close();
        }

        private static void Get_Audio(Tipo tipo)
        {
            System.IO.Stream str;
            switch (tipo)
            {
                case Tipo.Completado:
                    str = Properties.Resources.Completadoaudio;
                    break;
                case Tipo.Pregunta:
                    str = Properties.Resources.pregunta;
                    break;
                case Tipo.Advertencia:
                    str = Properties.Resources.alerta;
                    break;
                case Tipo.Error:
                    str = Properties.Resources.Error;
                    break;
                default:
                    str = Properties.Resources.Completadoaudio;
                    break;
            }
            snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }
        private static void Tiempo(Object myObject, EventArgs myEventArgs)
        {
            if (a == 1)
            {
                Get_Audio(tipo_global);
                timer1.Stop();
                timer1.Enabled = false;
                a = 0;
            }
            a++;
        }
    }
}
