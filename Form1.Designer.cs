namespace changeBatteryStatus
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
            this.Eco = new System.Windows.Forms.Button();
            this.Extreme = new System.Windows.Forms.Button();
            this.Balance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Eco
            // 
            this.Eco.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Eco.Location = new System.Drawing.Point(12, 68);
            this.Eco.Name = "Eco";
            this.Eco.Size = new System.Drawing.Size(280, 86);
            this.Eco.TabIndex = 0;
            this.Eco.Text = "Экономный";
            this.Eco.UseVisualStyleBackColor = true;
            this.Eco.Click += new System.EventHandler(this.Eco_Click);
            // 
            // Extreme
            // 
            this.Extreme.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Extreme.Location = new System.Drawing.Point(12, 293);
            this.Extreme.Name = "Extreme";
            this.Extreme.Size = new System.Drawing.Size(280, 86);
            this.Extreme.TabIndex = 1;
            this.Extreme.Text = "Экстримальная производительность";
            this.Extreme.UseVisualStyleBackColor = true;
            this.Extreme.Click += new System.EventHandler(this.Extreme_Click);
            // 
            // Balance
            // 
            this.Balance.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Balance.Location = new System.Drawing.Point(12, 180);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(280, 86);
            this.Balance.TabIndex = 2;
            this.Balance.Text = "Сбалансированный";
            this.Balance.UseVisualStyleBackColor = true;
            this.Balance.Click += new System.EventHandler(this.Balance_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 456);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.Extreme);
            this.Controls.Add(this.Eco);
            this.Name = "Form1";
            this.Text = "changeBatterySatus";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Eco;
        private System.Windows.Forms.Button Extreme;
        private System.Windows.Forms.Button Balance;
    }
}

