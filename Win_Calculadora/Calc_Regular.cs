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
    public partial class Calc_Regular : Form
    {
        public Calc_Regular()
        {
            InitializeComponent();
        }

        // VARIABLES GLOBALES----------------------------------------------------------
        decimal MEMO = 0;

        private void Calc_Regular_Load(object sender, EventArgs e)
        {
            lbl_Operacion02.Text = "";
            lbl_Pantalla.Text = "0";
            lbl_Memo.Text = "";
        }

        // BOTONES NUMEROS--------------------------------------------------------------
        private void btn_01_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "1";
            }
            else
            {
                if (lbl_Pantalla.Text.Length < 8)
                {
                    lbl_Pantalla.Text += "1";
                }

            }

        }

        private void btn_02_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "2";
            }
            else
            {
                if (lbl_Pantalla.Text.Length < 8)
                {
                    lbl_Pantalla.Text += "2";
                }

            }
        }

        private void btn_03_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "3";
            }
            else
            {
                if (lbl_Pantalla.Text.Length < 8)
                {
                    lbl_Pantalla.Text += "3";
                }

            }
        }

        private void btn_04_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "4";
            }
            else
            {
                if (lbl_Pantalla.Text.Length < 8)
                {
                    lbl_Pantalla.Text += "4";
                }

            }
        }

        private void btn_05_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "5";
            }
            else
            {
                if (lbl_Pantalla.Text.Length < 8)
                {
                    lbl_Pantalla.Text += "5";
                }

            }
        }

        private void btn_06_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "6";
            }
            else
            {
                if (lbl_Pantalla.Text.Length < 8)
                {
                    lbl_Pantalla.Text += "6";
                }

            }
        }

        private void btn_07_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "7";
            }
            else
            {
                if (lbl_Pantalla.Text.Length < 8)
                {
                    lbl_Pantalla.Text += "7";
                }

            }
        }

        private void btn_08_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "8";
            }
            else
            {
                if (lbl_Pantalla.Text.Length < 8)
                {
                    lbl_Pantalla.Text += "8";
                }

            }
        }

        private void btn_09_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "9";
            }
            else
            {
                if (lbl_Pantalla.Text.Length < 8)
                {
                    lbl_Pantalla.Text += "9";
                }

            }
        }

        private void btn_00_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "0";
            }
            else
            {
                if (lbl_Pantalla.Text.Length < 8)
                {
                    lbl_Pantalla.Text += "0";
                }

            }
        }

        private void btn_pto_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text += ".";
            }
            else
            {
                if (lbl_Pantalla.Text.Length < 8)
                {
                    if (lbl_Pantalla.Text.Contains(".") == false)
                    {
                        lbl_Pantalla.Text += ".";
                    }

                }

            }
        }

        // BOTONES LIMPIAR--------------------------------------------------------------

        private void btn_CA_Click(object sender, EventArgs e)
        {
            lbl_Pantalla.Text = "0";
            lbl_Operacion02.Text = "";
            lbl_Memo.Text = "";
            MEMO = 0;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text == "0")
            {
                lbl_Pantalla.Text = "0";
            }
            else
            {
                lbl_Pantalla.Text = lbl_Pantalla.Text.Substring(0, lbl_Pantalla.Text.Length - 1);
                if (lbl_Pantalla.Text.Length == 0)
                {
                    lbl_Pantalla.Text = "0";
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


        // BOTONES OPERACIONES--------------------------------------------------------------

        private void btn_mas_Click(object sender, EventArgs e)
        {
            if (lbl_Operacion02.Text == "")
            {
                MEMO = decimal.Parse(lbl_Pantalla.Text);
                lbl_Memo.Text = MEMO.ToString();
                lbl_Operacion02.Text = "+";
                lbl_Pantalla.Text = "0";
            }
            else
            {

                if (lbl_Pantalla.Text != "0")
                {
                    switch (lbl_Operacion02.Text)
                    {
                        case "+":
                            MEMO = MEMO + decimal.Parse(lbl_Pantalla.Text);
                            lbl_Memo.Text = MEMO.ToString();
                            lbl_Pantalla.Text = "0";
                            break;

                        case "-":
                            MEMO = MEMO - decimal.Parse(lbl_Pantalla.Text);
                            lbl_Memo.Text = MEMO.ToString();
                            lbl_Pantalla.Text = "0";
                            break;

                        case "x":
                            MEMO = MEMO * decimal.Parse(lbl_Pantalla.Text);
                            lbl_Memo.Text = MEMO.ToString();
                            lbl_Pantalla.Text = "0";
                            break;

                        case "/":
                            MEMO = MEMO / decimal.Parse(lbl_Pantalla.Text);
                            lbl_Memo.Text = MEMO.ToString();
                            lbl_Pantalla.Text = "0";
                            break;

                    }
                }

                lbl_Operacion02.Text = "+";

            }

        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            if (lbl_Operacion02.Text == "")
            {
                MEMO = decimal.Parse(lbl_Pantalla.Text);
                lbl_Memo.Text = MEMO.ToString();
                lbl_Operacion02.Text = "-";
                lbl_Pantalla.Text = "0";
            }
            else
            {

                if (lbl_Pantalla.Text != "0")
                {
                    switch (lbl_Operacion02.Text)
                    {
                        case "+":
                            MEMO = MEMO + decimal.Parse(lbl_Pantalla.Text);
                            lbl_Memo.Text = MEMO.ToString();
                            lbl_Pantalla.Text = "0";
                            break;

                        case "-":
                            MEMO = MEMO - decimal.Parse(lbl_Pantalla.Text);
                            lbl_Memo.Text = MEMO.ToString();
                            lbl_Pantalla.Text = "0";
                            break;

                        case "x":
                            MEMO = MEMO * decimal.Parse(lbl_Pantalla.Text);
                            lbl_Memo.Text = MEMO.ToString();
                            lbl_Pantalla.Text = "0";
                            break;

                        case "/":
                            MEMO = MEMO / decimal.Parse(lbl_Pantalla.Text);
                            lbl_Memo.Text = MEMO.ToString();
                            lbl_Pantalla.Text = "0";
                            break;

                    }
                }

                lbl_Operacion02.Text = "-";

            }

        }

        private void btn_por_Click(object sender, EventArgs e)
        {
            if (lbl_Operacion02.Text == "")
            {
                MEMO = decimal.Parse(lbl_Pantalla.Text);
                lbl_Memo.Text = MEMO.ToString();
                lbl_Operacion02.Text = "x";
                lbl_Pantalla.Text = "0";
            }
            else
            {

                if (lbl_Pantalla.Text != "0")
                {
                    switch (lbl_Operacion02.Text)
                    {
                        case "+":
                            MEMO = MEMO + decimal.Parse(lbl_Pantalla.Text);
                            lbl_Memo.Text = MEMO.ToString();
                            lbl_Pantalla.Text = "0";
                            break;

                        case "-":
                            MEMO = MEMO - decimal.Parse(lbl_Pantalla.Text);
                            lbl_Memo.Text = MEMO.ToString();
                            lbl_Pantalla.Text = "0";
                            break;

                        case "x":
                            MEMO = MEMO * decimal.Parse(lbl_Pantalla.Text);
                            lbl_Memo.Text = MEMO.ToString();
                            lbl_Pantalla.Text = "0";
                            break;

                        case "/":
                            MEMO = MEMO / decimal.Parse(lbl_Pantalla.Text);
                            lbl_Memo.Text = MEMO.ToString();
                            lbl_Pantalla.Text = "0";
                            break;

                    }
                }

                lbl_Operacion02.Text = "x";

            }

        }

        private void btn_entre_Click(object sender, EventArgs e)
        {
            if (lbl_Operacion02.Text == "")
            {
                MEMO = decimal.Parse(lbl_Pantalla.Text);
                lbl_Memo.Text = MEMO.ToString();
                lbl_Operacion02.Text = "/";
                lbl_Pantalla.Text = "0";
            }
            else
            {

                if (lbl_Pantalla.Text != "0")
                {
                    switch (lbl_Operacion02.Text)
                    {
                        case "+":
                            MEMO = MEMO + decimal.Parse(lbl_Pantalla.Text);
                            lbl_Memo.Text = MEMO.ToString();
                            lbl_Pantalla.Text = "0";
                            break;

                        case "-":
                            MEMO = MEMO - decimal.Parse(lbl_Pantalla.Text);
                            lbl_Memo.Text = MEMO.ToString();
                            lbl_Pantalla.Text = "0";
                            break;

                        case "x":
                            MEMO = MEMO * decimal.Parse(lbl_Pantalla.Text);
                            lbl_Memo.Text = MEMO.ToString();
                            lbl_Pantalla.Text = "0";
                            break;

                        case "/":
                            MEMO = MEMO / decimal.Parse(lbl_Pantalla.Text);
                            lbl_Memo.Text = MEMO.ToString();
                            lbl_Pantalla.Text = "0";
                            break;

                    }
                }

                lbl_Operacion02.Text = "/";

            }

        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            if (lbl_Pantalla.Text != "0")
            {
                switch (lbl_Operacion02.Text)
                {
                    case "+":
                        lbl_Pantalla.Text = Math.Round(MEMO + decimal.Parse(lbl_Pantalla.Text), 5).ToString();
                        lbl_Memo.Text = "";
                        lbl_Operacion02.Text = "";
                        break;

                    case "-":
                        lbl_Pantalla.Text = Math.Round(MEMO - decimal.Parse(lbl_Pantalla.Text), 5).ToString();
                        lbl_Memo.Text = "";
                        lbl_Operacion02.Text = "";
                        break;

                    case "x":
                        lbl_Pantalla.Text = Math.Round(MEMO * decimal.Parse(lbl_Pantalla.Text), 5).ToString();
                        lbl_Memo.Text = "";
                        lbl_Operacion02.Text = "";
                        break;

                    case "/":
                        lbl_Pantalla.Text = Math.Round(MEMO / decimal.Parse(lbl_Pantalla.Text), 5).ToString();
                        lbl_Memo.Text = "";
                        lbl_Operacion02.Text = "";
                        break;

                }
            }
        }

    }
}
