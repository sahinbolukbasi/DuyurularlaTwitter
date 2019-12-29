using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TwitterDuyuru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=SAHAN\\SQLEXPRESS;Initial Catalog=Twitter;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT * FROM kullaniciler where kullaniciAdi='" + kullaniciAdi.Text + "' AND sifre='" + sifre.Text + "'";
            SqlDataReader dr= cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Başarılı bir şekilde giriş yaptınız.");
                Form2 frm2 = new Form2();              
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            baglanti.Close();
            kullaniciAdi.Clear();
            sifre.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                Application.Exit();
            }
 
          
        }
        private void goster_MouseHover(object sender, EventArgs e)
        {
                sifre.UseSystemPasswordChar = false;
        }

        private void goster_MouseLeave(object sender, EventArgs e)
        {
                sifre.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
