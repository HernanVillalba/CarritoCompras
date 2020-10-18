using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1WF
{
    public partial class Hola : Form
    {
        public Hola()
        {
            InitializeComponent();
        }

        private void BotonSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola mundo!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No te saludo, ja");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
