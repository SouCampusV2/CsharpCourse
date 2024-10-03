namespace Assigment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1 != null && textBox2 != null)
            {
                float weight = float.Parse(textBox1.Text);
                float height = float.Parse(textBox2.Text);

                float bmi = weight / (height * height) * 703;

                label3.Text = $"BMI: {bmi}";
                if (bmi > 0 && bmi < 18.25)
                {
                    label4.Text = "Status: Underweight";
                }
                else if(bmi > 18.25 && bmi <25)
                {
                    label4.Text = "Status: Normal";
                }
                else if (bmi > 25)
                {
                    label4.Text = "Status: Overweight";
                }
                else
                {
                    label4.Text = "Status: wrong";
                }
            }
        }
    }
}
