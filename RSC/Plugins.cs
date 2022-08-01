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
using System.Text.RegularExpressions;
using System.Drawing.Text;

namespace RSC
{
    public partial class Plugins : Form
    {
        public void ListPlugins()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            string[] files = Directory.GetFiles(@"rust_server\oxide\plugins", "*.cs");
            foreach (var file in files)
            {
                comboBox1.Items.Add(file);
            }
            string[] files2 = Directory.GetFiles(@"rust_server\oxide\plugins\disabled", "*.cs");
            foreach (var file2 in files2)
            {
                comboBox2.Items.Add(file2);
            }
        }
        public void RSCFont()
        {
            if (File.Exists(@"RSC\Rust_Font.ttf") == true)
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile(@"RSC\Rust_Font.ttf");
                label1.Font = new Font(pfc.Families[0], 8);
                label2.Font = new Font(pfc.Families[0], 8);
                button1.Font = new Font(pfc.Families[0], 20);
                button2.Font = new Font(pfc.Families[0], 20);
                button3.Font = new Font(pfc.Families[0], 20);
                button4.Font = new Font(pfc.Families[0], 20);
            }
            if (File.Exists(@"RSC\Valorant_Font.ttf") == true)
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile(@"RSC\Valorant_Font.ttf");
                comboBox1.Font = new Font(pfc.Families[0], 8);
                comboBox2.Font = new Font(pfc.Families[0], 8);
            }
        }
        public Plugins()
        {
            InitializeComponent();
            RSCFont();
            ListPlugins();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string disabledplugin = comboBox2.Text;
            Process.Start("cmd.exe", @"/k @echo off && title RSC - Plugin Manager && color 5 && copy "+disabledplugin+@" rust_server\oxide\plugins && exit");
            Thread.Sleep(1000);
            File.Delete(disabledplugin);
            ListPlugins();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string enabledplugin = comboBox1.Text;
            Process.Start("cmd.exe", @"/k @echo off && title RSC - Plugin Manager && color 5 && copy "+enabledplugin+@" rust_server\oxide\plugins\disabled && exit");
            Thread.Sleep(1000);
            File.Delete(enabledplugin);
            ListPlugins();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"rust_server\oxide\plugins");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string enabledplugin = comboBox1.Text;
            string pluginselected = enabledplugin.Remove(0, 26);
            string plugin = Regex.Replace(pluginselected, ".cs", "");
            if (File.Exists(@"rust_server\oxide\config\"+plugin+".json") == true) { Process.Start(@"rust_server\oxide\config\"+plugin+".json"); }
            else
            {
                MessageBox.Show("Plugin config isn't found :(", "Rust Server Creator",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
