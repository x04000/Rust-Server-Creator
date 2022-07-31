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
using System.Net;

namespace RSC
{
    public partial class Installer : Form
    {
        public Installer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("steamcmd.exe") == false)
            {
                string remoteUri = "https://download941.mediafire.com/xsaqk3538uag/rcfqek1oj8g7u8q/steamcmd.exe";
                string fileName = "steamcmd.exe", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri + fileName;
                myWebClient.DownloadFile(myStringWebResource, fileName);
            }
            Process.Start("cmd.exe", "/k @echo off && title RSC - Updater && start steamcmd.exe +login anonymous +force_install_dir rust_server +app_update 258550 -beta validate +quit && exit");
            if (Directory.Exists("rust_server") == false)
            {
                Directory.CreateDirectory("rust_server");
                Directory.CreateDirectory(@"rust_server\oxide");
                Directory.CreateDirectory(@"rust_server\oxide\plugins");
                Directory.CreateDirectory(@"rust_server\oxide\plugins\disabled");
                Directory.CreateDirectory(@"rust_server\oxide\config");
                Directory.CreateDirectory(@"rust_server\oxide\config\disabled");
            }
        }
    }
}
