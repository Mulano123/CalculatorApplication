namespace CalculatorApplication
{
    partial class FrmCalculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDisplayOutput = new System.Windows.Forms.Label();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.txtBoxInput1 = new System.Windows.Forms.TextBox();
            this.txtBoxInput2 = new System.Windows.Forms.TextBox();
            this.btnEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter First Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Second Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Answer:";
            // 
            // lblDisplayOutput
            // 
            this.lblDisplayOutput.AutoSize = true;
            this.lblDisplayOutput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayOutput.Location = new System.Drawing.Point(260, 256);
            this.lblDisplayOutput.Name = "lblDisplayOutput";
            this.lblDisplayOutput.Size = new System.Drawing.Size(60, 22);
            this.lblDisplayOutput.TabIndex = 3;
            this.lblDisplayOutput.Text = "label4";
            // 
            // cbOperator
            // 
            this.cbOperator.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbOperator.Location = new System.Drawing.Point(338, 123);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(67, 30);
            this.cbOperator.TabIndex = 4;
            // 
            // txtBoxInput1
            // 
            this.txtBoxInput1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInput1.Location = new System.Drawing.Point(264, 70);
            this.txtBoxInput1.Name = "txtBoxInput1";
            this.txtBoxInput1.Size = new System.Drawing.Size(176, 30);
            this.txtBoxInput1.TabIndex = 5;
            // 
            // txtBoxInput2
            // 
            this.txtBoxInput2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInput2.Location = new System.Drawing.Point(264, 177);
            this.txtBoxInput2.Name = "txtBoxInput2";
            this.txtBoxInput2.Size = new System.Drawing.Size(176, 30);
            this.txtBoxInput2.TabIndex = 6;
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(286, 320);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(165, 51);
            this.btnEqual.TabIndex = 7;
            this.btnEqual.Text = "Calculate";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 434);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.txtBoxInput2);
            this.Controls.Add(this.txtBoxInput1);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.lblDisplayOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCalculator";
            this.Text = "FrmCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDisplayOutput;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.TextBox txtBoxInput1;
        private System.Windows.Forms.TextBox txtBoxInput2;
        private System.Windows.Forms.Button btnEqual;
    }
}