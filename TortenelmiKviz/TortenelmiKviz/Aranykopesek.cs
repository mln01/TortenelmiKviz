namespace TortenelmiKviz
{
    public partial class Aranykopesek : Form
    {
        private Form Main;

        private List<Question> questions;
        private int currentQuestionIndex;
        private int score;
        private bool quizFinished;


        public Aranykopesek(Form Main)
        {
            InitializeComponent();
            InitializeQuiz();
            this.Main = Main;
        }

        private void InitializeQuiz()
        {
            questions = new List<Question>
            {
                new Question("Az arany középen vagyon a boldogság", "Horatius;Kr. e. 1. század" ),
                new Question("Jobb későn, mint soha", "Livius;Kr. e. 1. század"),
                new Question("Az igazság beszéde egyszerű", "Seneca;Kr. e. 4 k.–Kr. u. 65."),
                new Question("A pénznek nincs szaga", "Vespasianus;Kr. e. 1. század"),
                new Question("Kezdetben vala az ige, az ige vala az Istennél, és az\nIsten vala az ige", "János evangélista;Kr. idején"),
                new Question("Minden ami ismeretlen, nagszerűnek tetszik.", "Tacitus;Kr. e. 1. század"),
                new Question("Gyakorlat növeli a merészséget", "Ifj. Plinius;Kr. u. 2. század"),
                new Question("E jelben győzni fogsz", "Constantinus;Kr. u. 274–337"),
                new Question("Gazdag hatalmasok szövetkezése igazságosság\nnélkül mi más, mint nagy rablóbanda.", "Augustus;Kr. e. 1. század"),
                new Question("Az ember igazi gazdasága az a jó, amit a világban\nvéghezvitt", "Mohamed;Kr. u. 571–632"),
                new Question("Az egynyelvű és egyszokású ország erőtlen és\nromlandó.", "Szent István;Kr. u. 975–1038"),
                new Question("A matematika a tudományok kapuja és kulcsa.", "Roger Bacon;Kr. u. 13. század")
            };

            currentQuestionIndex = 0;
            progressBar1.Maximum = questions.Count;
            progressBar1.Value = currentQuestionIndex + 1;
            score = 0;
            quizFinished = false;

            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            textBox1.Text = "";
            textBox2.Text = "";

            if (currentQuestionIndex < questions.Count)
            {
                Question currentQuestion = questions[currentQuestionIndex];

                questionLabel.Text = currentQuestion.Text;

                progressBar1.Value = currentQuestionIndex + 1;
                choicesGroupBox.Visible = true;
                nextButton.Visible = true;
                scoreLabel.Visible = false;
                retryButton.Visible = false;
            }
            else
            {
                quizFinished = true;
                questionLabel.Text = "Kvíz vége";
                choicesGroupBox.Visible = false;
                nextButton.Visible = false;
                scoreLabel.Visible = true;
                retryButton.Visible = true;

                scoreLabel.Text = $"Pontszam: {score}/{questions.Count * 2}";
            }
        }



        private class Question
        {
            public string Text { get; }
            public string CorrectAnswer { get; }

            public Question(string Text, string correctAnswer)
            {
                this.Text = Text;
                CorrectAnswer = correctAnswer;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (choicesGroupBox.Controls.OfType<TextBox>().Any(TextBox
                => TextBox.Text != ""))
            {
                Question currentQuestion = questions[currentQuestionIndex];
                string useranswer1 = textBox1.Text.Trim();
                string useranswer2 = textBox2.Text.Trim();
                string answer1 = currentQuestion.CorrectAnswer.Split(';')[0].Trim();
                string answer2 = currentQuestion.CorrectAnswer.Split(';')[1].Trim();

                if (useranswer1 == answer1)
                {
                    score++;
                }

                if (useranswer2 == answer2)
                {
                    score++;
                }

                currentQuestionIndex++;
                DisplayQuestion();
            }
            else
            {
                MessageBox.Show("Légyszíves írj be a mezőkbe választ mielött a következőre mész.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            InitializeQuiz();
        }

        private void Vissza_Click(object sender, EventArgs e)
        {
            Main.Enabled = true;
            this.Close();
        }
    }
}
