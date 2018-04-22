namespace Project_4.GeneratedCode
{
    partial class CashierOutputView
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
            this.uxRecipteLabel = new System.Windows.Forms.Label();
            this.uxReciptOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxRecipteLabel
            // 
            this.uxRecipteLabel.AutoSize = true;
            this.uxRecipteLabel.Location = new System.Drawing.Point(12, 9);
            this.uxRecipteLabel.Name = "uxRecipteLabel";
            this.uxRecipteLabel.Size = new System.Drawing.Size(47, 13);
            this.uxRecipteLabel.TabIndex = 0;
            this.uxRecipteLabel.Text = "Recipte:";
            // 
            // uxReciptOutput
            // 
            this.uxReciptOutput.Location = new System.Drawing.Point(15, 25);
            this.uxReciptOutput.Multiline = true;
            this.uxReciptOutput.Name = "uxReciptOutput";
            this.uxReciptOutput.Size = new System.Drawing.Size(257, 224);
            this.uxReciptOutput.TabIndex = 1;
            // 
            // CashierOutputView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uxReciptOutput);
            this.Controls.Add(this.uxRecipteLabel);
            this.Name = "CashierOutputView";
            this.Text = "CashierOutputView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxRecipteLabel;
        private System.Windows.Forms.TextBox uxReciptOutput;
    }
}