using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace cifraViginere
{
    public partial class Form1 : Form
    {
        private string fextension;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog ofd = new OpenFileDialog();
        private Viginere v = new Viginere();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkEncriptar_CheckedChanged(object sender, EventArgs e)
        {
            if(checkEncriptar.Checked == true)
            {
                txtSaida.Text = "";
                checkDescriptar.Checked = false;
            }
        }

        private void checkDescriptar_CheckedChanged(object sender, EventArgs e)
        {
            if(checkDescriptar.Checked == true)
            {
                txtSaida.Text = "";
                checkEncriptar.Checked = false;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if ( checkEncriptar.Checked == true)
            {
                txtSaida.Text = v.Encriptar(txtEntrada.Text, txtChave.Text);
            }
            if (checkDescriptar.Checked == true)
            {
                txtSaida.Text = v.Descriptar(txtEntrada.Text, txtChave.Text);
            }
        }
    }
}
