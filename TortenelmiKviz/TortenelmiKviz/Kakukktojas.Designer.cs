namespace TortenelmiKviz
{
    partial class tortenelmiKvizKakukktojas
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
            label1 = new Label();
            buttonVissza = new Button();
            buttonABuvosHetesSzam = new Button();
            buttonHazankTajain = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold);
            label1.Location = new Point(41, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 54);
            label1.TabIndex = 5;
            label1.Text = "Kakukktojás";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonVissza
            // 
            buttonVissza.Anchor = AnchorStyles.None;
            buttonVissza.Location = new Point(112, 264);
            buttonVissza.Margin = new Padding(2, 3, 2, 3);
            buttonVissza.Name = "buttonVissza";
            buttonVissza.Size = new Size(86, 27);
            buttonVissza.TabIndex = 7;
            buttonVissza.Text = "Vissza";
            buttonVissza.UseVisualStyleBackColor = true;
            buttonVissza.Click += buttonVissza_Click;
            // 
            // buttonABuvosHetesSzam
            // 
            buttonABuvosHetesSzam.Anchor = AnchorStyles.None;
            buttonABuvosHetesSzam.Location = new Point(55, 66);
            buttonABuvosHetesSzam.Margin = new Padding(2, 3, 2, 3);
            buttonABuvosHetesSzam.Name = "buttonABuvosHetesSzam";
            buttonABuvosHetesSzam.Size = new Size(201, 36);
            buttonABuvosHetesSzam.TabIndex = 8;
            buttonABuvosHetesSzam.Text = "A Bűvös Hetes Szám";
            buttonABuvosHetesSzam.UseVisualStyleBackColor = true;
            buttonABuvosHetesSzam.Click += buttonABuvosHetesSzam_Click;
            // 
            // buttonHazankTajain
            // 
            buttonHazankTajain.Anchor = AnchorStyles.None;
            buttonHazankTajain.Location = new Point(55, 108);
            buttonHazankTajain.Margin = new Padding(2, 3, 2, 3);
            buttonHazankTajain.Name = "buttonHazankTajain";
            buttonHazankTajain.Size = new Size(201, 33);
            buttonHazankTajain.TabIndex = 9;
            buttonHazankTajain.Text = "Hazánk Tájain";
            buttonHazankTajain.UseVisualStyleBackColor = true;
            buttonHazankTajain.Click += buttonHazankTajain_Click;
            // 
            // tortenelmiKvizKakukktojas
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 303);
            Controls.Add(buttonHazankTajain);
            Controls.Add(buttonABuvosHetesSzam);
            Controls.Add(buttonVissza);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MinimumSize = new Size(330, 340);
            Name = "tortenelmiKvizKakukktojas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Történelmi Kvíz - Kakukktojás";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonKakukktojas;
        private Button button3;
        private Button button2;
        private Label label1;
        private Button buttonVissza;
        private Button buttonABuvosHetesSzam;
        private Button buttonHazankTajain;
    }
}