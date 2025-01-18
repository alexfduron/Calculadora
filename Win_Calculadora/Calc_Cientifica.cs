using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Calculadora
{
    public partial class Calc_Cientifica : Form
    {
        public Calc_Cientifica()
        {
            InitializeComponent();
        }
        
        // VARIABLE GLOBAL ------------------------------------------------------
        
        List<string> Lista_01 = new();
        
        
        
        private void Calc_Cientifica_Load(object sender, EventArgs e)
        {
            lbl_Pantalla.Text = "0";
            lbl_Memo.Text = "";
            lbl_Operacion02.Text = "";
        }
        
        
        // BOTON NUMERO ------------------------------------------------------
        
        private void btn_01_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "1";
            }
            else
            {
                lbl_Pantalla.Text += "1";
            }
            Lista_01.Add("1");
        }
        
        private void btn_02_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "2";
            }
            else
            {
                lbl_Pantalla.Text += "2";
            }
            Lista_01.Add("2");
        }
        
        private void btn_03_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "3";
            }
            else
            {
                lbl_Pantalla.Text += "3";
            }
            Lista_01.Add("3");
        }
        
        private void btn_04_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "4";
            }
            else
            {
                lbl_Pantalla.Text += "4";
            }
            Lista_01.Add("4");
        }
        
        private void btn_05_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "5";
            }
            else
            {
                lbl_Pantalla.Text += "5";
            }
            Lista_01.Add("5");
        }
        
        private void btn_06_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "6";
            }
            else
            {
                lbl_Pantalla.Text += "6";
            }
            Lista_01.Add("6");
        }
        
        private void btn_07_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "7";
            }
            else
            {
                lbl_Pantalla.Text += "7";
            }
            Lista_01.Add("7");
        }
        
        private void btn_08_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "8";
            }
            else
            {
                lbl_Pantalla.Text += "8";
            }
            Lista_01.Add("8");
        }
        
        private void btn_09_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "9";
            }
            else
            {
                lbl_Pantalla.Text += "9";
            }
            Lista_01.Add("9");
        }
        
        private void btn_00_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "0";
            }
            else
            {
                lbl_Pantalla.Text += "0";
                Lista_01.Add("0");
            }
        }
        
        private void btn_pto_Click(object sender, EventArgs e)
        {
            bool ValPto = false;
            
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "0.";
                Lista_01.Add("0");
                Lista_01.Add(".");
            }
            else
            {
                if (lbl_Pantalla.Text.Last() != '.' &&
                    lbl_Pantalla.Text.Last() != '+' &&
                    lbl_Pantalla.Text.Last() != '-' &&
                    lbl_Pantalla.Text.Last() != 'x' &&
                    lbl_Pantalla.Text.Last() != '/' &&
                    lbl_Pantalla.Text.Last() != '(' &&
                    lbl_Pantalla.Text.Last() != ')')
                {
                    
                    List<string> Temp01 = new List<string>(Lista_01);
                    Temp01.Reverse();
                    
                    foreach (var j in Temp01)
                    {
                        if (j.ToString() == "+" || j.ToString() == "-" ||
                            j.ToString() == "x" || j.ToString() == "/" ||
                            j.ToString() == "(" || j.ToString() == ")")
                        {
                            break;
                        }
                        if (j.ToString() == ".")
                        {
                            ValPto = true;
                            break;
                        }
                    }
                    
                    if (ValPto == false)
                    {
                        lbl_Pantalla.Text += ".";
                        Lista_01.Add(".");
                    }
                }
            }
        }
        
        private void btn_signo_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text.Contains("-") == true)
            {
                lbl_Pantalla.Text = lbl_Pantalla.Text.Replace("-", "");
            }
            else
            {
                lbl_Pantalla.Text = "-" + lbl_Pantalla.Text;
            }
        }
        
        // BOTON LIMPIAR ---------------------------------------------------------
        
        private void btn_CA_Click(object sender, EventArgs e)
        {
            lbl_Pantalla.Text = "0";
            Lista_01.Clear();
        }
        
        private void btn_Back_Click(object sender, EventArgs e)
        {
            lbl_Pantalla.Text = lbl_Pantalla.Text.Substring(0, lbl_Pantalla.Text.Length - 1);
            
            if (lbl_Pantalla.Text.Length == 0)
            {
                lbl_Pantalla.Text = "0";
                Lista_01.Clear();
            }
            else
            {
                Lista_01.RemoveAt(Lista_01.Count - 1);
            }
        }
        
        // BOTON OPERACION ---------------------------------------------------------
        
        private void btn_mas_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text.Last() != '(')
            {
                if (lbl_Pantalla.Text.Last() == '+' ||
                    lbl_Pantalla.Text.Last() == '-' ||
                    lbl_Pantalla.Text.Last() == 'x' ||
                    lbl_Pantalla.Text.Last() == '/')
                {
                    lbl_Pantalla.Text = lbl_Pantalla.Text.Substring(0, lbl_Pantalla.Text.Length - 1);
                    lbl_Pantalla.Text += "+";
                    
                    Lista_01.RemoveAt(Lista_01.Count - 1);
                    Lista_01.Add("+");
                }
                else
                {
                    if (lbl_Pantalla.Text == "0")
                    {
                        Lista_01.Add("0");
                    }
                    lbl_Pantalla.Text += "+";
                    Lista_01.Add("+");
                }
            }
        }
        
        private void btn_menos_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text.Last() == '+' ||
                lbl_Pantalla.Text.Last() == '-' ||
                lbl_Pantalla.Text.Last() == 'x' ||
                lbl_Pantalla.Text.Last() == '/')
            {
                lbl_Pantalla.Text = lbl_Pantalla.Text.Substring(0, lbl_Pantalla.Text.Length - 1);
                lbl_Pantalla.Text += "-";
                
                Lista_01.RemoveAt(Lista_01.Count - 1);
                Lista_01.Add("-");
            }
            else
            {
                if (lbl_Pantalla.Text == "0")
                {
                    Lista_01.Add("0");
                }
                lbl_Pantalla.Text += "-";
                Lista_01.Add("-");
            }
        }
        
        private void btn_por_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text.Last() != '(')
            {
                if (lbl_Pantalla.Text.Last() == '+' ||
                    lbl_Pantalla.Text.Last() == '-' ||
                    lbl_Pantalla.Text.Last() == 'x' ||
                    lbl_Pantalla.Text.Last() == '/')
                {
                    lbl_Pantalla.Text = lbl_Pantalla.Text.Substring(0, lbl_Pantalla.Text.Length - 1);
                    lbl_Pantalla.Text += "x";
                    
                    Lista_01.RemoveAt(Lista_01.Count - 1);
                    Lista_01.Add("x");
                }
                else
                {
                    if (lbl_Pantalla.Text == "0")
                    {
                        Lista_01.Add("0");
                    }
                    lbl_Pantalla.Text += "x";
                    Lista_01.Add("x");
                }
            }
        }
        
        private void btn_entre_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text.Last() != '(')
            {
                if (lbl_Pantalla.Text.Last() == '+' ||
                    lbl_Pantalla.Text.Last() == '-' ||
                    lbl_Pantalla.Text.Last() == 'x' ||
                    lbl_Pantalla.Text.Last() == '/')
                {
                    lbl_Pantalla.Text = lbl_Pantalla.Text.Substring(0, lbl_Pantalla.Text.Length - 1);
                    lbl_Pantalla.Text += "/";
                    
                    Lista_01.RemoveAt(Lista_01.Count - 1);
                    Lista_01.Add("/");
                }
                else
                {
                    if (lbl_Pantalla.Text == "0")
                    {
                        Lista_01.Add("0");
                    }
                    lbl_Pantalla.Text += "/";
                    Lista_01.Add("/");
                }
            }
        }
        
        private void btn_PIzq_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "(";
            }
            else
            {
                lbl_Pantalla.Text += "(";
            }
            Lista_01.Add("(");
        }
        
        private void btn_PDer_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = ")";
            }
            else
            {
                lbl_Pantalla.Text += ")";
            }
            Lista_01.Add(")");
        }
        
        private void btn_igual_Click(object sender, EventArgs e)
        {
            // Convertimos las secuencias de numeros de la Lista_01
            // a numeros completos en la Lista_02. Por ejemplo:
            // Lista_01 = {"1", "0", ".", "5", "+", "8", ".", "5"}
            // Lista_02 = {"10.5", "+", "8.5"}
            List<string> Lista_02 = new List<string>();
            
            foreach (var Letra in Lista_01)
            {
                if (Letra == "+" || Letra == "-" || 
                    Letra == "x" || Letra == "/" ||
                    Letra == "(" || Letra == ")")
                {
                    if (Lista_02.Count > 0)
                    {
                        if (Lista_02[Lista_02.Count - 1] == ")" && Letra == "(")
                        {
                            Lista_02.Add("x");
                        }
                    }
                    
                    Lista_02.Add(Letra);
                }
                else
                {
                    if (Lista_02.Count == 0)
                    {
                        Lista_02.Add("");
                    }
                    else if (Lista_02[Lista_02.Count - 1] == "+" || Lista_02[Lista_02.Count - 1] == "-" ||
                            Lista_02[Lista_02.Count - 1] == "x" || Lista_02[Lista_02.Count - 1] == "/" ||
                            Lista_02[Lista_02.Count - 1] == "(" || Lista_02[Lista_02.Count - 1] == ")")
                    {
                        bool Validar = false;
                        // aqui le digo que si el signo menos esta delante de un numero
                        // que lo agregue al numero
                        if (Lista_02.Count >= 2)
                        {
                            if (Lista_02[Lista_02.Count - 2] == "(" && Lista_02[Lista_02.Count - 1] == "-")
                            {
                                Validar = true;
                            }
                            else
                            {
                                if (Validar == false)
                                {
                                    Lista_02.Add("");
                                    Validar = true;
                                }
                            }
                        }
                        
                        if (Lista_02.Count >= 1)
                        {
                            if (Lista_02[Lista_02.Count - 1] == "-" && Lista_02.Count == 1)
                            {
                                Validar = true;
                            }
                            else
                            {
                                if (Validar == false)
                                {
                                    Lista_02.Add("");
                                    Validar = true;
                                }
                                
                            }
                        }
                        
                    }
                    Lista_02[Lista_02.Count - 1] = Lista_02[Lista_02.Count - 1] + Letra;
                }
            }
            
            
            // CALCULO NIVEL 00 ---------------------------------------------------
            // aqui procesamos la parte de los parentesis
            if (Validar_Parentesis(Lista_02) == true)
            {
                Lista_02 = Calcular_Parentesis(Lista_02);
            }
            
            // CALCULO NIVEL 01 ---------------------------------------------------
            // aqui procesamos los calculos para las operaciones de 
            // multiplicacion y division de Izquierda a Derecha
            Lista_02 = Calcular_Nivel_01(Lista_02);
            
            
            // CALCULO NIVEL 02 ---------------------------------------------------
            // aqui procesamos los calculos para las operaciones de 
            // adicion y substracion de Izquierda a Derecha
            Lista_02 = Calcular_Nivel_02(Lista_02);
            
            
            // MOSTRAR EN PANTALLA ------------------------------------------------
            
            lbl_Pantalla.Text = "";
            Lista_01.Clear();
            foreach (var db in Lista_02)
            {
                lbl_Pantalla.Text += db;
            }
            foreach (var txt in lbl_Pantalla.Text)
            {
                Lista_01.Add(txt.ToString());
            }
            // FIN ----------------------------------------------------------------
        }
        
        
        private List<string> Calcular_Parentesis(List<string> Lista_X)
        {
            List<string> Temp02 = new List<string>(Lista_X);
            List<string> Temp03 = new List<string>();
            
            for (int k = 0; k < Contar_Parentesis(Lista_X); k++)
            {
                bool Control = false;
                Temp03.Clear();
                // aqui buscamos el "(" que abre
                for (int i = 0; i < Temp02.Count; i++)
                {
                    if (i < Temp02.Count)
                    {
                        if (Temp02[i] == "(")
                        {
                            if (Control == false)
                            {
                                // aqui buscamos el ")" que cierra
                                for (int j = i; j < Temp02.Count; j++)
                                {
                                    if (Temp02[j] == ")")
                                    {
                                        if (Control == false)
                                        {
                                            // aqui extraemos los elementos que estan
                                            // entre los "(...)"
                                            for (int h = i + 1; h < j; h++)
                                            {
                                                Temp03.Add(Temp02[h]);
                                            }
                                            // aqui validamos si existen "(" o ")" 
                                            // en medio del rango seleccionado
                                            if (Existe_Parentesis(Temp03) == false)
                                            {
                                                Control = true;
                                                // CALCULO NIVEL 01 -----------------------------------
                                                Temp03 = Calcular_Nivel_01(Temp03);
                                                // CALCULO NIVEL 02 -----------------------------------
                                                Temp03 = Calcular_Nivel_02(Temp03);
                                                
                                                // aqui le digo que actualice la lista
                                                for (int r = i; r <= j; r++)
                                                {
                                                    Temp02.RemoveAt(i);
                                                }
                                                Temp02.Insert(i, Temp03[0]);
                                            }
                                            else
                                            {
                                                Temp03.Clear();
                                            }
                                        }
                                        
                                    }
                                }
                            }
                            
                        }
                    }
                }
            }
            return Temp02;
        }
        
        private List<string> Calcular_Nivel_01(List<string> Lista_X)
        {
            List<string> Temp02 = new List<string>(Lista_X);
            List<string> Temp03 = new List<string>();
            
            for (int k = 0; k < Contar_Oper_Nivel_01(Lista_X); k++)
            {
                bool Control = false;
                Temp03.Clear();
                for (int j = 0; j < Temp02.Count; j++)
                {
                    if (j < Temp02.Count)
                    {
                        if (Temp02[j] == "x")
                        {
                            if (Control == false)
                            {
                                Temp03.RemoveAt(Temp03.Count - 1);
                                Temp03.Add((decimal.Parse(Temp02[j - 1]) * decimal.Parse(Temp02[j + 1])).ToString());
                                Control = true;
                                j++;
                                j++;
                            }
                        }
                    }
                    
                    if (j < Temp02.Count)
                    {
                        if (Temp02[j] == "/")
                        {
                            if (Control == false)
                            {
                                Temp03.RemoveAt(Temp03.Count - 1);
                                Temp03.Add(decimal.Round(decimal.Parse(Temp02[j - 1]) / decimal.Parse(Temp02[j + 1]), 8).ToString());
                                Control = true;
                                j++;
                                j++;
                            }
                        }
                    }
                    if (j < Temp02.Count)
                    {
                        Temp03.Add(Temp02[j]);
                    }
                }
                Temp02 = new List<string>(Temp03);
            }
            return Temp02;
        }
        
        private List<string> Calcular_Nivel_02(List<string> Lista_X)
        {
            List<string> Temp02 = new List<string>(Lista_X);
            List<string> Temp03 = new List<string>();

            for (int k = 0; k < Contar_Oper_Nivel_02(Lista_X); k++)
            {
                bool Control = false;
                Temp03.Clear();
                for (int j = 0; j < Temp02.Count; j++)
                {
                    if (j < Temp02.Count)
                    {
                        if (Temp02[j] == "+")
                        {
                            if (Control == false)
                            {
                                Temp03.RemoveAt(Temp03.Count - 1);
                                Temp03.Add((decimal.Parse(Temp02[j - 1]) + decimal.Parse(Temp02[j + 1])).ToString());
                                Control = true;
                                j++;
                                j++;
                            }
                        }
                    }
                    
                    if (j < Temp02.Count)
                    {
                        if (Temp02[j] == "-")
                        {
                            if (Control == false)
                            {
                                Temp03.RemoveAt(Temp03.Count - 1);
                                Temp03.Add((decimal.Parse(Temp02[j - 1]) - decimal.Parse(Temp02[j + 1])).ToString());
                                Control = true;
                                j++;
                                j++;
                            }
                        }
                    }
                    
                    if (j < Temp02.Count)
                    {
                        Temp03.Add(Temp02[j]);
                    }
                }
                Temp02 = new List<string>(Temp03);
            }
            return Temp02;
        }
        
        private int Contar_Oper_Nivel_01(List<string> Lista04)
        {
            int Contador = 0;
            foreach (string str in Lista04)
            {
                if (str == "x" || str == "/")
                {
                    Contador++;
                }
            }
            return Contador;
        }
        
        private int Contar_Oper_Nivel_02(List<string> Lista04)
        {
            int Contador = 0;
            foreach (string str in Lista04)
            {
                if (str == "+" || str == "-")
                {
                    Contador++;
                }
            }
            return Contador;
        }
        
        private int Contar_Parentesis(List<string> Lista_X)
        {
            int P_Open = 0;
            
            foreach (var db in Lista_X)
            {
                if (db == "(")
                {
                    P_Open++;
                }
            }
            return P_Open;
        }
        
        private bool Existe_Parentesis(List<string> Lista_03)
        {
            bool Valido = false;
            
            foreach(var db in Lista_03)
            {
                if (db == "(" || db == ")")
                {
                    Valido = true;
                }
            }
            
            if (Valido == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        private bool Validar_Parentesis(List<string> Lista_03)
        {
            int P_Open = 0;
            int P_Close = 0;
            foreach (var db in Lista_03)
            {
                if (db == "(")
                {
                    P_Open++;
                }
                if (db == ")")
                {
                    P_Close++;
                }
            }
            if (P_Open == P_Close)
            {
                if (P_Open == 0 && P_Close == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                
            }
            else
            {
                return false;
            }
            
        }

    }
}
