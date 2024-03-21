namespace formyılan_oynu
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            oyunalanı = new Panel();
            başla = new Label();
            puan = new Label();
            skor = new Label();
            sonuç = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // oyunalanı
            // 
            oyunalanı.BackColor = Color.Bisque;
            oyunalanı.Location = new Point(198, 12);
            oyunalanı.Name = "oyunalanı";
            oyunalanı.Size = new Size(500, 500);
            oyunalanı.TabIndex = 0;
            // 
            // başla
            // 
            başla.AutoSize = true;
            başla.BackColor = Color.PaleGreen;
            başla.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            başla.Location = new Point(27, 244);
            başla.Name = "başla";
            başla.Size = new Size(122, 45);
            başla.TabIndex = 1;
            başla.Text = "BAŞLA";
            başla.Click += başla_Click;
            // 
            // puan
            // 
            puan.AutoSize = true;
            puan.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            puan.Location = new Point(761, 127);
            puan.Name = "puan";
            puan.Size = new Size(110, 45);
            puan.TabIndex = 2;
            puan.Text = "PUAN";
            // 
            // skor
            // 
            skor.AutoSize = true;
            skor.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            skor.ForeColor = Color.Red;
            skor.Location = new Point(799, 172);
            skor.Name = "skor";
            skor.Size = new Size(26, 30);
            skor.TabIndex = 3;
            skor.Text = "0";
            // 
            // sonuç
            // 
            sonuç.AutoSize = true;
            sonuç.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            sonuç.ForeColor = Color.Red;
            sonuç.Location = new Point(325, 539);
            sonuç.Name = "sonuç";
            sonuç.Size = new Size(222, 45);
            sonuç.TabIndex = 4;
            sonuç.Text = "KAYBETTİNİZ";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 611);
            Controls.Add(sonuç);
            Controls.Add(skor);
            Controls.Add(puan);
            Controls.Add(başla);
            Controls.Add(oyunalanı);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel oyunalanı;
        private Label başla;
        private Label puan;
        private Label skor;
        private Label sonuç;
        private System.Windows.Forms.Timer timer1;
    }
}
