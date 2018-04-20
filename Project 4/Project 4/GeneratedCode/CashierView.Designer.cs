namespace Project_4.GeneratedCode
{
    partial class CashierView
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
            this.uxNewTransaction = new System.Windows.Forms.Button();
            this.uxFinishTransaction = new System.Windows.Forms.Button();
            this.uxAddItem = new System.Windows.Forms.Button();
            this.uxReciptLabel = new System.Windows.Forms.Label();
            this.uxOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxNewTransaction
            // 
            this.uxNewTransaction.Location = new System.Drawing.Point(12, 12);
            this.uxNewTransaction.Name = "uxNewTransaction";
            this.uxNewTransaction.Size = new System.Drawing.Size(108, 23);
            this.uxNewTransaction.TabIndex = 0;
            this.uxNewTransaction.Text = "New Transaction";
            this.uxNewTransaction.UseVisualStyleBackColor = true;
            this.uxNewTransaction.Click += new System.EventHandler(this.uxNewTransaction_Click);
            // 
            // uxFinishTransaction
            // 
            this.uxFinishTransaction.Location = new System.Drawing.Point(126, 12);
            this.uxFinishTransaction.Name = "uxFinishTransaction";
            this.uxFinishTransaction.Size = new System.Drawing.Size(108, 23);
            this.uxFinishTransaction.TabIndex = 1;
            this.uxFinishTransaction.Text = "Finish Transaction";
            this.uxFinishTransaction.UseVisualStyleBackColor = true;
            this.uxFinishTransaction.Click += new System.EventHandler(this.uxFinishTransaction_Click);
            // 
            // uxAddItem
            // 
            this.uxAddItem.Location = new System.Drawing.Point(240, 12);
            this.uxAddItem.Name = "uxAddItem";
            this.uxAddItem.Size = new System.Drawing.Size(108, 23);
            this.uxAddItem.TabIndex = 2;
            this.uxAddItem.Text = "Add Item";
            this.uxAddItem.UseVisualStyleBackColor = true;
            this.uxAddItem.Click += new System.EventHandler(this.uxAddItem_Click);
            // 
            // uxReciptLabel
            // 
            this.uxReciptLabel.AutoSize = true;
            this.uxReciptLabel.Location = new System.Drawing.Point(12, 51);
            this.uxReciptLabel.Name = "uxReciptLabel";
            this.uxReciptLabel.Size = new System.Drawing.Size(106, 13);
            this.uxReciptLabel.TabIndex = 3;
            this.uxReciptLabel.Text = "Transaction Reciept:";
            // 
            // uxOutput
            // 
            this.uxOutput.Location = new System.Drawing.Point(12, 76);
            this.uxOutput.Multiline = true;
            this.uxOutput.Name = "uxOutput";
            this.uxOutput.Size = new System.Drawing.Size(336, 239);
            this.uxOutput.TabIndex = 4;
            // 
            // CashierView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 327);
            this.Controls.Add(this.uxOutput);
            this.Controls.Add(this.uxReciptLabel);
            this.Controls.Add(this.uxAddItem);
            this.Controls.Add(this.uxFinishTransaction);
            this.Controls.Add(this.uxNewTransaction);
            this.Name = "CashierView";
            this.Text = "CashierView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxNewTransaction;
        private System.Windows.Forms.Button uxFinishTransaction;
        private System.Windows.Forms.Button uxAddItem;
        private System.Windows.Forms.Label uxReciptLabel;
        private System.Windows.Forms.TextBox uxOutput;
    }
}