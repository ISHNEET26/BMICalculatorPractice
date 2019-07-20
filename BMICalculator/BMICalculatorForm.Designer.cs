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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.metricradiobutton = new System.Windows.Forms.RadioButton();
            this.BMICalculatorLabel = new System.Windows.Forms.Label();
            this.imperialradiobutton = new System.Windows.Forms.RadioButton();
            this.heightlabel = new System.Windows.Forms.Label();
            this.weightlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.HeightTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.metricradiobutton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BMICalculatorLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.imperialradiobutton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.heightlabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.weightlabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CalculateBMIButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(241, 342);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 291);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 48);
            this.textBox2.TabIndex = 9;
            // 
            // button1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Location = new System.Drawing.Point(3, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
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
            // metricradiobutton
            // 
            this.metricradiobutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metricradiobutton.AutoSize = true;
            this.metricradiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metricradiobutton.Location = new System.Drawing.Point(123, 51);
            this.metricradiobutton.Name = "metricradiobutton";
            this.metricradiobutton.Size = new System.Drawing.Size(115, 42);
            this.metricradiobutton.TabIndex = 2;
            this.metricradiobutton.TabStop = true;
            this.metricradiobutton.Text = "Metric";
            this.metricradiobutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metricradiobutton.UseVisualStyleBackColor = true;
            // 
            // BMICalculatorLabel
            // 
            this.BMICalculatorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMICalculatorLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.tableLayoutPanel1.SetColumnSpan(this.BMICalculatorLabel, 2);
            this.BMICalculatorLabel.Location = new System.Drawing.Point(3, 0);
            this.BMICalculatorLabel.Name = "BMICalculatorLabel";
            this.BMICalculatorLabel.Size = new System.Drawing.Size(235, 48);
            this.BMICalculatorLabel.TabIndex = 0;
            this.BMICalculatorLabel.Text = "BMI Calculator";
            this.BMICalculatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imperialradiobutton
            // 
            this.imperialradiobutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imperialradiobutton.AutoSize = true;
            this.imperialradiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imperialradiobutton.Location = new System.Drawing.Point(3, 51);
            this.imperialradiobutton.Name = "imperialradiobutton";
            this.imperialradiobutton.Size = new System.Drawing.Size(114, 42);
            this.imperialradiobutton.TabIndex = 1;
            this.imperialradiobutton.TabStop = true;
            this.imperialradiobutton.Text = "Imperial";
            this.imperialradiobutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.imperialradiobutton.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.SetColumnSpan(this.CalculateBMIButton, 2);
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
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton metricradiobutton;
        private System.Windows.Forms.Label BMICalculatorLabel;
        private System.Windows.Forms.RadioButton imperialradiobutton;
        private System.Windows.Forms.Label heightlabel;
        private System.Windows.Forms.Label weightlabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}

