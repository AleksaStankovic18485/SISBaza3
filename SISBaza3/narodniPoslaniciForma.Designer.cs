namespace SISBaza3
{
    partial class narodniPoslaniciForma
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
            listViewPoslanici = new ListView();
            btnUpdatePoslanici = new Button();
            btnPrikazStalniRadniOdnos = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listViewPoslanici
            // 
            listViewPoslanici.Location = new Point(12, 12);
            listViewPoslanici.Name = "listViewPoslanici";
            listViewPoslanici.Size = new Size(323, 336);
            listViewPoslanici.TabIndex = 0;
            listViewPoslanici.UseCompatibleStateImageBehavior = false;
            // 
            // btnUpdatePoslanici
            // 
            btnUpdatePoslanici.Font = new Font("SimSun", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUpdatePoslanici.ForeColor = SystemColors.ControlText;
            btnUpdatePoslanici.Location = new Point(341, 145);
            btnUpdatePoslanici.Name = "btnUpdatePoslanici";
            btnUpdatePoslanici.Size = new Size(138, 106);
            btnUpdatePoslanici.TabIndex = 1;
            btnUpdatePoslanici.Text = "Update Poslanika";
            btnUpdatePoslanici.UseVisualStyleBackColor = true;
            // 
            // btnPrikazStalniRadniOdnos
            // 
            btnPrikazStalniRadniOdnos.Font = new Font("SimSun", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPrikazStalniRadniOdnos.Location = new Point(485, 145);
            btnPrikazStalniRadniOdnos.Name = "btnPrikazStalniRadniOdnos";
            btnPrikazStalniRadniOdnos.Size = new Size(136, 106);
            btnPrikazStalniRadniOdnos.TabIndex = 2;
            btnPrikazStalniRadniOdnos.Text = "Prikaži posalnike sa stalnim radnim odnosom";
            btnPrikazStalniRadniOdnos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(213, 176, 115);
            label1.Location = new Point(386, 46);
            label1.Name = "label1";
            label1.Size = new Size(196, 19);
            label1.TabIndex = 3;
            label1.Text = "Narodni Poslanici";
            // 
            // narodniPoslaniciForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 36, 75);
            ClientSize = new Size(633, 360);
            Controls.Add(label1);
            Controls.Add(btnPrikazStalniRadniOdnos);
            Controls.Add(btnUpdatePoslanici);
            Controls.Add(listViewPoslanici);
            Name = "narodniPoslaniciForma";
            Text = "narodniPoslaniciForma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewPoslanici;
        private Button btnUpdatePoslanici;
        private Button btnPrikazStalniRadniOdnos;
        private Label label1;
    }
}