namespace formyılan_oynu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Panel kare;
        Panel yem = new Panel();
        List<Panel> yılan = new List<Panel>();
        string yön = "sağ";




        private void başla_Click(object sender, EventArgs e)
        {
            skor.Text = "0";
            sonuç.Text = "";

            kare = new Panel();
            kare.Location = new Point(200, 200);
            kare.BackColor = Color.Green;
            kare.Size = new Size(20, 20);
            yılan.Add(kare);
            oyunalanı.Controls.Add(yılan[0]);
            yemoluş();

            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            int yılx = yılan[0].Location.X;
            int yıly = yılan[0].Location.Y;

            yemyedi();
            hareket();
            çarpma();

            if (yön == "sağ")
            {
                if (yılx < 580)
                {
                    yılx += 20;


                }
                else
                {
                    yılx = 0;
                }

            }

            if (yön == "sol")
            {
                if (yılx > 0)
                {
                    yılx -= 20;


                }
                else
                {
                    yılx = 580;
                }

            }

            if (yön == "aşağa")
            {
                if (yıly < 580)
                {
                    yıly += 20;


                }
                else
                {
                    yıly = 0;
                }

            }
            if (yön == "yukarı")
            {
                if (yıly > 0)
                {
                    yıly -= 20;


                }
                else
                {
                    yıly = 580;
                }


            }
            yılan[0].Location = new Point(yılx, yıly);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                yön = "sağ";

            }
            if (e.KeyCode == Keys.Left)
            {
                yön = "sol";

            }
            if (e.KeyCode == Keys.Down)
            {
                yön = "aşağa";

            }
            if (e.KeyCode == Keys.Up)
            {
                yön = "yukarı";

            }

        }
        void yemoluş()
        {
            Random random = new Random();
            int yemx = random.Next(580);
            int yemy = random.Next(580);

            yemx -= yemx % 20;
            yemy -= yemy % 20;

            yem.Size = new Size(20, 20);
            yem.BackColor = Color.Red;
            yem.Location=new Point(yemx, yemy);
            oyunalanı.Controls.Add(yem);

        }
        void yemyedi()
        {
            int puan = int.Parse(skor.Text);
            if (yılan[0].Location==yem.Location)
            {
                oyunalanı.Controls.Remove(yem);
                puan += 100;
                skor.Text=Convert.ToString(puan);
                yemoluş();
                gövdeekle();

            }
        }

        void gövdeekle()
        {
            Panel gövde = new Panel();
            gövde.Size = new Size(20, 20); 
            gövde.BackColor = Color.Green;
            yılan.Add(gövde);
            oyunalanı.Controls.Add(gövde);

        }
        void hareket()
        {
            for (int i = yılan.Count-1; i >0; i--) 
            {
                yılan[i].Location = yılan[i - 1].Location;
            }


        }
        void çarpma()
        {
            for (int i = 2; i < yılan.Count; i++)
            {
                if (yılan[0].Location == yılan[i].Location)
                {
                    sonuç.Text = "kaybettiniz";
                    timer1.Stop();  

                }


            }
        }
       
    }
}
