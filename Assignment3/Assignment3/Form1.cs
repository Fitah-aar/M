using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtNoteContent.Clear();
            txtTitle.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitle.Text))
                {
                    MessageBox.Show("Enter the name");
                    return;
                }

                saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog1.FileName = txtTitle.Text.Trim() + ".txt";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                { 
                    string fullContent = "Title : " + txtTitle.Text + "Content :" + txtNoteContent.Text;


                    File.WriteAllText(saveFileDialog1.FileName, fullContent);
                    MessageBox.Show("Seccseful" );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtNoteContent.Text = File.ReadAllText(openFileDialog1.FileName);
                    txtTitle.Text = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                    MessageBox.Show("Secccseful");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtNoteContent.Clear();
            txtTitle.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
