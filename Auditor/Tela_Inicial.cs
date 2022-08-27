using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auditor
{
    public partial class Tela_Inicial : Form
    {
        public Tela_Inicial()
        {
            InitializeComponent();
        }

        private void buscadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscador to = new Buscador();
            to.Show();
        }
    }
}
