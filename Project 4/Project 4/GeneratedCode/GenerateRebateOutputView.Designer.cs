﻿namespace Project_4.GeneratedCode
{
    partial class uxForm
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
            this.uxRebateOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxRebateOutput
            // 
            this.uxRebateOutput.Location = new System.Drawing.Point(0, 0);
            this.uxRebateOutput.Name = "uxRebateOutput";
            this.uxRebateOutput.Size = new System.Drawing.Size(100, 20);
            this.uxRebateOutput.TabIndex = 0;
            // 
            // uxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uxRebateOutput);
            this.Name = "uxForm";
            this.Text = "RebateCheckOutputView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxRebateOutput;
    }
}