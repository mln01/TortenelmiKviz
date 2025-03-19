using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace TortenelmiKviz
{
    public partial class HazankTajain : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex;
        private int score;
        private bool quizFinished;
        private Form Kakukk;

        public HazankTajain(Form Kakukk)
        {
            InitializeComponent();
            InitializeQuiz();
            this.Kakukk = Kakukk;
        }

        private void HazankTajain_Load(object sender, EventArgs e)
        {

        }

        private void InitializeQuiz()
        {
            questions = new List<Question>
            {
                new Question(new List<string> { "Bugac", "Jászság", "Ecsedi-láp", "Göcsej", "Nyírség" }, "Göcsej" ),
                new Question(new List<string> { "Bükk", "Mátra", "Almás", "Cserhát", "Börzsöny" }, "Almás" ),
                new Question(new List < string > { "Vértes", "Pilis", "Bakony", "Őrség", "Temesköz" }, "Temesköz"),
                new Question(new List < string > { "Csallóköz", "Mátyusföld", "Hanság", "Kemeneshát", "Cserhát" }, "Cserhát"),
                new Question(new List < string > { "Csíki-havasok", "Eperjes-Tokaj-hegység", "Baróti-hegység", "Brassói-havasok", "Háromszéki-havasok" }, "Eperjes-Tokaj-hegység")
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

        private void Vissza_Click_1(object sender, EventArgs e)
        {
            Kakukk.Enabled = true;
            this.Close();
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            InitializeQuiz();
        }

        private void nextButton_Click(object sender, EventArgs e)
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
    }
}
