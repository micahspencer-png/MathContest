using System.Diagnostics.Eventing.Reader;

namespace MathContest
{
    //Micah Spencer
    //RCET 2265
    //Fall 2025
    //Math Contest Form Program
    //
    public partial class MathContest : Form
    {
        public MathContest()
        {
            InitializeComponent();
            SetDefaults();
        }

        int TotalAnswers = 0;
        int RightAnswers = 0;
        double firstNumber = 0.0;
        double secondNumber = 0.0;

        //Program Logic--------------------------------------------------------------------------------------------
        
        void SetDefaults() 
        {
            RightAnswers = 0;
            TotalAnswers = 0;
            NameTextBox.Text = "";
            AgeTextBox.Text = "";
            GradeTextBox.Text = "";
            OneNumTextBox.Text = "";
            TwoNumTextBox.Text = "";
            AnswerTextBox.Text = "";

            
            AddButton.Enabled = false;
            SubtractButton.Enabled = false;
            MultiplyButton.Enabled = false;
            DivideButton.Enabled = false;
            
            SubmitButton.Enabled = false;
            SummaryButton.Enabled = false;
        }

        void ValidateInputs() 
        {
            bool allFieldsAreValid = true;
            NameTextBox.BackColor = Color.White;
            AgeTextBox.BackColor = Color.White;
            GradeTextBox.BackColor = Color.White;
            int _grade = 0;
            int _age = 0;
            RightAnswers = 0;
            TotalAnswers = 0;
            
            try
            {
                _grade = int.Parse(GradeTextBox.Text);
                if (_grade <= 0 || _grade >= 6)
                {
                    allFieldsAreValid = false;
                    GradeTextBox.BackColor = Color.LightYellow;
                }
                
            }
            catch (Exception)
            {
                allFieldsAreValid = false;
                GradeTextBox.BackColor = Color.LightYellow;
                
            }

            try
            {
                _age = int.Parse(AgeTextBox.Text);
                if (_age <= 6 || _age >= 12)
                {
                    allFieldsAreValid = false;
                    AgeTextBox.BackColor = Color.LightYellow;
                }
            }
            catch (Exception)
            {
                allFieldsAreValid = false;
                AgeTextBox.BackColor = Color.LightYellow;
                
            }

            // name should not be empty
            if (NameTextBox.Text == "")
            {
                allFieldsAreValid = false;
                NameTextBox.BackColor = Color.LightYellow;
                
            }

            if (allFieldsAreValid == true)
            {
                ProgramNumbers();
            }

            SummaryButton.Enabled = false;

            SubmitButton.Enabled = allFieldsAreValid;
            AddButton.Enabled = allFieldsAreValid;
            SubtractButton.Enabled = allFieldsAreValid;
            MultiplyButton.Enabled = allFieldsAreValid;
            DivideButton.Enabled = allFieldsAreValid;
            AddButton.Checked = allFieldsAreValid;
        }

        void Summary() 
        {
            MessageBox.Show($"{NameTextBox.Text} has {RightAnswers} out of {TotalAnswers} correct");
        }

        void ProgramNumbers() 
        {
            Random random = new Random();
            firstNumber = random.Next(1,13);
            secondNumber = random.Next(1,13);
            string Num1 = $"{firstNumber}";
            string Num2 = $"{secondNumber}";
            OneNumTextBox.Text = Num1;
            TwoNumTextBox.Text = Num2; 
        }
        void CheckNumbers() 
        {
            double userAnswer = 0;
            double answer = 0;
            if (AddButton.Checked) 
            {
                answer = firstNumber + secondNumber;
            }
            else if (SubtractButton.Checked) 
            {
                answer = firstNumber - secondNumber;
            }
            else if (MultiplyButton.Checked) 
            {
                answer = secondNumber * secondNumber;
            }
            else if (DivideButton.Checked) 
            { 
                answer += firstNumber / secondNumber;
            }
            double topAnswer = answer * 1.1;
            double bottomAnswer = answer * 0.9;
            
            try
            {
                userAnswer = double.Parse(AnswerTextBox.Text);
                if (userAnswer <= topAnswer && userAnswer >= bottomAnswer)
                {
                    MessageBox.Show("Correct");
                    RightAnswers += 1;
                }
                else if (userAnswer <= bottomAnswer && userAnswer >= topAnswer) 
                {
                    MessageBox.Show("Correct");
                    RightAnswers += 1;
                }

                else
                {
                    MessageBox.Show("Incorrect");
                }

            }
            catch (Exception)
            {

            }

            
            TotalAnswers += 1;
            if (TotalAnswers > 0)
            {
                SummaryButton.Enabled = true;
            }
            
        }

        //Event Handlers------------------------------------------------------------------------------------------
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (AnswerTextBox.Text != "") 
            {
                CheckNumbers();
                ProgramNumbers();
                AnswerTextBox.Text = "";
                AnswerTextBox.Focus(); 
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            Summary();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Text_Changed(object sender, EventArgs e) 
        {
            ValidateInputs();
        }

        private void Button_Changed(object sender, EventArgs e) 
        {
            ProgramNumbers();
        }
    }
}
