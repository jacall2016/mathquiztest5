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
            components=new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timeLabel=new Label();
            label1=new Label();
            plusLeftLabel=new Label();
            label2=new Label();
            plusRightLabel=new Label();
            label4=new Label();
            sum=new NumericUpDown();
            label5=new Label();
            label6=new Label();
            label7=new Label();
            label8=new Label();
            label9=new Label();
            label10=new Label();
            difference=new NumericUpDown();
            minusRightLabel=new Label();
            minusLeftLabel=new Label();
            product=new NumericUpDown();
            timesRightLabel=new Label();
            timesLeftLabel=new Label();
            quotient=new NumericUpDown();
            dividedRightLabel=new Label();
            dividedLeftLabel=new Label();
            label3=new Label();
            timer1=new System.Windows.Forms.Timer(components);
            timer2=new System.Windows.Forms.Timer(components);
            startButton=new Button();
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle=BorderStyle.FixedSingle;
            timeLabel.Font=new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location=new Point(270, 9);
            timeLabel.Name="timeLabel";
            timeLabel.Size=new Size(200, 30);
            timeLabel.TabIndex=0;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(138, 2);
            label1.Name="label1";
            label1.Size=new Size(126, 37);
            label1.TabIndex=1;
            label1.Text="Time Left";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            plusLeftLabel.Location=new Point(42, 55);
            plusLeftLabel.Name="plusLeftLabel";
            plusLeftLabel.Size=new Size(60, 50);
            plusLeftLabel.TabIndex=2;
            plusLeftLabel.Text="?";
            plusLeftLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(108, 55);
            label2.Name="label2";
            label2.Size=new Size(60, 50);
            label2.TabIndex=3;
            label2.Text="+";
            label2.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            plusRightLabel.Location=new Point(174, 55);
            plusRightLabel.Name="plusRightLabel";
            plusRightLabel.Size=new Size(60, 50);
            plusRightLabel.TabIndex=4;
            plusRightLabel.Text="?";
            plusRightLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location=new Point(240, 55);
            label4.Name="label4";
            label4.Size=new Size(60, 50);
            label4.TabIndex=5;
            label4.Text="=";
            label4.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            sum.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            sum.Location=new Point(330, 55);
            sum.Name="sum";
            sum.Size=new Size(100, 47);
            sum.TabIndex=1;
            // 
            // label5
            // 
            label5.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location=new Point(240, 105);
            label5.Name="label5";
            label5.Size=new Size(60, 50);
            label5.TabIndex=8;
            label5.Text="=";
            label5.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location=new Point(108, 105);
            label6.Name="label6";
            label6.Size=new Size(60, 50);
            label6.TabIndex=7;
            label6.Text="-";
            label6.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location=new Point(240, 158);
            label7.Name="label7";
            label7.Size=new Size(60, 50);
            label7.TabIndex=10;
            label7.Text="=";
            label7.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location=new Point(108, 158);
            label8.Name="label8";
            label8.Size=new Size(60, 50);
            label8.TabIndex=9;
            label8.Text="×";
            label8.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location=new Point(240, 211);
            label9.Name="label9";
            label9.Size=new Size(60, 50);
            label9.TabIndex=12;
            label9.Text="=";
            label9.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location=new Point(108, 211);
            label10.Name="label10";
            label10.Size=new Size(60, 50);
            label10.TabIndex=11;
            label10.Text="÷";
            label10.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // difference
            // 
            difference.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            difference.Location=new Point(330, 108);
            difference.Name="difference";
            difference.Size=new Size(100, 47);
            difference.TabIndex=2;
            // 
            // minusRightLabel
            // 
            minusRightLabel.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            minusRightLabel.Location=new Point(174, 108);
            minusRightLabel.Name="minusRightLabel";
            minusRightLabel.Size=new Size(60, 50);
            minusRightLabel.TabIndex=14;
            minusRightLabel.Text="?";
            minusRightLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            minusLeftLabel.Location=new Point(42, 108);
            minusLeftLabel.Name="minusLeftLabel";
            minusLeftLabel.Size=new Size(60, 50);
            minusLeftLabel.TabIndex=13;
            minusLeftLabel.Text="?";
            minusLeftLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            product.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            product.Location=new Point(330, 161);
            product.Name="product";
            product.Size=new Size(100, 47);
            product.TabIndex=3;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            timesRightLabel.Location=new Point(174, 161);
            timesRightLabel.Name="timesRightLabel";
            timesRightLabel.Size=new Size(60, 50);
            timesRightLabel.TabIndex=17;
            timesRightLabel.Text="?";
            timesRightLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            timesLeftLabel.Location=new Point(42, 161);
            timesLeftLabel.Name="timesLeftLabel";
            timesLeftLabel.Size=new Size(60, 50);
            timesLeftLabel.TabIndex=16;
            timesLeftLabel.Text="?";
            timesLeftLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            quotient.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            quotient.Location=new Point(330, 214);
            quotient.Name="quotient";
            quotient.Size=new Size(100, 47);
            quotient.TabIndex=4;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dividedRightLabel.Location=new Point(174, 214);
            dividedRightLabel.Name="dividedRightLabel";
            dividedRightLabel.Size=new Size(60, 50);
            dividedRightLabel.TabIndex=20;
            dividedRightLabel.Text="?";
            dividedRightLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dividedLeftLabel.Location=new Point(42, 214);
            dividedLeftLabel.Name="dividedLeftLabel";
            dividedLeftLabel.Size=new Size(60, 50);
            dividedLeftLabel.TabIndex=19;
            dividedLeftLabel.Text="?";
            dividedLeftLabel.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(62, 302);
            label3.Name="label3";
            label3.Size=new Size(39, 20);
            label3.TabIndex=22;
            label3.Text="date";
            // 
            // timer1
            // 
            timer1.Tick+=timer1_Tick;
            // 
            // startButton
            // 
            startButton.AutoSize=true;
            startButton.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.Location=new Point(283, 283);
            startButton.Name="startButton";
            startButton.Size=new Size(166, 42);
            startButton.TabIndex=0;
            startButton.Text="Start the quiz";
            startButton.UseVisualStyleBackColor=true;
            startButton.Click+=startButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(482, 353);
            Controls.Add(startButton);
            Controls.Add(label3);
            Controls.Add(quotient);
            Controls.Add(dividedRightLabel);
            Controls.Add(dividedLeftLabel);
            Controls.Add(product);
            Controls.Add(timesRightLabel);
            Controls.Add(timesLeftLabel);
            Controls.Add(difference);
            Controls.Add(minusRightLabel);
            Controls.Add(minusLeftLabel);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(sum);
            Controls.Add(label4);
            Controls.Add(plusRightLabel);
            Controls.Add(label2);
            Controls.Add(plusLeftLabel);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            FormBorderStyle=FormBorderStyle.Fixed3D;
            Icon=(Icon)resources.GetObject("$this.Icon");
            Name="Form1";
            StartPosition=FormStartPosition.CenterParent;
            Text="James Call + Math Quiz";
            Load+=Form1_Load;
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
        private Label label4;
        private NumericUpDown sum;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private NumericUpDown difference;
        private Label minusRightLabel;
        private Label minusLeftLabel;
        private NumericUpDown product;
        private Label timesRightLabel;
        private Label timesLeftLabel;
        private NumericUpDown quotient;
        private Label dividedRightLabel;
        private Label dividedLeftLabel;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Button startButton;
    }
}