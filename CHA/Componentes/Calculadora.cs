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
    public partial class Calculadora : Form
    {
        public bool Programable { get; set; }
        decimal LastAns;
        string last_oparator = "";
        public Calculadora()
        {
            InitializeComponent();
            Programable = true;
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bt7_Click(object sender, EventArgs e)
        {
            if (Programable)
            {
                Set_Number(sender, true);
            }
        }
        private string quitarPrimercero(string cadena)
        {
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena.Substring(0, 1) == "0")
                {
                    return cadena.Substring(1);
                }

            }
            return cadena;
        }
        bool reiniciar = true;
        private void Set_Number(object sender, bool number_symbol)
        {
            Control imageButton = sender as Control;
            if (number_symbol)
            {
                if (reiniciar)
                    lblresultado.Text = quitarPrimercero(lblresultado.Text + imageButton.Name.Substring(2));
                else
                    lblresultado.Text = quitarPrimercero(imageButton.Name.Substring(2));
                reiniciar = true;
            }
            else
            {
                //lblnumeros.Text += imageButton.Tag;
                EvaluarCalcularNumero(imageButton.Tag.ToString());
                last_oparator = imageButton.Tag.ToString();
            }
        }
        decimal numeros = 0;
        int resta = 0, multiplicacion = 0, division = 0, suma = 0;
        private void EvaluarCalcularNumero(string Tags, bool last = false)
        {
            try
            {
                decimal numero = Convert.ToDecimal(lblresultado.Text);
                switch (Tags)
                {
                    case "+":
                        if (!Verificar_Operador_Cambiado("+"))
                        {
                            numeros += numero;
                            lblnumeros.Text += numero + "+";
                            suma++;
                            reiniciar = false;
                        }
                        else
                            return;
                        break;
                    case "-":
                        if (!Verificar_Operador_Cambiado("-"))
                        {
                            if (resta == 0)
                            {
                                numeros = numero;
                            }
                            else
                                numeros -= numero;
                            lblnumeros.Text += numero + "-";
                            resta++;
                            reiniciar = false;
                        }
                        else
                            return;
                        break;
                    case "x":
                        if (!Verificar_Operador_Cambiado("x"))
                        {
                            if (multiplicacion == 0)
                            {
                                numeros = numero;
                            }
                            else
                                numeros *= numero;
                            lblnumeros.Text += numero + "x";
                            multiplicacion++;
                            reiniciar = false;
                        }
                        else
                            return;
                        break;
                    case "/":
                        if (!Verificar_Operador_Cambiado("/"))
                        {
                            if (division == 0)
                            {
                                numeros = numero;
                            }
                            else
                                numeros /= numero;
                            lblnumeros.Text += numero + "/";
                            division++;
                            reiniciar = false;
                        }
                        else
                            return;
                        break;
                    default:
                        break;
                }
                lblresultado.Text = numeros.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        public bool Verificar_Operador_Cambiado(string operador)
        {
            if (!string.IsNullOrEmpty(lblnumeros.Text))
            {
                var resultado = lblnumeros.Text;
                var length_result = lblnumeros.Text.Length;
                if (resultado.Substring(length_result - 1) != operador)
                {
                    lblnumeros.Text = lblnumeros.Text.Substring(0, length_result - 1) + operador;
                    return true;
                }
                return false;
            }
            return false;
        }
        //private string SplitNumber(char operador, string numero)
        //{
        //    string cadena = "";
        //    var cadena_split = numero.Replace('x',operador).Replace('-', operador).Replace('/',operador).Replace('+', operador).Split(operador);
        //    for (int i = 0; i < cadena_split.Length-1; i++)
        //    {
        //        if (i== cadena_split.Length-2)
        //        {
        //            cadena = Regex.Match(cadena_split[i], @"\d+").Value.ToString();
        //        }
        //    }
        //    return cadena;
        //}
        private void BunifuImageButton25_Click(object sender, EventArgs e)
        {
            if (Programable)
            {
                EvaluarCalcularNumero(last_oparator, true);
                LastAns = numeros.ToString().Length;
                timer1.Start();
            }
        }
        int i = 0;
        private string Get_RandomNums(int length)
        {
            string temp = "";
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                if (numeros < 0)
                {
                    temp += random.Next(Convert.ToInt32(numeros), 0);
                }
                else
                    temp += random.Next(0, Convert.ToInt32(numeros));
            }
            return temp;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Programable)
            {
                if (i < 15)
                {
                    lblresultado.Text = Get_RandomNums(LastAns.ToString().Length);
                    i++;
                }
                else
                {
                    i = 0;
                    lblresultado.Text = numeros.ToString();
                    lblnumeros.Text = "";
                    timer1.Stop();
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Programable)
            {
                lblresultado.Text += ".";
            }
        }

        private void BunifuImageButton22_Click(object sender, EventArgs e)
        {
            if (Programable)
            {
                var operador = lblresultado.Text[0];
                lblresultado.Text = (operador == '-') ? lblresultado.Text.Substring(1) : "-" + lblresultado.Text;
            }
        }



        private void Button2_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Button2_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            BunifuImageButton2_Click(sender, e);
        }

        private void Calculadora_KeyUp(object sender, KeyEventArgs e)
        {
            if (Programable)
            {
                switch (e.KeyValue)
                {
                    case (char)Keys.D0:
                        Bt7_Click(bt0, e);
                        break;
                    case (char)Keys.NumPad0:
                        Bt7_Click(bt0, e);
                        break;
                    case (char)Keys.D1:
                        Bt7_Click(bt1, e);
                        break;
                    case (char)Keys.NumPad1:
                        Bt7_Click(bt1, e);
                        break;
                    case (char)Keys.D2:
                        Bt7_Click(bt2, e);
                        break;
                    case (char)Keys.NumPad2:
                        Bt7_Click(bt2, e);
                        break;
                    case (char)Keys.D3:
                        Bt7_Click(bt3, e);
                        break;
                    case (char)Keys.NumPad3:
                        Bt7_Click(bt3, e);
                        break;
                    case (char)Keys.D4:
                        Bt7_Click(bt4, e);
                        break;
                    case (char)Keys.NumPad4:
                        Bt7_Click(bt4, e);
                        break;
                    case (char)Keys.D5:
                        Bt7_Click(bt5, e);
                        break;
                    case (char)Keys.NumPad5:
                        Bt7_Click(bt5, e);
                        break;
                    case (char)Keys.D6:
                        Bt7_Click(bt6, e);
                        break;
                    case (char)Keys.NumPad6:
                        Bt7_Click(bt6, e);
                        break;
                    case (char)Keys.D7:
                        Bt7_Click(bt7, e);
                        break;
                    case (char)Keys.NumPad7:
                        Bt7_Click(bt7, e);
                        break;
                    case (char)Keys.D8:
                        Bt7_Click(bt8, e);
                        break;
                    case (char)Keys.NumPad8:
                        Bt7_Click(bt8, e);
                        break;
                    case (char)Keys.D9:
                        Bt7_Click(bt9, e);
                        break;
                    case (char)Keys.NumPad9:
                        Bt7_Click(bt9, e);
                        break;
                    case (char)Keys.Back:
                        BunifuImageButton4_Click(null, e);
                        break;
                    case (char)Keys.Enter:
                        BunifuImageButton25_Click(bunifuImageButton25, e);
                        break;
                    case 110:
                        Button1_Click(button1, e);
                        break;
                    case 190:
                        Button1_Click(button1, e);
                        break;
                    case 106:
                        BunifuImageButton17_Click(bunifuImageButton9, e);
                        break;
                    case 107:
                        BunifuImageButton17_Click(bunifuImageButton17, e);
                        break;
                    case 109:
                        BunifuImageButton17_Click(bunifuImageButton18, e);
                        break;
                    case 111:
                        BunifuImageButton17_Click(bunifuImageButton5, e);
                        break;
                    default:
                        break;
                }
                if (e.Control && e.KeyCode == Keys.V)
                {
                    lblresultado.Text = Clipboard.GetText();
                }
                else if (e.Control && e.KeyCode == Keys.C)
                    Clipboard.SetText(lblresultado.Text);
            }
        }

        private void BunifuImageButton17_Click(object sender, EventArgs e)
        {
            if (Programable)
            {
                Set_Number(sender, false);
            }
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (Programable)
            {
                lblnumeros.Text = "";
                lblresultado.Text = "0";
                numeros = 0;
                resta = 0;
                multiplicacion = 0;
                division = 0;
                suma = 0;
            }
        }

        private void BunifuImageButton4_Click(object sender, EventArgs e)
        {
            if (Programable)
            {
                if (lblresultado.Text.Length > 1)
                {
                    lblresultado.Text = lblresultado.Text.Substring(0, lblresultado.Text.Length - 1);
                }
                else if (lblresultado.Text.Length == 1)
                {
                    lblresultado.Text = "0";

                }
            }
        }
    }
}
