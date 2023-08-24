namespace MathQuiz
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
            components=new System.ComponentModel.Container();
            timeLabel=new Label();
            label1=new Label();
            plusLeftLabel=new Label();
            label2=new Label();
            plusRightLabel=new Label();
            label3=new Label();
            sum=new NumericUpDown();
            minusLeftLabel=new Label();
            label4=new Label();
            minusRightLabel=new Label();
            label5=new Label();
            difference=new NumericUpDown();
            timesLeftLabel=new Label();
            label6=new Label();
            timesRightLabel=new Label();
            label7=new Label();
            product=new NumericUpDown();
            dividedLeftLabel=new Label();
            label8=new Label();
            dividedRightLabel=new Label();
            label9=new Label();
            quotient=new NumericUpDown();
            startButton=new Button();
            timer1=new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle=BorderStyle.FixedSingle;
            timeLabel.Font=new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location=new Point(272, 9);
            timeLabel.Name="timeLabel";
            timeLabel.Size=new Size(200, 30);
            timeLabel.TabIndex=0;
            timeLabel.Text=" ";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(145, 9);
            label1.Name="label1";
            label1.Size=new Size(103, 30);
            label1.TabIndex=1;
            label1.Text="Time Left";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            plusLeftLabel.Location=new Point(52, 75);
            plusLeftLabel.Name="plusLeftLabel";
            plusLeftLabel.Size=new Size(60, 50);
            plusLeftLabel.TabIndex=2;
            plusLeftLabel.Text="?";
            plusLeftLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(118, 75);
            label2.Name="label2";
            label2.Size=new Size(60, 50);
            label2.TabIndex=3;
            label2.Text="+";
            label2.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            plusRightLabel.Location=new Point(188, 75);
            plusRightLabel.Name="plusRightLabel";
            plusRightLabel.Size=new Size(60, 50);
            plusRightLabel.TabIndex=4;
            plusRightLabel.Text="?";
            plusRightLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location=new Point(254, 75);
            label3.Name="label3";
            label3.Size=new Size(60, 50);
            label3.TabIndex=5;
            label3.Text="=";
            label3.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            sum.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            sum.Location=new Point(320, 82);
            sum.Name="sum";
            sum.Size=new Size(100, 39);
            sum.TabIndex=1;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            minusLeftLabel.Location=new Point(52, 136);
            minusLeftLabel.Name="minusLeftLabel";
            minusLeftLabel.Size=new Size(60, 50);
            minusLeftLabel.TabIndex=7;
            minusLeftLabel.Text="?";
            minusLeftLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location=new Point(118, 136);
            label4.Name="label4";
            label4.Size=new Size(60, 50);
            label4.TabIndex=8;
            label4.Text="-";
            label4.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            minusRightLabel.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            minusRightLabel.Location=new Point(188, 136);
            minusRightLabel.Name="minusRightLabel";
            minusRightLabel.Size=new Size(60, 50);
            minusRightLabel.TabIndex=9;
            minusRightLabel.Text="?";
            minusRightLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location=new Point(254, 136);
            label5.Name="label5";
            label5.Size=new Size(60, 50);
            label5.TabIndex=10;
            label5.Text="=";
            label5.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // difference
            // 
            difference.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            difference.Location=new Point(320, 143);
            difference.Name="difference";
            difference.Size=new Size(100, 39);
            difference.TabIndex=2;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            timesLeftLabel.Location=new Point(52, 186);
            timesLeftLabel.Name="timesLeftLabel";
            timesLeftLabel.Size=new Size(60, 50);
            timesLeftLabel.TabIndex=12;
            timesLeftLabel.Text="?";
            timesLeftLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location=new Point(118, 186);
            label6.Name="label6";
            label6.Size=new Size(60, 50);
            label6.TabIndex=13;
            label6.Text="x";
            label6.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            timesRightLabel.Location=new Point(188, 186);
            timesRightLabel.Name="timesRightLabel";
            timesRightLabel.Size=new Size(60, 50);
            timesRightLabel.TabIndex=14;
            timesRightLabel.Text="?";
            timesRightLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location=new Point(254, 186);
            label7.Name="label7";
            label7.Size=new Size(60, 50);
            label7.TabIndex=15;
            label7.Text="=";
            label7.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            product.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            product.Location=new Point(320, 193);
            product.Name="product";
            product.Size=new Size(100, 39);
            product.TabIndex=3;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dividedLeftLabel.Location=new Point(52, 246);
            dividedLeftLabel.Name="dividedLeftLabel";
            dividedLeftLabel.Size=new Size(60, 50);
            dividedLeftLabel.TabIndex=17;
            dividedLeftLabel.Text="?";
            dividedLeftLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location=new Point(118, 246);
            label8.Name="label8";
            label8.Size=new Size(60, 50);
            label8.TabIndex=18;
            label8.Text=" ÷ ";
            label8.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dividedRightLabel.Location=new Point(188, 246);
            dividedRightLabel.Name="dividedRightLabel";
            dividedRightLabel.Size=new Size(60, 50);
            dividedRightLabel.TabIndex=19;
            dividedRightLabel.Text="?";
            dividedRightLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location=new Point(254, 236);
            label9.Name="label9";
            label9.Size=new Size(60, 50);
            label9.TabIndex=20;
            label9.Text="=";
            label9.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            quotient.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            quotient.Location=new Point(320, 247);
            quotient.Name="quotient";
            quotient.Size=new Size(100, 39);
            quotient.TabIndex=4;
            // 
            // startButton
            // 
            startButton.AutoSize=true;
            startButton.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.Location=new Point(161, 314);
            startButton.Name="startButton";
            startButton.Size=new Size(137, 35);
            startButton.TabIndex=0;
            startButton.Text="Start the quiz.";
            startButton.UseVisualStyleBackColor=true;
            startButton.Click+=startButton_Click;
            // 
            // timer1
            // 
            timer1.Interval=1000;
            timer1.Tick+=timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(484, 361);
            Controls.Add(startButton);
            Controls.Add(quotient);
            Controls.Add(label9);
            Controls.Add(dividedRightLabel);
            Controls.Add(label8);
            Controls.Add(dividedLeftLabel);
            Controls.Add(product);
            Controls.Add(label7);
            Controls.Add(timesRightLabel);
            Controls.Add(label6);
            Controls.Add(timesLeftLabel);
            Controls.Add(difference);
            Controls.Add(label5);
            Controls.Add(minusRightLabel);
            Controls.Add(label4);
            Controls.Add(minusLeftLabel);
            Controls.Add(sum);
            Controls.Add(label3);
            Controls.Add(plusRightLabel);
            Controls.Add(label2);
            Controls.Add(plusLeftLabel);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            FormBorderStyle=FormBorderStyle.Fixed3D;
            MaximizeBox=false;
            Name="Form1";
            Text="Math Quiz";
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)difference).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label label1;
        private Label plusLeftLabel;
        private Label label2;
        private Label plusRightLabel;
        private Label label3;
        private NumericUpDown sum;
        private Label minusLeftLabel;
        private Label label4;
        private Label minusRightLabel;
        private Label label5;
        private NumericUpDown difference;
        private Label timesLeftLabel;
        private Label label6;
        private Label timesRightLabel;
        private Label label7;
        private NumericUpDown product;
        private Label dividedLeftLabel;
        private Label label8;
        private Label dividedRightLabel;
        private Label label9;
        private NumericUpDown quotient;
        private Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}