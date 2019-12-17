using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace Presentation_Tier
{
    public partial class FormConsulta : Form
    {
        private Product businessProduct = new Business.Product();
        public FormConsulta()
        {
            InitializeComponent();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            
            //businessProduct.GetProduct(3,String.Empty);

            int number;
            bool success = Int32.TryParse(textBoxProdId.Text, out number);
            if (success)
            {
                dataGridView1.DataSource = businessProduct.GetProduct(number, "");
            }
            else if(!(success = Int32.TryParse(textBoxProdName.Text,out number)))
            {
                dataGridView1.DataSource = businessProduct.GetProduct(null, textBoxProdName.Text);
            }
            
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private void textBoxProdId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteProd(object sender, EventArgs e)
        {
           var isDeleted = businessProduct.DeleteProduct(   Int16.Parse(textBoxProdId.Text));
        }
    }
}
