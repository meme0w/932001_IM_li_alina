
namespace Lab_11
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startBut = new System.Windows.Forms.Button();
            this.MeanNmd = new System.Windows.Forms.NumericUpDown();
            this.VarNmd = new System.Windows.Forms.NumericUpDown();
            this.SizeNmd = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AverLabel = new System.Windows.Forms.Label();
            this.VarLabel = new System.Windows.Forms.Label();
            this.ChiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MeanNmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VarNmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mean";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(46, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Variance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(46, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "SampleSize";
            // 
            // startBut
            // 
            this.startBut.Location = new System.Drawing.Point(128, 248);
            this.startBut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startBut.Name = "startBut";
            this.startBut.Size = new System.Drawing.Size(137, 55);
            this.startBut.TabIndex = 3;
            this.startBut.Text = "Start";
            this.startBut.UseVisualStyleBackColor = true;
            this.startBut.Click += new System.EventHandler(this.startBut_Click);
            // 
            // MeanNmd
            // 
            this.MeanNmd.DecimalPlaces = 3;
            this.MeanNmd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.MeanNmd.Location = new System.Drawing.Point(178, 55);
            this.MeanNmd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MeanNmd.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.MeanNmd.Name = "MeanNmd";
            this.MeanNmd.Size = new System.Drawing.Size(94, 28);
            this.MeanNmd.TabIndex = 4;
            this.MeanNmd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MeanNmd.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // VarNmd
            // 
            this.VarNmd.DecimalPlaces = 1;
            this.VarNmd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.VarNmd.Location = new System.Drawing.Point(178, 116);
            this.VarNmd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.VarNmd.Name = "VarNmd";
            this.VarNmd.Size = new System.Drawing.Size(94, 28);
            this.VarNmd.TabIndex = 5;
            this.VarNmd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.VarNmd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SizeNmd
            // 
            this.SizeNmd.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SizeNmd.Location = new System.Drawing.Point(178, 175);
            this.SizeNmd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SizeNmd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SizeNmd.Name = "SizeNmd";
            this.SizeNmd.Size = new System.Drawing.Size(94, 28);
            this.SizeNmd.TabIndex = 6;
            this.SizeNmd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SizeNmd.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(425, 55);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(852, 427);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // AverLabel
            // 
            this.AverLabel.AutoSize = true;
            this.AverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AverLabel.Location = new System.Drawing.Point(468, 516);
            this.AverLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AverLabel.Name = "AverLabel";
            this.AverLabel.Size = new System.Drawing.Size(90, 22);
            this.AverLabel.TabIndex = 8;
            this.AverLabel.Text = "Average:";
            // 
            // VarLabel
            // 
            this.VarLabel.AutoSize = true;
            this.VarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VarLabel.Location = new System.Drawing.Point(468, 568);
            this.VarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VarLabel.Name = "VarLabel";
            this.VarLabel.Size = new System.Drawing.Size(95, 22);
            this.VarLabel.TabIndex = 9;
            this.VarLabel.Text = "Variance:";
            // 
            // ChiLabel
            // 
            this.ChiLabel.AutoSize = true;
            this.ChiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChiLabel.Location = new System.Drawing.Point(468, 618);
            this.ChiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChiLabel.Name = "ChiLabel";
            this.ChiLabel.Size = new System.Drawing.Size(128, 22);
            this.ChiLabel.TabIndex = 10;
            this.ChiLabel.Text = "Chi-Squared:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 661);
            this.Controls.Add(this.ChiLabel);
            this.Controls.Add(this.VarLabel);
            this.Controls.Add(this.AverLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.SizeNmd);
            this.Controls.Add(this.VarNmd);
            this.Controls.Add(this.MeanNmd);
            this.Controls.Add(this.startBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MeanNmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VarNmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startBut;
        private System.Windows.Forms.NumericUpDown MeanNmd;
        private System.Windows.Forms.NumericUpDown VarNmd;
        private System.Windows.Forms.NumericUpDown SizeNmd;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label AverLabel;
        private System.Windows.Forms.Label VarLabel;
        private System.Windows.Forms.Label ChiLabel;
    }
}

