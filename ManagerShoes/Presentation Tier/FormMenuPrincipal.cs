using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Tier
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormConsulta formConsulta = new FormConsulta();
            formConsulta.TopLevel = false;
            formConsulta.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;           
            panel1.Controls.Add(formConsulta);
            formConsulta.Show();

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormAlta formAlta = new FormAlta();
            formAlta.TopLevel = false;
            formAlta.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;           
            panel1.Controls.Add(formAlta);
            formAlta.Show();
        }
    }
}
