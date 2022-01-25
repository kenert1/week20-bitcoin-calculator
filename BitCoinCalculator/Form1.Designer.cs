namespace BitCoinCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencyBox = new System.Windows.Forms.ComboBox();
            this.resultRates = new System.Windows.Forms.Button();
            this.amountOfBTC = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencyBox
            // 
            this.currencyBox.FormattingEnabled = true;
            this.currencyBox.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.currencyBox.Location = new System.Drawing.Point(60, 77);
            this.currencyBox.Name = "currencyBox";
            this.currencyBox.Size = new System.Drawing.Size(121, 21);
            this.currencyBox.TabIndex = 0;
            this.currencyBox.Text = "Select Currency";
            // 
            // resultRates
            // 
            this.resultRates.Location = new System.Drawing.Point(207, 110);
            this.resultRates.Name = "resultRates";
            this.resultRates.Size = new System.Drawing.Size(75, 23);
            this.resultRates.TabIndex = 1;
            this.resultRates.Text = "Get Rates";
            this.resultRates.UseVisualStyleBackColor = true;
            this.resultRates.Click += new System.EventHandler(this.button1_Click);
            // 
            // amountOfBTC
            // 
            this.amountOfBTC.Location = new System.Drawing.Point(60, 112);
            this.amountOfBTC.Name = "amountOfBTC";
            this.amountOfBTC.Size = new System.Drawing.Size(100, 20);
            this.amountOfBTC.TabIndex = 2;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(60, 178);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 3;
            this.result.Visible = false;
            this.result.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(60, 159);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(37, 13);
            this.resultLbl.TabIndex = 4;
            this.resultLbl.Text = "Result";
            this.resultLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.result);
            this.Controls.Add(this.amountOfBTC);
            this.Controls.Add(this.resultRates);
            this.Controls.Add(this.currencyBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyBox;
        private System.Windows.Forms.Button resultRates;
        private System.Windows.Forms.TextBox amountOfBTC;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label resultLbl;
    }
}

