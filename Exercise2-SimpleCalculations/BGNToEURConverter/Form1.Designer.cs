﻿namespace BGNToEURConverter
{
	partial class FormConverter
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
			this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.labelResult = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Convert";
			// 
			// numericUpDownAmount
			// 
			this.numericUpDownAmount.DecimalPlaces = 2;
			this.numericUpDownAmount.Location = new System.Drawing.Point(93, 11);
			this.numericUpDownAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.numericUpDownAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.numericUpDownAmount.Name = "numericUpDownAmount";
			this.numericUpDownAmount.Size = new System.Drawing.Size(180, 26);
			this.numericUpDownAmount.TabIndex = 1;
			this.numericUpDownAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownAmount.ValueChanged += new System.EventHandler(this.numericUpDownAmount_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(282, 14);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "BGN to EUR";
			// 
			// labelResult
			// 
			this.labelResult.BackColor = System.Drawing.Color.PaleGreen;
			this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelResult.Location = new System.Drawing.Point(22, 46);
			this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(361, 20);
			this.labelResult.TabIndex = 3;
			this.labelResult.Text = "label3";
			this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormConverter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(399, 85);
			this.Controls.Add(this.labelResult);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numericUpDownAmount);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormConverter";
			this.Text = "BGN to EUR";
			this.Load += new System.EventHandler(this.FormConverter_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDownAmount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelResult;
	}
}

