using System.Drawing;
namespace CHA.Componentes.Alertas
{
    public enum Tipo
    {
        Info,
        Warning,
        Success,
        Danger
    }
    /// <summary>
    /// Crea una alerta personalizada en la parte superior derecha.
    /// </summary>
    public static class Alertas
    {
        /// <summary>
        /// Muestra la alerta en la pantalla
        /// </summary>
        /// <param name="Titulo">El titulo de la alerta.</param>
        /// <param name="Descripcion">La descripcion de la alerta.</param>
        /// <param name="tipo">El tipo de alerta(cambia de color).</param>
        /// <param name="interval">Segundo que durara la alerta.</param>
        public static void Mostrar(string Titulo, string Descripcion, Tipo tipo, int interval)
        {
            AlertaForm alertaForm = new AlertaForm();
            alertaForm.timer1.Interval = interval;
            alertaForm.lbltitulo.Text = Titulo;
            alertaForm.lblmensaje.Text = Descripcion;

            switch (tipo)
            {
                case Tipo.Info:
                    alertaForm.pbiconotype.Image = Properties.Resources.Info;
                    alertaForm.BackColor = Color.RoyalBlue;
                    break;
                case Tipo.Warning:
                    alertaForm.pbiconotype.Image = Properties.Resources.Warning;
                    alertaForm.BackColor = Color.DarkOrange;
                    break;
                case Tipo.Success:
                    alertaForm.pbiconotype.Image = Properties.Resources.Success;
                    alertaForm.BackColor = Color.SeaGreen;
                    break;
                case Tipo.Danger:
                    alertaForm.pbiconotype.Image = Properties.Resources.Danger;
                    alertaForm.BackColor = Color.Crimson;
                    break;
                default:
                    break;
            }
            alertaForm.Show();
        }
    }
}
