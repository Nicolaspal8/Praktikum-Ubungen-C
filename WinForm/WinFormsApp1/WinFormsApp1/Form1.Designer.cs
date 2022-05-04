
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eigth = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(28, 77);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(52, 49);
            this.one.TabIndex = 0;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.sendValue);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(89, 77);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(52, 49);
            this.two.TabIndex = 1;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.sendValue);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(152, 77);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(52, 49);
            this.three.TabIndex = 2;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.sendValue);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(28, 132);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(52, 49);
            this.four.TabIndex = 3;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.sendValue);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(89, 132);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(52, 49);
            this.five.TabIndex = 4;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.sendValue);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(152, 132);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(52, 49);
            this.six.TabIndex = 5;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.sendValue);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(28, 187);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(52, 50);
            this.seven.TabIndex = 6;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.sendValue);
            // 
            // eigth
            // 
            this.eigth.Location = new System.Drawing.Point(89, 187);
            this.eigth.Name = "eigth";
            this.eigth.Size = new System.Drawing.Size(52, 50);
            this.eigth.TabIndex = 7;
            this.eigth.Text = "8";
            this.eigth.UseVisualStyleBackColor = true;
            this.eigth.Click += new System.EventHandler(this.sendValue);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(152, 187);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(52, 50);
            this.nine.TabIndex = 8;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.sendValue);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(89, 253);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(52, 50);
            this.button10.TabIndex = 9;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.sendValue);
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(28, 253);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(52, 50);
            this.point.TabIndex = 10;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.sendValue);
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(152, 253);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(52, 50);
            this.square.TabIndex = 11;
            this.square.Text = "√";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.sendValue);
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(215, 77);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(52, 49);
            this.sum.TabIndex = 12;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sendValue);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(215, 132);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(52, 49);
            this.subtract.TabIndex = 13;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.sendValue);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(215, 187);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(52, 50);
            this.multiply.TabIndex = 14;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.sendValue);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(215, 253);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(52, 50);
            this.divide.TabIndex = 15;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.sendValue);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(152, 314);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(115, 40);
            this.equal.TabIndex = 16;
            this.equal.Text = "CE";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.clean);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(28, 26);
            this.txtResult.MaxLength = 21;
            this.txtResult.Name = "txtResult";
            this.txtResult.PlaceholderText = "0";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(239, 23);
            this.txtResult.TabIndex = 17;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.calculate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 362);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.square);
            this.Controls.Add(this.point);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eigth);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eigth;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button button1;
    }
}

