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

namespace MC_Login
{
    public partial class OturumAç : Form
    {
        public OturumAç()
        {
            InitializeComponent();
        }
        public static string kullaniciadi;
        public static string sifre;
        private void OturumAç_Load(object sender, EventArgs e)
        {

        }

        private static void hesabiOlustur()
        {
            string dosya_yolu = @"hesap\username.txt";
            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            StreamWriter sw = new StreamWriter(fs);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            sw.WriteLine(kullaniciadi);
            //Dosyaya ekleyeceğimiz iki satırlık yazıyı WriteLine() metodu ile yazacağız.
            sw.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
        }

        private static void sifreyiOlustur()
        {
            string dosya_yolu = @"hesap\sifre.txt";
            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            StreamWriter sw = new StreamWriter(fs);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            sw.WriteLine(sifre);
            //Dosyaya ekleyeceğimiz iki satırlık yazıyı WriteLine() metodu ile yazacağız.
            sw.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == " " || textBox1.Text == "  " || textBox1.Text == "   " || textBox1.Text == "    " || textBox1.Text == "     " || textBox1.Text == "      " || textBox1.Text == "       " || textBox1.Text == "        " || textBox1.Text == "         " || textBox1.Text == "          " || textBox1.Text == "           " || textBox1.Text == "            " || textBox1.Text == "             " || textBox1.Text == "              " || textBox1.Text == "               " || textBox1.Text == "                " || textBox1.Text == "Minecraft Username")
            {
                MessageBox.Show("Kullanıcı adı olmayan bir hesap oluşturmak, hiç deneme bence.");
            }
            else
            {
                Directory.CreateDirectory("hesap");

                FileStream kullaniciadiolusturma = File.Create(@"hesap\username.txt");
                kullaniciadiolusturma.Close();

                hesabiOlustur();

                FileStream sifreolusturma = File.Create(@"hesap\password.txt");
                sifreolusturma.Close();

                sifreyiOlustur();
            }
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void OturumAç_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            kullaniciadi = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sifre = textBox2.Text;
        }
    }
}
