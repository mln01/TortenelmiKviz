namespace TortenelmiKviz
{
    partial class Aranykopesek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aranykopesek));
            progressBar1 = new ProgressBar();
            Vissza = new Button();
            scoreLabel = new Label();
            retryButton = new Button();
            nextButton = new Button();
            choicesGroupBox = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            questionLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            choicesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.None;
            progressBar1.ForeColor = Color.DarkSeaGreen;
            progressBar1.Location = new Point(32, 156);
            progressBar1.Maximum = 7;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(268, 23);
            progressBar1.TabIndex = 27;
            // 
            // Vissza
            // 
            Vissza.Anchor = AnchorStyles.None;
            Vissza.Location = new Point(248, 12);
            Vissza.Name = "Vissza";
            Vissza.Size = new Size(76, 25);
            Vissza.TabIndex = 26;
            Vissza.Text = "Vissza";
            Vissza.UseVisualStyleBackColor = true;
            Vissza.Click += Vissza_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.Anchor = AnchorStyles.None;
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(12, 318);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(60, 15);
            scoreLabel.TabIndex = 25;
            scoreLabel.Text = "Eredmeny";
            // 
            // retryButton
            // 
            retryButton.Anchor = AnchorStyles.None;
            retryButton.Location = new Point(250, 318);
            retryButton.Name = "retryButton";
            retryButton.Size = new Size(74, 23);
            retryButton.TabIndex = 24;
            retryButton.Text = "Újrakezdés";
            retryButton.UseVisualStyleBackColor = true;
            retryButton.Click += retryButton_Click;
            // 
            // nextButton
            // 
            nextButton.Anchor = AnchorStyles.None;
            nextButton.Location = new Point(249, 318);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(74, 23);
            nextButton.TabIndex = 23;
            nextButton.Text = "Következő";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // choicesGroupBox
            // 
            choicesGroupBox.Anchor = AnchorStyles.None;
            choicesGroupBox.Controls.Add(label4);
            choicesGroupBox.Controls.Add(label3);
            choicesGroupBox.Controls.Add(textBox2);
            choicesGroupBox.Controls.Add(textBox1);
            choicesGroupBox.Controls.Add(questionLabel);
            choicesGroupBox.Location = new Point(14, 185);
            choicesGroupBox.Name = "choicesGroupBox";
            choicesGroupBox.Size = new Size(310, 120);
            choicesGroupBox.TabIndex = 22;
            choicesGroupBox.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(186, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(18, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 29;
            // 
            // questionLabel
            // 
            questionLabel.Anchor = AnchorStyles.None;
            questionLabel.AutoSize = true;
            questionLabel.Location = new Point(6, 36);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(100, 15);
            questionLabel.TabIndex = 28;
            questionLabel.Text = "Aranyköpés helye";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(206, 64);
            label1.TabIndex = 20;
            label1.Text = "Aranyköpések\r\n(vagy néha ezüst)";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(316, 75);
            label2.TabIndex = 21;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(18, 97);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 31;
            label3.Text = "Név";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(186, 97);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 32;
            label4.Text = "Mikor élt";
            // 
            // Aranykopesek
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 361);
            Controls.Add(progressBar1);
            Controls.Add(Vissza);
            Controls.Add(scoreLabel);
            Controls.Add(retryButton);
            Controls.Add(nextButton);
            Controls.Add(choicesGroupBox);
            Controls.Add(label1);
            Controls.Add(label2);
            MinimumSize = new Size(350, 400);
            Name = "Aranykopesek";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aranykopesek";
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
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label questionLabel;
        private Label label4;
        private Label label3;
    }
}