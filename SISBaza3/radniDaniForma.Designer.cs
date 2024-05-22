namespace SISBaza3
{
    partial class radniDaniForma
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
            btnSortPoBrojuPoslanika = new Button();
            btnSortirajPoVremenu = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(253, 426);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnSortPoBrojuPoslanika
            // 
            btnSortPoBrojuPoslanika.Font = new Font("SimSun", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSortPoBrojuPoslanika.Location = new Point(271, 367);
            btnSortPoBrojuPoslanika.Name = "btnSortPoBrojuPoslanika";
            btnSortPoBrojuPoslanika.Size = new Size(125, 71);
            btnSortPoBrojuPoslanika.TabIndex = 1;
            btnSortPoBrojuPoslanika.Text = "Sortiraj po broju poslanika";
            btnSortPoBrojuPoslanika.UseVisualStyleBackColor = true;
            // 
            // btnSortirajPoVremenu
            // 
            btnSortirajPoVremenu.Font = new Font("SimSun", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSortirajPoVremenu.Location = new Point(271, 290);
            btnSortirajPoVremenu.Name = "btnSortirajPoVremenu";
            btnSortirajPoVremenu.Size = new Size(125, 71);
            btnSortirajPoVremenu.TabIndex = 4;
            btnSortirajPoVremenu.Text = "Sortiraj po vremenu";
            btnSortirajPoVremenu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(213, 176, 115);
            label1.Location = new Point(279, 12);
            label1.Name = "label1";
            label1.Size = new Size(117, 33);
            label1.TabIndex = 5;
            label1.Text = "Radni ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(213, 176, 115);
            label2.Location = new Point(288, 57);
            label2.Name = "label2";
            label2.Size = new Size(83, 33);
            label2.TabIndex = 6;
            label2.Text = "Dani";
            // 
            // radniDaniForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 36, 75);
            ClientSize = new Size(408, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSortirajPoVremenu);
            Controls.Add(btnSortPoBrojuPoslanika);
            Controls.Add(listView1);
            Name = "radniDaniForma";
            Text = "radniDaniForma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button btnSortPoBrojuPoslanika;
        private Button btnSortirajPoVremenu;
        private Label label1;
        private Label label2;
    }
}