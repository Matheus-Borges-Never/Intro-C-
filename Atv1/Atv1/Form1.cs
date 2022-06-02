using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atv1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double v1 = 0, v2 = 0, v = 0;

            v1 = Convert.ToDouble(txtValor1.Text);
            v2 = Convert.ToDouble(txtValor2.Text);
            v = v1 - v2;


            if (rdbMaior.Checked == true)
            {
                if (v1 > v2)
                {
                    lblResultado.Text = (v1 + " é maior que " + v2); 
                }
                else if (v1 < v2)
                {
                    lblResultado.Text = (v2 + " é maior que " + v1);
                }
                else if (v1 == v2)
                {
                    lblResultado.Text = (v1 + " é igual " + v2);
                }
            }
            else if (rdbDiferenca.Checked == true)
            {
                lblResultado.Text = ("A diferença entre " + v1 + " e " + v2 + " é " + v);
            }
            else if (rdbEntre.Checked == true)
            {
                if (v1 < v2)
                {
                    int cont = 0;
                    lblResultado.Text = "";

                    for (cont = (int)v1 + 1; cont < v2; cont++)
                    {
                        lblResultado.Text += " " + cont;
                    }
                } 
                else if (v1 > v2)
                {
                    int cont = 0;
                    lblResultado.Text = "";

                    for (cont = (int)v2 + 1; cont < v1; cont++)
                    {
                        lblResultado.Text += " " + cont;
                    }
                }
                else
                {
                    lblResultado.Text = ("Ambos números são iguais!!");
                }

               
            }
            else
            {
                lblResultado.Text = ("Selecione uma ação.");
            }

        }
    }
}
