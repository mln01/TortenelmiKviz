namespace TortenelmiKviz
{
    public partial class ABuvosHetesSzam : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex;
        private int score;
        private bool quizFinished;
        private Form Kakukk;

        public ABuvosHetesSzam(Form Kakukk)
        {
            InitializeComponent();
            InitializeQuiz();
            this.Kakukk = Kakukk;
        }

        private void ABuvosHetesSzam_Load(object sender, EventArgs e)
        {

        }

        private void InitializeQuiz()
        {
            questions = new List<Question>
            {
                new Question(new List<string> { "a wittenbergi herceg", "a vajnai palotagróf", "a hannoveri fejedelem", "a brandenburgi őrgróf", "a cseh király", "a kölni érsek", "a trieri érsek" }, "a hannoveri fejedelem" ),
                new Question(new List<string> { "a grammatika", "a dialektika", "a retorika", "a geometria", "az eritmetika", "a dogmatika", "az asztronómia" }, "a dogmatika" ),
                new Question(new List<string> { "Pheidias olympiai Zeus-szobra", "Semiramis függőkertje", "a rhodosi kolosszus", "a Mausszoleion", "az alexandriai Phárosz világítótornya", "az epheszoszi Artemis-templom", "Antipartos epigrammája" }, "az alexandriai Phárosz világítótornya" ),
                new Question(new List<string> { "a gyermek körülmetélése", "az egyiptomi menekülés", "a gyermek elmaradása a templomban", "a kereszthozó Jézussal való találkozás", "a halál szemlélete", "a keresztről való levétel", "a mennybemenetel" }, "a mennybemenetel" ),
                new Question(new List<string> { "Árpád", "Szabolcs", "Kurszán", "Ete", "Örs", "Lél", "Tétény" }, "Örs" ),
                new Question(new List<string> { "Nyék", "Megyer", "Kürtgyarmat", "Tarján", "Jász", "Keszi", "Jenő" }, "Jász" ),
                new Question(new List<string> { "Bácsfalu", "Türkös", "Csernátfalu", "Hosszúfalu", "Tatrang", "Zajzon", "Tamásfalva" }, "Tamásfalva" )
            };

            progressBar1.Value = 0;
            progressBar1.Maximum = questions.Count;
            currentQuestionIndex = 0;
            score = 0;
            quizFinished = false;

            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                Question currentQuestion = questions[currentQuestionIndex];

                choiceRadioButton1.Text = currentQuestion.Choices[0];
                choiceRadioButton2.Text = currentQuestion.Choices[1];
                choiceRadioButton3.Text = currentQuestion.Choices[2];
                choiceRadioButton4.Text = currentQuestion.Choices[3];
                choiceRadioButton5.Text = currentQuestion.Choices[4];
                choiceRadioButton6.Text = currentQuestion.Choices[5];
                choiceRadioButton7.Text = currentQuestion.Choices[6];

                choicesGroupBox.Controls.OfType<RadioButton>().ToList().ForEach(radioButton => radioButton.Checked = false);

                choicesGroupBox.Visible = true;
                nextButton.Visible = true;
                scoreLabel.Visible = false;
                retryButton.Visible = false;
                progressBar1.Value = currentQuestionIndex + 1;
            }
            else
            {
                quizFinished = true;
                choicesGroupBox.Visible = false;
                nextButton.Visible = false;
                scoreLabel.Visible = true;
                retryButton.Visible = true;

                scoreLabel.Text = $"A pontszámod: {score}/{questions.Count}";
            }
        }


        public class Question
        {
            public List<string> Choices { get; }
            public string CorrectAnswer { get; }

            public Question(List<string> choices, string correctAnswer)
            {
                Choices = choices;
                CorrectAnswer = correctAnswer;
            }
        }

        private void nextButton_Click_1(object sender, EventArgs e)
        {
            // Check the selected answer
            if (choicesGroupBox.Controls.OfType<RadioButton>().Any(radioButton => radioButton.Checked))
            {
                Question currentQuestion = questions[currentQuestionIndex];
                RadioButton selectedRadioButton = choicesGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(radioButton => radioButton.Checked);
                string selectedAnswer = selectedRadioButton.Text;

                if (selectedAnswer == currentQuestion.CorrectAnswer)
                {
                    score++;
                }

                currentQuestionIndex++;
                DisplayQuestion();
            }
            else
            {
                MessageBox.Show("Légyszíves jelölj be egy választ mielőtt a következőre mész.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void retryButton_Click_1(object sender, EventArgs e)
        {
            InitializeQuiz();
        }

        private void Vissza_Click(object sender, EventArgs e)
        {
            Kakukk.Enabled = true;
            this.Close();
        }
    }
}
