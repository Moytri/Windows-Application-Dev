using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign05
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //initially result label is empty 
        private void MainForm_Load(object sender, EventArgs e)
        {
           labelResult.Text = string.Empty;
        }

        private void buttonCheckDate_Click(object sender, EventArgs e)
        {
            bool isValidDate = DateValidator.Validate(textBoxYear.Text, textBoxMonth.Text, textBoxDay.Text);
            showResult(isValidDate);
        }

        private void showResult(bool isValidDate)
        {
            if(isValidDate)
            {
                labelResult.ForeColor = Color.Green;
                labelResult.Text = "Valid";
                toolTip.SetToolTip(labelResult, "Entered Date is Valid");
            }
            else
            {
                labelResult.ForeColor = Color.Red;
                labelResult.Text = "Invalid";
                toolTip.SetToolTip(labelResult, "Entered Date is NOT Valid");
            }
        }

        //previous input is highlighted when a textbox is reentered
        private void textBoxYear_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.SelectAll();
        }
    }
}
