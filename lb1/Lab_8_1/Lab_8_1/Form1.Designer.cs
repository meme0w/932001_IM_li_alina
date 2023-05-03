
namespace Lab_8_1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.answBut = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // answBut
            // 
            this.answBut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.answBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answBut.Location = new System.Drawing.Point(277, 92);
            this.answBut.Name = "answBut";
            this.answBut.Size = new System.Drawing.Size(228, 79);
            this.answBut.TabIndex = 1;
            this.answBut.Text = "Answer!";
            this.answBut.UseVisualStyleBackColor = false;
            this.answBut.Click += new System.EventHandler(this.answBut_Click);
            // 
            // answer
            // 
            this.answer.BackColor = System.Drawing.Color.PaleGreen;
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer.Location = new System.Drawing.Point(290, 236);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(201, 106);
            this.answer.TabIndex = 2;
            this.answer.Text = "label1";
            this.answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.answBut);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button answBut;
        private System.Windows.Forms.Label answer;
    }
}

