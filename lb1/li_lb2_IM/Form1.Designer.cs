
namespace li_lb2_IM
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.clearBut = new System.Windows.Forms.Button();
            this.activeBut = new System.Windows.Forms.Button();
            this.edDollar = new System.Windows.Forms.NumericUpDown();
            this.edEuro = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.edDollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // clearBut
            // 
            this.clearBut.Location = new System.Drawing.Point(601, 11);
            this.clearBut.Margin = new System.Windows.Forms.Padding(2);
            this.clearBut.Name = "clearBut";
            this.clearBut.Size = new System.Drawing.Size(83, 22);
            this.clearBut.TabIndex = 11;
            this.clearBut.Text = "Очистить";
            this.clearBut.UseVisualStyleBackColor = true;
            this.clearBut.Click += new System.EventHandler(this.clearBut_Click);
            // 
            // activeBut
            // 
            this.activeBut.Location = new System.Drawing.Point(495, 12);
            this.activeBut.Margin = new System.Windows.Forms.Padding(2);
            this.activeBut.Name = "activeBut";
            this.activeBut.Size = new System.Drawing.Size(83, 20);
            this.activeBut.TabIndex = 10;
            this.activeBut.Text = "Старт";
            this.activeBut.UseVisualStyleBackColor = true;
            this.activeBut.Click += new System.EventHandler(this.activeBut_Click);
            // 
            // edDollar
            // 
            this.edDollar.DecimalPlaces = 4;
            this.edDollar.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.edDollar.Location = new System.Drawing.Point(382, 12);
            this.edDollar.Margin = new System.Windows.Forms.Padding(2);
            this.edDollar.Name = "edDollar";
            this.edDollar.Size = new System.Drawing.Size(80, 20);
            this.edDollar.TabIndex = 9;
            this.edDollar.Value = new decimal(new int[] {
            7546,
            0,
            0,
            131072});
            // 
            // edEuro
            // 
            this.edEuro.DecimalPlaces = 4;
            this.edEuro.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.edEuro.Location = new System.Drawing.Point(142, 11);
            this.edEuro.Margin = new System.Windows.Forms.Padding(2);
            this.edEuro.Name = "edEuro";
            this.edEuro.Size = new System.Drawing.Size(80, 20);
            this.edEuro.TabIndex = 8;
            this.edEuro.Value = new decimal(new int[] {
            8005,
            0,
            0,
            131072});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Текущий курс Доллара:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Текущий курс Евро:";
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisY.Minimum = 70D;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(23, 55);
            this.chart1.Name = "chart1";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.IsValueShownAsLabel = true;
            series5.LabelFormat = "C";
            series5.Legend = "Legend1";
            series5.Name = "Euro";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.IsValueShownAsLabel = true;
            series6.LabelFormat = "C";
            series6.Legend = "Legend1";
            series6.Name = "Dollar";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(661, 362);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.clearBut);
            this.Controls.Add(this.activeBut);
            this.Controls.Add(this.edDollar);
            this.Controls.Add(this.edEuro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.edDollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearBut;
        private System.Windows.Forms.Button activeBut;
        private System.Windows.Forms.NumericUpDown edDollar;
        private System.Windows.Forms.NumericUpDown edEuro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

