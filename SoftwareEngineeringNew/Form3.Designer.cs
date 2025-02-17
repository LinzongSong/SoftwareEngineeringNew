﻿namespace SoftwareEngineeringNew
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFunction = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownV1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownV2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY2 = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Continuous distribution";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(31, 33);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(501, 382);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Function:";
            // 
            // comboBoxFunction
            // 
            this.comboBoxFunction.FormattingEnabled = true;
            this.comboBoxFunction.Items.AddRange(new object[] {
            "Normal distribution",
            "Uniform distribution",
            "The Rayleigh Distribution"});
            this.comboBoxFunction.Location = new System.Drawing.Point(86, 453);
            this.comboBoxFunction.Name = "comboBoxFunction";
            this.comboBoxFunction.Size = new System.Drawing.Size(446, 24);
            this.comboBoxFunction.TabIndex = 3;
            this.comboBoxFunction.SelectedIndexChanged += new System.EventHandler(this.comboBoxFunction_SelectedIndexChanged);
            this.comboBoxFunction.Click += new System.EventHandler(this.comboBoxFunction_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(542, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(243, 382);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "μ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 543);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "σ:";
            // 
            // numericUpDownV1
            // 
            this.numericUpDownV1.DecimalPlaces = 1;
            this.numericUpDownV1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownV1.Location = new System.Drawing.Point(86, 511);
            this.numericUpDownV1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownV1.Name = "numericUpDownV1";
            this.numericUpDownV1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownV1.TabIndex = 8;
            // 
            // numericUpDownV2
            // 
            this.numericUpDownV2.DecimalPlaces = 1;
            this.numericUpDownV2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownV2.Location = new System.Drawing.Point(85, 543);
            this.numericUpDownV2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownV2.Name = "numericUpDownV2";
            this.numericUpDownV2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownV2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 548);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Y:";
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.DecimalPlaces = 1;
            this.numericUpDownX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownX.Location = new System.Drawing.Point(247, 514);
            this.numericUpDownX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(113, 22);
            this.numericUpDownX.TabIndex = 12;
            // 
            // numericUpDownX2
            // 
            this.numericUpDownX2.DecimalPlaces = 1;
            this.numericUpDownX2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownX2.Location = new System.Drawing.Point(412, 514);
            this.numericUpDownX2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownX2.Name = "numericUpDownX2";
            this.numericUpDownX2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownX2.TabIndex = 13;
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.DecimalPlaces = 1;
            this.numericUpDownY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownY.Location = new System.Drawing.Point(247, 548);
            this.numericUpDownY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(113, 22);
            this.numericUpDownY.TabIndex = 14;
            // 
            // numericUpDownY2
            // 
            this.numericUpDownY2.DecimalPlaces = 1;
            this.numericUpDownY2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownY2.Location = new System.Drawing.Point(412, 548);
            this.numericUpDownY2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownY2.Name = "numericUpDownY2";
            this.numericUpDownY2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownY2.TabIndex = 15;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(606, 496);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(148, 40);
            this.buttonGenerate.TabIndex = 16;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(606, 548);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(148, 40);
            this.buttonReturn.TabIndex = 17;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 607);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.numericUpDownY2);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.numericUpDownX2);
            this.Controls.Add(this.numericUpDownX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownV2);
            this.Controls.Add(this.numericUpDownV1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBoxFunction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(804, 654);
            this.MinimumSize = new System.Drawing.Size(804, 654);
            this.Name = "Form3";
            this.Text = "Reference System for PD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFunction;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownV1;
        private System.Windows.Forms.NumericUpDown numericUpDownV2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.NumericUpDown numericUpDownX2;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownY2;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonReturn;
    }
}