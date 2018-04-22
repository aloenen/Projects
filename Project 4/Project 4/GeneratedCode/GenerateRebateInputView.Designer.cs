namespace Project_4.GeneratedCode
{
    partial class GenerateRebateInputView
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
            this.uxGenerateRebateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxGenerateRebateButton
            // 
            this.uxGenerateRebateButton.Location = new System.Drawing.Point(12, 12);
            this.uxGenerateRebateButton.Name = "uxGenerateRebateButton";
            this.uxGenerateRebateButton.Size = new System.Drawing.Size(260, 23);
            this.uxGenerateRebateButton.TabIndex = 0;
            this.uxGenerateRebateButton.Text = "Generate Rebate";
            this.uxGenerateRebateButton.UseVisualStyleBackColor = true;
            this.uxGenerateRebateButton.Click += new System.EventHandler(this.uxGenerateRebateButton_Click);
            // 
            // GenerateRebateInputView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 48);
            this.Controls.Add(this.uxGenerateRebateButton);
            this.Name = "GenerateRebateInputView";
            this.Text = "GenerateRebateOutputView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxGenerateRebateButton;
    }
}