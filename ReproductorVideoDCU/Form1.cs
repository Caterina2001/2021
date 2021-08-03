using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproductorVideoDCU
{
    //2019-8106
    public partial class Form1 : Form
    {
        private string link = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                link = openFileDialog1.FileName;
                lbruta.Text = link;
            }
        }

        private void btReproducir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = link;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btPausar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btDetener_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}
