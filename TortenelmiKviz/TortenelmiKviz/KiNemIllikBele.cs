using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TortenelmiKviz
{
    public partial class KiNemIllikBele : Form
    {
        private Form Kakukk;
        private List<Question> questions;
        private int currentQuestionIndex;
        private int score;
        private bool quizFinished;

        public KiNemIllikBele(Form Kakukk)
        {
            InitializeComponent();
            InitializeQuiz();
            this.Kakukk = Kakukk;
            this.FormClosing += KiNemIllikBele_FormClosing;
        }

        private void KiNemIllikBele_FormClosing(object sender, FormClosingEventArgs e)
        {
            Kakukk.Enabled = true; // Re-enable the previous form
        }

        private void InitializeQuiz()
        {
            questions = new List<Question>
            {
                new Question(new List<string> { "Deák Ferenc", "Eötvös József báró", "Teleki Pál gróf", "Szalay László", "Apponyi Albert gróf" }, "Teleki Pál gróf" ),
                new Question(new List<string> { "Otto von Bismarck", "Ferdinand Lassalle", "Eduard Bernstein", "Robert Ley", "Friedrich Engels" }, "Robert Ley" ),
                new Question(new List < string > { "Giuseppe Garibaldi", "II. Viktor Emanuel", "Ciano gróf (Galeazzo Ciano di Cortelazzo)", "Francesco Crispi", "Giovanni Giolitti" }, "Ciano gróf (Galeazzo Ciano di Cortelazzo)"),
                new Question(new List < string > { "August Bebel", "Karl Liebknecht", "Alfred Windischgrätz herceg", "Pierre-Joseph Proudhon", "Friedrich Adler" }, "Alfred Windischgrätz herceg"),
                new Question(new List < string > { "Georgij Valentyinovics Plehanov", "III. Sándor cáр", "Makszim Makszimovics Litvinov", "Trockij Lev Ravidovics", "Kamenyev Leo Boriszovics" }, "III. Sándor cáр"),
                new Question(new List < string > { "Tiberius Sempronius Gracchus", "Gaius Sempronius Gracchus", "Cornelius Tacitus", "Gaius Marius", "Livius Drusus" }, "Cornelius Tacitus"),
                new Question(new List < string > { "Chlodvig", "Martell Károly", "Kis Pipin", "Hódító Vilmos", "Nagy Károly" }, "Hódító Vilmos"),
                new Question( new List < string > { "Párizsi Notre-Dame", "Reimsi dóm", "Konstantinápolyi Hagia Sophia", "Strasbourgi dóm", "Westminster-apátság – London" }, "Konstantinápolyi Hagia Sophia"),
                new Question(new List < string > { "Szophoklész", "Hérodotosz", "Thuküdidész", "Titus Livius", "Cornelius Tacitus" }, "Szophoklész"),
                new Question(new List < string > { "Thuróczy János", "Károli Gáspár", "Marcantonio Bonfini", "Szerémi György", "Istvánffy Miklós" }, "Károli Gáspár"),
                new Question(new List < string > { "Bethlen Gábor", "Albrecht Wallenstein", "Gusztáv Adolf", "Thököly Imre", "II. Ferdinánd" }, "Thököly Imre"),
                new Question(new List < string > { "Kazinczy Ferenc", "Martinovics Ignác", "Hajnóczy József", "Szentmarjai Ferenc", "Sigray Jakab" }, "Kazinczy Ferenc"),
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

        private void Vissza_Click(object sender, EventArgs e)
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
