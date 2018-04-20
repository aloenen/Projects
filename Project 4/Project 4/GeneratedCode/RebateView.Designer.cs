namespace Project_4.GeneratedCode
{
    partial class RebateView
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
            this.uxRebateAmount = new System.Windows.Forms.NumericUpDown();
            this.uxRebateAmountLabel = new System.Windows.Forms.Label();
            this.uxTransactionNumLabel = new System.Windows.Forms.Label();
            this.uxTransactionNumber = new System.Windows.Forms.NumericUpDown();
            this.uxEnterRebateButton = new System.Windows.Forms.Button();
            this.uxGenerateRebateButton = new System.Windows.Forms.Button();
            this.uxDateLabel = new System.Windows.Forms.Label();
            this.uxDate = new System.Windows.Forms.TextBox();
            this.uxValidRebate = new System.Windows.Forms.TextBox();
            this.uxRebateReciptLabel = new System.Windows.Forms.Label();
            this.uxRebateReciptOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxRebateAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxTransactionNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // uxRebateAmount
            // 
            this.uxRebateAmount.Location = new System.Drawing.Point(122, 7);
            this.uxRebateAmount.Name = "uxRebateAmount";
            this.uxRebateAmount.Size = new System.Drawing.Size(54, 20);
            this.uxRebateAmount.TabIndex = 0;
            // 
            // uxRebateAmountLabel
            // 
            this.uxRebateAmountLabel.AutoSize = true;
            this.uxRebateAmountLabel.Location = new System.Drawing.Point(12, 9);
            this.uxRebateAmountLabel.Name = "uxRebateAmountLabel";
            this.uxRebateAmountLabel.Size = new System.Drawing.Size(104, 13);
            this.uxRebateAmountLabel.TabIndex = 1;
            this.uxRebateAmountLabel.Text = "Rebate Amount (%) :";
            // 
            // uxTransactionNumLabel
            // 
            this.uxTransactionNumLabel.AutoSize = true;
            this.uxTransactionNumLabel.Location = new System.Drawing.Point(12, 40);
            this.uxTransactionNumLabel.Name = "uxTransactionNumLabel";
            this.uxTransactionNumLabel.Size = new System.Drawing.Size(109, 13);
            this.uxTransactionNumLabel.TabIndex = 3;
            this.uxTransactionNumLabel.Text = "Transaction Number :";
            // 
            // uxTransactionNumber
            // 
            this.uxTransactionNumber.Location = new System.Drawing.Point(122, 38);
            this.uxTransactionNumber.Name = "uxTransactionNumber";
            this.uxTransactionNumber.Size = new System.Drawing.Size(54, 20);
            this.uxTransactionNumber.TabIndex = 2;
            // 
            // uxEnterRebateButton
            // 
            this.uxEnterRebateButton.Location = new System.Drawing.Point(197, 4);
            this.uxEnterRebateButton.Name = "uxEnterRebateButton";
            this.uxEnterRebateButton.Size = new System.Drawing.Size(75, 79);
            this.uxEnterRebateButton.TabIndex = 4;
            this.uxEnterRebateButton.Text = "Enter Rebate";
            this.uxEnterRebateButton.UseVisualStyleBackColor = true;
            this.uxEnterRebateButton.Click += new System.EventHandler(this.uxEnterRebateButton_Click);
            // 
            // uxGenerateRebateButton
            // 
            this.uxGenerateRebateButton.Location = new System.Drawing.Point(12, 133);
            this.uxGenerateRebateButton.Name = "uxGenerateRebateButton";
            this.uxGenerateRebateButton.Size = new System.Drawing.Size(260, 23);
            this.uxGenerateRebateButton.TabIndex = 5;
            this.uxGenerateRebateButton.Text = "GenerateRebate";
            this.uxGenerateRebateButton.UseVisualStyleBackColor = true;
            this.uxGenerateRebateButton.Click += new System.EventHandler(this.uxGenerateRebateButton_Click);
            // 
            // uxDateLabel
            // 
            this.uxDateLabel.AutoSize = true;
            this.uxDateLabel.Location = new System.Drawing.Point(12, 66);
            this.uxDateLabel.Name = "uxDateLabel";
            this.uxDateLabel.Size = new System.Drawing.Size(82, 13);
            this.uxDateLabel.TabIndex = 7;
            this.uxDateLabel.Text = "Date (1/1/18)  :";
            // 
            // uxDate
            // 
            this.uxDate.Location = new System.Drawing.Point(100, 63);
            this.uxDate.Name = "uxDate";
            this.uxDate.Size = new System.Drawing.Size(76, 20);
            this.uxDate.TabIndex = 8;
            // 
            // uxValidRebate
            // 
            this.uxValidRebate.Location = new System.Drawing.Point(12, 92);
            this.uxValidRebate.Name = "uxValidRebate";
            this.uxValidRebate.Size = new System.Drawing.Size(260, 20);
            this.uxValidRebate.TabIndex = 9;
            // 
            // uxRebateReciptLabel
            // 
            this.uxRebateReciptLabel.AutoSize = true;
            this.uxRebateReciptLabel.Location = new System.Drawing.Point(12, 169);
            this.uxRebateReciptLabel.Name = "uxRebateReciptLabel";
            this.uxRebateReciptLabel.Size = new System.Drawing.Size(82, 13);
            this.uxRebateReciptLabel.TabIndex = 10;
            this.uxRebateReciptLabel.Text = "Rebate Recipt :";
            // 
            // uxRebateReciptOutput
            // 
            this.uxRebateReciptOutput.Location = new System.Drawing.Point(12, 185);
            this.uxRebateReciptOutput.Multiline = true;
            this.uxRebateReciptOutput.Name = "uxRebateReciptOutput";
            this.uxRebateReciptOutput.Size = new System.Drawing.Size(260, 146);
            this.uxRebateReciptOutput.TabIndex = 11;
            // 
            // RebateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 343);
            this.Controls.Add(this.uxRebateReciptOutput);
            this.Controls.Add(this.uxRebateReciptLabel);
            this.Controls.Add(this.uxValidRebate);
            this.Controls.Add(this.uxDate);
            this.Controls.Add(this.uxDateLabel);
            this.Controls.Add(this.uxGenerateRebateButton);
            this.Controls.Add(this.uxEnterRebateButton);
            this.Controls.Add(this.uxTransactionNumLabel);
            this.Controls.Add(this.uxTransactionNumber);
            this.Controls.Add(this.uxRebateAmountLabel);
            this.Controls.Add(this.uxRebateAmount);
            this.Name = "RebateView";
            this.Text = "RebateView";
            ((System.ComponentModel.ISupportInitialize)(this.uxRebateAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxTransactionNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown uxRebateAmount;
        private System.Windows.Forms.Label uxRebateAmountLabel;
        private System.Windows.Forms.Label uxTransactionNumLabel;
        private System.Windows.Forms.NumericUpDown uxTransactionNumber;
        private System.Windows.Forms.Button uxEnterRebateButton;
        private System.Windows.Forms.Button uxGenerateRebateButton;
        private System.Windows.Forms.Label uxDateLabel;
        private System.Windows.Forms.TextBox uxDate;
        private System.Windows.Forms.TextBox uxValidRebate;
        private System.Windows.Forms.Label uxRebateReciptLabel;
        private System.Windows.Forms.TextBox uxRebateReciptOutput;
    }
}