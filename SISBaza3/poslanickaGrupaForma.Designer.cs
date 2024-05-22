namespace SISBaza3
{
    partial class poslanickaGrupaForma
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
            listView1 = new ListView();
            label1 = new Label();
            btnSortiraj = new Button();
            btnPrikaziPredsednike = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 198);
            listView1.Name = "listView1";
            listView1.Size = new Size(445, 240);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(213, 176, 115);
            label1.Location = new Point(76, 9);
            label1.Name = "label1";
            label1.Size = new Size(316, 35);
            label1.TabIndex = 1;
            label1.Text = "Poslaničke grupe";
            // 
            // btnSortiraj
            // 
            btnSortiraj.Font = new Font("SimSun", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSortiraj.Location = new Point(251, 103);
            btnSortiraj.Name = "btnSortiraj";
            btnSortiraj.Size = new Size(141, 56);
            btnSortiraj.TabIndex = 2;
            btnSortiraj.Text = "Sortiraj";
            btnSortiraj.UseVisualStyleBackColor = true;
            // 
            // btnPrikaziPredsednike
            // 
            btnPrikaziPredsednike.Font = new Font("SimSun", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPrikaziPredsednike.Location = new Point(76, 103);
            btnPrikaziPredsednike.Name = "btnPrikaziPredsednike";
            btnPrikaziPredsednike.Size = new Size(141, 56);
            btnPrikaziPredsednike.TabIndex = 3;
            btnPrikaziPredsednike.Text = "Prikaži predsednike";
            btnPrikaziPredsednike.UseVisualStyleBackColor = true;
            // 
            // poslanickaGrupaForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 36, 75);
            ClientSize = new Size(482, 450);
            Controls.Add(btnPrikaziPredsednike);
            Controls.Add(btnSortiraj);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "poslanickaGrupaForma";
            Text = "poslanickaGrupaForma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private Button btnSortiraj;
        private Button btnPrikaziPredsednike;
    }
}