using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Created by: Tiva Rait
 * Created on: 07-03-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 - Circumference
 * This program asks the user for the radius and then calculates...
 * ... The circumference for them.
*/

namespace Circumference
{
    public partial class frmCircumference : Form
    {
        public frmCircumference()
        {
            InitializeComponent();
            this.lblQuestionAnswer.Hide();
            this.lblAnswer.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Declare Variables
            double radius, circumference;
            const double PI = 3.14;

            // Get the radius
            radius = double.Parse(txtUsersInputBox.Text);

            // Calculation
            circumference = 2 * PI * radius;

            this.lblQuestionAnswer.Show();
            this.lblAnswer.Show();
            this.lblAnswer.Text = Convert.ToString(circumference) + " cm";
        }
    }
}
