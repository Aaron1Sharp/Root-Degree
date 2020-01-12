namespace TriangleForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.InputA = new System.Windows.Forms.TextBox();
            this.InputB = new System.Windows.Forms.TextBox();
            this.InputC = new System.Windows.Forms.TextBox();
            this.OutputP = new System.Windows.Forms.Label();
            this.OutputS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Высчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // InputA
            // 
            this.InputA.Location = new System.Drawing.Point(127, 11);
            this.InputA.Name = "InputA";
            this.InputA.Size = new System.Drawing.Size(100, 20);
            this.InputA.TabIndex = 1;
            // 
            // InputB
            // 
            this.InputB.Location = new System.Drawing.Point(127, 37);
            this.InputB.Name = "InputB";
            this.InputB.Size = new System.Drawing.Size(100, 20);
            this.InputB.TabIndex = 2;
            // 
            // InputC
            // 
            this.InputC.Location = new System.Drawing.Point(127, 63);
            this.InputC.Name = "InputC";
            this.InputC.Size = new System.Drawing.Size(100, 20);
            this.InputC.TabIndex = 3;
            // 
            // OutputP
            // 
            this.OutputP.AutoSize = true;
            this.OutputP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.OutputP.Location = new System.Drawing.Point(351, 57);
            this.OutputP.Name = "OutputP";
            this.OutputP.Size = new System.Drawing.Size(0, 25);
            this.OutputP.TabIndex = 4;
            this.OutputP.Click += new System.EventHandler(this.Label1_Click);
            // 
            // OutputS
            // 
            this.OutputS.AutoSize = true;
            this.OutputS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.OutputS.Location = new System.Drawing.Point(351, 18);
            this.OutputS.Name = "OutputS";
            this.OutputS.Size = new System.Drawing.Size(0, 25);
            this.OutputS.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.Location = new System.Drawing.Point(233, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Периметр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label4.Location = new System.Drawing.Point(235, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Площадь";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label5.Location = new System.Drawing.Point(7, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Сторона a";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Сторона b";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label7.Location = new System.Drawing.Point(7, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Сторона с";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 171);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OutputS);
            this.Controls.Add(this.OutputP);
            this.Controls.Add(this.InputC);
            this.Controls.Add(this.InputB);
            this.Controls.Add(this.InputA);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Площадь треугольника";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox InputA;
        private System.Windows.Forms.TextBox InputB;
        private System.Windows.Forms.TextBox InputC;
        private System.Windows.Forms.Label OutputP;
        private System.Windows.Forms.Label OutputS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

