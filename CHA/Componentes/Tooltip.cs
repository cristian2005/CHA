using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace CHA.Componentes
{
    /// <summary>
    /// Clase que crear un tooltip con texto e imagenes y mas..
    /// </summary>
    public class TooltipPersonalizado
    {
        /// <summary>
        /// Inicializando el Tooltip
        /// </summary>
        public static Bunifu.UI.WinForms.BunifuToolTip BunifuToolTip = new Bunifu.UI.WinForms.BunifuToolTip();
        /// <summary>
        /// Color del fondo del tooltip(Por defecto es blanco).
        /// </summary>
        public static Color Fondo_Tootipp = Color.White;
        /// <summary>
        /// Color del borde del tooltip(Por defecto es gris).
        /// </summary>
        public static Color Border_Tootipp = Color.Gray;
        /// <summary>
        /// Color del Titulo del tooltip(Por defecto es negro).
        /// </summary>
        public static Color TituloColor_Tootipp = Color.Black;
        /// <summary>
        /// Color del texto del tooltip(Por defecto es negro).
        /// </summary>
        public static Color DescripcionColor_Tootipp = Color.Black;

        /// <summary>
        /// Metodo que mostra el tooltip en un control del formulario especifico.
        /// </summary>
        /// <param name="Descripcion">El texto que va en el tooltip.</param>
        /// <param name="control">El control donde aparecerá el tooltip.</param>
        public static void Mostrar(string Descripcion, Control control)
        {
            Mostrar(Descripcion, "", control, null, null, false);
        }
        /// <summary>
        /// Metodo que mostra el tooltip en un control del formulario especifico.
        /// </summary>
        /// <param name="Descripcion">El texto que va en el tooltip.</param>
        /// <param name="Titulo">El titulo que desea mostrar en el tooltip.</param>
        /// <param name="control">El control donde aparecerá el tooltip.</param>
        public static void Mostrar(string Descripcion, string Titulo, Control control)
        {
            Mostrar(Descripcion, Titulo, control, null, null, false);
        }
        /// <summary>
        /// Metodo que mostra el tooltip en un control del formulario especifico.
        /// </summary>
        /// <param name="Descripcion">El texto que va en el tooltip.</param>
        /// <param name="Titulo">El titulo que desea mostrar en el tooltip.</param>
        /// <param name="control">El control donde aparecerá el tooltip.</param>
        /// <param name="imagen">El icono del titulo tooltip.</param>
        public static void Mostrar(string Descripcion, string Titulo, Control control, Bitmap imagen)
        {
            Mostrar(Descripcion, Titulo, control, imagen, null);
        }

        /// <summary>
        /// Metodo que mostra el tooltip en un control del formulario especifico.
        /// </summary>
        /// <param name="Descripcion">El texto que va en el tooltip.</param>
        /// <param name="Titulo">El titulo que desea mostrar en el tooltip.</param>
        /// <param name="control">El control donde aparecerá el tooltip.</param>
        /// <param name="imagen">El icono del titulo tooltip.</param>
        /// <param name="userControl">En caso de que quiera mostrar un user control en vez del tooltip predeterminado</param>
        public static void Mostrar(string Descripcion, string Titulo, Control control, Bitmap imagen, UserControl userControl)
        {
            Mostrar(Descripcion, Titulo, control, imagen, userControl, false);
        }
        /// <summary>
        /// Metodo que mostra el tooltip en un control del formulario especifico.
        /// </summary>
        /// <param name="Descripcion">El texto que va en el tooltip.</param>
        /// <param name="Titulo">El titulo que desea mostrar en el tooltip.</param>
        /// <param name="control">El control donde aparecerá el tooltip.</param>
        /// <param name="imagen">El icono del titulo tooltip.</param>
        /// <param name="userControl">En caso de que quiera mostrar un user control en vez del tooltip predeterminado</param>
        /// <param name="ClicUserControl">Parámetro que indica si el user control aparecerá cuando le haga clic al <paramref name="control"></paramref>.(Por defecto es false)</param>
        public static void Mostrar(string Descripcion, string Titulo, Control control, Bitmap imagen, UserControl userControl, bool ClicUserControl)
        {
            BunifuToolTip.BackColor = Fondo_Tootipp;
            BunifuToolTip.BorderColor = Border_Tootipp;
            BunifuToolTip.TitleForeColor = TituloColor_Tootipp;
            BunifuToolTip.TextForeColor = DescripcionColor_Tootipp;
            if (!ClicUserControl)
            {
                BunifuToolTip.SetToolTipTitle(control, Titulo);
                BunifuToolTip.SetToolTip(control, Descripcion);
                BunifuToolTip.SetToolTipIcon(control, imagen);
            }
            else
            {
                BunifuToolTip.SetToolTipTitle(control, "");
                BunifuToolTip.SetToolTip(control, Descripcion);
                BunifuToolTip.SetToolTipIcon(control, null);
            }
            if (userControl != null)
            {
                BunifuToolTip.DisplayControl = userControl;
                BunifuToolTip.ClickToShowDisplayControl = ClicUserControl;
            }

        }
    }
}
