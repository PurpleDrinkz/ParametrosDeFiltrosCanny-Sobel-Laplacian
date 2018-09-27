namespace DeteccionBordes
{
    partial class Sobel_Parameters
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numericApertureSize = new System.Windows.Forms.NumericUpDown();
            this.numericYOrder = new System.Windows.Forms.NumericUpDown();
            this.numericXOrder = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericApertureSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericXOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.numericApertureSize);
            this.groupBox1.Controls.Add(this.numericYOrder);
            this.groupBox1.Controls.Add(this.numericXOrder);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sobel Parameters";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericApertureSize
            // 
            this.numericApertureSize.Location = new System.Drawing.Point(103, 107);
            this.numericApertureSize.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericApertureSize.Name = "numericApertureSize";
            this.numericApertureSize.Size = new System.Drawing.Size(120, 20);
            this.numericApertureSize.TabIndex = 5;
            // 
            // numericYOrder
            // 
            this.numericYOrder.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericYOrder.Location = new System.Drawing.Point(103, 67);
            this.numericYOrder.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericYOrder.Name = "numericYOrder";
            this.numericYOrder.Size = new System.Drawing.Size(120, 20);
            this.numericYOrder.TabIndex = 4;
            this.numericYOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericXOrder
            // 
            this.numericXOrder.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericXOrder.Location = new System.Drawing.Point(103, 20);
            this.numericXOrder.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericXOrder.Name = "numericXOrder";
            this.numericXOrder.Size = new System.Drawing.Size(120, 20);
            this.numericXOrder.TabIndex = 3;
            this.numericXOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericXOrder.ValueChanged += new System.EventHandler(this.numericXOrder_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aperture Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y Order";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X Order";
            // 
            // Sobel_Parameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 234);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sobel_Parameters";
            this.Text = "Sobel_Parameters";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericApertureSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericXOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericApertureSize;
        private System.Windows.Forms.NumericUpDown numericYOrder;
        private System.Windows.Forms.NumericUpDown numericXOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}