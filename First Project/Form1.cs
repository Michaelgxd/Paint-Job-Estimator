using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Project
{
    public partial class FirstProjectForm : Form
    {
        public FirstProjectForm()
        {
            InitializeComponent();
        }

        private void demoButton_Click(object sender, EventArgs e)
        {
            int gallons, hours, squareFeet;
            double paintCost, laborCost, totalCost, paintPerGallon;
            int.TryParse(squareFeetInput.Text, out squareFeet);
            double.TryParse(pricePaintInput.Text, out paintPerGallon);


            gallons = squareFeet / 15;
            hours = gallons * 8;
            paintCost = paintPerGallon * gallons;
            laborCost = hours * 20.00;
            totalCost = laborCost + paintCost;

            lblOutputGallonsPaint.Text = gallons.ToString("0.##");
            lblOutputHoursLabor.Text = hours.ToString("0.##");
            lblOutputCostPaint.Text = paintCost.ToString("0.##");
            lblOutputLaborCharges.Text = laborCost.ToString("0.##");
            lblOutputTotalCost.Text = totalCost.ToString("0.##");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSquareFeet_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPricePaint_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
