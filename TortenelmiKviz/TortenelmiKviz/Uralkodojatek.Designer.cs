namespace TortenelmiKviz
{
    partial class Uralkodojatek
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            progressBar1 = new ProgressBar();
            Vissza = new Button();
            scoreLabel = new Label();
            retryButton = new Button();
            nextButton = new Button();
            choicesGroupBox = new GroupBox();
            label3 = new Label();
            textBox1 = new TextBox();
            questionLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            choicesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.None;
            progressBar1.ForeColor = Color.DarkSeaGreen;
            progressBar1.Location = new Point(34, 114);
            progressBar1.Margin = new Padding(4);
            progressBar1.Maximum = 7;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(343, 24);
            progressBar1.TabIndex = 35;
            // 
            // Vissza
            // 
            Vissza.Anchor = AnchorStyles.None;
            Vissza.Location = new Point(316, 13);
            Vissza.Margin = new Padding(4);
            Vissza.Name = "Vissza";
            Vissza.Size = new Size(94, 30);
            Vissza.TabIndex = 34;
            Vissza.Text = "Vissza";
            Vissza.UseVisualStyleBackColor = true;
            Vissza.Click += Vissza_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.Anchor = AnchorStyles.None;
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(12, 408);
            scoreLabel.Margin = new Padding(4, 0, 4, 0);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(80, 21);
            scoreLabel.TabIndex = 33;
            scoreLabel.Text = "Eredmeny";
            // 
            // retryButton
            // 
            retryButton.Anchor = AnchorStyles.None;
            retryButton.Location = new Point(315, 408);
            retryButton.Margin = new Padding(4);
            retryButton.Name = "retryButton";
            retryButton.Size = new Size(95, 32);
            retryButton.TabIndex = 32;
            retryButton.Text = "Újrakezdés";
            retryButton.UseVisualStyleBackColor = true;
            retryButton.Click += retryButton_Click;
            // 
            // nextButton
            // 
            nextButton.Anchor = AnchorStyles.None;
            nextButton.Location = new Point(315, 408);
            nextButton.Margin = new Padding(4);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(95, 32);
            nextButton.TabIndex = 31;
            nextButton.Text = "Következő";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // choicesGroupBox
            // 
            choicesGroupBox.Anchor = AnchorStyles.None;
            choicesGroupBox.Controls.Add(label3);
            choicesGroupBox.Controls.Add(textBox1);
            choicesGroupBox.Controls.Add(questionLabel);
            choicesGroupBox.Location = new Point(13, 133);
            choicesGroupBox.Margin = new Padding(4);
            choicesGroupBox.Name = "choicesGroupBox";
            choicesGroupBox.Padding = new Padding(4);
            choicesGroupBox.Size = new Size(399, 256);
            choicesGroupBox.TabIndex = 30;
            choicesGroupBox.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(21, 225);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 31;
            label3.Text = "Ország";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(88, 222);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 29);
            textBox1.TabIndex = 29;
            // 
            // questionLabel
            // 
            questionLabel.Anchor = AnchorStyles.None;
            questionLabel.AutoSize = true;
            questionLabel.Location = new Point(21, 20);
            questionLabel.Margin = new Padding(4, 0, 4, 0);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(112, 21);
            questionLabel.TabIndex = 28;
            questionLabel.Text = "Feladat szöveg";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(11, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 32);
            label1.TabIndex = 28;
            label1.Text = "Uralkodójátek";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(11, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(371, 63);
            label2.TabIndex = 29;
            label2.Text = "   A következőkben néhány távoli ország uralokodóit\r\nsoroljuk fel kronologikus sorrendben.\r\n   Melyik országról van szó?";
            // 
            // Uralkodojatek
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 451);
            Controls.Add(progressBar1);
            Controls.Add(Vissza);
            Controls.Add(scoreLabel);
            Controls.Add(retryButton);
            Controls.Add(nextButton);
            Controls.Add(choicesGroupBox);
            Controls.Add(label1);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MinimumSize = new Size(440, 490);
            Name = "Uralkodojatek";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Történelmi Kvíz - Uralkodójáték";
            choicesGroupBox.ResumeLayout(false);
            choicesGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Button Vissza;
        private Label scoreLabel;
        private Button retryButton;
        private Button nextButton;
        private GroupBox choicesGroupBox;
        private Label label3;
        private TextBox textBox1;
        private Label questionLabel;
        private Label label1;
        private Label label2;
    }
}