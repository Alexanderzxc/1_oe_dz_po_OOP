namespace pervoe_zadanie
{
    public partial class Form1 : Form
    {
        MyFloat float_1;
        MyFloat float_2;
        MyFloat float_3;
        MyFloat float_4;
        MyFloat float_5;
        public Form1()
        {
            InitializeComponent();
            Chislitel_box.Text = "25";
            Znam_box.Text = "2";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Chislitel_box_TextChanged(object sender, EventArgs e)
        {
            float_1 = new MyFloat(Convert.ToDouble(Chislitel_box.Text), Convert.ToDouble(Znam_box.Text));
        }

        private void visualize_float_Click(object sender, EventArgs e)
        {
            float_1 = new MyFloat(Convert.ToDouble(Chislitel_box.Text), Convert.ToDouble(Znam_box.Text));
            float_1.Visualize(Float_visualize);
        }

        private void button_for_sum_Click(object sender, EventArgs e)
        {
            float_2 = new MyFloat(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            label2.Text = Convert.ToString(float_1.Sum(float_2));
        }

        private void Znam_box_TextChanged(object sender, EventArgs e)
        {
            float_1 = new MyFloat(Convert.ToDouble(Chislitel_box.Text), Convert.ToDouble(Znam_box.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float_3 = new MyFloat(Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
            label5.Text = Convert.ToString(float_1.Div(float_3));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float_4 = new MyFloat(Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text));
            label7.Text = Convert.ToString(float_1.Mult(float_4));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float_5 = new MyFloat(Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox8.Text));
            label9.Text = Convert.ToString(float_1.Sub(float_5));
        }
    }
}