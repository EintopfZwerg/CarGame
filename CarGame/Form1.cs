namespace CarGame
{
    public partial class Form1 : Form
    {
        int carspeed = 6;  // geschwindigkeit der Linien
        int enemyspeed = 3;
        int carmoveside = 6; // Auto seitwärtsbewegung

        public Form1()
        {
            InitializeComponent();
            gameover.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Moveline(carspeed); //Moveline(5); 
            EnemyCar(enemyspeed);
            Gameover();
        }
        
        void Gameover()
        {
            if (playercar.Bounds.IntersectsWith(enemycar1.Bounds))
            {
                timer1.Enabled = false;
                gameover.Visible = true;
            }
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
        Random r = new Random();
        int x, y;
        void EnemyCar(int speed)
        {
            if(enemycar1.Top >= 500)
            {
                x = r.Next(0, 200);
                y = 0;
                enemycar1.Location = new Point(x, y);
                // enemycar1.Top = 0;
            } else
            {
                enemycar1.Top += speed;
            }
            if (enemycar2.Top >= 500)
            {
                x = r.Next(200, 400);
                y = 0;
                enemycar2.Location = new Point(x, y);
                // enemycar1.Top = 0;
            }
            else
            {
                enemycar2.Top += speed;
            }
            if (enemycar3.Top >= 500)
            {
                x = r.Next(0, 200);
                y = 0;
                enemycar3.Location = new Point(x, y);
                // enemycar1.Top = 0;
            }
            else
            {
                enemycar3.Top += speed;
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
            { if (playercar.Right < 380)
                {
                    playercar.Left += carmoveside;
                }
            }
             if (e.KeyCode == Keys.Up) // Auto beschleunigt
            {
                carspeed += 2;
            }
            if (e.KeyCode == Keys.Down) // Auto bremst
            {
                if (carspeed <= 0)
                {
                    carspeed = 0;
                    return;
                }
                carspeed += -2;
            }
        }
    }
}