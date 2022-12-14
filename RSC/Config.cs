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
using System.Drawing.Text;

namespace RSC
{
    public partial class Config : Form
    {
        public void RSCFont()
        {
            if (File.Exists(@"RSC\Rust_Font.ttf") == true)
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile(@"RSC\Rust_Font.ttf");
                label1.Font = new Font(pfc.Families[0], 8);
                label2.Font = new Font(pfc.Families[0], 8);
                label3.Font = new Font(pfc.Families[0], 8);
                label4.Font = new Font(pfc.Families[0], 8);
                label5.Font = new Font(pfc.Families[0], 8);
                label6.Font = new Font(pfc.Families[0], 8);
                label7.Font = new Font(pfc.Families[0], 8);
                label9.Font = new Font(pfc.Families[0], 8);
                label10.Font = new Font(pfc.Families[0], 8);
                label11.Font = new Font(pfc.Families[0], 8);
                label12.Font = new Font(pfc.Families[0], 8);
                label13.Font = new Font(pfc.Families[0], 8);
                label14.Font = new Font(pfc.Families[0], 8);
                button1.Font = new Font(pfc.Families[0], 9);
                button2.Font = new Font(pfc.Families[0], 9);
                button3.Font = new Font(pfc.Families[0], 9);
            }
            if (File.Exists(@"RSC\Valorant_Font.ttf") == true)
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile(@"RSC\Valorant_Font.ttf");
                name.Font = new Font(pfc.Families[0], 8);
                description.Font = new Font(pfc.Families[0], 8);
                url.Font = new Font(pfc.Families[0], 8);
                header.Font = new Font(pfc.Families[0], 8);
                serverseed.Font = new Font(pfc.Families[0], 8);
                size.Font = new Font(pfc.Families[0], 8);
                maxplayers.Font = new Font(pfc.Families[0], 8);
                ip.Font = new Font(pfc.Families[0], 8);
                port.Font = new Font(pfc.Families[0], 8);
                rconip.Font = new Font(pfc.Families[0], 8);
                rconport.Font = new Font(pfc.Families[0], 8);
                rconpassword.Font = new Font(pfc.Families[0], 8);
                map.Font = new Font(pfc.Families[0], 8);
            }
        }
        public Config()
        {
            InitializeComponent();
            RSCFont();
            StreamReader src = new StreamReader(@"RSC\config");
            string configfile = src.ReadLine();
            src.Close();
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

            name.Text = Name;
            description.Text = Description;
            url.Text = URL;
            header.Text = Header;
            serverseed.Text = SEED;
            size.Text = Size;
            maxplayers.Text = Maxplayers;
            ip.Text = IP;
            port.Text = Port;
            rconip.Text = Rconip;
            rconport.Text = Rconport;
            rconpassword.Text = Rconpassword;
            map.Text = Map;
        }

        private void button1_Click(object sender, EventArgs e)
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
            serverseed.Text = seed;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader src = new StreamReader(@"RSC\config");
            string configfile = src.ReadLine();
            src.Close();
            if (configfile == "server1") { configfile = "config1"; }
            if (configfile == "server2") { configfile = "config2"; }
            if (configfile == "server3") { configfile = "config3"; }
            if (configfile == "server4") { configfile = "config4"; }
            if (configfile == "server5") { configfile = "config5"; }
            configfile = @"RSC\"+configfile;
            StreamWriter sw = new StreamWriter(configfile);
            sw.WriteLine(name.Text);
            sw.WriteLine(description.Text);
            sw.WriteLine(url.Text);
            sw.WriteLine(header.Text);
            sw.WriteLine(serverseed.Text);
            sw.WriteLine(size.Text);
            sw.WriteLine(maxplayers.Text);
            sw.WriteLine(ip.Text);
            sw.WriteLine(port.Text);
            sw.WriteLine(rconip.Text);
            sw.WriteLine(rconport.Text);
            sw.WriteLine(rconpassword.Text);
            sw.WriteLine(map.Text);
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader src = new StreamReader(@"RSC\config");
            string configfile = src.ReadLine();
            src.Close();
            if (File.Exists(@"rust_server\server\"+configfile+@"\cfg\serverauto.cfg") == true)
            {
                Process.Start(@"rust_server\server\"+configfile+@"\cfg\serverauto.cfg");
            }
            else
            {
                MessageBox.Show("serverauto.cfg config doesn't exists :(", "Rust Server Creator",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
