using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CmlLib.Launcher;
using CmlLib.Utils;
using CmlLib;
using System.Diagnostics;
using System.Net;

namespace MC_Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private Class1.EventHandlers handlers;
        private Class1.RichPresence presence;


        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.user;

            this.handlers = default(Class1.EventHandlers);
            Class1.Initialize("814431076712710174", ref this.handlers, true, null);
            this.handlers = default(Class1.EventHandlers);
            Class1.Initialize("814431076712710174", ref this.handlers, true, null);
            this.presence.details = "MCLogin'de!";
            this.presence.state = "Profile Bakıyor...";
            this.presence.largeImageKey = "mclogin";
            this.presence.smallImageKey = "None";
            this.presence.largeImageText = "MCLogin";
            Class1.UpdatePresence(ref this.presence);


            var request = WebRequest.Create("https://minecraftskinstealer.com/api/v1/skin/render/fullbody/" +Form1.user+ "/700");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox4.Image = Bitmap.FromStream(stream);
            }
        
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var request = WebRequest.Create("https://cravatar.eu/helmavatar/" +label2.Text+ "/190.png");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox1.Image = Bitmap.FromStream(stream);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                        var request = WebRequest.Create("https://minotar.net/armor/bust/" + label2.Text + "/190.png");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox2.Image = Bitmap.FromStream(stream);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var request = WebRequest.Create("https://cravatar.eu/helmhead/" +label2.Text+ "/190.png");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox3.Image = Bitmap.FromStream(stream);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://minecraftskinstealer.com/api/v1/skin/download/skin/" +label2.Text+ "");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText("" +Form1.user+ "");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://minecraftskinstealer.com/api/v1/skin/download/face/" + Form1.user + "");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://minecraftskinstealer.com/api/v1/skin/download/cube/" +Form1.user+ "");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://minecraftskinstealer.com/api/v1/skin/download/bust/" + Form1.user + "");
        }

        private void mod_CheckedChanged(object sender, EventArgs e)
        {
            if (mod.Checked == true)
            {
                // Hex Kodu
                this.BackColor = System.Drawing.ColorTranslator.FromHtml("#232324");
                // Desimal Kodu
                this.BackColor = System.Drawing.Color.FromArgb(35, 35, 36);

                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
            }
            if (mod.Checked == false)
            {
                this.BackColor = SystemColors.Control;

                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var request = WebRequest.Create("https://minotar.net/body/" +Form1.user+ "/100.png" + label2.Text + "/190.png");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox5.Image = Bitmap.FromStream(stream);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://minecraftskinstealer.com/api/v1/skin/download/body/" + Form1.user + "");
        }
    }
}
