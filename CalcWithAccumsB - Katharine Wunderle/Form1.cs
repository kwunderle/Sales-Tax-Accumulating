using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWithAccumsB___Katharine_Wunderle
{
    //Author: Katharine Wunderle
    //ID: 623748
    //Date: 03/02/2021
    //Goal: Calculate total price with sales tax and accumulate total sales and tax
    public partial class taxCalcAccum : Form
    {
        //Tax rate constant
        private const decimal TAX_RATE = .0675m;
        //Declare accumulation variables
        decimal grdTtl = 0m;
        decimal ttlTax = 0m;
        decimal ttlAmt = 0m;
        int ttlItems = 0;
        decimal average = 0;
        public taxCalcAccum()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            //declare variables
            decimal salesAmount;
            decimal taxAmount;
            decimal totalAmount;
           
            //Get Sales Amount as input from user
            salesAmount = decimal.Parse(salesAmountInputTxtBx.Text);

            //Calculate Tax Amount
            taxAmount = salesAmount * TAX_RATE;
            //Calculate Total Price
            totalAmount = salesAmount + taxAmount;
            //Calculate grand total
            grdTtl += salesAmount;
            //Calculate tax total
            ttlTax += taxAmount;
            //Calculate total amount to pay
            ttlAmt += totalAmount;
            //Calculate total items sold
            ttlItems++;
            //Calculate average cost per item before tax
            average = grdTtl / ttlItems;

            //Display Tax Amount
            taxAmountOutput.Text = taxAmount.ToString("c");
            //Display Total Price
            totalAmountOutput.Text = totalAmount.ToString("c");
             //Display grand total
            gndTtlOutput.Text = grdTtl.ToString("c");
            //Display tax total
            ttlTaxOutPut.Text = ttlTax.ToString("c");
            //Display total amount to pay
            ttlAmtOutput.Text = ttlAmt.ToString("c");
            //Display total items sold
            ttlItemsOutput.Text = ttlItems.ToString();
            //Display average cost per item before tax
            avgCostOutput.Text = average.ToString("c");
        }

        private void taxCalcAccum_Load(object sender, EventArgs e)
        {//Display current tax rate
            taxRateLbl.Text = "(@ " + TAX_RATE.ToString("p") + "):";

        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            //Clear text boxes
            salesAmountInputTxtBx.Text = "";
            taxAmountOutput.Text = "";
            totalAmountOutput.Text = "";
            gndTtlOutput.Text = "";
            ttlTaxOutPut.Text = "";
            ttlAmtOutput.Text = "";
            ttlItemsOutput.Text = "";
            avgCostOutput.Text = "";
        }
    }
}
