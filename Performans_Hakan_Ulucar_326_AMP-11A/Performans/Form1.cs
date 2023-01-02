using System.Numerics;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Performans
{
    public partial class Form1 : Form
    {
        /*
         * karakterlerin forma biti�i ba�lamas�n� istemedi�im i�in de�i�eknlere 0 atamad�m
         * 3 tane random atad�m ve bu radomlardan gelen say�y� x,y ve z de�i�kenlerinin i�ine koydum
         * karakterlerin ka�ar ka�ar ilerieyece�ini bu sayede hesaplad�m
         */
        int a = 12;
        int b = 12;
        int c = 12;
        Random rnd_1 = new Random();
        Random rnd_2 = new Random();
        Random rnd_3 = new Random();
        
        /* karakterleri insan olarak d���nd�m
         * bir insan ko�arken insandan insana hem att��� ad�mlar�n h�z� hemde att��� ad�mlar�n geni�li�i h�zda etken rol oynar
         * bu y�zden her kisinide random bir �ekilde yapt�m
        */

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // label 1 ba�ta g�r�nt� kirlili�i yapmas�n diye g�r�n�rl���n� kapatt�m
            label1.Visible = false;
        }
        /*  4 adet timer kulland�m
         *  ��'�ne random hz� atad�m 
         *  bir'inide zaman� g�stersin diye kulland�m
        */
        int p = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
             * 1000 koordinat�n� biti� olarak belirledim
             * a de�iskeni 1000 de�ilse x de�i�kenine random bir say� atay�p a ile toplad�m
             * ilk �nce 1000 koordinat�na hangi karakter ula��rsa b�t�n timerleri durdurdum
             * yar��� kazanan� messagebox'�n i�ine yazd�rtt�m
             * ve b�t�n timerler i�in ayn� kodu yazd�m
             */
            int x = rnd_1.Next(0, 6);
            if (a > 1000)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                button4.Visible = true;
                button5.Visible = true;
                MessageBox.Show("Sonik yar��� kazand�..");
                if (j == 1)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    timer3.Enabled = false;
                    timer4.Enabled = false;
                    MessageBox.Show(""+"do�ru bildiniz..");
                }else
                {
                    MessageBox.Show("tahmininiz yanl��...");
                }

               

            }
            else
            {
                a += x;
                pictureBox1.SetBounds(a, 183, 173, 150);
            }

            p++;
            if (p == 1)
            {
                pictureBox1.Image = Properties.Resources.S1;
            }else if (p == 2)
            {
                pictureBox1.Image = Properties.Resources.S2;
            }else if (p == 3)
            {
                pictureBox1.Image = Properties.Resources.S3;
            }else if (p == 4)
            {
                pictureBox1.Image = Properties.Resources.S4;
            }else if (p > 4) p = 0;
        }

        int f = 0;


        private void timer2_Tick(object sender, EventArgs e)
        {

            int y = rnd_2.Next(0, 6);
            if (b > 1000)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                button4.Visible = true;
                button5.Visible = true;
                MessageBox.Show("S�per mario yar��� kazand�..");
                if (j == 2)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    timer3.Enabled = false;
                    timer4.Enabled = false;
                    MessageBox.Show("" + "do�ru bildiniz..");
                }
                else
                {
                    MessageBox.Show("tahmininiz yanl��...");
                }
            }
            else
            {
                b += y;
                pictureBox2.SetBounds(b, 339, 173, 150);
            }

            f++;
            if (f == 1)
            {
                pictureBox2.Image = Properties.Resources.Mario_1;
            }else if (f == 2)
            {
                pictureBox2.Image = Properties.Resources.Mario2;
            }else if (f > 2) f = 0;

        }
        int n = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {

            int z = rnd_3.Next(0, 6);
            if (c > 1000)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                button4.Visible = true;
                button5.Visible = true;
                MessageBox.Show("Spiderman yar��� kazand�..");
                if (j == 3)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    timer3.Enabled = false;
                    timer4.Enabled = false;
                    MessageBox.Show("" + "do�ru bildiniz..");
                }
                else
                {
                    MessageBox.Show("tahmininiz yanl��...");
                }


            }
            else
            {
                c += z;
                pictureBox3.SetBounds(c, 495, 173, 150);
            }

            n++;
            if (n == 1)
            {
                pictureBox3.Image = Properties.Resources.Spyd�rman1;
            }else if (n == 2)
            {
                pictureBox3.Image = Properties.Resources.Spyd�rman2;
            }else if (n == 3)
            {
                pictureBox3.Image = Properties.Resources.Spyd�rman3;
            }else if (n > 3) n = 0;

        }


        int j = 0;

        /*
         * butonlar�n i�inde timerleri aktifle�tirip timerlere random de�erler atad�m bu random de�erleride timerlerin h�z� yapt�m
         * labeli g�r�n�r yapt�m ve butonlar� g�r�nmez yapt�m
         * bu i�lemleri b�t�n butonlar i�in tekrarlad�m
         */
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;

            timer4.Enabled = true;

            timer1.Enabled = true;
            int ms1 = rnd_1.Next(50, 100);
            timer1.Interval = ms1;
            pictureBox1.SetBounds(a, 183, 173, 150);

            timer2.Enabled = true;
            int ms2 = rnd_2.Next(50, 100);
            timer2.Interval = ms2;
            pictureBox2.SetBounds(b, 339, 173, 150);

            timer3.Enabled = true;
            int ms3 = rnd_3.Next(50, 100);
            timer3.Interval = ms3;
            pictureBox3.SetBounds(c, 495, 173, 150);
            j++;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;

            timer4.Enabled = true;

            timer1.Enabled = true;
            int ms1 = rnd_1.Next(50, 100);
            timer1.Interval = ms1;
            pictureBox1.SetBounds(a, 183, 173, 150);

            timer2.Enabled = true;
            int ms2 = rnd_2.Next(50, 100);
            timer2.Interval = ms2;
            pictureBox2.SetBounds(b, 339, 173, 150);

            timer3.Enabled = true;
            int ms3 = rnd_3.Next(50, 100);
            timer3.Interval = ms3;
            pictureBox3.SetBounds(c, 495, 173, 150);
            j += 2;
           
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;

            timer4.Enabled = true;

            timer1.Enabled = true;
            int ms1 = rnd_1.Next(50, 100);
            timer1.Interval = ms1;
            pictureBox1.SetBounds(a, 183, 173, 150);

            timer2.Enabled = true;
            int ms2 = rnd_2.Next(50, 100);
            timer2.Interval = ms2;
            pictureBox2.SetBounds(b, 339, 173, 150);

            timer3.Enabled = true;
            int ms3 = rnd_3.Next(50, 100);
            timer3.Interval = ms3;
            pictureBox3.SetBounds(c, 495, 173, 150);
            j += 3;
            button1.Enabled=false;
            button2.Enabled=false;
            button3.Enabled=false;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }
        int zmn = 0;
        // zaman� g�stermek i�in timer4 � kulland�m
        private void timer4_Tick(object sender, EventArgs e)
        {
            
            zmn++;
            label1.Text=zmn.ToString();
            if (a >= 1000 || b >= 1000 || c >= 1000)
            {
                zmn = 0;
            }
        }
      
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            label1.Text = "";
            pictureBox1.Left = label2.Right;
            pictureBox2.Left = label3.Right;
            pictureBox3.Left = label4.Right;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            a = 12;
            b = 12;
            c = 12;
            button4.Visible = false;
            button5.Visible = false;
            j=0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
