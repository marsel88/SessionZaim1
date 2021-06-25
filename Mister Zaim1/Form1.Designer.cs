namespace Mister_Zaim1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonCount = new System.Windows.Forms.Button();
            this.TbSum = new System.Windows.Forms.TextBox();
            this.TbDays = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbPercent = new System.Windows.Forms.TextBox();
            this.LvPayments = new System.Windows.Forms.ListView();
            this.TbFullSum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbSumOfPercent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(260, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Микрозаймы \"Mister Zaim\"";
            // 
            // ButtonCount
            // 
            this.ButtonCount.Location = new System.Drawing.Point(139, 282);
            this.ButtonCount.Name = "ButtonCount";
            this.ButtonCount.Size = new System.Drawing.Size(153, 31);
            this.ButtonCount.TabIndex = 1;
            this.ButtonCount.Text = "Рассчитать кредит";
            this.ButtonCount.UseVisualStyleBackColor = true;
            this.ButtonCount.Click += new System.EventHandler(this.ButtonCount_Click);
            // 
            // TbSum
            // 
            this.TbSum.Location = new System.Drawing.Point(43, 84);
            this.TbSum.Name = "TbSum";
            this.TbSum.Size = new System.Drawing.Size(100, 20);
            this.TbSum.TabIndex = 2;
            // 
            // TbDays
            // 
            this.TbDays.Location = new System.Drawing.Point(43, 128);
            this.TbDays.Name = "TbDays";
            this.TbDays.Size = new System.Drawing.Size(100, 20);
            this.TbDays.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сумма займа в рублях";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Срок займа в днях";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Проценты по дням";
            // 
            // TbPercent
            // 
            this.TbPercent.Location = new System.Drawing.Point(43, 177);
            this.TbPercent.Name = "TbPercent";
            this.TbPercent.Size = new System.Drawing.Size(100, 20);
            this.TbPercent.TabIndex = 7;
            // 
            // LvPayments
            // 
            this.LvPayments.HideSelection = false;
            this.LvPayments.Location = new System.Drawing.Point(429, 63);
            this.LvPayments.Name = "LvPayments";
            this.LvPayments.Size = new System.Drawing.Size(331, 309);
            this.LvPayments.TabIndex = 8;
            this.LvPayments.UseCompatibleStateImageBehavior = false;
            // 
            // TbFullSum
            // 
            this.TbFullSum.Location = new System.Drawing.Point(238, 144);
            this.TbFullSum.Name = "TbFullSum";
            this.TbFullSum.Size = new System.Drawing.Size(115, 20);
            this.TbFullSum.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(175, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Полная выплачиваемая сумма";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(186, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Сумма процентов по долгу";
            // 
            // TbSumOfPercent
            // 
            this.TbSumOfPercent.Location = new System.Drawing.Point(238, 197);
            this.TbSumOfPercent.Name = "TbSumOfPercent";
            this.TbSumOfPercent.Size = new System.Drawing.Size(115, 20);
            this.TbSumOfPercent.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(175, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Эффективная процентная ставка";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(762, 406);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TbSumOfPercent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbFullSum);
            this.Controls.Add(this.LvPayments);
            this.Controls.Add(this.TbPercent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbDays);
            this.Controls.Add(this.TbSum);
            this.Controls.Add(this.ButtonCount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonCount;
        private System.Windows.Forms.TextBox TbSum;
        private System.Windows.Forms.TextBox TbDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbPercent;
        private System.Windows.Forms.ListView LvPayments;
        private System.Windows.Forms.TextBox TbFullSum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbSumOfPercent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}

