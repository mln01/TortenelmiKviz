namespace TortenelmiKviz
{
    partial class tortenelmiKvízMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ButtonKakukktojas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold);
            label1.Location = new Point(14, 30);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(465, 72);
            label1.TabIndex = 0;
            label1.Text = "Történelem Kvíz";
            // 
            // button1
            // 
            button1.Location = new Point(75, 121);
            button1.Name = "button1";
            button1.Size = new Size(340, 48);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(75, 177);
            button2.Name = "button2";
            button2.Size = new Size(340, 48);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(75, 233);
            button3.Name = "button3";
            button3.Size = new Size(340, 48);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // ButtonKakukktojas
            // 
            ButtonKakukktojas.Location = new Point(75, 289);
            ButtonKakukktojas.Name = "ButtonKakukktojas";
            ButtonKakukktojas.Size = new Size(340, 48);
            ButtonKakukktojas.TabIndex = 4;
            ButtonKakukktojas.Text = "Kakukktojás";
            ButtonKakukktojas.UseVisualStyleBackColor = true;
            ButtonKakukktojas.Click += ButtonKakukktojas_Click;
            // 
            // tortenelmiKvízMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(484, 381);
            Controls.Add(ButtonKakukktojas);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(5);
            MinimumSize = new Size(500, 420);
            Name = "tortenelmiKvízMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Történelem Kvíz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button ButtonKakukktojas;
    }
}
