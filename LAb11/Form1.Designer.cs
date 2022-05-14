namespace LAb11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelChiSquared = new System.Windows.Forms.Label();
            this.labelVariance = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btStart = new System.Windows.Forms.Button();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.numVariance = new System.Windows.Forms.NumericUpDown();
            this.numMean = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelChiSquared);
            this.panel1.Controls.Add(this.labelVariance);
            this.panel1.Controls.Add(this.labelAverage);
            this.panel1.Location = new System.Drawing.Point(3, 512);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 165);
            this.panel1.TabIndex = 0;
            // 
            // labelChiSquared
            // 
            this.labelChiSquared.AutoSize = true;
            this.labelChiSquared.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChiSquared.Location = new System.Drawing.Point(274, 118);
            this.labelChiSquared.Name = "labelChiSquared";
            this.labelChiSquared.Size = new System.Drawing.Size(0, 46);
            this.labelChiSquared.TabIndex = 7;
            // 
            // labelVariance
            // 
            this.labelVariance.AutoSize = true;
            this.labelVariance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVariance.Location = new System.Drawing.Point(274, 66);
            this.labelVariance.Name = "labelVariance";
            this.labelVariance.Size = new System.Drawing.Size(0, 46);
            this.labelVariance.TabIndex = 6;
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAverage.Location = new System.Drawing.Point(274, 15);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(0, 46);
            this.labelAverage.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btStart);
            this.panel2.Controls.Add(this.numSize);
            this.panel2.Controls.Add(this.numVariance);
            this.panel2.Controls.Add(this.numMean);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 506);
            this.panel2.TabIndex = 1;
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(15, 198);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(245, 78);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // numSize
            // 
            this.numSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numSize.Location = new System.Drawing.Point(171, 117);
            this.numSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(100, 39);
            this.numSize.TabIndex = 7;
            this.numSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numVariance
            // 
            this.numVariance.DecimalPlaces = 2;
            this.numVariance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numVariance.Location = new System.Drawing.Point(140, 65);
            this.numVariance.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numVariance.Name = "numVariance";
            this.numVariance.Size = new System.Drawing.Size(106, 39);
            this.numVariance.TabIndex = 6;
            this.numVariance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numMean
            // 
            this.numMean.DecimalPlaces = 2;
            this.numMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numMean.Location = new System.Drawing.Point(126, 12);
            this.numMean.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numMean.Name = "numMean";
            this.numMean.Size = new System.Drawing.Size(105, 39);
            this.numMean.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sample size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Variance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mean";
            // 
            // chart1
            // 
            chartArea5.AxisY.Maximum = 0.7D;
            chartArea5.AxisY.Minimum = 0D;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Location = new System.Drawing.Point(283, 0);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Name = "Series1";
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(912, 506);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 679);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelChiSquared;
        private System.Windows.Forms.Label labelVariance;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.NumericUpDown numVariance;
        private System.Windows.Forms.NumericUpDown numMean;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

