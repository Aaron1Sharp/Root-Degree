namespace FormAlgorithmEuclidean
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
            this.output = new System.Windows.Forms.Label();
            this.firstnumber = new System.Windows.Forms.TextBox();
            this.secondnumber = new System.Windows.Forms.TextBox();
            this.thirdnumber = new System.Windows.Forms.TextBox();
            this.fourthnumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.Location = new System.Drawing.Point(247, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Высчитать НОД";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.output.Location = new System.Drawing.Point(256, 64);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(46, 39);
            this.output.TabIndex = 1;
            this.output.Text = "= ";
            // 
            // firstnumber
            // 
            this.firstnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.firstnumber.ForeColor = System.Drawing.Color.Black;
            this.firstnumber.Location = new System.Drawing.Point(12, 5);
            this.firstnumber.Name = "firstnumber";
            this.firstnumber.Size = new System.Drawing.Size(229, 46);
            this.firstnumber.TabIndex = 2;
            this.firstnumber.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // secondnumber
            // 
            this.secondnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.secondnumber.ForeColor = System.Drawing.Color.Black;
            this.secondnumber.Location = new System.Drawing.Point(12, 57);
            this.secondnumber.Name = "secondnumber";
            this.secondnumber.Size = new System.Drawing.Size(229, 46);
            this.secondnumber.TabIndex = 3;
            this.secondnumber.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // thirdnumber
            // 
            this.thirdnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.thirdnumber.ForeColor = System.Drawing.Color.Black;
            this.thirdnumber.Location = new System.Drawing.Point(12, 109);
            this.thirdnumber.Name = "thirdnumber";
            this.thirdnumber.Size = new System.Drawing.Size(229, 46);
            this.thirdnumber.TabIndex = 4;
            // 
            // fourthnumber
            // 
            this.fourthnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.fourthnumber.ForeColor = System.Drawing.Color.Black;
            this.fourthnumber.Location = new System.Drawing.Point(12, 161);
            this.fourthnumber.Name = "fourthnumber";
            this.fourthnumber.Size = new System.Drawing.Size(229, 46);
            this.fourthnumber.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 221);
            this.Controls.Add(this.fourthnumber);
            this.Controls.Add(this.thirdnumber);
            this.Controls.Add(this.secondnumber);
            this.Controls.Add(this.firstnumber);
            this.Controls.Add(this.output);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.TextBox firstnumber;
        private System.Windows.Forms.TextBox secondnumber;
        private System.Windows.Forms.TextBox thirdnumber;
        private System.Windows.Forms.TextBox fourthnumber;
    }
}

