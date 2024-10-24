namespace SixthAssigment
{
    public partial class Form1 : Form
    {
        private string[] options = { "Stone", "Sciccors", "Paper" };
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void WhoIsWinner(string userChoice, string computerChoice)
        {
            if(userChoice == "Stone" && computerChoice == "Sciccors") 
            {
                label3.Text = "You win!";
            }
            else if(userChoice == "Paper" && computerChoice == "Stone")
            {
                label3.Text = "You win!";
            }
            else if (userChoice == "Sciccors" && computerChoice == "Paper")
            {
                label3.Text = "You win!";
            }
            else if (userChoice == computerChoice)
            {
                label3.Text = "Draw";
            }
            else
            {
                label3.Text = "You lose!";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string userChoice = "Paper";
            int index = random.Next(0, options.Length);
            string computerChoice = options[index];
            label1.Text = "Computer: " + computerChoice;
            label2.Text = "Your choice: " + userChoice;
            WhoIsWinner(userChoice, computerChoice);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userChoice = "Stone";
            int index = random.Next(0, options.Length);
            string computerChoice = options[index];
            label1.Text = "Computer: " + computerChoice;
            label2.Text = "Your choice: " + userChoice;
            WhoIsWinner(userChoice, computerChoice);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string userChoice = "Sciccors";
            int index = random.Next(0, options.Length);
            string computerChoice = options[index];
            label1.Text = "Computer: " + computerChoice;
            label2.Text = "Your choice: " + userChoice;
            WhoIsWinner(userChoice, computerChoice);
        }
    }
}
