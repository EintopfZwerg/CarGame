using System.IO;
using System.Media;
using System.Windows.Media;

namespace CarGame
{

    // https://www.youtube.com/watch?v=xyggRDkoOwU&t=1485s
    public partial class Form1 : Form
    {

        static string gametitel = "CarGameV0.4";
        string filepath = System.Reflection.Assembly.GetExecutingAssembly().Location + ".txt"; // Pfad der exe datei
        int carspeed = 6;       // geschwindigkeit der Linien
        int enemyspeed = 3;     // geschwindigkeit der Gegnerischen Autos
        int carmoveside = 8;    // Auto seitwärtsbewegung
        int coinspeed = 2;
        int coins = 0;          // Anzahl eingesammelter Coins
        int death = 0;          // Anzahl tode
        int traveldistance = 0; // erreichte Distanz
        int distancetimer = 0;  // zur Steuerung der zurückgelegten distanz
        int distancerecord = 0; // Rekord der erreichten Distanz
        int dificulty = 1000;   // Entfernung nach der sich die Geschwindigkeit erhöht
        private SoundPlayer player = new SoundPlayer("Sounds\\music.wav");

        int playmusic = 0;
        int playsounds = 0;

        int usemouse = 1;
        public Form1()
        {
            InitializeComponent();
            this.Text = gametitel;
            Readrecord();
            Writerecord();
            gameover.Visible = false;
            travelrecord.Visible = false;
            travelrecordlabel.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Moveline(carspeed);
            if (usemouse == 1)
            {
                Movecarmouse();
            }
            EnemyCar(enemyspeed);
            Coin(coinspeed);
            Distance(carspeed);
            CoinIntersect();
            Gameover();
            Dificulty(traveldistance);
        }
        void Play(string audioPath)
        {
            MediaPlayer myPlayer = new MediaPlayer();
            myPlayer.Open(new System.Uri(audioPath));
            myPlayer.Play();
        }
        void Writerecord()
        {
            bool filexist = File.Exists(filepath);

            StreamWriter sw = new StreamWriter(filepath);
            sw.Write(distancerecord);
            sw.Close();

        }
        void Readrecord()
        {
            try
            {
                StreamReader sr = new StreamReader(filepath);

                string line = sr.ReadLine();
                distancerecord = Convert.ToInt32(line);
                travelrecord.Text = Convert.ToString(distancerecord);
                sr.Close();
            }
            catch
            {
                System.Console.WriteLine("Lesefehler der Record Datei");
            }
        }
        void Movecarmouse()
        {

            int i = Location.X;
            int carposition = Cursor.Position.X - 25 - i;
            if (carposition <= 0)
            {
                playercar.Left = 0;
            }
            else if (carposition >= 350)
            {
                playercar.Left = 350;
            }
            else
            {
                playercar.Left = carposition;
            }
        }
        void Dificulty(int i)
        {

            if (i > dificulty)
            {
                enemyspeed++;
                dificulty += 1000;
            }
        }
        void Gameover()
        {
            if (playercar.Bounds.IntersectsWith(enemycar1.Bounds) || playercar.Bounds.IntersectsWith(enemycar2.Bounds) || playercar.Bounds.IntersectsWith(enemycar3.Bounds))
            {
                death++;
                deathcounter.Text = Convert.ToString(death);

                timer1.Enabled = false;
                gameover.Visible = true;
                startlabel.Visible = true;
                travelrecordlabel.Visible = true;
                travelrecord.Visible = true;
                labelsound.Visible = true;
                labelsoundtoggle.Visible = true;
                labelmusic.Visible = true;
                labelmusictoggle.Visible = true;
                if (traveldistance > distancerecord)
                {
                    distancerecord = traveldistance;
                    travelrecord.Text = Convert.ToString(distancerecord);
                    Writerecord();
                    if (playsounds == 1)
                    {
                        Play(Application.StartupPath + "Sounds\\fanfare.wav");
                    }
                }
            }
        }
        void Restart()
        {
            timer1.Enabled = true;
            gameover.Visible = false;
            startlabel.Visible = false;
            travelrecordlabel.Visible = false;
            travelrecord.Visible = false;
            labelmusictoggle.Visible = false;
            labelmusic.Visible = false;
            labelsoundtoggle.Visible = false;
            labelsound.Visible = false;
            traveldistance = 0;
            coins = 0;
            coincounter.Text = Convert.ToString(coins);
            carspeed = 6;
            enemyspeed = 3;
            coinspeed = 2;
            dificulty = 1000;
            enemycar1.Top = -100;
            enemycar2.Top = -120;
            enemycar3.Top = -150;
        }
        void Distance(int speed)
        {
            if (carspeed > 0)
            {
                distancetimer++;
                if (distancetimer == 10)
                {
                    traveldistance += speed;
                    meter.Text = Convert.ToString(traveldistance) + "m";
                    distancetimer = 0;
                }
            }
        }
        void Moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = -100;
            }
            else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = -100;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = -100;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = -100;
            }
            else
            {
                pictureBox4.Top += speed;
            }

        }
        void EnemyCar(int speed)
        {
            Random r = new Random();
            int x, y;
            if (enemycar1.Top >= 500)
            {
                x = r.Next(0, 200);
                y = r.Next(-200, -100);
                enemycar1.Location = new Point(x, y);

            }
            else
            {
                enemycar1.Top += speed;
            }
            if (enemycar2.Top >= 500)
            {
                x = r.Next(200, 400);
                y = r.Next(-200, -100);
                enemycar2.Location = new Point(x, y);

            }
            else
            {
                enemycar2.Top += speed;
            }
            if (enemycar3.Top >= 500)
            {
                x = r.Next(0, 200);
                y = r.Next(-200, -100);
                enemycar3.Location = new Point(x, y);

            }
            else
            {
                enemycar3.Top += speed;
            }
        }
        void Coin(int speed)
        {
            Random r = new Random();
            int x, y;
            if (coin.Top >= 500)
            {
                x = r.Next(0, 200);
                y = r.Next(-200, -100);
                coin.Location = new Point(x, y);
            }
            else
            {
                coin.Top += speed;
            }
        }
        void CoinIntersect()
        {
            if (playercar.Bounds.IntersectsWith(coin.Bounds))
            {
                coin.Location = new Point(500, 500);
                coins++;
                coincounter.Text = Convert.ToString(coins);
                if (playsounds == 1)
                {
                    Play(Application.StartupPath + "Sounds\\collectcoin.wav");
                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (usemouse == 0)
            {
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) // Auto fährt links
                {
                    if (playercar.Left >= 10)
                    {
                        if (carspeed > 0)
                        {
                            playercar.Left += -carmoveside;
                        }
                    }

                }
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) // Auto fährt rechts
                {
                    if (playercar.Right < 380)
                    {
                        if (carspeed > 0)
                        {
                            playercar.Left += carmoveside;
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W) // Auto beschleunigt
            {
                carspeed += 2;
                enemyspeed += 2;
                coinspeed += 2;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S) // Auto bremst
            {
                if (carspeed <= 0)
                {
                    carspeed = 0;
                    return;
                }
                carspeed += -2;
                if (enemyspeed <= 2) return;
                enemyspeed += -2;
                coinspeed += -2;
            }
            if (e.KeyCode == Keys.Space)
            {
                Restart();
            }
            if (e.KeyCode == Keys.M)
            {
                if (playmusic == 0)
                {
                    playmusic = 1;
                    labelmusictoggle.Text = "ON";
                    player.Play();
                    return;
                }
                if (playmusic == 1)
                {
                    playmusic = 0;
                    labelmusictoggle.Text = "OFF";
                    player.Stop();
                    return;
                }
            }
            if (e.KeyCode == Keys.N)
            {
                if (playsounds == 0)
                {
                    playsounds = 1;
                    labelsoundtoggle.Text = "ON";
                    Play(Application.StartupPath + "Sounds\\collectcoin.wav");
                    return;
                }
                if (playsounds == 1)
                {
                    playsounds = 0;
                    labelsoundtoggle.Text = "OFF";
                    return;
                }
            }
            if (e.KeyCode == Keys.R)
            {
                distancerecord = 0;
                Writerecord();
                Readrecord();
            }
        }
    }
}