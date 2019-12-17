using Business;
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
    public partial class FormAlta : Form
    {
        private Product product = new Product();
        private Provider provider = new Provider();

        public FormAlta()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            var productColors = product.GetProductColors();
            foreach (var item in productColors)
            {
                listBoxProductColors.Items.Add(item.Name);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //To where your opendialog box get starting location. My initial directory location is desktop.
                openFileDialog.InitialDirectory = "C://Desktop";

                //Your opendialog box title name.
                openFileDialog.Title = "Selecciona la imagen a ser cargada";
                //which type image format you want to upload in database. just add them.
                openFileDialog.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

                //FilterIndex property represents the index of the filter currently selected in the file dialog box.
                openFileDialog.FilterIndex = 1;

                try
                {
                    if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (openFileDialog.CheckFileExists)
                        {
                            pictureBox.Image = new Bitmap(openFileDialog.FileName);
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Upload image.");
                    }
                }
                catch (Exception ex)
                {
                    //it will give if file is already exits..
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
