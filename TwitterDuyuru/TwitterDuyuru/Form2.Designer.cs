namespace TwitterDuyuru
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.yenile = new System.Windows.Forms.Button();
            this.yeniDuyuru = new System.Windows.Forms.ListBox();
            this.tumDuyurular = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tweetAt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LbSayac = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.karakterSayisi = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // yenile
            // 
            this.yenile.BackColor = System.Drawing.Color.Black;
            this.yenile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.yenile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yenile.ForeColor = System.Drawing.Color.White;
            this.yenile.Location = new System.Drawing.Point(9, 12);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(347, 49);
            this.yenile.TabIndex = 0;
            this.yenile.Text = "Duyuruları Al";
            this.yenile.UseVisualStyleBackColor = false;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // yeniDuyuru
            // 
            this.yeniDuyuru.FormattingEnabled = true;
            this.yeniDuyuru.Location = new System.Drawing.Point(9, 94);
            this.yeniDuyuru.Name = "yeniDuyuru";
            this.yeniDuyuru.Size = new System.Drawing.Size(528, 69);
            this.yeniDuyuru.TabIndex = 2;
            // 
            // tumDuyurular
            // 
            this.tumDuyurular.FormattingEnabled = true;
            this.tumDuyurular.Location = new System.Drawing.Point(9, 186);
            this.tumDuyurular.Name = "tumDuyurular";
            this.tumDuyurular.Size = new System.Drawing.Size(528, 251);
            this.tumDuyurular.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yeni Duyurular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tüm Duyurular";
            // 
            // tweetAt
            // 
            this.tweetAt.BackColor = System.Drawing.Color.Black;
            this.tweetAt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tweetAt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tweetAt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tweetAt.ForeColor = System.Drawing.Color.White;
            this.tweetAt.Location = new System.Drawing.Point(362, 12);
            this.tweetAt.Name = "tweetAt";
            this.tweetAt.Size = new System.Drawing.Size(175, 49);
            this.tweetAt.TabIndex = 6;
            this.tweetAt.Text = "Duyuruları Tweet At";
            this.tweetAt.UseVisualStyleBackColor = false;
            this.tweetAt.Click += new System.EventHandler(this.tweetAt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(557, 160);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 173);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(557, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = " Tweet At";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(620, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 55);
            this.label3.TabIndex = 9;
            this.label3.Text = "Twitter";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LbSayac
            // 
            this.LbSayac.AutoSize = true;
            this.LbSayac.Location = new System.Drawing.Point(662, 12);
            this.LbSayac.Name = "LbSayac";
            this.LbSayac.Size = new System.Drawing.Size(23, 13);
            this.LbSayac.TabIndex = 10;
            this.LbSayac.Text = "****";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(829, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 29);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // karakterSayisi
            // 
            this.karakterSayisi.AutoSize = true;
            this.karakterSayisi.Location = new System.Drawing.Point(812, 336);
            this.karakterSayisi.Name = "karakterSayisi";
            this.karakterSayisi.Size = new System.Drawing.Size(23, 13);
            this.karakterSayisi.TabIndex = 12;
            this.karakterSayisi.Text = "****";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Green;
            this.progressBar1.Location = new System.Drawing.Point(557, 336);
            this.progressBar1.Maximum = 280;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(249, 13);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.karakterSayisi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LbSayac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tweetAt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tumDuyurular);
            this.Controls.Add(this.yeniDuyuru);
            this.Controls.Add(this.yenile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Twitter Duyuru";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.ListBox yeniDuyuru;
        private System.Windows.Forms.ListBox tumDuyurular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tweetAt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LbSayac;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label karakterSayisi;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}