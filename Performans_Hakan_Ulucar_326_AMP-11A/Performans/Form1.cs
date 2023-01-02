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
         * karakterlerin forma bitiþi baþlamasýný istemediðim için deðiþeknlere 0 atamadým
         * 3 tane random atadým ve bu radomlardan gelen sayýyý x,y ve z deðiþkenlerinin içine koydum
         * karakterlerin kaçar kaçar ilerieyeceðini bu sayede hesapladým
         */
        int a = 12;
        int b = 12;
        int c = 12;
        Random rnd_1 = new Random();
        Random rnd_2 = new Random();
        Random rnd_3 = new Random();
        
        /* karakterleri insan olarak düþündüm
         * bir insan koþarken insandan insana hem attýðý adýmlarýn hýzý hemde attýðý adýmlarýn geniþliði hýzda etken rol oynar
         * bu yüzden her kisinide random bir þekilde yaptým
        */

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // label 1 baþta görüntü kirliliði yapmasýn diye görünürlüðünü kapattým
            label1.Visible = false;
        }
        /*  4 adet timer kullandým
         *  üç'üne random hzý atadým 
         *  bir'inide zamaný göstersin diye kullandým
        */
        int p = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
             * 1000 koordinatýný bitiþ olarak belirledim
             * a deðiskeni 1000 deðilse x deðiþkenine random bir sayý atayýp a ile topladým
             * ilk önce 1000 koordinatýna hangi karakter ulaþýrsa bütün timerleri durdurdum
             * yarýþý kazananý messagebox'ýn içine yazdýrttým
             * ve bütün timerler için ayný kodu yazdým
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
                MessageBox.Show("Sonik yarýþý kazandý..");
                if (j == 1)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    timer3.Enabled = false;
                    timer4.Enabled = false;
                    MessageBox.Show(""+"doðru bildiniz..");
                }else
                {
                    MessageBox.Show("tahmininiz yanlýþ...");
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
                MessageBox.Show("Süper mario yarýþý kazandý..");
                if (j == 2)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    timer3.Enabled = false;
                    timer4.Enabled = false;
                    MessageBox.Show("" + "doðru bildiniz..");
                }
                else
                {
                    MessageBox.Show("tahmininiz yanlýþ...");
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
                MessageBox.Show("Spiderman yarýþý kazandý..");
                if (j == 3)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    timer3.Enabled = false;
                    timer4.Enabled = false;
                    MessageBox.Show("" + "doðru bildiniz..");
                }
                else
                {
                    MessageBox.Show("tahmininiz yanlýþ...");
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
                pictureBox3.Image = Properties.Resources.Spydýrman1;
            }else if (n == 2)
            {
                pictureBox3.Image = Properties.Resources.Spydýrman2;
            }else if (n == 3)
            {
                pictureBox3.Image = Properties.Resources.Spydýrman3;
            }else if (n > 3) n = 0;

        }


        int j = 0;

        /*
         * butonlarýn içinde timerleri aktifleþtirip timerlere random deðerler atadým bu random deðerleride timerlerin hýzý yaptým
         * labeli görünür yaptým ve butonlarý görünmez yaptým
         * bu iþlemleri bütün butonlar için tekrarladým
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
        // zamaný göstermek için timer4 ü kullandým
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
