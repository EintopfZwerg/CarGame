namespace CarGame
{
    public partial class Form1 : Form
    {
        int linemovespeed = 6;
        int carmoveside = 4;

        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Moveline(linemovespeed); //Moveline(5); 
        }
        void Moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            } else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Left) // Auto fährt links
            {
                if (playercar.Left >= 10)
                {
                    playercar.Left += -carmoveside;
                }
       
            }
             if (e.KeyCode == Keys.Right) // Auto fährt rechts
            { if (playercar.Right <= 390)
                {
                    playercar.Left += carmoveside;
                }
            }
             if (e.KeyCode == Keys.Up) // Auto beschleunigt
            {
                linemovespeed += 2;
            }
            if (e.KeyCode == Keys.Down) // Auto bremst
            {
                if (linemovespeed <= 0)
                {
                    linemovespeed = 0;
                    return;
                }
                linemovespeed += -2;
            }
        }
    }
}