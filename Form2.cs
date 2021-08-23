using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exemplo_While_For
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            novo.Show();
            this.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int contador;
            contador = 2016;

            while (contador >= 1950)
            {
                cboAno.Items.Add(contador);
                contador--;
            } 
        }
    }
}
