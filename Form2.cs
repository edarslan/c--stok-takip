using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stoktakip
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JBK4KL2;Initial Catalog=stoktakip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet",baglanti);
            adtr.Fill(daset,"sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txttc.Text=="")
            {
                txtadsoyad.Text = "";
                txttelefon.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from müşteri where tc like '" + txttc.Text + "'", baglanti);
            SqlDataReader read=komut.ExecuteReader();
            while(read.Read())
            {
                txtadsoyad.Text = read["adsoyad"].ToString();
                txttelefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMüşteriEkle ekle = new frmMüşteriEkle();
            ekle.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMüşteriListele listele = new frmMüşteriListele();
            listele.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmÜrünEkle ekle = new frmÜrünEkle();
            ekle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmÜrünListele listele = new frmÜrünListele();
            listele.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtbarkod_TextChanged(object sender, EventArgs e)
        {
            Temizle();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where barkodno like '" + txtbarkod.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txturunadi.Text = read["urunadi"].ToString();
                txtsatisfiyat.Text = read["satisfiyati"].ToString();
            }
            baglanti.Close();
        }

        private void Temizle()
        {
            if (txtbarkod.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtmiktar)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }

        bool durum;
        private void barkodkontrol()
        {
            durum= true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from sepet",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                if (txtbarkod.Text == read["barkodno"].ToString())
                {
                    durum = false;
                }

            }
            baglanti.Close();
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into sepet(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih) ", baglanti);
                komut.Parameters.AddWithValue("@tc", txttc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", txtbarkod.Text);
                komut.Parameters.AddWithValue("@urunadi", txturunadi.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtmiktar.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtsatisfiyat.Text));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(txttoplamfiyat.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update sepet miktari=miktari+ '"+int.Parse(txtmiktar.Text)+ "' where barkodno='" + txtbarkod.Text + "'", baglanti);
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update sepet toplamfiyati=miktari*satisfiyati where barkodno='"+txtbarkod.Text+"' ", baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
            txtmiktar.Text = "1";
            daset.Tables["sepet"].Clear();
            sepetlistele();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtmiktar)
                    {
                        item.Text = "";
                    }
                }
            }


        }

        private void txtmiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttoplamfiyat.Text = (double.Parse(txtmiktar.Text) * double.Parse(txtsatisfiyat.Text)).ToString();
            }
            catch(Exception)
            {
                ;
            }
        }

        private void txtsatisfiyat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttoplamfiyat.Text = (double.Parse(txtmiktar.Text) * double.Parse(txtsatisfiyat.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }
    }
}
