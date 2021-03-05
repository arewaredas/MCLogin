using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmlLib.Launcher;
using CmlLib.Utils;
using CmlLib;

namespace MC_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string user;
        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Minecraft Username")
            {
                username.ForeColor = Color.Black;
                username.Text = "";
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.ForeColor = Color.Gray;
                username.Text = "Minecraft Username";
            }

            if (username.Text == " ")
            {
                username.ForeColor = Color.Gray;
                MessageBox.Show("Kullanıcı adı boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (username.Text == "  ")
            {
                username.ForeColor = Color.Gray;
                MessageBox.Show("Kullanıcı adı boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (username.Text == "   ")
            {
                username.ForeColor = Color.Gray;
                MessageBox.Show("Kullanıcı adı boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (username.Text == "    ")
            {
                username.ForeColor = Color.Gray;
                MessageBox.Show("Kullanıcı adı boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (username.Text == "     ")
            {
                username.ForeColor = Color.Gray;
                MessageBox.Show("Kullanıcı adı boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = username.Text;
            if (username.Text == "Minecraft Username")
            {
                MessageBox.Show("Kullanıcı adı boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.speddyaredas.cf");
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
