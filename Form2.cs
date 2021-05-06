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

        void IlkProfil() 
        {
            basarimkazanildi.Text = "Başarım Kazanıldı";
            basarimadi.Text = "İlk Profil";
            basarimaciklamasi.Text = "İlk kez bir profili görüntüleyin.";

            basarimgidiyor.Start();
                
            File.Create(@"AchievementsData\IlkProfil.mcloginachievement");
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.user;

            this.handlers = default(Class1.EventHandlers);
            Class1.Initialize("814431076712710174", ref this.handlers, true, null);
            this.handlers = default(Class1.EventHandlers);
            Class1.Initialize("814431076712710174", ref this.handlers, true, null);
            this.presence.details = "Profile Bakıyor...";
            this.presence.state = "" +Form1.user+ "";
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

            if (Directory.Exists("AchievementsData"))
            {
                if (File.Exists(@"AchievementsData\IlkProfil.mcloginachievement"))
                {
                    
                }
                else
                {
                    IlkProfil();
                }
            }
            else
            {
                Directory.CreateDirectory("AchievementsData");
                IlkProfil();
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
            if (Directory.Exists(@"C:\MCLoginDownloadedAvatars"))
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://minecraftskinstealer.com/api/v1/skin/download/skin/" + label2.Text + "", @"C:\MCLoginDownloadedAvatars\" + Form1.user + "_Skin.png");

                AvatarIndirildi indirildi = new AvatarIndirildi();
                indirildi.Show();
            }
            else
            {
                Directory.CreateDirectory(@"C:\MCLoginDownloadedAvatars");


                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://minecraftskinstealer.com/api/v1/skin/download/skin/" + label2.Text + "", @"C:\MCLoginDownloadedAvatars\" + Form1.user + "_Skin.png");

                AvatarIndirildi indirildi = new AvatarIndirildi();
                indirildi.Show();
            }
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
            if (Directory.Exists(@"C:\MCLoginDownloadedAvatars"))
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://minecraftskinstealer.com/api/v1/skin/download/face/" + Form1.user + "", @"C:\MCLoginDownloadedAvatars\" + Form1.user + "_Face_Avatar.png");

                AvatarIndirildi indirildi = new AvatarIndirildi();
                indirildi.Show();
            }
            else
            {
                Directory.CreateDirectory(@"C:\MCLoginDownloadedAvatars");


                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://minecraftskinstealer.com/api/v1/skin/download/face/" + Form1.user + "", @"C:\MCLoginDownloadedAvatars\" + Form1.user + "_Face_Avatar.png");

                AvatarIndirildi indirildi = new AvatarIndirildi();
                indirildi.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\MCLoginDownloadedAvatars"))
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://minecraftskinstealer.com/api/v1/skin/download/cube/" + Form1.user + "", @"C:\MCLoginDownloadedAvatars\" + Form1.user + "_Cube_Head_Avatar.png");

                AvatarIndirildi indirildi = new AvatarIndirildi();
                indirildi.Show();
            }
            else
            {
                Directory.CreateDirectory(@"C:\MCLoginDownloadedAvatars");


                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://minecraftskinstealer.com/api/v1/skin/download/cube/" + Form1.user + "", @"C:\MCLoginDownloadedAvatars\" + Form1.user + "_Cube_Head_Avatar.png");

                AvatarIndirildi indirildi = new AvatarIndirildi();
                indirildi.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\MCLoginDownloadedAvatars"))
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://minecraftskinstealer.com/api/v1/skin/download/bust/" + Form1.user + "", @"C:\MCLoginDownloadedAvatars\" + Form1.user + "_Bust_Avatar.png");

                AvatarIndirildi indirildi = new AvatarIndirildi();
                indirildi.Show();
            }
            else
            {
                Directory.CreateDirectory(@"C:\MCLoginDownloadedAvatars");


                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://minecraftskinstealer.com/api/v1/skin/download/bust/" + Form1.user + "", @"C:\MCLoginDownloadedAvatars\" + Form1.user + "_Bust_Avatar.png");

                AvatarIndirildi indirildi = new AvatarIndirildi();
                indirildi.Show();
            }
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
                button1.ForeColor = SystemColors.Control;
                button2.ForeColor = SystemColors.Control;
                button3.ForeColor = SystemColors.Control;
                button4.ForeColor = SystemColors.Control;
                button8.ForeColor = SystemColors.Control;
                button6.ForeColor = SystemColors.Control;
                button7.ForeColor = SystemColors.Control;
                button8.ForeColor = SystemColors.Control;
                button9.ForeColor = SystemColors.Control;
                button10.ForeColor = SystemColors.Control;
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
                button1.ForeColor = Color.Black;
                button2.ForeColor = Color.Black;
                button3.ForeColor = Color.Black;
                button4.ForeColor = Color.Black;
                button8.ForeColor = Color.Black;
                button6.ForeColor = Color.Black;
                button7.ForeColor = Color.Black;
                button8.ForeColor = Color.Black;
                button9.ForeColor = Color.Black;
                button10.ForeColor = Color.Black;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var request = WebRequest.Create("https://minotar.net/armor/body/" +Form1.user+ "/100.png" + label2.Text + "/190.png");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox5.Image = Bitmap.FromStream(stream);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\MCLoginDownloadedAvatars"))
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://minecraftskinstealer.com/api/v1/skin/download/body/" + Form1.user + "", @"C:\MCLoginDownloadedAvatars\" + Form1.user + "_Body_Avatar.png");

                AvatarIndirildi indirildi = new AvatarIndirildi();
                indirildi.Show();
            }
            else
            {
                Directory.CreateDirectory(@"C:\MCLoginDownloadedAvatars");


                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://minecraftskinstealer.com/api/v1/skin/download/body/" + Form1.user + "", @"C:\MCLoginDownloadedAvatars\" + Form1.user + "_Body_Avatar.png");

                AvatarIndirildi indirildi = new AvatarIndirildi();
                indirildi.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                this.TopMost = true;
            }

            if (checkBox1.Checked == false)
            {
                this.TopMost = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
                label1.Text = "Logined";
                linkLabel1.Text = "Login a different account";
                button5.Text = "Copy Name";
                mod.Text = "Dark Theme";
                checkBox1.Text = "Pin Window";
                button12.Text = "Square monitor mode";
                karemodcik.Text = "Exit Square monitor mode";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            english.Text = "English";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            english.Text = "Turkce";
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Giriş yapıldı";
            linkLabel1.Text = "Başka bir hesaba giriş yap";
            button5.Text = "Adi Kopyala";
            mod.Text = "Karanlik Mod";
            checkBox1.Text = "Sabitle";
            button12.Text = "Kare Monitor Modu";
            karemodcik.Text = "Kare monitor modundan cik";
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
            WindowState = FormWindowState.Maximized;
        }

        private void adıKopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("" + Form1.user + "");
        }

        private void generateFaceAvatarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var request = WebRequest.Create("https://cravatar.eu/helmavatar/" + label2.Text + "/190.png");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox1.Image = Bitmap.FromStream(stream);
            }
        }

        private void generateBustAvatarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var request = WebRequest.Create("https://minotar.net/armor/bust/" + label2.Text + "/190.png");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox2.Image = Bitmap.FromStream(stream);
            }
        }

        private void generateCubeHeadAvatarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var request = WebRequest.Create("https://cravatar.eu/helmhead/" + label2.Text + "/190.png");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox3.Image = Bitmap.FromStream(stream);
            }
        }

        private void generateBodyAvatarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var request = WebRequest.Create("https://minotar.net/armor/body/" + Form1.user + "/100.png" + label2.Text + "/190.png");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox5.Image = Bitmap.FromStream(stream);
            }
        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turkce.PerformClick();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            english.PerformClick();
        }

        private void downloadBodyAvatarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button9.PerformClick();
        }

        private void downloadFaceAvatarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button6.PerformClick();
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button8.PerformClick();
        }

        private void downloadCubeHeadAvatarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button7.PerformClick();
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click_2(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void mLGOlarakKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog opf = new SaveFileDialog();
            opf.Title = "MLG Olarak Kaydet";
            opf.Filter = "MCLogin Profili Dosyası|*.mlg";
            opf.DefaultExt = "mlg";
            opf.FileName = "" + Form1.user + "";
            if (opf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(opf.FileName, Form1.user, Encoding.Default);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            IlkProfil();
        }

        private void basarimgidiyor_Tick(object sender, EventArgs e)
        {
            basarimkazanildi.Text = "";
            basarimadi.Text = "";
            basarimaciklamasi.Text = "";

            basarimgidiyor.Stop();
        }
    }
}
