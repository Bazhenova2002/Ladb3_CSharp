namespace Lab3_Csharp
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResultTextBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ResultTextBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ResultTextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CN4 = new System.Windows.Forms.Label();
            this.tBoxImaginaryPart4 = new System.Windows.Forms.TextBox();
            this.tBoxRealPart4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxImaginaryPart3 = new System.Windows.Forms.TextBox();
            this.tBoxRealPart3 = new System.Windows.Forms.TextBox();
            this.tBoxImaginaryPart2 = new System.Windows.Forms.TextBox();
            this.tBoxRealPart2 = new System.Windows.Forms.TextBox();
            this.tBoxImaginaryPart1 = new System.Windows.Forms.TextBox();
            this.tBoxRealPart1 = new System.Windows.Forms.TextBox();
            this.CN3 = new System.Windows.Forms.Label();
            this.CN2 = new System.Windows.Forms.Label();
            this.CN1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CalculateButton.Location = new System.Drawing.Point(114, 216);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(343, 76);
            this.CalculateButton.TabIndex = 55;
            this.CalculateButton.Text = "CALCULATE";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click_1);
            // 
            // ResultTextBox3
            // 
            this.ResultTextBox3.Location = new System.Drawing.Point(165, 460);
            this.ResultTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.ResultTextBox3.Name = "ResultTextBox3";
            this.ResultTextBox3.Size = new System.Drawing.Size(291, 22);
            this.ResultTextBox3.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(110, 464);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 53;
            this.label11.Text = "R++ =";
            // 
            // ResultTextBox2
            // 
            this.ResultTextBox2.Location = new System.Drawing.Point(165, 428);
            this.ResultTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.ResultTextBox2.Name = "ResultTextBox2";
            this.ResultTextBox2.Size = new System.Drawing.Size(291, 22);
            this.ResultTextBox2.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 432);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 51;
            this.label10.Text = "|R| =";
            // 
            // ResultTextBox1
            // 
            this.ResultTextBox1.Location = new System.Drawing.Point(165, 396);
            this.ResultTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ResultTextBox1.Name = "ResultTextBox1";
            this.ResultTextBox1.Size = new System.Drawing.Size(291, 22);
            this.ResultTextBox1.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 400);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "R =";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 300);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 78);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // CN4
            // 
            this.CN4.AutoSize = true;
            this.CN4.Location = new System.Drawing.Point(186, 172);
            this.CN4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CN4.Name = "CN4";
            this.CN4.Size = new System.Drawing.Size(16, 17);
            this.CN4.TabIndex = 47;
            this.CN4.Text = "d";
            // 
            // tBoxImaginaryPart4
            // 
            this.tBoxImaginaryPart4.Location = new System.Drawing.Point(301, 169);
            this.tBoxImaginaryPart4.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxImaginaryPart4.Name = "tBoxImaginaryPart4";
            this.tBoxImaginaryPart4.Size = new System.Drawing.Size(52, 22);
            this.tBoxImaginaryPart4.TabIndex = 46;
            // 
            // tBoxRealPart4
            // 
            this.tBoxRealPart4.Location = new System.Drawing.Point(211, 169);
            this.tBoxRealPart4.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxRealPart4.Name = "tBoxRealPart4";
            this.tBoxRealPart4.Size = new System.Drawing.Size(52, 22);
            this.tBoxRealPart4.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(362, 172);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "i";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 172);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "i";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "i";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "i";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "+";
            // 
            // tBoxImaginaryPart3
            // 
            this.tBoxImaginaryPart3.Location = new System.Drawing.Point(301, 137);
            this.tBoxImaginaryPart3.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxImaginaryPart3.Name = "tBoxImaginaryPart3";
            this.tBoxImaginaryPart3.Size = new System.Drawing.Size(52, 22);
            this.tBoxImaginaryPart3.TabIndex = 36;
            // 
            // tBoxRealPart3
            // 
            this.tBoxRealPart3.Location = new System.Drawing.Point(211, 137);
            this.tBoxRealPart3.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxRealPart3.Name = "tBoxRealPart3";
            this.tBoxRealPart3.Size = new System.Drawing.Size(52, 22);
            this.tBoxRealPart3.TabIndex = 35;
            // 
            // tBoxImaginaryPart2
            // 
            this.tBoxImaginaryPart2.Location = new System.Drawing.Point(301, 105);
            this.tBoxImaginaryPart2.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxImaginaryPart2.Name = "tBoxImaginaryPart2";
            this.tBoxImaginaryPart2.Size = new System.Drawing.Size(52, 22);
            this.tBoxImaginaryPart2.TabIndex = 34;
            // 
            // tBoxRealPart2
            // 
            this.tBoxRealPart2.Location = new System.Drawing.Point(211, 105);
            this.tBoxRealPart2.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxRealPart2.Name = "tBoxRealPart2";
            this.tBoxRealPart2.Size = new System.Drawing.Size(52, 22);
            this.tBoxRealPart2.TabIndex = 33;
            // 
            // tBoxImaginaryPart1
            // 
            this.tBoxImaginaryPart1.Location = new System.Drawing.Point(301, 73);
            this.tBoxImaginaryPart1.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxImaginaryPart1.Name = "tBoxImaginaryPart1";
            this.tBoxImaginaryPart1.Size = new System.Drawing.Size(52, 22);
            this.tBoxImaginaryPart1.TabIndex = 32;
            // 
            // tBoxRealPart1
            // 
            this.tBoxRealPart1.Location = new System.Drawing.Point(211, 73);
            this.tBoxRealPart1.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxRealPart1.Name = "tBoxRealPart1";
            this.tBoxRealPart1.Size = new System.Drawing.Size(52, 22);
            this.tBoxRealPart1.TabIndex = 31;
            // 
            // CN3
            // 
            this.CN3.AutoSize = true;
            this.CN3.Location = new System.Drawing.Point(186, 140);
            this.CN3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CN3.Name = "CN3";
            this.CN3.Size = new System.Drawing.Size(15, 17);
            this.CN3.TabIndex = 30;
            this.CN3.Text = "c";
            // 
            // CN2
            // 
            this.CN2.AutoSize = true;
            this.CN2.Location = new System.Drawing.Point(186, 108);
            this.CN2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CN2.Name = "CN2";
            this.CN2.Size = new System.Drawing.Size(16, 17);
            this.CN2.TabIndex = 29;
            this.CN2.Text = "b";
            // 
            // CN1
            // 
            this.CN1.AutoSize = true;
            this.CN1.Location = new System.Drawing.Point(186, 76);
            this.CN1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CN1.Name = "CN1";
            this.CN1.Size = new System.Drawing.Size(16, 17);
            this.CN1.TabIndex = 28;
            this.CN1.Text = "a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 554);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ResultTextBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ResultTextBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ResultTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CN4);
            this.Controls.Add(this.tBoxImaginaryPart4);
            this.Controls.Add(this.tBoxRealPart4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxImaginaryPart3);
            this.Controls.Add(this.tBoxRealPart3);
            this.Controls.Add(this.tBoxImaginaryPart2);
            this.Controls.Add(this.tBoxRealPart2);
            this.Controls.Add(this.tBoxImaginaryPart1);
            this.Controls.Add(this.tBoxRealPart1);
            this.Controls.Add(this.CN3);
            this.Controls.Add(this.CN2);
            this.Controls.Add(this.CN1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox ResultTextBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ResultTextBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ResultTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CN4;
        private System.Windows.Forms.TextBox tBoxImaginaryPart4;
        private System.Windows.Forms.TextBox tBoxRealPart4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxImaginaryPart3;
        private System.Windows.Forms.TextBox tBoxRealPart3;
        private System.Windows.Forms.TextBox tBoxImaginaryPart2;
        private System.Windows.Forms.TextBox tBoxRealPart2;
        private System.Windows.Forms.TextBox tBoxImaginaryPart1;
        private System.Windows.Forms.TextBox tBoxRealPart1;
        private System.Windows.Forms.Label CN3;
        private System.Windows.Forms.Label CN2;
        private System.Windows.Forms.Label CN1;
    }
}

