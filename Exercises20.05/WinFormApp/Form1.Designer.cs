namespace WinFormApp
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
            groupBox1=new GroupBox();
            textBox2=new TextBox();
            textBox1=new TextBox();
            label2=new Label();
            label1=new Label();
            listBox1=new ListBox();
            radioButton1=new RadioButton();
            radioButton2=new RadioButton();
            radioButton3=new RadioButton();
            radioButton4=new RadioButton();
            button1=new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location=new Point(26, 39);
            groupBox1.Name="groupBox1";
            groupBox1.Size=new Size(215, 119);
            groupBox1.TabIndex=0;
            groupBox1.TabStop=false;
            groupBox1.Text="User Detail";
            // 
            // textBox2
            // 
            textBox2.Location=new Point(78, 71);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(100, 23);
            textBox2.TabIndex=3;
            // 
            // textBox1
            // 
            textBox1.Location=new Point(78, 24);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(100, 23);
            textBox1.TabIndex=2;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(18, 74);
            label2.Name="label2";
            label2.Size=new Size(49, 15);
            label2.TabIndex=1;
            label2.Text="Address";
            label2.Click+=label2_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(18, 27);
            label1.Name="label1";
            label1.Size=new Size(30, 15);
            label1.TabIndex=0;
            label1.Text="User";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled=true;
            listBox1.ItemHeight=15;
            listBox1.Items.AddRange(new object[] { "Skopje", "Belgrad", "Zagreb" });
            listBox1.Location=new Point(26, 254);
            listBox1.Name="listBox1";
            listBox1.Size=new Size(120, 94);
            listBox1.TabIndex=1;
            listBox1.SelectedIndexChanged+=listBox1_SelectedIndexChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize=true;
            radioButton1.Location=new Point(428, 60);
            radioButton1.Name="radioButton1";
            radioButton1.Size=new Size(51, 19);
            radioButton1.TabIndex=2;
            radioButton1.TabStop=true;
            radioButton1.Text="Male";
            radioButton1.UseVisualStyleBackColor=true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize=true;
            radioButton2.Location=new Point(428, 96);
            radioButton2.Name="radioButton2";
            radioButton2.Size=new Size(63, 19);
            radioButton2.TabIndex=3;
            radioButton2.TabStop=true;
            radioButton2.Text="Female";
            radioButton2.UseVisualStyleBackColor=true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize=true;
            radioButton3.Location=new Point(430, 196);
            radioButton3.Name="radioButton3";
            radioButton3.Size=new Size(40, 19);
            radioButton3.TabIndex=4;
            radioButton3.TabStop=true;
            radioButton3.Text="C#";
            radioButton3.UseVisualStyleBackColor=true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize=true;
            radioButton4.Location=new Point(432, 230);
            radioButton4.Name="radioButton4";
            radioButton4.Size=new Size(46, 19);
            radioButton4.TabIndex=5;
            radioButton4.TabStop=true;
            radioButton4.Text="ASP";
            radioButton4.UseVisualStyleBackColor=true;
            // 
            // button1
            // 
            button1.Location=new Point(432, 382);
            button1.Name="button1";
            button1.Size=new Size(75, 23);
            button1.TabIndex=6;
            button1.Text="Submit";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Name="Form1";
            Text="Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListBox listBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button1;
    }
}