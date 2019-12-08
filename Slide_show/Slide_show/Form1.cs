using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Slide_show
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer startsoundplayer = new System.Media.SoundPlayer(@"C:\Users\Personal\Downloads\Music\01.Bruce.Lynch.&.Douglas.Sloan.Power.Rangers.Dino.Thunder.Main.Theme-[CRS][61C9FFA3].wav");
        //PictureBox pb;
        //int a;
        //object o;
        //EventArgs e1;
        public Form1()
        {
            InitializeComponent();
            startsoundplayer.Play();
            
        }
        private static int image_number = 2;
        private void nextimage()
        {
            if (image_number == 13)
            {
                image_number = 2;
            }
            else
            {
                image_number = image_number + 1;
                slideshow(image_number);
            }
        }
        private void slideshow(int image_number)
        {
            
            picture.ImageLocation = string.Format(@"Images\{0}.jpg",image_number);
            //pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            image_number++;
            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nextimage();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // pb.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (image_number == 13)
            {
                image_number = 2;
            }
            else
            {
                image_number = image_number + 1;
                slideshow(image_number);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (image_number == 2)
            {
                image_number = 13;
                slideshow(image_number);
            }
            else
            {
                image_number = image_number - 1;
                slideshow(image_number);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void picture_ContextMenuStripChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            startsoundplayer.Stop();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            startsoundplayer.Stop();
            this.Dispose();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            startsoundplayer.Stop();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            startsoundplayer.Stop();
            this.Dispose();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            startsoundplayer.Play();
        }

        private void startToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            startsoundplayer.Play();
        }
    }
}
