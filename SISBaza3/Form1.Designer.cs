namespace SisBaza2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cmdLoadBaze = new Button();
            narodnaSkupstina = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnPoslanickeGrupe = new Button();
            btnRadnaTela = new Button();
            btnSednica = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmdLoadBaze
            // 
            cmdLoadBaze.Font = new Font("SimSun", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cmdLoadBaze.Location = new Point(329, 140);
            cmdLoadBaze.Margin = new Padding(4, 3, 4, 3);
            cmdLoadBaze.Name = "cmdLoadBaze";
            cmdLoadBaze.Size = new Size(135, 60);
            cmdLoadBaze.TabIndex = 0;
            cmdLoadBaze.Text = "Ucitavanja Baze";
            cmdLoadBaze.UseVisualStyleBackColor = true;
            cmdLoadBaze.Click += cmdLoadBaze_Click;
            // 
            // narodnaSkupstina
            // 
            narodnaSkupstina.AutoSize = true;
            narodnaSkupstina.Font = new Font("SimSun", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            narodnaSkupstina.ForeColor = Color.FromArgb(213, 176, 115);
            narodnaSkupstina.Location = new Point(12, 9);
            narodnaSkupstina.Name = "narodnaSkupstina";
            narodnaSkupstina.Size = new Size(357, 35);
            narodnaSkupstina.TabIndex = 1;
            narodnaSkupstina.Text = "Narodna Skupština ";
            narodnaSkupstina.Click += narodnaSkupstina_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(213, 176, 115);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(129, 35);
            label1.TabIndex = 2;
            label1.Text = "Srbije";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnPoslanickeGrupe
            // 
            btnPoslanickeGrupe.Font = new Font("SimSun", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPoslanickeGrupe.Location = new Point(329, 286);
            btnPoslanickeGrupe.Name = "btnPoslanickeGrupe";
            btnPoslanickeGrupe.Size = new Size(134, 59);
            btnPoslanickeGrupe.TabIndex = 4;
            btnPoslanickeGrupe.Text = "Poslaničke grupe";
            btnPoslanickeGrupe.UseVisualStyleBackColor = true;
            // 
            // btnRadnaTela
            // 
            btnRadnaTela.Font = new Font("SimSun", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRadnaTela.Location = new Point(331, 382);
            btnRadnaTela.Name = "btnRadnaTela";
            btnRadnaTela.Size = new Size(134, 59);
            btnRadnaTela.TabIndex = 5;
            btnRadnaTela.Text = "Radna Tela";
            btnRadnaTela.UseVisualStyleBackColor = true;
            // 
            // btnSednica
            // 
            btnSednica.Font = new Font("SimSun", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSednica.Location = new Point(171, 382);
            btnSednica.Name = "btnSednica";
            btnSednica.Size = new Size(134, 59);
            btnSednica.TabIndex = 6;
            btnSednica.Text = "Sednice";
            btnSednica.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("SimSun", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.Location = new Point(171, 288);
            button4.Name = "button4";
            button4.Size = new Size(134, 59);
            button4.TabIndex = 7;
            button4.Text = "Radni Dani";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("SimSun", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.Location = new Point(12, 336);
            button5.Name = "button5";
            button5.Size = new Size(135, 59);
            button5.TabIndex = 8;
            button5.Text = "Narodni Poslanici";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 36, 75);
            ClientSize = new Size(477, 472);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnSednica);
            Controls.Add(btnRadnaTela);
            Controls.Add(btnPoslanickeGrupe);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(narodnaSkupstina);
            Controls.Add(cmdLoadBaze);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button cmdLoadBaze;
        private Label narodnaSkupstina;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnPoslanickeGrupe;
        private Button btnRadnaTela;
        private Button btnSednica;
        private Button button4;
        private Button button5;
    }
}

