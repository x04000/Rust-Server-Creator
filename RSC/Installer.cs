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
using System.Threading;
using System.IO.Compression;

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"rust_server\RustDedicated_Data\Managed\Oxide.Rust.dll") == false)
            {
                if (File.Exists("Oxide.Rust.zip") == false)
                {
                    string remoteUri = "https://umod.org/games/rust/download?tag=public";
                    string fileName = "Oxide.Rust.zip", myStringWebResource = null;
                    WebClient myWebClient = new WebClient();
                    myStringWebResource = remoteUri + fileName;
                    myWebClient.DownloadFile(myStringWebResource, fileName);
                }
                string zipPath = @".\Oxide.Rust.zip";
                string extractPath = @".\rust_server";

                ZipFile.ExtractToDirectory(zipPath, extractPath);

                File.Delete("Oxide.Rust.zip");

                MessageBox.Show("Oxide has been fully installed sucessfully :D", "Rust Server Creator",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            else
            {
                File.Delete(@"rust_server\RustDedicated_Data\Managed\Assembly-CSharp.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\Facepunch.Console.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\Facepunch.Network.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\Facepunch.Rcon.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\Facepunch.UnityEngine.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\Mono.Data.Tds.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\MySql.Data.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\Oxide.Core.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\Oxide.CSharp.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\Oxide.MySql.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\Oxide.References.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\Oxide.Rust.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\Oxide.SQLite.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\Oxide.Unity.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\System.Configuration.Install.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\System.Data.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\System.Data.SQLite.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\System.Drawing.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\System.Runtime.Serialization.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\System.Transactions.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\x64\libmonoboehm-2.0.so.1");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\x64\libMonoPosixHelper.so");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\x64\libsqlite3");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\x64\libsqlite3.so");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\x64\sqlite3.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\x86\libmonoboehm-2.0.so.1");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\x86\libMonoPosixHelper.so");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\x86\libsqlite3");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\x86\libsqlite3.so");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\x86\mono-2.0.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\x86\msvcp140.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\x86\msvcr120.dll");
                File.Delete(@"rust_server\RustDedicated_Data\Managed\x86\sqlite3.dll");

                if (File.Exists("Oxide.Rust.zip") == false)
                {
                    string remoteUri = "https://umod.org/games/rust/download?tag=public";
                    string fileName = "Oxide.Rust.zip", myStringWebResource = null;
                    WebClient myWebClient = new WebClient();
                    myStringWebResource = remoteUri + fileName;
                    myWebClient.DownloadFile(myStringWebResource, fileName);
                }
                string zipPath = @".\Oxide.Rust.zip";
                string extractPath = @".\rust_server";

                ZipFile.ExtractToDirectory(zipPath, extractPath);

                File.Delete("Oxide.Rust.zip");

                MessageBox.Show("Oxide has been fully updated sucessfully :D", "Rust Server Creator",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
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
            if (lastestversion == "v.1.2.1")
            {
                MessageBox.Show("RSC is updated :D", "Rust Server Creator",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                WebRequest requestr = WebRequest.Create("https://raw.githubusercontent.com/x04000/Rust-Server-Creator/main/RSC/version");
                requestr.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse responser = (HttpWebResponse)requestr.GetResponse();
                Stream dataStreamr = responser.GetResponseStream();
                StreamReader readerr = new StreamReader(dataStreamr);
                string responseFromServerr = readerr.ReadToEnd();
                StreamWriter pwr = new StreamWriter(@"RSC\release");
                pwr.WriteLine(responseFromServerr);
                pwr.Close();
                StreamReader srcr = new StreamReader(@"RSC\release");
                string release = srcr.ReadLine();
                srcr.Close();
                File.Delete(@"RSC\release");
                StreamWriter sw = new StreamWriter(@"RSC\RSC_Updater.bat");
                sw.WriteLine("@echo off");
                sw.WriteLine("title RSC Updater");
                sw.WriteLine("color 5");
                sw.WriteLine("echo Updating RSC...");
                sw.WriteLine("taskkill /f /im RSC.exe");
                sw.WriteLine("ping localhost^1 >nul");
                sw.WriteLine("powershell curl "+release+" -o RSC.exe");
                sw.WriteLine("echo Update Finished :D");
                sw.WriteLine("pause>nul");
                sw.WriteLine("exit");
                sw.Close();
                Process.Start(@"RSC\RSC_Updater.bat");
            }
        }
    }
}
