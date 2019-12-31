using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;
using System.Net;
using HtmlAgilityPack;
using System.Data.Sql;
using System.Data.SqlClient;
namespace TwitterDuyuru
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Auth.SetUserCredentials("", "", "", "");//Twitter Token Yazılacak

        }
        SqlConnection baglanti = new SqlConnection("Data Source=SAHAN\\SQLEXPRESS;Initial Catalog=Twitter;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }
        List<string> veriTabniDuyuru = new List<string>();
        List<string> alınanDuyuru = new List<string>();
        public void otomatikYenile()
        {
            

            tumDuyurular.Items.Clear();
            yeniDuyuru.Items.Clear();

            Uri url = new Uri("https://www.arel.edu.tr/duyurular");
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);
            HtmlNodeCollection basliklar = dokuman.DocumentNode.SelectNodes("//td/a");
            baglanti.Open();
            foreach (var baslik in basliklar)
            {
                tumDuyurular.Items.Add(baslik.InnerText);
                alınanDuyuru.Add(baslik.InnerText);
            }

            //for (int i = 0; i < alınanDuyuru.Count; i++)
            //{
            //    SqlCommand komut1 = new SqlCommand("INSERT INTO duyurular VALUES(@p1)", baglanti);
            //    komut1.Parameters.AddWithValue("@p1", alınanDuyuru[i]);
            //    komut1.ExecuteNonQuery();
            //    komut1.Parameters.Clear();
            //}

            SqlCommand komut = new SqlCommand("SELECT*FROM duyurular", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                veriTabniDuyuru.Add(oku["Duyurular"].ToString());
            }

            string[] yeniGelenDuyuru = alınanDuyuru.Except(veriTabniDuyuru).ToArray();

            foreach (var item in yeniGelenDuyuru)
            {
                yeniDuyuru.Items.Add(item);
            }

            baglanti.Close();
            MessageBox.Show("Duyurular alındı", "Bildirim");
        }

        public void otomatikTweetAt()
        {
            baglanti.Open();

            if (yeniDuyuru.Items.Count == 0)
            {
                MessageBox.Show("Tweet atılacak gönderi bulunamadı", "Bildirim");
            }
            else
            {
                for (int i = 0; i<yeniDuyuru.Items.Count; i++)
                {
                    SqlCommand komut0 = new SqlCommand("INSERT INTO duyurular VALUES(@p1)", baglanti);
    komut0.Parameters.AddWithValue("@p1", yeniDuyuru.Items[i]);
                    komut0.ExecuteNonQuery();
                    komut0.Parameters.Clear();
                    Tweet.PublishTweet(yeniDuyuru.Items[i].ToString());
                }
yeniDuyuru.Items.Clear();
                MessageBox.Show("Duyurular Tweet Atıldı", "Bildirim");
            }
            baglanti.Close();
        }
        private void yenile_Click(object sender, EventArgs e)
        {
            otomatikYenile();
            sayac = 0;
        }

        private void tweetAt_Click(object sender, EventArgs e)
        {
            otomatikTweetAt();
            sayac = 0;

        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show(textBox1.Text + " tweetiniz  atılsınmı.", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                Tweet.PublishTweet(textBox1.Text);
                textBox1.Text = "Tweet yaz";
            }
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            LbSayac.Text = "Yenilenmeye Kalan Süre :"+sayac.ToString();
            if(sayac==300)
            {
                otomatikYenile();
                otomatikTweetAt();
                
                sayac = 0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int girilenDeger = textBox1.TextLength;
            karakterSayisi.Text = girilenDeger.ToString();

            if (girilenDeger <= 280)
            {
                button1.Enabled = true;
                progressBar1.Value = textBox1.TextLength;
              
            } 
            else 
            {               
                button1.Enabled = false;
            }       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayac = 299;
        }
    }
}

