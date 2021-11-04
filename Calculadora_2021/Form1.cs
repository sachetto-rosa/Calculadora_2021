using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_2021
{
    public partial class Form1 : Form
    {
        VisualEffects visualEffects;
        Task blink;

        public Form1()
        {
            InitializeComponent();

            this.visualEffects = new VisualEffects();
            this.visualEffects.ChangeColor += changeTextBoxColor;

            this.blink = new Task(visualEffects.doVisualEffects);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tBmensagem.Text = "Calculadora de SisSup 2021/2!";

            this.blink.Start();
        }

        private void changeTextBoxColor(object sender, EventArgs e)
        {
            if (tBmensagem.BackColor == System.Drawing.Color.Red)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    tBmensagem.BackColor = System.Drawing.Color.Green;
                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    tBmensagem.BackColor = System.Drawing.Color.Red;
                });
            }
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            double numero1, numero2, result;

            try
            {
                numero1 = double.Parse(tBsoma1.Text);
                numero2 = double.Parse(tBsoma2.Text);

                result = numero1 + numero2;

                tBSomaResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                tBmensagem.Text = ex.Message;
            }
        }
    }
}