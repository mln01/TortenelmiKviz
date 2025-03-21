using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TortenelmiKviz
{
    public partial class Uralkodojatek : Form
    {
        private Form Main;

        private List<Question> questions;
        private int currentQuestionIndex;
        private int score;
        private bool quizFinished;

        public Uralkodojatek(Form Main)
        {
            InitializeComponent();
            InitializeQuiz();
            this.FormClosing += Uralkodojatek_FormClosing;
            this.Main = Main;
        }

        private void Uralkodojatek_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.Enabled = true; // Re-enable the previous form
        }

        private void InitializeQuiz()
        {
            questions = new List<Question>
            {
                new Question("Egy olyan uralkodóházból való királyok, amely a \r\nsaját országában több mint fél évezredig uralkodott.\r\nTedzsó (Ri Szonggje)       Taudzsong\r\nCsondzsong                Szedzsó\r\nTedzsong                  Jegzsong\r\nSzednong                  Szondzsong\r\nMundnong                  Csungdzsong", "Koreai Királyság"),
                new Question("Ez a dinasztia több mint egy évszázadig volt \r\nuralmon.\r\nAlaungpaja                Bodavpaja\r\nNaungdavgji               Bagidav\r\nHszinbjusin               Tharavádi\r\nSzingu                    Pagan\r\nMaung Maung               Mindon", "Burmai Királyság"),
                new Question("Ez a dinasztia a leghosszabbak közül való, ha nem a \r\nleghosszabban uralkodott. Bő hét \r\névszázadon keresztül megtartotta a hatalmát.\r\nJekumo Amlak            Nevaja Mirjám\r\nJogbea Szejum           I. Dávid\r\nVedem Raad              I. Theodorosz\r\nI. Ama Szejum           Izsák\r\nNevaja Kresztosz        András", "Etióp Császárság"),
                new Question("Ezt a közel kétszáz évig uralkodó dinasztiát egy \r\ntávoli földrészről jött hódítók döntötték \r\nmeg egy ősi kultúrával együtt.\r\nAcamapichtli            Axajacatl\r\nHuitzilihuitl           Tizoc\r\nChimalpopoca            Ahuitzotl\r\nItzoatl                II. Motenzcoma Xocayotzin\r\nI. Mortenczoma Ilhuicamina  Cuitlahuac", "Azték Királyság"),
                new Question("Ebben az országban közel egy évezredes a \r\nmonarchikus államforma. Egy-egy uralkodó általában \r\nsokáig állt a hatalom élén. Mi az első hét és \r\nfél évszázad első 10 uralkodóját soroljuk fel.\r\nDzsimu                Kóan\r\nSzuidzei              Kórei\r\nAnnei                 Kógen\r\nIkotu                 Kaika\r\nKósó                  Szudzsin", "Japán Császárság")
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

                scoreLabel.Text = $"Pontszam: {score}/{questions.Count}";
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


        private void Vissza_Click(object sender, EventArgs e)
        {
            Main.Enabled = true;
            this.Close();
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            InitializeQuiz();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Question currentQuestion = questions[currentQuestionIndex];
                string useranswer1 = textBox1.Text.Trim();
                string answer1 = currentQuestion.CorrectAnswer;

                if (useranswer1 == answer1)
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
    }
}
