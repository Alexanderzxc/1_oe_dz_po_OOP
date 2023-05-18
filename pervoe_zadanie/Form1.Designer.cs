namespace pervoe_zadanie
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
            Chislitel_box = new TextBox();
            Znam_box = new TextBox();
            label1 = new Label();
            Float_visualize = new Label();
            visualize_float = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            button_for_sum = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            button2 = new Button();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label7 = new Label();
            button3 = new Button();
            label8 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // Chislitel_box
            // 
            Chislitel_box.Location = new Point(97, 56);
            Chislitel_box.Name = "Chislitel_box";
            Chislitel_box.Size = new Size(100, 23);
            Chislitel_box.TabIndex = 0;
            Chislitel_box.Text = "25";
            Chislitel_box.TextChanged += Chislitel_box_TextChanged;
            // 
            // Znam_box
            // 
            Znam_box.Location = new Point(97, 85);
            Znam_box.Name = "Znam_box";
            Znam_box.Size = new Size(100, 23);
            Znam_box.TabIndex = 1;
            Znam_box.Text = "2";
            Znam_box.TextChanged += Znam_box_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 75);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 2;
            label1.Text = "Myfloat";
            // 
            // Float_visualize
            // 
            Float_visualize.AutoSize = true;
            Float_visualize.Location = new Point(203, 75);
            Float_visualize.Name = "Float_visualize";
            Float_visualize.Size = new Size(0, 15);
            Float_visualize.TabIndex = 4;
            // 
            // visualize_float
            // 
            visualize_float.Location = new Point(25, 6);
            visualize_float.Name = "visualize_float";
            visualize_float.Size = new Size(130, 44);
            visualize_float.TabIndex = 5;
            visualize_float.Text = "Визуализировать число";
            visualize_float.UseVisualStyleBackColor = true;
            visualize_float.Click += visualize_float_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            textBox1.Text = "15";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 133);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 7;
            label3.Text = "Слагаемое";
            // 
            // button_for_sum
            // 
            button_for_sum.Location = new Point(161, 6);
            button_for_sum.Name = "button_for_sum";
            button_for_sum.Size = new Size(120, 44);
            button_for_sum.TabIndex = 8;
            button_for_sum.Text = "Сложить";
            button_for_sum.UseVisualStyleBackColor = true;
            button_for_sum.Click += button_for_sum_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(97, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            textBox2.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 133);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 191);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 11;
            label4.Text = "Частное";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(97, 172);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            textBox3.Text = "3";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(97, 201);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 13;
            textBox4.Text = "1";
            // 
            // button1
            // 
            button1.Location = new Point(287, 6);
            button1.Name = "button1";
            button1.Size = new Size(122, 44);
            button1.TabIndex = 14;
            button1.Text = "Разделить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(203, 191);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 15;
            // 
            // button2
            // 
            button2.Location = new Point(415, 6);
            button2.Name = "button2";
            button2.Size = new Size(122, 44);
            button2.TabIndex = 16;
            button2.Text = "Умножить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 248);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 17;
            label6.Text = "Множитель";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(97, 230);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 18;
            textBox5.Text = "2";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(97, 259);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 19;
            textBox6.Text = "1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(203, 248);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 20;
            // 
            // button3
            // 
            button3.Location = new Point(543, 6);
            button3.Name = "button3";
            button3.Size = new Size(119, 44);
            button3.TabIndex = 21;
            button3.Text = "Вычесть";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 307);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 22;
            label8.Text = "Вычитваемое";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(97, 288);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 23;
            textBox7.Text = "8";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(97, 317);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 24;
            textBox8.Text = "1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(203, 307);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button_for_sum);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(visualize_float);
            Controls.Add(Float_visualize);
            Controls.Add(label1);
            Controls.Add(Znam_box);
            Controls.Add(Chislitel_box);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Chislitel_box;
        private TextBox Znam_box;
        private Label label1;
        private Label Float_visualize;
        private Button visualize_float;
        private TextBox textBox1;
        private Label label3;
        private Button button_for_sum;
        private TextBox textBox2;
        private Label label2;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label label5;
        private Button button2;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label7;
        private Button button3;
        private Label label8;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label9;
    }
}