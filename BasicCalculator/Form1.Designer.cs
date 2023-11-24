namespace BasicCalculator
{
    partial class Form1
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
            this.txtBoxNum1 = new System.Windows.Forms.TextBox();
            this.cbBox1 = new System.Windows.Forms.ComboBox();
            this.txtBoxNum2 = new System.Windows.Forms.TextBox();
            this.txtBoxNum3 = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
            // 
            // txtBoxNum1
            // 
            this.txtBoxNum1.Location = new System.Drawing.Point(46, 73);
            this.txtBoxNum1.Multiline = true;
            this.txtBoxNum1.Name = "txtBoxNum1";
            this.txtBoxNum1.Size = new System.Drawing.Size(179, 37);
            this.txtBoxNum1.TabIndex = 1;
            // 
            // cbBox1
            // 
            this.cbBox1.FormattingEnabled = true;
            this.cbBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbBox1.Location = new System.Drawing.Point(97, 133);
            this.cbBox1.Name = "cbBox1";
            this.cbBox1.Size = new System.Drawing.Size(76, 21);
            this.cbBox1.TabIndex = 2;
            // 
            // txtBoxNum2
            // 
            this.txtBoxNum2.Location = new System.Drawing.Point(46, 172);
            this.txtBoxNum2.Multiline = true;
            this.txtBoxNum2.Name = "txtBoxNum2";
            this.txtBoxNum2.Size = new System.Drawing.Size(179, 41);
            this.txtBoxNum2.TabIndex = 3;
            // 
            // txtBoxNum3
            // 
            this.txtBoxNum3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtBoxNum3.Location = new System.Drawing.Point(46, 247);
            this.txtBoxNum3.Multiline = true;
            this.txtBoxNum3.Name = "txtBoxNum3";
            this.txtBoxNum3.Size = new System.Drawing.Size(179, 60);
            this.txtBoxNum3.TabIndex = 4;
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.Tomato;
            this.btnCompute.ForeColor = System.Drawing.Color.Black;
            this.btnCompute.Location = new System.Drawing.Point(98, 332);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 5;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(261, 379);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtBoxNum3);
            this.Controls.Add(this.txtBoxNum2);
            this.Controls.Add(this.cbBox1);
            this.Controls.Add(this.txtBoxNum1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNum1;
        private System.Windows.Forms.ComboBox cbBox1;
        private System.Windows.Forms.TextBox txtBoxNum2;
        private System.Windows.Forms.TextBox txtBoxNum3;
        private System.Windows.Forms.Button btnCompute;
    }
}

