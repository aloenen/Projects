namespace Project_4.GeneratedCode
{
    partial class CashierInputView
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
            // CashierInputView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 48);
            this.Controls.Add(this.uxFinishTransaction);
            this.Controls.Add(this.uxNewTransaction);
            this.Name = "CashierInputView";
            this.Text = "CashierView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxNewTransaction;
        private System.Windows.Forms.Button uxFinishTransaction;
    }
}