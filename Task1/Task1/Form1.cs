namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "Ace of Diamonds";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Text = "2 of Diamonds";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "6 of Spades";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label1.Text = "3 of Clubs";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label1.Text = "8 of Hearts";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
