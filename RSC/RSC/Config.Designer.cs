namespace RSC
{
    partial class Config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.serverseed = new System.Windows.Forms.TextBox();
            this.size = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maxplayers = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.map = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rconpassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rconport = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rconip = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server name: ";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("VALORANT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(16, 29);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(294, 20);
            this.name.TabIndex = 1;
            this.name.Text = "Default Server";
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("VALORANT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(16, 99);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(294, 20);
            this.description.TabIndex = 3;
            this.description.Text = "Default Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server description: ";
            // 
            // url
            // 
            this.url.Font = new System.Drawing.Font("VALORANT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url.Location = new System.Drawing.Point(16, 171);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(294, 20);
            this.url.TabIndex = 5;
            this.url.Text = "https://yourweb.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Server URL: ";
            // 
            // header
            // 
            this.header.Font = new System.Drawing.Font("VALORANT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(16, 242);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(294, 20);
            this.header.TabIndex = 7;
            this.header.Text = "https://yourweb.com/banner.png";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Server header image: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Server seed: ";
            // 
            // serverseed
            // 
            this.serverseed.Font = new System.Drawing.Font("VALORANT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverseed.Location = new System.Drawing.Point(16, 315);
            this.serverseed.Name = "serverseed";
            this.serverseed.Size = new System.Drawing.Size(294, 20);
            this.serverseed.TabIndex = 9;
            this.serverseed.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // size
            // 
            this.size.Font = new System.Drawing.Font("VALORANT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size.Location = new System.Drawing.Point(16, 384);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(294, 20);
            this.size.TabIndex = 11;
            this.size.Text = "2500";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Server world size: ";
            // 
            // maxplayers
            // 
            this.maxplayers.Font = new System.Drawing.Font("VALORANT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxplayers.Location = new System.Drawing.Point(16, 449);
            this.maxplayers.Name = "maxplayers";
            this.maxplayers.Size = new System.Drawing.Size(182, 20);
            this.maxplayers.TabIndex = 13;
            this.maxplayers.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Server max players: ";
            // 
            // map
            // 
            this.map.Font = new System.Drawing.Font("VALORANT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.map.Location = new System.Drawing.Point(319, 384);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(235, 20);
            this.map.TabIndex = 25;
            this.map.Text = "Procedural Map";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Server map: ";
            // 
            // rconpassword
            // 
            this.rconpassword.Font = new System.Drawing.Font("VALORANT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rconpassword.Location = new System.Drawing.Point(319, 315);
            this.rconpassword.Name = "rconpassword";
            this.rconpassword.Size = new System.Drawing.Size(235, 20);
            this.rconpassword.TabIndex = 23;
            this.rconpassword.Text = "12345";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Server RCON Password: ";
            // 
            // rconport
            // 
            this.rconport.Font = new System.Drawing.Font("VALORANT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rconport.Location = new System.Drawing.Point(319, 242);
            this.rconport.Name = "rconport";
            this.rconport.Size = new System.Drawing.Size(235, 20);
            this.rconport.TabIndex = 21;
            this.rconport.Text = "28016";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(316, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Server RCON Port:";
            // 
            // rconip
            // 
            this.rconip.Font = new System.Drawing.Font("VALORANT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rconip.Location = new System.Drawing.Point(319, 171);
            this.rconip.Name = "rconip";
            this.rconip.Size = new System.Drawing.Size(235, 20);
            this.rconip.TabIndex = 19;
            this.rconip.Text = "0.0.0.0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(316, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Server RCON IP: ";
            // 
            // port
            // 
            this.port.Font = new System.Drawing.Font("VALORANT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port.Location = new System.Drawing.Point(319, 99);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(235, 20);
            this.port.TabIndex = 17;
            this.port.Text = "28015";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(316, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Server port: ";
            // 
            // ip
            // 
            this.ip.Font = new System.Drawing.Font("VALORANT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip.Location = new System.Drawing.Point(319, 29);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(235, 20);
            this.ip.TabIndex = 15;
            this.ip.Text = "0.0.0.0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(316, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Server ip: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Font = new System.Drawing.Font("Rust", 9.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(424, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 36);
            this.button1.TabIndex = 26;
            this.button1.Text = "Generate seed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.Font = new System.Drawing.Font("Rust", 9.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(319, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 36);
            this.button2.TabIndex = 27;
            this.button2.Text = "Save config";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button3.Font = new System.Drawing.Font("Rust", 9.25F);
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(219, 433);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 36);
            this.button3.TabIndex = 28;
            this.button3.Text = "All Configs";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(566, 484);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.map);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rconpassword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rconport);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rconip);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.port);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.maxplayers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.size);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.serverseed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.header);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.url);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rust", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Config";
            this.Text = "Rust Server Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox header;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox serverseed;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maxplayers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox map;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rconpassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox rconport;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox rconip;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}