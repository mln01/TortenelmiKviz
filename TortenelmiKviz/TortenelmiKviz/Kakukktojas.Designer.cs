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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold);
            label1.Location = new Point(24, 32);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(357, 72);
            label1.TabIndex = 5;
            label1.Text = "Kakukktojás";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonVissza
            // 
            buttonVissza.Location = new Point(30, 294);
            buttonVissza.Name = "buttonVissza";
            buttonVissza.Size = new Size(340, 48);
            buttonVissza.TabIndex = 7;
            buttonVissza.Text = "Vissza";
            buttonVissza.UseVisualStyleBackColor = true;
            buttonVissza.Click += buttonVissza_Click;
            // 
            // buttonABuvosHetesSzam
            // 
            buttonABuvosHetesSzam.Location = new Point(30, 107);
            buttonABuvosHetesSzam.Name = "buttonABuvosHetesSzam";
            buttonABuvosHetesSzam.Size = new Size(340, 48);
            buttonABuvosHetesSzam.TabIndex = 8;
            buttonABuvosHetesSzam.Text = "A Bűvös Hetes Szám";
            buttonABuvosHetesSzam.UseVisualStyleBackColor = true;
            buttonABuvosHetesSzam.Click += buttonABuvosHetesSzam_Click;
            // 
            // tortenelmiKvizKakukktojas
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 364);
            Controls.Add(buttonABuvosHetesSzam);
            Controls.Add(buttonVissza);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(5);
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
    }
}