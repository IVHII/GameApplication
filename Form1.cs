namespace FirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillCbxGuess(10);
        }

        private void FillCbxGuess(int max)
        {
            for ( int i = 0; i < max; i++)
                CbxGuess.Items.Add(i.ToString());
        }

        public int GenerateNumber(int max)
        {
            Random rnd = new Random();
            return rnd.Next(max);
        }

        InputBoxValidation validateNum = delegate (string val, int? min, int? max)

        {

            string response = "";
            if (val == "")
                return "Value cannot be empty.";
            response = CheckInt(val, min, max);
            if (response != "")
                return response;
            return "";

        };



       private static string CheckInt(string val, int? min, int? max)
        {
            if (val == "")
                return "Value cannot be empty.";
            if (!int.TryParse(val, out int result))
                return "Error, Not a number";
            if (result < min)
                return $"Error, input is too small, it must be greater than {min} value";
            if (val.Length < min)
                return $"Error, input is too big, it must less than {max} value";
            return "";
}



        public int GetInt(string prompt, int max, int min = 0)
        {
            string temp = "";
            int value = 0;
            temp = InputBox.Show(prompt, $"Enter {prompt} between {min} and {max}", validateNum, 0, max);
            value = int.Parse(temp);
            return value;
        }

        private string CheckGuess(int answer, int guess)
        {
            if (guess == answer)
                return "Congratulations you guessed correctly";
            if (guess > answer)
                return "Error you guessed too high";
            if (guess < answer)
                return "Error you guessed too low";
            if (guess != answer)
                return "Error you guessed incorrectly";
            return "";
        }
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            string firstName; //a
            string lastName;
            string fullName;
            string response;

            firstName = TbxFirstName.Text;
            lastName = TbxLastName.Text;
            fullName = firstName + " " + lastName;
            int temp = int.Parse(TbxTemp.Text);

            response = "Hi " + fullName;
            response += CheckTemp(temp, 15, 25);
            MessageBox.Show(response, "Greetings from the World");
        }
        public string CheckTemp(int temp, int min, int max)
        {
            string response = "it's ";
            if (temp < min)
                response += "Too cold";
            else if (temp > max)
                response += "Too Hot";
            else
                response += "Okay";
            return response;
        }

        private void BtnGradeBasedOnMark_Click(object sender, EventArgs e)
        {
            string firstName; //a
            string lastName;
            string fullName;
            int mark;
            string response;
            string grade;

            firstName = TbxFirstName.Text;
            lastName = TbxLastName.Text;
            fullName = firstName + " " + lastName;
            mark = int.Parse(TbxMark.Text);

            
            response = "Hi " + fullName;
            response += CalculateGrade(mark);
            MessageBox.Show(response, "Greetings from the World");
        }
        public string CalculateGrade(int mark)
        {
            string response = " you got a ";
            if (mark >= 80)
                response += "Distinction";
            else if (mark >= 70 )
                response += "Merit";
            else if (mark >= 60 )
                response += "Pass";
            else
                response += "Fail";
            return response;
        }

        private void BtnPlayGuessingGame_Click(object sender, EventArgs e)
        {
            int answer = 0;
            string temp = "";
            int guess = 0;


            answer = GenerateNumber(10); 
            temp = CbxGuess.Text;
            guess = int.Parse(temp);
            string feedback = CheckGuess(answer, guess);
            MessageBox.Show(feedback, "Guessing Game Feedback");

        }

        private void BtnGuessingGame_P_Click(object sender, EventArgs e)
        {
            const int max = 10; 
            int attempt = 0;
            bool valid = false;
            string feedback = "";
            int guess = 0;
            int answer = GenerateNumber(max);
            do
            {
                attempt = attempt + 1;
                guess = GetInt("Guess", max);
                feedback = CheckGuess(answer, guess);
                MessageBox.Show(feedback, $"Guessing Game Feedback on attempt {attempt}");
            } while ((attempt < 3) && (feedback.StartsWith("Error")));
            if (feedback.StartsWith ("Error"))
                MessageBox.Show("You have had 3 attempts. Better look next time");
           


        }
    }
    }

