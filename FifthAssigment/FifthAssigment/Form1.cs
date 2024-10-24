namespace FifthAssigment
{
    public partial class Form1 : Form
    {
        private int randomNumber;
        private int guessCount;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            randomNumber = rand.Next(1, 101);

            if (textBox1.Text != null)
            {
                try
                {
                    int number = int.Parse(textBox1.Text);
                    if (number == randomNumber)
                    {
                        label1.Text = "Wow you guess the number, congratulation!";                                               
                    }
                    else if(number < randomNumber)
                    {
                        label1.Text = "Number was higher than your!";
                    }
                    else if (number > randomNumber)
                    {
                        label1.Text = "Number was less than your!";
                    }
                    guessCount++;
                    label3.Text = "Count: " + guessCount;
                }
                catch
                {
                    label1.Text = "Try to write number!";
                }
            }
        }
    }
}
