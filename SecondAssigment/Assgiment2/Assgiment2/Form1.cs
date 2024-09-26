namespace Assgiment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double aPrice = 15.00;
            double bPrice = 12.0;
            double cPrice = 9.0;

            double revenueA = aPrice * double.Parse(textBox1.Text);
            double revenueB = bPrice * double.Parse(textBox2.Text);
            double revenueC = cPrice * double.Parse(textBox3.Text);

            Console.WriteLine(revenueA);

            label9.Text = revenueA.ToString("F2") + " euro";
            label10.Text = revenueB.ToString("F2") + " euro";
            label11.Text = revenueC.ToString("F2") + " euro";

            label12.Text = (revenueA + revenueB + revenueC).ToString("F2") + " euro";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = "0.00 euro";
            label10.Text = "0.00 euro";
            label11.Text = "0.00 euro";
            label12.Text = "0.00 euro";

            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
