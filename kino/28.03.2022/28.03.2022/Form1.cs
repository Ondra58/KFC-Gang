using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28._03._2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();                     
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int Sloupce = Convert.ToInt32(numericUpDown1.Value);
            numericUpDown3.Maximum = Sloupce / 2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int rozmer = 50;
            panel1.Controls.Clear();

            //Label sl = new Label();
            //sl.Text = "Sloupce";
            //sl.Left = rozmer;
            //sl.Top = rozmer / 2;
            //this.Controls.Add(sl);

            //NumericUpDown slNum = new NumericUpDown();
            //slNum.Minimum = 1;
            //sl.Left = sl.Size.Width + 10;
            //sl.Top = rozmer / 2;
            //this.Controls.Add(slNum);

            int Sloupce = Convert.ToInt32(numericUpDown1.Value);
            int Radky = Convert.ToInt32(numericUpDown2.Value);
            int Dvojsedacky = Convert.ToInt32(numericUpDown3.Value);
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
                if (i == 1 && Dvojsedacky != 0)
                {
                    for (int j = 1; j <= Dvojsedacky; j++)
                    {
                        Button tlacitko = new Button();
                        tlacitko.Text = "" + Convert.ToChar(j + 64) + " " + i.ToString();
                        tlacitko.Width = rozmer * 2;
                        tlacitko.Height = rozmer;
                        if (j == 1)
                        {
                            tlacitko.Left = rozmer * j;
                        }
                        else
                        {
                            tlacitko.Left = rozmer * 2 * j;
                        }
                        tlacitko.Click += tlacitko_Click;
                        panel1.Controls.Add(tlacitko);
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
            MessageBox.Show("Chcete zarezervovat sedadlo č. "+(sender as Button).Text+"?", "Objednávka", MessageBoxButtons.YesNo, MessageBoxIcon.Question);           
        }

        
    }
}
