using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojaPrvaWindowsAplikacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIzracun_Click(object sender, EventArgs e)
        {
            try
            {
                int brojA, brojB, zbroj;
                brojA = Convert.ToInt32(txtUnosBrA.Text);
                brojB = Convert.ToInt32(txtUnosBrB.Text);
                zbroj = brojA + brojB;
                txtRez.Text = Convert.ToString(zbroj);
            }
            catch(Exception ex)
            {
                string text = "Molim upisati broj. \n" + ex.Message;
                string naslov = "Pogrešan unos";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icons = MessageBoxIcon.Error;
                MessageBox.Show(text, naslov, buttons, icons);
            }
        }

        private void txtRez_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
