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

namespace Assigenmet2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string data = "Student Name :" + txtStudentName.Text + "Student Id : " + txtStudentID.Text;
                File.WriteAllText(saveFileDialog1.FileName, data);
                MessageBox.Show("seccseful");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string content = File.ReadAllText(openFileDialog1.FileName);
                MessageBox.Show(content , "oppend the file");
                 
            }
        }
    }
}
