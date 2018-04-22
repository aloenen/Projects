namespace Project_4.GeneratedCode
{
    partial class CustomerServiceView
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
            this.uxTransactionNum = new System.Windows.Forms.NumericUpDown();
            this.uxTransactionNumLabel = new System.Windows.Forms.Label();
            this.uxAddReturnButton = new System.Windows.Forms.Button();
            this.uxFinishReturn = new System.Windows.Forms.Button();
            this.uxReturnedItemsLabel = new System.Windows.Forms.Label();
            this.uxReturnedItemsOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxTransactionNum)).BeginInit();
            this.SuspendLayout();
            // 
            // uxTransactionNum
            // 
            this.uxTransactionNum.Location = new System.Drawing.Point(124, 7);
            this.uxTransactionNum.Name = "uxTransactionNum";
            this.uxTransactionNum.Size = new System.Drawing.Size(50, 20);
            this.uxTransactionNum.TabIndex = 0;
            // 
            // uxTransactionNumLabel
            // 
            this.uxTransactionNumLabel.AutoSize = true;
            this.uxTransactionNumLabel.Location = new System.Drawing.Point(12, 9);
            this.uxTransactionNumLabel.Name = "uxTransactionNumLabel";
            this.uxTransactionNumLabel.Size = new System.Drawing.Size(106, 13);
            this.uxTransactionNumLabel.TabIndex = 1;
            this.uxTransactionNumLabel.Text = "Transaction Number:";
            // 
            // uxAddReturnButton
            // 
            this.uxAddReturnButton.Location = new System.Drawing.Point(180, 7);
            this.uxAddReturnButton.Name = "uxAddReturnButton";
            this.uxAddReturnButton.Size = new System.Drawing.Size(75, 23);
            this.uxAddReturnButton.TabIndex = 2;
            this.uxAddReturnButton.Text = "Add Item";
            this.uxAddReturnButton.UseVisualStyleBackColor = true;
            this.uxAddReturnButton.Click += new System.EventHandler(this.uxReturnButton_Click);
            // 
            // uxFinishReturn
            // 
            this.uxFinishReturn.Location = new System.Drawing.Point(261, 7);
            this.uxFinishReturn.Name = "uxFinishReturn";
            this.uxFinishReturn.Size = new System.Drawing.Size(85, 23);
            this.uxFinishReturn.TabIndex = 3;
            this.uxFinishReturn.Text = "Finish Return";
            this.uxFinishReturn.UseVisualStyleBackColor = true;
            // 
            // uxReturnedItemsLabel
            // 
            this.uxReturnedItemsLabel.AutoSize = true;
            this.uxReturnedItemsLabel.Location = new System.Drawing.Point(12, 33);
            this.uxReturnedItemsLabel.Name = "uxReturnedItemsLabel";
            this.uxReturnedItemsLabel.Size = new System.Drawing.Size(85, 13);
            this.uxReturnedItemsLabel.TabIndex = 4;
            this.uxReturnedItemsLabel.Text = "Returned Items :";
            // 
            // uxReturnedItemsOutput
            // 
            this.uxReturnedItemsOutput.Location = new System.Drawing.Point(15, 49);
            this.uxReturnedItemsOutput.Multiline = true;
            this.uxReturnedItemsOutput.Name = "uxReturnedItemsOutput";
            this.uxReturnedItemsOutput.Size = new System.Drawing.Size(331, 148);
            this.uxReturnedItemsOutput.TabIndex = 5;
            // 
            // CustomerServiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 209);
            this.Controls.Add(this.uxReturnedItemsOutput);
            this.Controls.Add(this.uxReturnedItemsLabel);
            this.Controls.Add(this.uxFinishReturn);
            this.Controls.Add(this.uxAddReturnButton);
            this.Controls.Add(this.uxTransactionNumLabel);
            this.Controls.Add(this.uxTransactionNum);
            this.Name = "CustomerServiceView";
            this.Text = "CustomerServiceView";
            ((System.ComponentModel.ISupportInitialize)(this.uxTransactionNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown uxTransactionNum;
        private System.Windows.Forms.Label uxTransactionNumLabel;
        private System.Windows.Forms.Button uxAddReturnButton;
        private System.Windows.Forms.Button uxFinishReturn;
        private System.Windows.Forms.Label uxReturnedItemsLabel;
        private System.Windows.Forms.TextBox uxReturnedItemsOutput;
    }
}