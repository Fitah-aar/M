namespace WindowsFormsEndingBlance
{
    partial class Form1
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
            this.lblStringBalance = new System.Windows.Forms.Label();
            this.lblNumberOgMonths = new System.Windows.Forms.Label();
            this.txtStringBalance = new System.Windows.Forms.TextBox();
            this.txtNumberOfMonths = new System.Windows.Forms.TextBox();
            this.lblEndingBalance = new System.Windows.Forms.Label();
            this.txtEndingBalance = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.detailListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblStringBalance
            // 
            this.lblStringBalance.AutoSize = true;
            this.lblStringBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStringBalance.Location = new System.Drawing.Point(64, 27);
            this.lblStringBalance.Name = "lblStringBalance";
            this.lblStringBalance.Size = new System.Drawing.Size(137, 20);
            this.lblStringBalance.TabIndex = 0;
            this.lblStringBalance.Text = "String Balance :";
            // 
            // lblNumberOgMonths
            // 
            this.lblNumberOgMonths.AutoSize = true;
            this.lblNumberOgMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOgMonths.Location = new System.Drawing.Point(64, 65);
            this.lblNumberOgMonths.Name = "lblNumberOgMonths";
            this.lblNumberOgMonths.Size = new System.Drawing.Size(169, 20);
            this.lblNumberOgMonths.TabIndex = 1;
            this.lblNumberOgMonths.Text = "Number Of Months :";
            // 
            // txtStringBalance
            // 
            this.txtStringBalance.Location = new System.Drawing.Point(207, 21);
            this.txtStringBalance.Name = "txtStringBalance";
            this.txtStringBalance.Size = new System.Drawing.Size(256, 26);
            this.txtStringBalance.TabIndex = 2;
            // 
            // txtNumberOfMonths
            // 
            this.txtNumberOfMonths.Location = new System.Drawing.Point(239, 65);
            this.txtNumberOfMonths.Name = "txtNumberOfMonths";
            this.txtNumberOfMonths.Size = new System.Drawing.Size(256, 26);
            this.txtNumberOfMonths.TabIndex = 3;
            // 
            // lblEndingBalance
            // 
            this.lblEndingBalance.AutoSize = true;
            this.lblEndingBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndingBalance.Location = new System.Drawing.Point(83, 319);
            this.lblEndingBalance.Name = "lblEndingBalance";
            this.lblEndingBalance.Size = new System.Drawing.Size(145, 20);
            this.lblEndingBalance.TabIndex = 5;
            this.lblEndingBalance.Text = "Ending Balance :";
            // 
            // txtEndingBalance
            // 
            this.txtEndingBalance.Location = new System.Drawing.Point(234, 316);
            this.txtEndingBalance.Name = "txtEndingBalance";
            this.txtEndingBalance.Size = new System.Drawing.Size(256, 26);
            this.txtEndingBalance.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(100, 363);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(128, 49);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(257, 363);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 49);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(409, 363);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 49);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // detailListBox
            // 
            this.detailListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailListBox.FormattingEnabled = true;
            this.detailListBox.ItemHeight = 22;
            this.detailListBox.Items.AddRange(new object[] {
            "detailListBox"});
            this.detailListBox.Location = new System.Drawing.Point(68, 103);
            this.detailListBox.Name = "detailListBox";
            this.detailListBox.Size = new System.Drawing.Size(427, 180);
            this.detailListBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.detailListBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtEndingBalance);
            this.Controls.Add(this.lblEndingBalance);
            this.Controls.Add(this.txtNumberOfMonths);
            this.Controls.Add(this.txtStringBalance);
            this.Controls.Add(this.lblNumberOgMonths);
            this.Controls.Add(this.lblStringBalance);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStringBalance;
        private System.Windows.Forms.Label lblNumberOgMonths;
        private System.Windows.Forms.TextBox txtStringBalance;
        private System.Windows.Forms.TextBox txtNumberOfMonths;
        private System.Windows.Forms.Label lblEndingBalance;
        private System.Windows.Forms.TextBox txtEndingBalance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox detailListBox;
    }
}

