namespace PictureViewer
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
            tableLayoutPanel1=new TableLayoutPanel();
            pictureBox1=new PictureBox();
            flowLayoutPanel1=new FlowLayoutPanel();
            ShowBtn=new Button();
            ClearBtn=new Button();
            BackgroundBtn=new Button();
            CloseBtn=new Button();
            checkBox1=new CheckBox();
            openFileDialog1=new OpenFileDialog();
            colorDialog1=new ColorDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount=2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 1);
            tableLayoutPanel1.Dock=DockStyle.Fill;
            tableLayoutPanel1.Location=new Point(0, 0);
            tableLayoutPanel1.Name="tableLayoutPanel1";
            tableLayoutPanel1.RowCount=2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size=new Size(774, 433);
            tableLayoutPanel1.TabIndex=0;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle=BorderStyle.Fixed3D;
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 2);
            pictureBox1.Dock=DockStyle.Fill;
            pictureBox1.Location=new Point(3, 3);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(768, 383);
            pictureBox1.TabIndex=0;
            pictureBox1.TabStop=false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(ShowBtn);
            flowLayoutPanel1.Controls.Add(ClearBtn);
            flowLayoutPanel1.Controls.Add(BackgroundBtn);
            flowLayoutPanel1.Controls.Add(CloseBtn);
            flowLayoutPanel1.Dock=DockStyle.Fill;
            flowLayoutPanel1.FlowDirection=FlowDirection.RightToLeft;
            flowLayoutPanel1.Location=new Point(119, 392);
            flowLayoutPanel1.Name="flowLayoutPanel1";
            flowLayoutPanel1.Size=new Size(652, 38);
            flowLayoutPanel1.TabIndex=2;
            // 
            // ShowBtn
            // 
            ShowBtn.AutoSize=true;
            ShowBtn.Location=new Point(554, 3);
            ShowBtn.Name="ShowBtn";
            ShowBtn.Size=new Size(95, 25);
            ShowBtn.TabIndex=0;
            ShowBtn.Text="Show a picture";
            ShowBtn.UseVisualStyleBackColor=true;
            ShowBtn.Click+=ShowBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.AutoSize=true;
            ClearBtn.Location=new Point(441, 3);
            ClearBtn.Name="ClearBtn";
            ClearBtn.Size=new Size(107, 25);
            ClearBtn.TabIndex=1;
            ClearBtn.Text="Clear the picture ";
            ClearBtn.UseVisualStyleBackColor=true;
            ClearBtn.Click+=ClearBtn_Click;
            // 
            // BackgroundBtn
            // 
            BackgroundBtn.AutoSize=true;
            BackgroundBtn.Location=new Point(285, 3);
            BackgroundBtn.Name="BackgroundBtn";
            BackgroundBtn.Size=new Size(150, 25);
            BackgroundBtn.TabIndex=2;
            BackgroundBtn.Text="Set the background color";
            BackgroundBtn.UseVisualStyleBackColor=true;
            BackgroundBtn.Click+=BackgroundBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.AutoSize=true;
            CloseBtn.Location=new Point(204, 3);
            CloseBtn.Name="CloseBtn";
            CloseBtn.Size=new Size(75, 25);
            CloseBtn.TabIndex=3;
            CloseBtn.Text="Close";
            CloseBtn.UseVisualStyleBackColor=true;
            CloseBtn.Click+=CloseBtn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize=true;
            checkBox1.CheckAlign=ContentAlignment.MiddleCenter;
            checkBox1.Dock=DockStyle.Fill;
            checkBox1.Location=new Point(3, 392);
            checkBox1.Name="checkBox1";
            checkBox1.Size=new Size(110, 38);
            checkBox1.TabIndex=1;
            checkBox1.Text="Stretch";
            checkBox1.UseVisualStyleBackColor=true;
            checkBox1.CheckedChanged+=checkBox1_CheckedChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName="openFileDialog1";
            openFileDialog1.Filter="JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog1.Title="Select a picture";
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(774, 433);
            Controls.Add(tableLayoutPanel1);
            Name="Form1";
            Text="Picture Viewer";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button ShowBtn;
        private Button ClearBtn;
        private Button BackgroundBtn;
        private Button CloseBtn;
        private OpenFileDialog openFileDialog1;
        private ColorDialog colorDialog1;
    }
}