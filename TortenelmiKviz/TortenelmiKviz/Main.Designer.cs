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
            ButtonKakukktojas = new Button();
            buttonAranykopesek = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 32F, FontStyle.Bold);
            label1.Location = new Point(24, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(336, 59);
            label1.TabIndex = 0;
            label1.Text = "Történelem Kvíz";
            // 
            // ButtonKakukktojas
            // 
            ButtonKakukktojas.Anchor = AnchorStyles.None;
            ButtonKakukktojas.AutoSize = true;
            ButtonKakukktojas.Location = new Point(66, 85);
            ButtonKakukktojas.Margin = new Padding(2, 3, 2, 3);
            ButtonKakukktojas.Name = "ButtonKakukktojas";
            ButtonKakukktojas.Size = new Size(247, 35);
            ButtonKakukktojas.TabIndex = 4;
            ButtonKakukktojas.Text = "Kakukktojás";
            ButtonKakukktojas.UseVisualStyleBackColor = true;
            ButtonKakukktojas.Click += ButtonKakukktojas_Click;
            // 
            // buttonAranykopesek
            // 
            buttonAranykopesek.Anchor = AnchorStyles.None;
            buttonAranykopesek.AutoSize = true;
            buttonAranykopesek.Location = new Point(66, 124);
            buttonAranykopesek.Margin = new Padding(2, 3, 2, 3);
            buttonAranykopesek.Name = "buttonAranykopesek";
            buttonAranykopesek.Size = new Size(247, 35);
            buttonAranykopesek.TabIndex = 5;
            buttonAranykopesek.Text = "Aranyköpések (néha csak ezüst)";
            buttonAranykopesek.UseVisualStyleBackColor = true;
            buttonAranykopesek.Click += buttonAranykopesek_Click;
            // 
            // tortenelmiKvízMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(384, 321);
            Controls.Add(buttonAranykopesek);
            Controls.Add(ButtonKakukktojas);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MinimumSize = new Size(400, 360);
            Name = "tortenelmiKvízMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Történelem Kvíz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ButtonKakukktojas;
        private Button buttonAranykopesek;
    }
}
