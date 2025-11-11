namespace MathContest
{
    public partial class MathContest : Form
    {
        public MathContest()
        {
            InitializeComponent();
            SetDefaults();
        }

        List<bool> TotalAnswers = new List<bool>();

        void SetDefaults() 
        {
            TotalAnswers.Clear();
            NameTextBox.Text = "";
            AgeTextBox.Text = "";
            GradeTextBox.Text = "";
            OneNumTextBox.Text = "";
            TwoNumTextBox.Text = "";
            AnswerTextBox.Text = "";

            AddButton.Checked = true;
            AddButton.Enabled = false;
            SubtractButton.Enabled = false;
            MultiplyButton.Enabled = false;
            DivideButton.Enabled = false;
            
            SubmitButton.Enabled = false;
            SummaryButton.Enabled = false;
        }

        void ValidateInputs() 
        {
            
        }

        void Summary() 
        { 
            
        }

        void CheckNumbers() 
        { 
            
        }

        //Event Handlers------------------------------------------------------------------------------------------
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            CheckNumbers();
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
    }
}
