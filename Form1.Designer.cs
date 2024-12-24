namespace ShoppingCart
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
            tbCoffeePrice = new TextBox();
            chbCoffee = new CheckBox();
            chbGreenTea = new CheckBox();
            tbGreenTeaPrice = new TextBox();
            tbTotal = new TextBox();
            label1 = new Label();
            button1 = new Button();
            tbCoffeeQuantity = new TextBox();
            tbGreenTeaQuantity = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            label9 = new Label();
            textBox8 = new TextBox();
            label10 = new Label();
            textBox9 = new TextBox();
            label11 = new Label();
            textBox10 = new TextBox();
            button2 = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbCoffeePrice
            // 
            tbCoffeePrice.Location = new Point(157, 21);
            tbCoffeePrice.Margin = new Padding(3, 2, 3, 2);
            tbCoffeePrice.Name = "tbCoffeePrice";
            tbCoffeePrice.Size = new Size(110, 23);
            tbCoffeePrice.TabIndex = 0;
            // 
            // chbCoffee
            // 
            chbCoffee.AutoSize = true;
            chbCoffee.Location = new Point(25, 22);
            chbCoffee.Margin = new Padding(3, 2, 3, 2);
            chbCoffee.Name = "chbCoffee";
            chbCoffee.Size = new Size(61, 19);
            chbCoffee.TabIndex = 1;
            chbCoffee.Text = "Coffee";
            chbCoffee.UseVisualStyleBackColor = true;
            // 
            // chbGreenTea
            // 
            chbGreenTea.AutoSize = true;
            chbGreenTea.Location = new Point(25, 47);
            chbGreenTea.Margin = new Padding(3, 2, 3, 2);
            chbGreenTea.Name = "chbGreenTea";
            chbGreenTea.Size = new Size(77, 19);
            chbGreenTea.TabIndex = 2;
            chbGreenTea.Text = "Green Tea";
            chbGreenTea.UseVisualStyleBackColor = true;
            // 
            // tbGreenTeaPrice
            // 
            tbGreenTeaPrice.Location = new Point(157, 46);
            tbGreenTeaPrice.Margin = new Padding(3, 2, 3, 2);
            tbGreenTeaPrice.Name = "tbGreenTeaPrice";
            tbGreenTeaPrice.Size = new Size(110, 23);
            tbGreenTeaPrice.TabIndex = 3;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(502, 20);
            tbTotal.Margin = new Padding(3, 2, 3, 2);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(110, 23);
            tbTotal.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(436, 22);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 5;
            label1.Text = "Total";
            // 
            // button1
            // 
            button1.Location = new Point(157, 320);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(241, 47);
            button1.TabIndex = 6;
            button1.Text = "Check out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonCheckout_Click;
            // 
            // tbCoffeeQuantity
            // 
            tbCoffeeQuantity.Location = new Point(288, 21);
            tbCoffeeQuantity.Margin = new Padding(3, 2, 3, 2);
            tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            tbCoffeeQuantity.Size = new Size(110, 23);
            tbCoffeeQuantity.TabIndex = 7;
            // 
            // tbGreenTeaQuantity
            // 
            tbGreenTeaQuantity.Location = new Point(288, 45);
            tbGreenTeaQuantity.Margin = new Padding(3, 2, 3, 2);
            tbGreenTeaQuantity.Name = "tbGreenTeaQuantity";
            tbGreenTeaQuantity.Size = new Size(110, 23);
            tbGreenTeaQuantity.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(436, 47);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 10;
            label2.Text = "Cash";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(502, 45);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 24);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 12;
            label3.Text = "Change";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(85, 21);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 51);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 14;
            label4.Text = "1000";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(85, 48);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 75);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 16;
            label5.Text = "500";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(85, 73);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 23);
            textBox4.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 100);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 18;
            label6.Text = "100";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(85, 98);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(110, 23);
            textBox5.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 125);
            label7.Name = "label7";
            label7.Size = new Size(19, 15);
            label7.TabIndex = 20;
            label7.Text = "50";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(85, 123);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(110, 23);
            textBox6.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 149);
            label8.Name = "label8";
            label8.Size = new Size(19, 15);
            label8.TabIndex = 22;
            label8.Text = "20";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(85, 147);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(110, 23);
            textBox7.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 174);
            label9.Name = "label9";
            label9.Size = new Size(19, 15);
            label9.TabIndex = 24;
            label9.Text = "10";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(85, 172);
            textBox8.Margin = new Padding(3, 2, 3, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(110, 23);
            textBox8.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 199);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 26;
            label10.Text = "5";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(85, 197);
            textBox9.Margin = new Padding(3, 2, 3, 2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(110, 23);
            textBox9.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 224);
            label11.Name = "label11";
            label11.Size = new Size(13, 15);
            label11.TabIndex = 28;
            label11.Text = "1";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(85, 221);
            textBox10.Margin = new Padding(3, 2, 3, 2);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(110, 23);
            textBox10.TabIndex = 27;
            // 
            // button2
            // 
            button2.Location = new Point(502, 72);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(110, 36);
            button2.TabIndex = 29;
            button2.Text = "Change details";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox10);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Location = new Point(417, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(214, 263);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Change";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 396);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(tbGreenTeaQuantity);
            Controls.Add(tbCoffeeQuantity);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(tbTotal);
            Controls.Add(tbGreenTeaPrice);
            Controls.Add(chbGreenTea);
            Controls.Add(chbCoffee);
            Controls.Add(tbCoffeePrice);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "POS";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbCoffeePrice;
        private CheckBox chbCoffee;
        private CheckBox chbGreenTea;
        private TextBox tbGreenTeaPrice;
        private TextBox tbTotal;
        private Label label1;
        private Button button1;
        private TextBox tbCoffeeQuantity;
        private TextBox tbGreenTeaQuantity;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private Label label9;
        private TextBox textBox8;
        private Label label10;
        private TextBox textBox9;
        private Label label11;
        private TextBox textBox10;
        private Button button2;
        private GroupBox groupBox1;
    }
}
