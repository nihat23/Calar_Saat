namespace Çalar_Saat
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1AlarmKur = new System.Windows.Forms.Button();
            this.button2Alarmdurdur = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label2saat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3tarih = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5iptal = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3PcKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(108, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saat : ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Book Antiqua", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(64, 118);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 42);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = " 00:00:00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1AlarmKur
            // 
            this.button1AlarmKur.BackColor = System.Drawing.Color.FloralWhite;
            this.button1AlarmKur.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1AlarmKur.Location = new System.Drawing.Point(83, 171);
            this.button1AlarmKur.Name = "button1AlarmKur";
            this.button1AlarmKur.Size = new System.Drawing.Size(122, 37);
            this.button1AlarmKur.TabIndex = 2;
            this.button1AlarmKur.Text = "Alarm Kur";
            this.button1AlarmKur.UseVisualStyleBackColor = false;
            this.button1AlarmKur.Click += new System.EventHandler(this.button1AlarmKur_Click);
            // 
            // button2Alarmdurdur
            // 
            this.button2Alarmdurdur.BackColor = System.Drawing.Color.FloralWhite;
            this.button2Alarmdurdur.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button2Alarmdurdur.Location = new System.Drawing.Point(228, 171);
            this.button2Alarmdurdur.Name = "button2Alarmdurdur";
            this.button2Alarmdurdur.Size = new System.Drawing.Size(128, 37);
            this.button2Alarmdurdur.TabIndex = 3;
            this.button2Alarmdurdur.Text = "Alarm Durdur";
            this.button2Alarmdurdur.UseVisualStyleBackColor = false;
            this.button2Alarmdurdur.Click += new System.EventHandler(this.button2Alarmdurdur_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(25, 249);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(466, 31);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // label2saat
            // 
            this.label2saat.AutoSize = true;
            this.label2saat.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2saat.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2saat.Location = new System.Drawing.Point(197, 70);
            this.label2saat.Name = "label2saat";
            this.label2saat.Size = new System.Drawing.Size(45, 24);
            this.label2saat.TabIndex = 5;
            this.label2saat.Text = ".....";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(92, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tarih :";
            // 
            // label3tarih
            // 
            this.label3tarih.AutoSize = true;
            this.label3tarih.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3tarih.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3tarih.Location = new System.Drawing.Point(197, 8);
            this.label3tarih.Name = "label3tarih";
            this.label3tarih.Size = new System.Drawing.Size(45, 24);
            this.label3tarih.TabIndex = 7;
            this.label3tarih.Text = ".....";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FloralWhite;
            this.linkLabel1.Location = new System.Drawing.Point(435, 417);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(74, 18);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "NihatBeyi";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.button5iptal);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button3PcKapat);
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3tarih);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1AlarmKur);
            this.panel1.Controls.Add(this.label2saat);
            this.panel1.Controls.Add(this.button2Alarmdurdur);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 442);
            this.panel1.TabIndex = 9;
            // 
            // button5iptal
            // 
            this.button5iptal.BackColor = System.Drawing.Color.FloralWhite;
            this.button5iptal.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5iptal.Location = new System.Drawing.Point(257, 388);
            this.button5iptal.Name = "button5iptal";
            this.button5iptal.Size = new System.Drawing.Size(88, 37);
            this.button5iptal.TabIndex = 13;
            this.button5iptal.Text = "İptal";
            this.button5iptal.UseVisualStyleBackColor = false;
            this.button5iptal.Click += new System.EventHandler(this.button5iptal_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Cornsilk;
            this.button4.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(451, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 30);
            this.button4.TabIndex = 12;
            this.button4.Text = "Renk ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(197, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "YADA";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Book Antiqua", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(64, 326);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(339, 42);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = " 00:00:00";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3PcKapat
            // 
            this.button3PcKapat.BackColor = System.Drawing.Color.FloralWhite;
            this.button3PcKapat.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3PcKapat.Location = new System.Drawing.Point(163, 388);
            this.button3PcKapat.Name = "button3PcKapat";
            this.button3PcKapat.Size = new System.Drawing.Size(88, 37);
            this.button3PcKapat.TabIndex = 9;
            this.button3PcKapat.Text = "PC Kapat";
            this.button3PcKapat.UseVisualStyleBackColor = false;
            this.button3PcKapat.Click += new System.EventHandler(this.button3PcKapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(32F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(535, 465);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Blackoak Std", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(17, 6, 17, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Alarm & pc Kapatma ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1AlarmKur;
        private System.Windows.Forms.Button button2Alarmdurdur;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label2saat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3tarih;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3PcKapat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5iptal;
    }
}

