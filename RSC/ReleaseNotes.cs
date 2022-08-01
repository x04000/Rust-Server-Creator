using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RSC
{
    public partial class ReleaseNotes : Form
    {
        public void RSCFont()
        {
            if (File.Exists(@"RSC\Valorant_Font.ttf") == true)
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile(@"RSC\Valorant_Font.ttf");
                richTextBox1.Font = new Font(pfc.Families[0], 8);
            }
        }
        public ReleaseNotes()
        {
            InitializeComponent();
            RSCFont();
        }

        private void ReleaseNotes_Load(object sender, EventArgs e)
        {

        }
    }
}
