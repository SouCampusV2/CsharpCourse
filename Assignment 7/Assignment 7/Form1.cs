namespace Assignment_7
{
    public partial class Form1 : Form
    {
        private readonly char[] correctAnswers = {
            'B', 'D', 'A', 'A', 'C', 'A', 'B', 'A', 'C', 'D',
            'B', 'C', 'D', 'A', 'D', 'C', 'C', 'B', 'D', 'A'
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\super\\OneDrive\\Рабочий стол\\C#\\Assignment 7\\Assignment 7\\studentsAnswers.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("The file does not exist, please paste file with name studentsAnswers.txt");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length != 20)
            {
                MessageBox.Show("Less or more answers");
                return;
            }

            char[] chars = new char[lines.Length];

            for(int i = 0; i < 20; i++)
            {
                chars[i] = lines[i].Trim().ToUpper()[0];
            }
            int correctCount = 0;
            List<int> incorrectAnswers = new List<int>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (chars[i] == correctAnswers[i])
                {
                    correctCount++;
                }
                else
                {
                    incorrectAnswers.Add(i+1);
                }
            }
            int incorrectCount = 20 - correctCount;
            bool passed = correctCount >= 15;

            if (passed == true)
                label5.Text = "Passed";
            else
                label5.Text = "Failed";

            label1.Text = "Correct answers: " + correctCount;
            label3.Text = "Incorrect answers: " + incorrectCount;
            incorrectNumbers.Items.Clear();
            foreach (int question in incorrectAnswers)
            {
                incorrectNumbers.Items.Add($"Question {question}");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
