using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEndingBlance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            decimal startingBalance;
            int numberOfMonths;

            // Validate the starting balance
            if (!decimal.TryParse(txtStringBalance.Text, out startingBalance)
                || startingBalance < 0)
            {
                MessageBox.Show("Enter a valid starting balance.");
                txtStringBalance.Focus();
                return;
            }

            // Validate the number of months
            if (!int.TryParse(txtNumberOfMonths.Text, out numberOfMonths)
                || numberOfMonths <= 0)
            {
                MessageBox.Show("Enter a valid number of months.");
                txtNumberOfMonths.Focus();
                return;
            }

            decimal balance = startingBalance;

            // Clear previous results
            
           
            detailListBox.Items.Clear();

            // Calculate the ending balance for each month
            for (int month = 1; month <= numberOfMonths; month++)
            {
                balance =  balance * 1.005m;
                  
                detailListBox.Items.Add(
                    $"The ending balance for month {month} is {balance:C2}"
                );
            }

            // Display the final ending balance
            txtEndingBalance.Text = balance.ToString("C2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtStringBalance.Clear();
            txtNumberOfMonths.Clear();
            txtEndingBalance.Clear();
            detailListBox.Items.Clear();

            txtStringBalance.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

