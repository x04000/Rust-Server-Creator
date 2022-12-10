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
using System.Diagnostics;
using System.Threading;
using System.Net;
using System.Drawing.Text;

namespace RSC
{
    public partial class Form1 : Form
    {
        public static class Global
        {
            public static string version;
            public static string configfile;
        }
        public void Updater()
        {
            WebRequest request = WebRequest.Create("https://raw.githubusercontent.com/x04000/Rust-Server-Creator/main/RSC/version");
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            StreamWriter pw = new StreamWriter(@"RSC\lastestversion");
            pw.WriteLine(responseFromServer);
            pw.Close();
            StreamReader src = new StreamReader(@"RSC\lastestversion");
            string lastestversion = src.ReadLine();
            src.Close();
            File.Delete(@"RSC\lastestversion");
            if (lastestversion == Global.version)
            {
                // RSC Is updated :D
            }
            else
            {
                MessageBox.Show("RSC is not updated :( | You can update them in Installer > Update RSC", "Rust Server Creator",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        public void WriteDefaultValues()
        {
            Random rdnc = new Random();
            string charsc = "23456789";
            int lengthc = charsc.Length;
            char randchars;
            int numcharsc = 1;
            string randnumchars = string.Empty;
            for (int i = 0; i < numcharsc; i++)
            {
                randchars = charsc[rdnc.Next(lengthc)];
                randnumchars += randchars.ToString();
            }
            Random rdn = new Random();
            string chars = "1234567890";
            int length = chars.Length;
            char randseed;
            int randnumchars1 = Convert.ToInt32(randnumchars);
            int numchars = randnumchars1;
            string seed = string.Empty;
            for (int i = 0; i < numchars; i++)
            {
                randseed = chars[rdn.Next(length)];
                seed += randseed.ToString();
            }
            StreamWriter sw = new StreamWriter(Global.configfile);
            sw.WriteLine("Default Server");
            sw.WriteLine("Default Description");
            sw.WriteLine("https://yourweb.com");
            sw.WriteLine("https://yourweb.com/header.png");
            sw.WriteLine(seed);
            sw.WriteLine("2500");
            sw.WriteLine("1");
            sw.WriteLine("0.0.0.0");
            sw.WriteLine("28015");
            sw.WriteLine("0.0.0.0");
            sw.WriteLine("28016");
            sw.WriteLine("12345");
            sw.WriteLine("Procedural Map");
            sw.Close();
        }
        public void RSCFont()
        {
            if (File.Exists(@"RSC\Rust_Font.ttf") == true)
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile(@"RSC\Rust_Font.ttf");
                label1.Font = new Font(pfc.Families[0], 38);
                label2.Font = new Font(pfc.Families[0], 8);
                label3.Font = new Font(pfc.Families[0], 8);
                button1.Font = new Font(pfc.Families[0], 9);
                button2.Font = new Font(pfc.Families[0], 7);
                button3.Font = new Font(pfc.Families[0], 7);
                button4.Font = new Font(pfc.Families[0], 7);
                button5.Font = new Font(pfc.Families[0], 7);
                button6.Font = new Font(pfc.Families[0], 9);
                button7.Font = new Font(pfc.Families[0], 7);
                panel.Font = new Font(pfc.Families[0], 8);
            }
            if (File.Exists(@"RSC\Valorant_Font.ttf") == true)
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile(@"RSC\Valorant_Font.ttf");
                comboBox1.Font = new Font(pfc.Families[0], 12);
                label4.Font = new Font(pfc.Families[0], 8, FontStyle.Bold);
            }
        }

        public Form1()
        {
            InitializeComponent();
            Global.version = "v.1.2.2.3";
            label4.Text = Global.version;
            if (Directory.Exists("RSC") == false) { Directory.CreateDirectory("RSC"); }
            if (File.Exists(@"RSC\config") == false) {
                StreamWriter swc = new StreamWriter(@"RSC\config");
                swc.WriteLine("server1");
                swc.Close();
            }
            if (File.Exists(@"RSC\config1") == false) {
                Global.configfile = @"RSC\config1";
                WriteDefaultValues();
            }
            if (File.Exists(@"RSC\config2") == false)
            {
                Global.configfile = @"RSC\config2";
                WriteDefaultValues();
            }
            if (File.Exists(@"RSC\config3") == false)
            {
                Global.configfile = @"RSC\config3";
                WriteDefaultValues();
            }
            if (File.Exists(@"RSC\config4") == false)
            {
                Global.configfile = @"RSC\config4";
                WriteDefaultValues();
            }
            if (File.Exists(@"RSC\config5") == false)
            {
                Global.configfile = @"RSC\config5";
                WriteDefaultValues();
            }
            if (File.Exists(@"RSC\Rust_Font.ttf") == false)
            {
                Process.Start("cmd.exe", @"/k @echo off && title RSC Font Downloader && powershell curl https://github.com/x04000/Rust-Server-Creator/raw/main/RSC/Rust_Font.ttf -o RSC\Rust_Font.ttf && exit");
            }
            if (File.Exists(@"RSC\Valorant_Font.ttf") == false)
            {
                Process.Start("cmd.exe", @"/k @echo off && title RSC Font Downloader && powershell curl https://github.com/x04000/Rust-Server-Creator/raw/main/RSC/Valorant_Font.ttf -o RSC\Valorant_Font.ttf && exit");
                Thread.Sleep(2000);
            }
            Updater();
            RSCFont();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) { activeForm.Close(); }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader src = new StreamReader(@"RSC\config");
            string configfile = src.ReadLine();
            src.Close();
            string serverfile = configfile;
            if (configfile == "server1") { configfile = "config1"; }
            if (configfile == "server2") { configfile = "config2"; }
            if (configfile == "server3") { configfile = "config3"; }
            if (configfile == "server4") { configfile = "config4"; }
            if (configfile == "server5") { configfile = "config5"; }
            configfile = @"RSC\"+configfile;
            StreamReader sr = new StreamReader(configfile);
            string Name = sr.ReadLine();
            string Description = sr.ReadLine();
            string URL = sr.ReadLine();
            string Header = sr.ReadLine();
            string SEED = sr.ReadLine();
            string Size = sr.ReadLine();
            string Maxplayers = sr.ReadLine();
            string IP = sr.ReadLine();
            string Port = sr.ReadLine();
            string Rconip = sr.ReadLine();
            string Rconport = sr.ReadLine();
            string Rconpassword = sr.ReadLine();
            string Map = sr.ReadLine();
            sr.Close();
            if (File.Exists(@"rust_server\RustDedicated.exe") == true)
            {
                string parameters = "-batchmode +server.hostname \""+Name+"\" +server.description \""+Description+"\" +server.url \""+URL+"\" +server.headerimage \""+Header+"\" +server.seed "+SEED+" +server.worldsize "+Size+" +server.maxplayers "+Maxplayers+" +server.ip "+IP+" +server.port "+Port+" +rcon.ip "+Rconip+" +rcon.port "+Rconport+" +rcon.password "+Rconpassword+" +server.level \""+Map+"\" +server.saveinterval 3600 +server.identity \""+serverfile+"\" -cfg \"server"+@"\"+serverfile+@"\cfg\server.cfg"+"\" -logFile \""+serverfile+"_log.txt\"";
                Process.Start("cmd.exe", "/k @echo off && title RSC - Server Console && color 5 && cd rust_server && start RustDedicated.exe "+parameters+" && exit");
            }
            else
            {
                MessageBox.Show("RustDedicated is not installed :(", "Rust Server Creator",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            openChildForm(config);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "server1") {
                StreamWriter swc = new StreamWriter(@"RSC\config");
                swc.WriteLine("server1");
                swc.Close();
            }
            if (comboBox1.Text == "server2")
            {
                StreamWriter swc = new StreamWriter(@"RSC\config");
                swc.WriteLine("server2");
                swc.Close();
            }
            if (comboBox1.Text == "server3")
            {
                StreamWriter swc = new StreamWriter(@"RSC\config");
                swc.WriteLine("server3");
                swc.Close();
            }
            if (comboBox1.Text == "server4")
            {
                StreamWriter swc = new StreamWriter(@"RSC\config");
                swc.WriteLine("server4");
                swc.Close();
            }
            if (comboBox1.Text == "server5")
            {
                StreamWriter swc = new StreamWriter(@"RSC\config");
                swc.WriteLine("server5");
                swc.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Installer installer = new Installer();
            openChildForm(installer);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"rust_server\oxide\plugins\disabled") == true)
            {
                Plugins plugins = new Plugins();
                openChildForm(plugins);
            }
            else 
            {
                MessageBox.Show("Plugin folder doesn't exists :(", "Rust Server Creator",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader src = new StreamReader(@"RSC\config");
            string configfile = src.ReadLine();
            src.Close();
            DialogResult wipeconfirm;
            wipeconfirm = MessageBox.Show("Are you sure you want to full wipe "+configfile+"?", "Rust Server Creator",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
            if (wipeconfirm == DialogResult.Yes)
            {
                if (Directory.Exists(@"rust_server\server\"+configfile+"") == true)
                {
                    string[] files = Directory.GetFiles(@"rust_server\server\"+configfile, "*.db");
                    foreach (var file in files)
                    {
                        File.Delete(file);
                    }
                    string[] files1 = Directory.GetFiles(@"rust_server\server\"+configfile, "*.db-*");
                    foreach (var file1 in files1)
                    {
                        File.Delete(file1);
                    }
                    string[] files2 = Directory.GetFiles(@"rust_server\server\"+configfile, "*.map");
                    foreach (var file2 in files2)
                    {
                        File.Delete(file2);
                    }
                    string[] files3 = Directory.GetFiles(@"rust_server\server\"+configfile, "*.sav");
                    foreach (var file3 in files3)
                    {
                        File.Delete(file3);
                    }
                    string[] files4 = Directory.GetFiles(@"rust_server\server\"+configfile, "*.sav.*");
                    foreach (var file4 in files4)
                    {
                        File.Delete(file4);
                    }
                    MessageBox.Show(configfile+" has been fully wiped sucessfully :D", "Rust Server Creator",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(configfile+" folder doesn't exists :(", "Rust Server Creator",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wipe operation cancelled :D", "Rust Server Creator",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamReader src = new StreamReader(@"RSC\config");
            string configfile = src.ReadLine();
            src.Close();
            DialogResult wipeconfirm;
            wipeconfirm = MessageBox.Show("Are you sure you want to wipe "+configfile+"?", "Rust Server Creator",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
            if (wipeconfirm == DialogResult.Yes)
            {
                if (Directory.Exists(@"rust_server\server\"+configfile+"") == true)
                {
                    string[] files2 = Directory.GetFiles(@"rust_server\server\"+configfile, "*.map");
                    foreach (var file2 in files2)
                    {
                        File.Delete(file2);
                    }
                    string[] files3 = Directory.GetFiles(@"rust_server\server\"+configfile, "*.sav");
                    foreach (var file3 in files3)
                    {
                        File.Delete(file3);
                    }
                    string[] files4 = Directory.GetFiles(@"rust_server\server\"+configfile, "*.sav.*");
                    foreach (var file4 in files4)
                    {
                        File.Delete(file4);
                    }
                    MessageBox.Show(configfile+" has been wiped sucessfully :D", "Rust Server Creator",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(configfile+" folder doesn't exists :(", "Rust Server Creator",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wipe operation cancelled :D", "Rust Server Creator",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReleaseNotes releasenotes = new ReleaseNotes();
            openChildForm(releasenotes);
        }
    }
}
