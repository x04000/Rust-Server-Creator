﻿using System;
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
        public Plugins()
        {
            InitializeComponent();
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
    }
}
