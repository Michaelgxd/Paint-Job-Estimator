
namespace First_Project
{
    partial class FirstProjectForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.squareFeetInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pricePaintInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOutputGallonsPaint = new System.Windows.Forms.Label();
            this.lblOutputHoursLabor = new System.Windows.Forms.Label();
            this.lblOutputCostPaint = new System.Windows.Forms.Label();
            this.lblOutputLaborCharges = new System.Windows.Forms.Label();
            this.lblOutputTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(197, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Square Feet of Wall Space:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(327, 183);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(115, 28);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.demoButton_Click);
            // 
            // squareFeetInput
            // 
            this.squareFeetInput.Location = new System.Drawing.Point(451, 54);
            this.squareFeetInput.Name = "squareFeetInput";
            this.squareFeetInput.Size = new System.Drawing.Size(92, 20);
            this.squareFeetInput.TabIndex = 2;
            this.squareFeetInput.TextChanged += new System.EventHandler(this.textBoxSquareFeet_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(197, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter price of paint per gallon:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pricePaintInput
            // 
            this.pricePaintInput.Location = new System.Drawing.Point(451, 107);
            this.pricePaintInput.Name = "pricePaintInput";
            this.pricePaintInput.Size = new System.Drawing.Size(92, 20);
            this.pricePaintInput.TabIndex = 4;
            this.pricePaintInput.TextChanged += new System.EventHandler(this.textBoxPricePaint_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gallons of Paint Required:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hour(s) of Labor Required:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Cost of Paint:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Labor Charges:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(469, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total Cost:";
            // 
            // lblOutputGallonsPaint
            // 
            this.lblOutputGallonsPaint.AutoSize = true;
            this.lblOutputGallonsPaint.Location = new System.Drawing.Point(226, 277);
            this.lblOutputGallonsPaint.Name = "lblOutputGallonsPaint";
            this.lblOutputGallonsPaint.Size = new System.Drawing.Size(0, 13);
            this.lblOutputGallonsPaint.TabIndex = 10;
            // 
            // lblOutputHoursLabor
            // 
            this.lblOutputHoursLabor.AutoSize = true;
            this.lblOutputHoursLabor.Location = new System.Drawing.Point(226, 316);
            this.lblOutputHoursLabor.Name = "lblOutputHoursLabor";
            this.lblOutputHoursLabor.Size = new System.Drawing.Size(0, 13);
            this.lblOutputHoursLabor.TabIndex = 11;
            // 
            // lblOutputCostPaint
            // 
            this.lblOutputCostPaint.AutoSize = true;
            this.lblOutputCostPaint.Location = new System.Drawing.Point(226, 354);
            this.lblOutputCostPaint.Name = "lblOutputCostPaint";
            this.lblOutputCostPaint.Size = new System.Drawing.Size(0, 13);
            this.lblOutputCostPaint.TabIndex = 12;
            // 
            // lblOutputLaborCharges
            // 
            this.lblOutputLaborCharges.AutoSize = true;
            this.lblOutputLaborCharges.Location = new System.Drawing.Point(226, 387);
            this.lblOutputLaborCharges.Name = "lblOutputLaborCharges";
            this.lblOutputLaborCharges.Size = new System.Drawing.Size(0, 13);
            this.lblOutputLaborCharges.TabIndex = 13;
            // 
            // lblOutputTotalCost
            // 
            this.lblOutputTotalCost.AutoSize = true;
            this.lblOutputTotalCost.Location = new System.Drawing.Point(551, 326);
            this.lblOutputTotalCost.Name = "lblOutputTotalCost";
            this.lblOutputTotalCost.Size = new System.Drawing.Size(0, 13);
            this.lblOutputTotalCost.TabIndex = 14;
            // 
            // FirstProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutputTotalCost);
            this.Controls.Add(this.lblOutputLaborCharges);
            this.Controls.Add(this.lblOutputCostPaint);
            this.Controls.Add(this.lblOutputHoursLabor);
            this.Controls.Add(this.lblOutputGallonsPaint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pricePaintInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.squareFeetInput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Name = "FirstProjectForm";
            this.Text = "Paint Job Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox squareFeetInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pricePaintInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOutputGallonsPaint;
        private System.Windows.Forms.Label lblOutputHoursLabor;
        private System.Windows.Forms.Label lblOutputCostPaint;
        private System.Windows.Forms.Label lblOutputLaborCharges;
        private System.Windows.Forms.Label lblOutputTotalCost;
    }
}

