
namespace Lab_2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearBut = new System.Windows.Forms.Button();
            this.activeBut = new System.Windows.Forms.Button();
            this.edDollarRate = new System.Windows.Forms.NumericUpDown();
            this.edEuroRate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edDollarRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edEuroRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clearBut);
            this.panel1.Controls.Add(this.activeBut);
            this.panel1.Controls.Add(this.edDollarRate);
            this.panel1.Controls.Add(this.edEuroRate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 100);
            this.panel1.TabIndex = 0;
            // 
            // clearBut
            // 
            this.clearBut.Location = new System.Drawing.Point(408, 49);
            this.clearBut.Name = "clearBut";
            this.clearBut.Size = new System.Drawing.Size(125, 34);
            this.clearBut.TabIndex = 5;
            this.clearBut.Text = "Очистить";
            this.clearBut.UseVisualStyleBackColor = true;
            this.clearBut.Click += new System.EventHandler(this.clearBut_Click);
            // 
            // activeBut
            // 
            this.activeBut.Location = new System.Drawing.Point(408, 12);
            this.activeBut.Name = "activeBut";
            this.activeBut.Size = new System.Drawing.Size(125, 31);
            this.activeBut.TabIndex = 4;
            this.activeBut.Text = "Старт";
            this.activeBut.UseVisualStyleBackColor = true;
            this.activeBut.Click += new System.EventHandler(this.activeBut_Click);
            // 
            // edDollarRate
            // 
            this.edDollarRate.DecimalPlaces = 4;
            this.edDollarRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.edDollarRate.Location = new System.Drawing.Point(240, 49);
            this.edDollarRate.Name = "edDollarRate";
            this.edDollarRate.Size = new System.Drawing.Size(120, 26);
            this.edDollarRate.TabIndex = 3;
            this.edDollarRate.Value = new decimal(new int[] {
            711012,
            0,
            0,
            262144});
            // 
            // edEuroRate
            // 
            this.edEuroRate.DecimalPlaces = 4;
            this.edEuroRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.edEuroRate.Location = new System.Drawing.Point(240, 11);
            this.edEuroRate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edEuroRate.Name = "edEuroRate";
            this.edEuroRate.Size = new System.Drawing.Size(120, 26);
            this.edEuroRate.TabIndex = 2;
            this.edEuroRate.Value = new decimal(new int[] {
            730738,
            0,
            0,
            262144});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Текущий курс Доллара:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущий курс Евро:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 100);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "f3";
            series1.Legend = "Legend1";
            series1.Name = "Euro";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "f3";
            series2.Legend = "Legend1";
            series2.Name = "Dollar";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1075, 614);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 714);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edDollarRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edEuroRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearBut;
        private System.Windows.Forms.Button activeBut;
        private System.Windows.Forms.NumericUpDown edDollarRate;
        private System.Windows.Forms.NumericUpDown edEuroRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
    }
}

