
namespace CalcWithAccumsB___Katharine_Wunderle
{
    partial class taxCalcAccum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterSalesAmtLbl = new System.Windows.Forms.Label();
            this.taxAmtLbl = new System.Windows.Forms.Label();
            this.taxRateLbl = new System.Windows.Forms.Label();
            this.taxAmountOutput = new System.Windows.Forms.Label();
            this.salesAmountInputTxtBx = new System.Windows.Forms.TextBox();
            this.totalAmtLbl = new System.Windows.Forms.Label();
            this.totalAmountOutput = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.grndTtlLbl = new System.Windows.Forms.Label();
            this.gndTtlOutput = new System.Windows.Forms.Label();
            this.ttlTaxLbl = new System.Windows.Forms.Label();
            this.ttlTaxOutPut = new System.Windows.Forms.Label();
            this.tltAmt = new System.Windows.Forms.Label();
            this.ttlAmtOutput = new System.Windows.Forms.Label();
            this.ttlItemsLbl = new System.Windows.Forms.Label();
            this.ttlItemsOutput = new System.Windows.Forms.Label();
            this.avgCostLbl = new System.Windows.Forms.Label();
            this.avgCostOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterSalesAmtLbl
            // 
            this.enterSalesAmtLbl.AutoSize = true;
            this.enterSalesAmtLbl.Location = new System.Drawing.Point(23, 25);
            this.enterSalesAmtLbl.Name = "enterSalesAmtLbl";
            this.enterSalesAmtLbl.Size = new System.Drawing.Size(96, 26);
            this.enterSalesAmtLbl.TabIndex = 0;
            this.enterSalesAmtLbl.Text = "Please Enter Sales\r\nAmount:";
            this.enterSalesAmtLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxAmtLbl
            // 
            this.taxAmtLbl.AutoSize = true;
            this.taxAmtLbl.Location = new System.Drawing.Point(27, 97);
            this.taxAmtLbl.Name = "taxAmtLbl";
            this.taxAmtLbl.Size = new System.Drawing.Size(99, 13);
            this.taxAmtLbl.TabIndex = 1;
            this.taxAmtLbl.Text = "Your Tax Amount is";
            this.taxAmtLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxRateLbl
            // 
            this.taxRateLbl.AutoSize = true;
            this.taxRateLbl.Location = new System.Drawing.Point(40, 119);
            this.taxRateLbl.Name = "taxRateLbl";
            this.taxRateLbl.Size = new System.Drawing.Size(63, 13);
            this.taxRateLbl.TabIndex = 2;
            this.taxRateLbl.Text = "TAX_RATE";
            this.taxRateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxAmountOutput
            // 
            this.taxAmountOutput.BackColor = System.Drawing.Color.Yellow;
            this.taxAmountOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxAmountOutput.Location = new System.Drawing.Point(35, 143);
            this.taxAmountOutput.Name = "taxAmountOutput";
            this.taxAmountOutput.Size = new System.Drawing.Size(79, 36);
            this.taxAmountOutput.TabIndex = 3;
            // 
            // salesAmountInputTxtBx
            // 
            this.salesAmountInputTxtBx.Location = new System.Drawing.Point(26, 54);
            this.salesAmountInputTxtBx.Name = "salesAmountInputTxtBx";
            this.salesAmountInputTxtBx.Size = new System.Drawing.Size(100, 20);
            this.salesAmountInputTxtBx.TabIndex = 4;
            // 
            // totalAmtLbl
            // 
            this.totalAmtLbl.AutoSize = true;
            this.totalAmtLbl.Location = new System.Drawing.Point(23, 208);
            this.totalAmtLbl.Name = "totalAmtLbl";
            this.totalAmtLbl.Size = new System.Drawing.Size(101, 26);
            this.totalAmtLbl.TabIndex = 5;
            this.totalAmtLbl.Text = "The Total Amount\r\nYou Have to Pay is:";
            this.totalAmtLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalAmountOutput
            // 
            this.totalAmountOutput.BackColor = System.Drawing.Color.Aqua;
            this.totalAmountOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalAmountOutput.Location = new System.Drawing.Point(35, 249);
            this.totalAmountOutput.Name = "totalAmountOutput";
            this.totalAmountOutput.Size = new System.Drawing.Size(79, 36);
            this.totalAmountOutput.TabIndex = 6;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(166, 27);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 7;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.Location = new System.Drawing.Point(166, 56);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(75, 23);
            this.clrBtn.TabIndex = 8;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // grndTtlLbl
            // 
            this.grndTtlLbl.AutoSize = true;
            this.grndTtlLbl.Location = new System.Drawing.Point(163, 97);
            this.grndTtlLbl.Name = "grndTtlLbl";
            this.grndTtlLbl.Size = new System.Drawing.Size(92, 13);
            this.grndTtlLbl.TabIndex = 9;
            this.grndTtlLbl.Text = "Grand Total Sales";
            this.grndTtlLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gndTtlOutput
            // 
            this.gndTtlOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gndTtlOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gndTtlOutput.Location = new System.Drawing.Point(166, 130);
            this.gndTtlOutput.Name = "gndTtlOutput";
            this.gndTtlOutput.Size = new System.Drawing.Size(79, 36);
            this.gndTtlOutput.TabIndex = 10;
            // 
            // ttlTaxLbl
            // 
            this.ttlTaxLbl.AutoSize = true;
            this.ttlTaxLbl.Location = new System.Drawing.Point(163, 177);
            this.ttlTaxLbl.Name = "ttlTaxLbl";
            this.ttlTaxLbl.Size = new System.Drawing.Size(84, 13);
            this.ttlTaxLbl.TabIndex = 11;
            this.ttlTaxLbl.Text = "Grand Total Tax";
            this.ttlTaxLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ttlTaxOutPut
            // 
            this.ttlTaxOutPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ttlTaxOutPut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ttlTaxOutPut.Location = new System.Drawing.Point(166, 198);
            this.ttlTaxOutPut.Name = "ttlTaxOutPut";
            this.ttlTaxOutPut.Size = new System.Drawing.Size(79, 36);
            this.ttlTaxOutPut.TabIndex = 12;
            // 
            // tltAmt
            // 
            this.tltAmt.AutoSize = true;
            this.tltAmt.Location = new System.Drawing.Point(146, 249);
            this.tltAmt.Name = "tltAmt";
            this.tltAmt.Size = new System.Drawing.Size(135, 13);
            this.tltAmt.TabIndex = 13;
            this.tltAmt.Text = "Grand Total Amount to Pay";
            this.tltAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ttlAmtOutput
            // 
            this.ttlAmtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ttlAmtOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ttlAmtOutput.Location = new System.Drawing.Point(166, 273);
            this.ttlAmtOutput.Name = "ttlAmtOutput";
            this.ttlAmtOutput.Size = new System.Drawing.Size(81, 36);
            this.ttlAmtOutput.TabIndex = 14;
            // 
            // ttlItemsLbl
            // 
            this.ttlItemsLbl.AutoSize = true;
            this.ttlItemsLbl.Location = new System.Drawing.Point(307, 97);
            this.ttlItemsLbl.Name = "ttlItemsLbl";
            this.ttlItemsLbl.Size = new System.Drawing.Size(83, 13);
            this.ttlItemsLbl.TabIndex = 15;
            this.ttlItemsLbl.Text = "Total Items Sold";
            this.ttlItemsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ttlItemsOutput
            // 
            this.ttlItemsOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ttlItemsOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ttlItemsOutput.Location = new System.Drawing.Point(309, 130);
            this.ttlItemsOutput.Name = "ttlItemsOutput";
            this.ttlItemsOutput.Size = new System.Drawing.Size(81, 36);
            this.ttlItemsOutput.TabIndex = 16;
            // 
            // avgCostLbl
            // 
            this.avgCostLbl.AutoSize = true;
            this.avgCostLbl.Location = new System.Drawing.Point(306, 192);
            this.avgCostLbl.Name = "avgCostLbl";
            this.avgCostLbl.Size = new System.Drawing.Size(90, 26);
            this.avgCostLbl.TabIndex = 17;
            this.avgCostLbl.Text = "Average Cost Per\r\nItem (Before Tax)";
            this.avgCostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avgCostOutput
            // 
            this.avgCostOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.avgCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.avgCostOutput.Location = new System.Drawing.Point(309, 235);
            this.avgCostOutput.Name = "avgCostOutput";
            this.avgCostOutput.Size = new System.Drawing.Size(80, 36);
            this.avgCostOutput.TabIndex = 18;
            // 
            // taxCalcAccum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 318);
            this.Controls.Add(this.avgCostOutput);
            this.Controls.Add(this.avgCostLbl);
            this.Controls.Add(this.ttlItemsOutput);
            this.Controls.Add(this.ttlItemsLbl);
            this.Controls.Add(this.ttlAmtOutput);
            this.Controls.Add(this.tltAmt);
            this.Controls.Add(this.ttlTaxOutPut);
            this.Controls.Add(this.ttlTaxLbl);
            this.Controls.Add(this.gndTtlOutput);
            this.Controls.Add(this.grndTtlLbl);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.totalAmountOutput);
            this.Controls.Add(this.totalAmtLbl);
            this.Controls.Add(this.salesAmountInputTxtBx);
            this.Controls.Add(this.taxAmountOutput);
            this.Controls.Add(this.taxRateLbl);
            this.Controls.Add(this.taxAmtLbl);
            this.Controls.Add(this.enterSalesAmtLbl);
            this.Name = "taxCalcAccum";
            this.Text = "Lorain County Sales Tax Calculator";
            this.Load += new System.EventHandler(this.taxCalcAccum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterSalesAmtLbl;
        private System.Windows.Forms.Label taxAmtLbl;
        private System.Windows.Forms.Label taxRateLbl;
        private System.Windows.Forms.Label taxAmountOutput;
        private System.Windows.Forms.TextBox salesAmountInputTxtBx;
        private System.Windows.Forms.Label totalAmtLbl;
        private System.Windows.Forms.Label totalAmountOutput;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Label grndTtlLbl;
        private System.Windows.Forms.Label gndTtlOutput;
        private System.Windows.Forms.Label ttlTaxLbl;
        private System.Windows.Forms.Label ttlTaxOutPut;
        private System.Windows.Forms.Label tltAmt;
        private System.Windows.Forms.Label ttlAmtOutput;
        private System.Windows.Forms.Label ttlItemsLbl;
        private System.Windows.Forms.Label ttlItemsOutput;
        private System.Windows.Forms.Label avgCostLbl;
        private System.Windows.Forms.Label avgCostOutput;
    }
}

