using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRpcDemo;
//using KrnlAPI;
//using WeAreDevs_API;
//using Anemo_API;
//using CheatSquad_API;

// Since I quit all this shit is open source and free to use go ahead skid it :)

namespace CoreXecutor
{
    public partial class CoreX : Form
    {
        //ExploitAPI moduel = new ExploitAPI();
        private SoundPlayer Attention;
        private SoundPlayer Active;
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        Point lastPoint;

        public CoreX()
        {
            InitializeComponent();
            Attention = new SoundPlayer("Dependencies/SFX/Attention.wav");
            Active = new SoundPlayer("Dependencies/SFX/Active.wav");
        }

        private void CoreX_Load(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("943249388829048903", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("943249388829048903", ref this.handlers, true, null);
            this.presence.details = "CoreX v1.4";
            this.presence.state = "Cheating In Roblox";
            this.presence.largeImageKey = "core_big";
            this.presence.smallImageKey = "core_small";
            this.presence.largeImageText = "v1.4";
            this.presence.smallImageText = "CoreX";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Attention.Play();
            string message = "Are you sure you want to repair? (This Requires a Restart)";
            string title = "Repair CoreX";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
                Application.Exit();

                //the fix code has been deleted lmao
            }
            else
            {
                //do nothing
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //bruh website go here
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Attention.Play();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Attention.Play();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Active.Play();
            fastColoredTextBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Active.Play();

            if (WeAreDevs.Checked == true)
            {
                //moduel.LaunchExploit();
            }

            else if (KRNL.Checked == true)
            {
                //MainAPI.Inject();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Active.Play();

            if (WeAreDevs.Checked == true)
            {
                //moduel.SendLuaScript(fastColoredTextBox1.Text);
            }

            else if (KRNL.Checked == true)
            {
               // MainAPI.Execute(fastColoredTextBox1.Text);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Scope03");
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/corexhub");
        }
    }
}
