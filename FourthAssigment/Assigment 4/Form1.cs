namespace Assigment_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            int sum = 1;
            for(int i = number; i > 0; i--)
            {
                sum = sum * i;   
            }
            label1.Text = sum.ToString();
        }
    }
}
