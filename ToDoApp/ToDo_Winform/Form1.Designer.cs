namespace ToDo_Winform
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
            tabControl1=new TabControl();
            Shopping=new TabPage();
            label3=new Label();
            panel1=new Panel();
            checkBox1=new CheckBox();
            button1=new Button();
            label2=new Label();
            domainUpDown1=new DomainUpDown();
            label1=new Label();
            textBox1=new TextBox();
            tabPage2=new TabPage();
            tabPage1=new TabPage();
            button2=new Button();
            tabControl1.SuspendLayout();
            Shopping.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Shopping);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock=DockStyle.Fill;
            tabControl1.Location=new Point(0, 0);
            tabControl1.Name="tabControl1";
            tabControl1.SelectedIndex=0;
            tabControl1.Size=new Size(800, 450);
            tabControl1.TabIndex=0;
            // 
            // Shopping
            // 
            Shopping.Controls.Add(label3);
            Shopping.Controls.Add(panel1);
            Shopping.Controls.Add(button1);
            Shopping.Controls.Add(label2);
            Shopping.Controls.Add(domainUpDown1);
            Shopping.Controls.Add(label1);
            Shopping.Controls.Add(textBox1);
            Shopping.Location=new Point(4, 29);
            Shopping.Name="Shopping";
            Shopping.Padding=new Padding(3);
            Shopping.Size=new Size(792, 417);
            Shopping.TabIndex=0;
            Shopping.Text="Shopping";
            Shopping.UseVisualStyleBackColor=true;
            Shopping.Click+=Shopping_Click;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(512, 28);
            label3.Name="label3";
            label3.Size=new Size(53, 20);
            label3.TabIndex=0;
            label3.Text="TO DO";
            label3.Click+=label3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(checkBox1);
            panel1.Location=new Point(393, 60);
            panel1.Name="panel1";
            panel1.Size=new Size(320, 306);
            panel1.TabIndex=6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize=true;
            checkBox1.Location=new Point(29, 44);
            checkBox1.Name="checkBox1";
            checkBox1.Size=new Size(101, 24);
            checkBox1.TabIndex=7;
            checkBox1.Text="checkBox1";
            checkBox1.UseVisualStyleBackColor=true;
            // 
            // button1
            // 
            button1.Location=new Point(44, 197);
            button1.Name="button1";
            button1.Size=new Size(94, 29);
            button1.TabIndex=4;
            button1.Text="Add";
            button1.UseVisualStyleBackColor=true;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(44, 108);
            label2.Name="label2";
            label2.Size=new Size(65, 20);
            label2.TabIndex=3;
            label2.Text="Quantity";
            label2.Click+=label2_Click;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location=new Point(44, 141);
            domainUpDown1.Name="domainUpDown1";
            domainUpDown1.Size=new Size(150, 27);
            domainUpDown1.TabIndex=2;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(44, 28);
            label1.Name="label1";
            label1.Size=new Size(107, 20);
            label1.TabIndex=1;
            label1.Text="Shopping item";
            label1.Click+=label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location=new Point(44, 60);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(125, 27);
            textBox1.TabIndex=0;
            // 
            // tabPage2
            // 
            tabPage2.Location=new Point(4, 29);
            tabPage2.Name="tabPage2";
            tabPage2.Padding=new Padding(3);
            tabPage2.Size=new Size(792, 417);
            tabPage2.TabIndex=1;
            tabPage2.Text="Work";
            tabPage2.UseVisualStyleBackColor=true;
            // 
            // tabPage1
            // 
            tabPage1.Location=new Point(4, 29);
            tabPage1.Name="tabPage1";
            tabPage1.Size=new Size(792, 417);
            tabPage1.TabIndex=2;
            tabPage1.Text="Personal";
            tabPage1.UseVisualStyleBackColor=true;
            // 
            // button2
            // 
            button2.Location=new Point(136, 41);
            button2.Name="button2";
            button2.Size=new Size(27, 29);
            button2.TabIndex=8;
            button2.Text="X";
            button2.UseVisualStyleBackColor=true;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(tabControl1);
            Name="Form1";
            Text="Form1";
            tabControl1.ResumeLayout(false);
            Shopping.ResumeLayout(false);
            Shopping.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Shopping;
        private TabPage tabPage2;
        private TextBox textBox1;
        private TabPage tabPage1;
        private Label label1;
        private Label label2;
        private DomainUpDown domainUpDown1;
        private Button button1;
        private Label label3;
        private Panel panel1;
        private CheckBox checkBox1;
        private Button button2;
    }
}