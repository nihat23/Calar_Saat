using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Çalar_Saat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int r, g, b;
        Random karisik = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = false;
            label2saat.Text = System.DateTime.Now.ToLongTimeString();
            label3tarih.Text = System.DateTime.Now.ToLongDateString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2saat.Text = System.DateTime.Now.ToLongTimeString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text == label2saat.Text)
            {
                axWindowsMediaPlayer1.URL =Application.StartupPath +"\\calarsaat.wav";
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }

            if (textBox2.Text == label2saat.Text)
            {

                System.Diagnostics.Process.Start("shutdown", "-f -s -t 1");
            }

        }

        private void button1AlarmKur_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            textBox1.Enabled = false;

        }

        private void button2Alarmdurdur_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Clear();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/n.beyi");
        }

        private void button5iptal_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            textBox2.Enabled = true;
        }

        private void button3PcKapat_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            textBox2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            r = karisik.Next(0, 255);
            g = karisik.Next(0, 255);
            b = karisik.Next(0, 255);
            this.BackColor = Color.FromArgb(r, g, b);
            button1AlarmKur.BackColor = Color.FromArgb(r, g, b);
            button2Alarmdurdur.BackColor = Color.FromArgb(r, g, b);
            button3PcKapat.BackColor = Color.FromArgb(r, g, b);
            button5iptal.BackColor = Color.FromArgb(r, g, b);
            button4.BackColor = Color.FromArgb(r, g, b);

        }
    }
}
