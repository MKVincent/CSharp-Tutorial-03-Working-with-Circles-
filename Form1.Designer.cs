namespace youtube_prac3
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radCircumference = new System.Windows.Forms.RadioButton();
            this.radArea = new System.Windows.Forms.RadioButton();
            this.radNoCalculation = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Working with Circles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter radius below:";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(246, 158);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(117, 20);
            this.txtRadius.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNoCalculation);
            this.groupBox1.Controls.Add(this.radArea);
            this.groupBox1.Controls.Add(this.radCircumference);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(246, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 181);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // radCircumference
            // 
            this.radCircumference.AutoSize = true;
            this.radCircumference.Location = new System.Drawing.Point(24, 38);
            this.radCircumference.Name = "radCircumference";
            this.radCircumference.Size = new System.Drawing.Size(170, 20);
            this.radCircumference.TabIndex = 0;
            this.radCircumference.TabStop = true;
            this.radCircumference.Text = "Calculate Circumference";
            this.radCircumference.UseVisualStyleBackColor = true;
            this.radCircumference.CheckedChanged += new System.EventHandler(this.radCircumference_CheckedChanged);
            // 
            // radArea
            // 
            this.radArea.AutoSize = true;
            this.radArea.Location = new System.Drawing.Point(24, 86);
            this.radArea.Name = "radArea";
            this.radArea.Size = new System.Drawing.Size(113, 20);
            this.radArea.TabIndex = 1;
            this.radArea.TabStop = true;
            this.radArea.Text = "Calculate Area";
            this.radArea.UseVisualStyleBackColor = true;
            this.radArea.CheckedChanged += new System.EventHandler(this.radArea_CheckedChanged);
            // 
            // radNoCalculation
            // 
            this.radNoCalculation.AutoSize = true;
            this.radNoCalculation.Location = new System.Drawing.Point(24, 135);
            this.radNoCalculation.Name = "radNoCalculation";
            this.radNoCalculation.Size = new System.Drawing.Size(112, 20);
            this.radNoCalculation.TabIndex = 2;
            this.radNoCalculation.TabStop = true;
            this.radNoCalculation.Text = "No Calculation";
            this.radNoCalculation.UseVisualStyleBackColor = true;
            this.radNoCalculation.CheckedChanged += new System.EventHandler(this.radNoCalculation_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Arithmetic";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radCircumference;
        private System.Windows.Forms.RadioButton radArea;
        private System.Windows.Forms.RadioButton radNoCalculation;
    }
}

