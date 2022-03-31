using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinoooooo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            int rozmer = 50;
            panel1.Controls.Clear();
            int Sloupce = 17;
            int Radky = 10;
            int Dvojsedacky = 6;
            int[,] dvoupole = new int[Sloupce, Radky];

            for (int i = 0; i < Radky; i++)
            {
                for (int j = 0; j < Sloupce; j++)
                {
                    dvoupole[j, i] = 0;
                }
            }
            for (int i = 1; i <= Radky; i++)
            {
                if (i == 1)
                {
                    int pomocna = 0;
                    for (int j = 1; j <= Dvojsedacky; j++)
                    {
                        Button tlacitko = new Button();
                        tlacitko.Text = "" + Convert.ToChar(j + 64) + " " + i.ToString();
                        tlacitko.Width = rozmer * 2;
                        tlacitko.Height = rozmer;
                        tlacitko.Left = rozmer + pomocna;
                        tlacitko.Top = rozmer;
                        tlacitko.Click += tlacitko_Click;                       
                        panel1.Controls.Add(tlacitko);
                        pomocna += 150;
                    }
                }
                else
                {
                    for (int j = 1; j <= Sloupce; j++)
                    {
                        Button tlacitko = new Button();
                        tlacitko.Text = "" + Convert.ToChar(j + 64) + " " + i.ToString();
                        tlacitko.Width = rozmer;
                        tlacitko.Height = rozmer;
                        tlacitko.Left = rozmer * j;
                        tlacitko.Top = rozmer * i;
                        tlacitko.Click += tlacitko_Click;
                        panel1.Controls.Add(tlacitko);
                    }
                }
            }
        }
        private void tlacitko_Click(object sender, EventArgs e)
        {
            DialogResult vysledek = MessageBox.Show("Chcete zarezervovat sedadlo č. " + (sender as Button).Text + "?", "Objednávka", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(vysledek == DialogResult.Yes)
            {
                MessageBox.Show("Sedadlo č. " + (sender as Button).Text + " bylo zarezervováno", "Objednávka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }       
    }
}

