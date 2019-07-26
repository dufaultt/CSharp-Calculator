namespace Calculator
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
            System.Windows.Forms.Button sin;
            this.equals = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.num0 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.Squared = new System.Windows.Forms.Button();
            this.SquareRoot = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            sin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sin
            // 
            sin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sin.Location = new System.Drawing.Point(590, 313);
            sin.Name = "sin";
            sin.Size = new System.Drawing.Size(118, 80);
            sin.TabIndex = 21;
            sin.Text = "Sin";
            sin.UseVisualStyleBackColor = false;
            sin.Click += new System.EventHandler(this.Sin_Click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(12, 523);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(547, 103);
            this.equals.TabIndex = 0;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(721, 53);
            this.textBox1.TabIndex = 1;
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(12, 422);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(117, 76);
            this.num0.TabIndex = 2;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.Num0_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(264, 422);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(122, 76);
            this.clear.TabIndex = 3;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(12, 319);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(117, 74);
            this.num1.TabIndex = 4;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.Num1_Click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(12, 215);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(117, 77);
            this.num4.TabIndex = 5;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.Num4_Click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(264, 319);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(122, 74);
            this.num3.TabIndex = 6;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.Num3_Click);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(264, 215);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(122, 77);
            this.num6.TabIndex = 7;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.Num6_Click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(264, 102);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(122, 80);
            this.num9.TabIndex = 8;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.Num9_Click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(135, 102);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(123, 80);
            this.num8.TabIndex = 9;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.Num8_Click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(135, 215);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(123, 77);
            this.num5.TabIndex = 10;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.Num5_Click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(135, 319);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(123, 74);
            this.num2.TabIndex = 11;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.Num2_Click);
            // 
            // dec
            // 
            this.dec.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec.Location = new System.Drawing.Point(135, 422);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(123, 76);
            this.dec.TabIndex = 12;
            this.dec.Text = ".";
            this.dec.UseVisualStyleBackColor = false;
            this.dec.Click += new System.EventHandler(this.Dec_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(435, 319);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(124, 74);
            this.plus.TabIndex = 13;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // mult
            // 
            this.mult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.Location = new System.Drawing.Point(435, 215);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(124, 77);
            this.mult.TabIndex = 14;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = false;
            this.mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(435, 102);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(124, 80);
            this.divide.TabIndex = 15;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(12, 102);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(117, 80);
            this.num7.TabIndex = 16;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.Num7_Click);
            // 
            // subtract
            // 
            this.subtract.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract.Location = new System.Drawing.Point(435, 421);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(124, 77);
            this.subtract.TabIndex = 17;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = false;
            this.subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Squared
            // 
            this.Squared.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Squared.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Squared.Location = new System.Drawing.Point(590, 102);
            this.Squared.Name = "Squared";
            this.Squared.Size = new System.Drawing.Size(118, 80);
            this.Squared.TabIndex = 18;
            this.Squared.Text = "X^2";
            this.Squared.UseVisualStyleBackColor = false;
            this.Squared.Click += new System.EventHandler(this.Squared_Click);
            // 
            // SquareRoot
            // 
            this.SquareRoot.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SquareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SquareRoot.Location = new System.Drawing.Point(590, 212);
            this.SquareRoot.Name = "SquareRoot";
            this.SquareRoot.Size = new System.Drawing.Size(118, 80);
            this.SquareRoot.TabIndex = 19;
            this.SquareRoot.Text = "Root";
            this.SquareRoot.UseVisualStyleBackColor = false;
            this.SquareRoot.Click += new System.EventHandler(this.SquareRoot_Click);
            // 
            // cos
            // 
            this.cos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cos.Location = new System.Drawing.Point(590, 421);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(118, 80);
            this.cos.TabIndex = 20;
            this.cos.Text = "Cos";
            this.cos.UseVisualStyleBackColor = false;
            this.cos.Click += new System.EventHandler(this.Cos_Click);
            // 
            // tan
            // 
            this.tan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tan.Location = new System.Drawing.Point(590, 523);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(118, 80);
            this.tan.TabIndex = 22;
            this.tan.Text = "Tan";
            this.tan.UseVisualStyleBackColor = false;
            this.tan.Click += new System.EventHandler(this.Tan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(745, 638);
            this.Controls.Add(this.tan);
            this.Controls.Add(sin);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.SquareRoot);
            this.Controls.Add(this.Squared);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.equals);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button Squared;
        private System.Windows.Forms.Button SquareRoot;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button tan;
    }
}

