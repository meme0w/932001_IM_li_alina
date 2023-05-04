
namespace Lab_8_3
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prob1 = new System.Windows.Forms.NumericUpDown();
            this.prob2 = new System.Windows.Forms.NumericUpDown();
            this.prob3 = new System.Windows.Forms.NumericUpDown();
            this.prob4 = new System.Windows.Forms.NumericUpDown();
            this.prob5 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.trials = new System.Windows.Forms.NumericUpDown();
            this.startBut = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.averLabel = new System.Windows.Forms.Label();
            this.variaLabel = new System.Windows.Forms.Label();
            this.chiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prob1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prob 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prob 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(40, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prob 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(40, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prob 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(40, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prob 5";
            // 
            // prob1
            // 
            this.prob1.DecimalPlaces = 2;
            this.prob1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.prob1.Location = new System.Drawing.Point(122, 40);
            this.prob1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prob1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.prob1.Name = "prob1";
            this.prob1.Size = new System.Drawing.Size(103, 28);
            this.prob1.TabIndex = 5;
            this.prob1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // prob2
            // 
            this.prob2.DecimalPlaces = 2;
            this.prob2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.prob2.Location = new System.Drawing.Point(122, 85);
            this.prob2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prob2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.prob2.Name = "prob2";
            this.prob2.Size = new System.Drawing.Size(103, 28);
            this.prob2.TabIndex = 6;
            this.prob2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // prob3
            // 
            this.prob3.DecimalPlaces = 2;
            this.prob3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.prob3.Location = new System.Drawing.Point(122, 131);
            this.prob3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prob3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.prob3.Name = "prob3";
            this.prob3.Size = new System.Drawing.Size(103, 28);
            this.prob3.TabIndex = 7;
            this.prob3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // prob4
            // 
            this.prob4.DecimalPlaces = 2;
            this.prob4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.prob4.Location = new System.Drawing.Point(122, 175);
            this.prob4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prob4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.prob4.Name = "prob4";
            this.prob4.Size = new System.Drawing.Size(103, 28);
            this.prob4.TabIndex = 8;
            this.prob4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // prob5
            // 
            this.prob5.DecimalPlaces = 2;
            this.prob5.Location = new System.Drawing.Point(122, 221);
            this.prob5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prob5.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.prob5.Name = "prob5";
            this.prob5.ReadOnly = true;
            this.prob5.Size = new System.Drawing.Size(103, 28);
            this.prob5.TabIndex = 9;
            this.prob5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(45, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Number of trials:";
            // 
            // trials
            // 
            this.trials.Location = new System.Drawing.Point(291, 287);
            this.trials.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trials.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.trials.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trials.Name = "trials";
            this.trials.Size = new System.Drawing.Size(84, 28);
            this.trials.TabIndex = 11;
            this.trials.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.trials.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startBut
            // 
            this.startBut.BackColor = System.Drawing.Color.PaleGreen;
            this.startBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBut.Location = new System.Drawing.Point(109, 341);
            this.startBut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startBut.Name = "startBut";
            this.startBut.Size = new System.Drawing.Size(166, 48);
            this.startBut.TabIndex = 12;
            this.startBut.Text = "Start";
            this.startBut.UseVisualStyleBackColor = false;
            this.startBut.Click += new System.EventHandler(this.startBut_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Maximum = 6D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(447, 40);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(758, 350);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // averLabel
            // 
            this.averLabel.AutoSize = true;
            this.averLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.averLabel.Location = new System.Drawing.Point(447, 418);
            this.averLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.averLabel.Name = "averLabel";
            this.averLabel.Size = new System.Drawing.Size(90, 22);
            this.averLabel.TabIndex = 14;
            this.averLabel.Text = "Average:";
            // 
            // variaLabel
            // 
            this.variaLabel.AutoSize = true;
            this.variaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variaLabel.Location = new System.Drawing.Point(447, 459);
            this.variaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.variaLabel.Name = "variaLabel";
            this.variaLabel.Size = new System.Drawing.Size(95, 22);
            this.variaLabel.TabIndex = 15;
            this.variaLabel.Text = "Variance:";
            // 
            // chiLabel
            // 
            this.chiLabel.AutoSize = true;
            this.chiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chiLabel.Location = new System.Drawing.Point(447, 499);
            this.chiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chiLabel.Name = "chiLabel";
            this.chiLabel.Size = new System.Drawing.Size(125, 22);
            this.chiLabel.TabIndex = 16;
            this.chiLabel.Text = "Chi-squared:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 554);
            this.Controls.Add(this.chiLabel);
            this.Controls.Add(this.variaLabel);
            this.Controls.Add(this.averLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.startBut);
            this.Controls.Add(this.trials);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prob5);
            this.Controls.Add(this.prob4);
            this.Controls.Add(this.prob3);
            this.Controls.Add(this.prob2);
            this.Controls.Add(this.prob1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prob1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown prob1;
        private System.Windows.Forms.NumericUpDown prob2;
        private System.Windows.Forms.NumericUpDown prob3;
        private System.Windows.Forms.NumericUpDown prob4;
        private System.Windows.Forms.NumericUpDown prob5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown trials;
        private System.Windows.Forms.Button startBut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label averLabel;
        private System.Windows.Forms.Label variaLabel;
        private System.Windows.Forms.Label chiLabel;
    }
}

