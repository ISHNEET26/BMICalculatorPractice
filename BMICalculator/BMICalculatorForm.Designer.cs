namespace BMICalculator
{
    partial class BMICalculatorForm
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
            this.ImperialTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.MetricRadioButton1 = new System.Windows.Forms.RadioButton();
            this.BMICalculatorLabel = new System.Windows.Forms.Label();
            this.ImperialRadioButton1 = new System.Windows.Forms.RadioButton();
            this.heightlabel = new System.Windows.Forms.Label();
            this.weightlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ImperialTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImperialTableLayoutPanel
            // 
            this.ImperialTableLayoutPanel.ColumnCount = 2;
            this.ImperialTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialTableLayoutPanel.Controls.Add(this.textBox2, 1, 6);
            this.ImperialTableLayoutPanel.Controls.Add(this.ResetButton, 0, 5);
            this.ImperialTableLayoutPanel.Controls.Add(this.HeightTextBox, 1, 3);
            this.ImperialTableLayoutPanel.Controls.Add(this.MetricRadioButton1, 1, 1);
            this.ImperialTableLayoutPanel.Controls.Add(this.BMICalculatorLabel, 0, 0);
            this.ImperialTableLayoutPanel.Controls.Add(this.ImperialRadioButton1, 0, 1);
            this.ImperialTableLayoutPanel.Controls.Add(this.heightlabel, 0, 2);
            this.ImperialTableLayoutPanel.Controls.Add(this.weightlabel, 0, 3);
            this.ImperialTableLayoutPanel.Controls.Add(this.textBox1, 1, 2);
            this.ImperialTableLayoutPanel.Controls.Add(this.CalculateBMIButton, 0, 4);
            this.ImperialTableLayoutPanel.Controls.Add(this.label1, 0, 6);
            this.ImperialTableLayoutPanel.Location = new System.Drawing.Point(36, 55);
            this.ImperialTableLayoutPanel.Name = "ImperialTableLayoutPanel";
            this.ImperialTableLayoutPanel.RowCount = 7;
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.ImperialTableLayoutPanel.Size = new System.Drawing.Size(241, 342);
            this.ImperialTableLayoutPanel.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 291);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 48);
            this.textBox2.TabIndex = 9;
            // 
            // ResetButton
            // 
            this.ImperialTableLayoutPanel.SetColumnSpan(this.ResetButton, 2);
            this.ResetButton.Location = new System.Drawing.Point(3, 243);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(235, 42);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightTextBox.Location = new System.Drawing.Point(123, 147);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(115, 38);
            this.HeightTextBox.TabIndex = 5;
            this.HeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MetricRadioButton1
            // 
            this.MetricRadioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricRadioButton1.AutoSize = true;
            this.MetricRadioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton1.Location = new System.Drawing.Point(123, 51);
            this.MetricRadioButton1.Name = "MetricRadioButton1";
            this.MetricRadioButton1.Size = new System.Drawing.Size(115, 42);
            this.MetricRadioButton1.TabIndex = 2;
            this.MetricRadioButton1.Text = "Metric";
            this.MetricRadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetricRadioButton1.UseVisualStyleBackColor = true;
            // 
            // BMICalculatorLabel
            // 
            this.BMICalculatorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMICalculatorLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.ImperialTableLayoutPanel.SetColumnSpan(this.BMICalculatorLabel, 2);
            this.BMICalculatorLabel.Location = new System.Drawing.Point(3, 0);
            this.BMICalculatorLabel.Name = "BMICalculatorLabel";
            this.BMICalculatorLabel.Size = new System.Drawing.Size(235, 48);
            this.BMICalculatorLabel.TabIndex = 0;
            this.BMICalculatorLabel.Text = "BMI Calculator";
            this.BMICalculatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImperialRadioButton1
            // 
            this.ImperialRadioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialRadioButton1.AutoSize = true;
            this.ImperialRadioButton1.Checked = true;
            this.ImperialRadioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton1.Location = new System.Drawing.Point(3, 51);
            this.ImperialRadioButton1.Name = "ImperialRadioButton1";
            this.ImperialRadioButton1.Size = new System.Drawing.Size(114, 42);
            this.ImperialRadioButton1.TabIndex = 1;
            this.ImperialRadioButton1.TabStop = true;
            this.ImperialRadioButton1.Text = "Imperial";
            this.ImperialRadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ImperialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // heightlabel
            // 
            this.heightlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heightlabel.AutoSize = true;
            this.heightlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightlabel.Location = new System.Drawing.Point(3, 96);
            this.heightlabel.Name = "heightlabel";
            this.heightlabel.Size = new System.Drawing.Size(114, 48);
            this.heightlabel.TabIndex = 1;
            this.heightlabel.Text = "My Height";
            this.heightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weightlabel
            // 
            this.weightlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weightlabel.AutoSize = true;
            this.weightlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightlabel.Location = new System.Drawing.Point(3, 144);
            this.weightlabel.Name = "weightlabel";
            this.weightlabel.Size = new System.Drawing.Size(114, 48);
            this.weightlabel.TabIndex = 3;
            this.weightlabel.Text = "My Weight";
            this.weightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 38);
            this.textBox1.TabIndex = 4;
            // 
            // CalculateBMIButton
            // 
            this.ImperialTableLayoutPanel.SetColumnSpan(this.CalculateBMIButton, 2);
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 195);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(235, 42);
            this.CalculateBMIButton.TabIndex = 6;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "My BMI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.ImperialTableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.ImperialTableLayoutPanel.ResumeLayout(false);
            this.ImperialTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ImperialTableLayoutPanel;
        private System.Windows.Forms.RadioButton MetricRadioButton1;
        private System.Windows.Forms.Label BMICalculatorLabel;
        private System.Windows.Forms.RadioButton ImperialRadioButton1;
        private System.Windows.Forms.Label heightlabel;
        private System.Windows.Forms.Label weightlabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}

